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
            //this.Click += GameDesc_Click;
            this.MouseClick += GameDesc_MouseClick;

            foreach (Control c in this.Controls)
            {
                c.MouseClick += GameDesc_MouseClick;
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
  
        private void GameDesc_Click(object sender, EventArgs e)
        {
            //onSelect?.Invoke(this, e);
            //this.OnClick(e);
        }

        private void GameDesc_MouseClick(object sender, MouseEventArgs e)
        {
            onSelect?.Invoke(this, e);
        }
    }
}
