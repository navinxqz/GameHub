﻿using GameServer_Management.Class;
using System;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace GameServer_Management.Forms
{
    public partial class AddGames : Form
    {
        private string dotbell;

        public AddGames()
        {
            InitializeComponent();
            this.AutoScaleDimensions = new SizeF(96F, 96F);
            this.AutoScaleMode = AutoScaleMode.Dpi;

            string projectDir = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName;
            dotbell = Path.Combine(projectDir, "asset", "bellred.png");
        }

        public int id = 0;
        public int catID = 0;

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string query = id == 0 ? "sp_addGame" : "sp_updateGame";

            //for img upload
            if (id ==0 && pictureBox1.Image == null)
            {
                MessageBox.Show("Please upload an image.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (pictureBox1.Image != null)
            {
                Image temp = new Bitmap(pictureBox1.Image);
                using (MemoryStream ms = new MemoryStream())
                {
                    temp.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                    imgByte = ms.ToArray();
                }
            } else { imgByte = null; }

            Hashtable h = new Hashtable();
            if (id != 0) { h.Add("@gameID", id); }

            h.Add("@gameName", txtName.Text);
            h.Add("@gameDesc", txtDesc.Text);
            h.Add("@categoryID", Convert.ToInt32(cbCat.SelectedValue));
            h.Add("@gameprice", Convert.ToDouble(txtPrice.Text));
            //h.Add("@releaseDate", txtRelDate.Text);

            DateTime releaseDate;
            if (DateTime.TryParseExact(txtRelDate.Text, "dd-MM-yyyy", null, System.Globalization.DateTimeStyles.None, out releaseDate))
            {
                h.Add("@releaseDate", releaseDate.ToString("yyyy-MM-dd")); // converted to sql recognized format
            }
            else
            {
                MessageBox.Show("Invalid date format! Please enter a valid date in dd-MM-yyyy format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //h.Add("@gameImage", imgByte);
            h.Add("@gameImage", imgByte != null ? (object)imgByte : DBNull.Value);  //method for the DBNUll approch


            if (DBconnect.SQL(query, h) > 0)
            {
                MessageBox.Show("Saved Successfully!", "GameHub", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();

                Home.Instance.bellbtn.Image = Image.FromFile(dotbell);
                if (Home.Instance.bellbtn.Image != Image.FromFile(dotbell))
                {
                    Home.Instance.msglbl.Content = "New game launched!";
                }
                else
                {
                    Home.Instance.msglbl.Content = "You are up to date!";
                }

            }
            else
            {
                MessageBox.Show("Error saving the game. Please check your inputs and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ClearForm()
        {
            id = 0;
            catID = 0;
            txtName.Clear();
            txtPrice.Clear();
            txtDesc.Clear();
            txtRelDate.Clear();
            cbCat.SelectedIndex = -1;
            pictureBox1.Image = null;
            
            try
            {   //for image load with relative file path
                string projectDir = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName;
                string relativeImgPath = Path.Combine(projectDir, "asset", "photo-256.png");

                if (File.Exists(relativeImgPath))
                {
                    pictureBox1.Image = Image.FromFile(relativeImgPath);
                }
                else
                {
                    MessageBox.Show("Image not found: " + relativeImgPath, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading image: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            txtName.Focus();
        }

        string filePath;
        Byte[] imgByte;

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Title = "Choose an image";
            op.Filter = "Images(.jpeg, .jpg, .png)|*.jpeg;*.jpg;*.png";

            if(op.ShowDialog() == DialogResult.OK)
            {
                filePath = op.FileName;
                pictureBox1.Image = new Bitmap(filePath);
            }
        }

        private void AddGames_Load(object sender, EventArgs e)
        {
            string query = "select catID as id, catName as name from categorytbl";
            DBconnect.CBFill(query,cbCat);

            if(catID > 0)
            {
                cbCat.SelectedValue = catID;
            }
            if(id > 0)
            {
                UpdateLoadData();
            }
        }

        private void cbCat_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DateSelect_ValueChanged(object sender, EventArgs e)
        {
            txtRelDate.ForeColor = Color.White;
            txtRelDate.Text = DateSelect.Value.ToString("dd-MM-yyyy");
        }
        private void UpdateLoadData()
        {
            string query = "SELECT * FROM gamestbl WHERE gameID = @gameID";
            Hashtable parameters = new Hashtable{ { "@gameID", id } };
            DataTable dt = new DataTable();

            using (SqlConnection con = new SqlConnection(DBconnect.cs))
            {
                try
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@gameID", id);
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            adapter.Fill(dt);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error! {ex.Message}");
                    return;
                }
            }
                
            if(dt.Rows.Count > 0)
            {
                DataRow r = dt.Rows[0];
                txtName.Text = r["gameName"].ToString();
                txtDesc.Text = r["gameDesc"].ToString();
                txtPrice.Text = r["gamePrice"].ToString();
                txtRelDate.Text = Convert.ToDateTime(r["releaseDate"]).ToString("dd-MM-yyyy");

                if (r["gameImage"] != DBNull.Value)
                {
                    Byte[] imgArray = (byte[])r["gameImage"];

                    using (MemoryStream ms = new MemoryStream(imgArray))
                    {
                        pictureBox1.Image = Image.FromStream(ms);
                    }
                }
                else
                {
                    pictureBox1.Image = null;
                }
            }
        }
    }
}
