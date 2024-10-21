using GameServer_Management.Class;
using GameServer_Management.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameServer_Management.Forms
{
    public partial class AdminHome : Form
    {
        public AdminHome()
        {
            InitializeComponent();
            gamePanel.VerticalScroll.Enabled = false;
            gamePanel.WrapContents = false;
        }
        private int currentX = 0;

        private async void LoadItems()
        {
            string query = "select * from gamestbl t1 inner join categorytbl t2 on t2.catID = t1.categoryID";
            using (SqlConnection con = DBconnect.GetConnection())
            {
                if (con == null)
                {
                    MessageBox.Show("Database connection is not established.", "GameHub", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                try
                {
                    await con.OpenAsync();
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        foreach (DataRow item in dt.Rows)
                        {
                            Byte[] imgAry = (byte[])item["gameImage"];
                            Image img = Image.FromStream(new MemoryStream(imgAry)); //
                            AddItems(item["gameID"].ToString(), item["gameName"].ToString(), item["catName"].ToString(), item["gamePrice"].ToString(), img, item["gameDesc"].ToString());
                        }
                    }
                }
                catch (Exception ex) { MessageBox.Show($"Error! {ex.Message}"); }
            }
        }

        private void AddItems(string id, string name, string cat, string price, Image img, string gameDescription)
        {
            var v = new GameDesc
            {
                GName = name,
                Price = price,
                Category = cat,
                Pic = img,
                id = Convert.ToInt32(id),
                desc = gameDescription,

                //Width = 200,
                //Height = gamePanel.Height - 10,
            };
            v.Location = new Point(currentX, 0);
            currentX += v.Width + 10;

            gamePanel.Controls.Add(v);
            v.BringToFront();

            gamePanel.AutoScrollMinSize = new Size(currentX, 0);

            // Ensure only horizontal scrolling is enabled
            gamePanel.HorizontalScroll.Enabled = true;
            gamePanel.VerticalScroll.Enabled = false;
        }

        private void AdminHome_Load(object sender, EventArgs e)
        {
            gamePanel.Controls.Clear();
            currentX = 0;
            LoadItems();
        }
    }
}
