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
    public partial class GameDesc : UserControl
    {
        public GameDesc()
        {
            InitializeComponent();
        }
        public event EventHandler onSelect = null;

        public int id { get;set; }
        public string GName 
        {
            get { return gameName.Text; }
            set { gameName.Text = value; }
        }
        public string Price
        {
            get { return pricelbl.Text; }
            set { pricelbl.Text = value; }
        }
        public Image Pic
        {
            get { return GameImg.Image; }
            set { GameImg.Image = value; }
        }
        public string Category 
        {
            get { return catName.Text; }
            set { catName.Text = value; }
        }

        private void GameImg_Click(object sender, EventArgs e)
        {
            onSelect?.Invoke(this, e);
        }
    }
}
