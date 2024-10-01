using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameServer_Management.Controller
{
    public partial class GetGame : UserControl
    {
        public GetGame()
        {
            InitializeComponent();
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void getbtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Game is added to your Librabry");
        }
        public int id { get; set; }
        public string desc
        {
            get { return gameDesc.Text; }
            set { gameDesc.Text = value; }
        }
        public string GName
        {
            get { return gameName.Text; }
            set { gameName.Text = value; }
        }
        public string Price
        {
            get { return gameprice.Text; }
            set { gameprice.Text = value; }
        }
        public Image Pic
        {
            get { return gameImg.Image; }
            set { gameImg.Image = value; }
        }
        public string Category
        {
            get { return gamecat.Text; }
            set { gamecat.Text = value; }
        }
    }
}
