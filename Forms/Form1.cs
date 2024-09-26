using System;
using System.Drawing;
using System.Windows.Forms;
using GameServer_Management.Forms;

namespace GameServer_Management
{
    public partial class LoadingForm : Form
    {
        public LoadingForm()
        {
            InitializeComponent();
            this.AutoScaleDimensions = new SizeF(96F, 96F);
            this.AutoScaleMode = AutoScaleMode.Dpi;
            //label1.BackColor = Color.FromArgb(100,0,0,0);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LoadPanel.Width += 3;
            if(LoadPanel.Width >= 870)
            {
                timer1.Stop();
                Login login = new Login();
                login.Show();
                this.Hide();
            }
        }
    }
}
