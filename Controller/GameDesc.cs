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
            this.MouseClick += GameImg_MouseClick;
            this.MouseClick += gameName_MouseClick;
            //this.MouseClick += GameDesc_MouseClick;

            foreach (Control c in this.Controls)
            {
                c.MouseClick += GameImg_MouseClick;
            } 
        }
        public event EventHandler onSelect; // = null

        public int id { get;set; }
        public string desc 
        {
            get { return desclbl.Text; }
            set { desclbl.Text = value; }
        }
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
        public string Date
        {
            get { return gameRelease.Text; }
            set { gameRelease.Text = value; }
        }

        private void GameImg_MouseClick(object sender, MouseEventArgs e)
        {
            onSelect?.Invoke(this, e);
        }

        private void gameName_MouseClick(object sender, MouseEventArgs e)
        {
            onSelect?.Invoke(this, e);
        }
    }
}
