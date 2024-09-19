using GameServer_Management.Class;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            Hashtable h = new Hashtable();
            h.Add("@gameID", id);
            h.Add("@gameName", txtName.Text);
            h.Add("@gameDesc", txtDesc.Text);
            h.Add("@gameCatID", txtCat.Text);
            h.Add("@gameprice", txtPrice.Text);
            h.Add("@releaseDate", txtRelDate.Text);
            h.Add("@gameImage", txtRelDate.Text);   //later

            if (DBconnect.SQL(query, h) > 0)
            {
                MessageBox.Show("Saved Successfully!", "GameServer Management", MessageBoxButtons.OK, MessageBoxIcon.Information);
                id = 0;
                txtName.Clear();
                txtPrice.Clear();
                txtDesc.Clear();
                txtRelDate.Clear();
                //txtCat.SelectedIndex = -1;
                txtCat.Clear();
                txtCat.Focus();
            }
        }

        string filePath;
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Title = "Choose an image";
            op.Filter = "Image Files(.jpeg,.jpg,.png)!*.jpeg;*.jpg;*.png";

            if(op.ShowDialog() == DialogResult.OK)
            {
                filePath = op.FileName;
                pictureBox1.Image = new Bitmap(filePath);
            }
        }

        private void AddGames_Load(object sender, EventArgs e)
        {
            string query = "select catID as id, catName as name from categorytbl";
            DBconnect.CBFill(query,c);
        }
    }
}
