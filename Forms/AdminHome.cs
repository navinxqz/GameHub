using GameServer_Management.Class;
using GameServer_Management.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
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
        }
        //async LoadItems function
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
                        using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                        {
                            if (reader.HasRows)
                            {
                                while (await reader.ReadAsync())
                                {
                                    ListViewItem item = new ListViewItem(reader["gameID"].ToString());
                                    item.SubItems.Add(reader["gameName"].ToString());
                                    item.SubItems.Add(reader["gamePrice"].ToString());
                                    item.SubItems.Add(reader["gameDescription"].ToString());
                                    item.SubItems.Add(reader["gameImage"].ToString());
                                    item.SubItems.Add(reader["catName"].ToString());
                                    //listView1.Items.Add(item);
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "GameHub", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
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
            };

            //v.onSelect += new EventHandler(Game_Click);
            gamePanel.Controls.Add(v);
            v.BringToFront();   //loading data backward
            //gameDescList.Add(v);
        }
    }
}
