using GameServer_Management.Class;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameServer_Management.Forms
{
    public partial class AddGames : Form
    {
        public AddGames()
        {
            InitializeComponent();
        }
        public int id = 0;
        public int catID = 0;

        private void labelName_Click(object sender, EventArgs e)
        {

        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string query = "";
            if (id == 0)
            {
                query = "sp_addGame"; //insert
            }
            else
            {
                query = "sp_updateGame"; //update
            }
            //for img upload
            Image temp = new Bitmap(pictureBox1.Image);
            MemoryStream ms = new MemoryStream();
            temp.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
            imgByte = ms.ToArray();

            Hashtable h = new Hashtable();
            h.Add("@gameID", id);
            h.Add("@gameName", txtName.Text);
            h.Add("@gameDesc", txtDesc.Text);
            h.Add("@gameCatID", Convert.ToInt32(cbCat.SelectedValue));
            h.Add("@gameprice", Convert.ToDouble(txtPrice.Text));
            h.Add("@releaseDate", txtRelDate.Text);
            h.Add("@gameImage", imgByte);   //later

            if (DBconnect.SQL(query, h) > 0)
            {
                MessageBox.Show("Saved Successfully!", "GameServer Management", MessageBoxButtons.OK, MessageBoxIcon.Information);
                id = 0;
                txtName.Clear();
                txtPrice.Clear();
                txtDesc.Clear();
                txtRelDate.Clear();
                cbCat.SelectedIndex = -1;
                txtName.Focus();
            }
        }

        string filePath;
        Byte[] imgByte;
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Title = "Choose an image";
            op.Filter = "Images(.jpeg,.jpg,.png)|*.jpeg;*.jpg;*.png";

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
        }

        private void cbCat_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DateSelect_ValueChanged(object sender, EventArgs e)
        {
            txtRelDate.ForeColor = Color.White;
            txtRelDate.Text = DateSelect.Value.ToString("dd-MM-yyyy");
        }
    }
}
