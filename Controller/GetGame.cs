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
            get { return gameDesc.Content; }
            set { gameDesc.Content = value; }
        }
        public string GName
        {
            get { return gameName.Content; }
            set { gameName.Content = value; }
        }
        public string Price
        {
            get { return gameprice.Text; }
            set { gameprice.Content = value; }
        }
        public Image Pic
        {
            get { return gameImg.Image; }
            set { gameImg.Image = value; }
        }
        public string Category
        {
            get { return gamecat.Content; }
            set { gamecat.Content = value; }
        }
    }
}
