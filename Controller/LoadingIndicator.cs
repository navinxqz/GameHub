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
    public partial class LoadingIndicator : Form
    {
        public LoadingIndicator()
        {
            InitializeComponent();
            this.AutoScaleDimensions = new SizeF(96F, 96F);
            this.AutoScaleMode = AutoScaleMode.Dpi;
            this.Visible = false;
            this.Load += LoadingIndicator_Load;
        }

        private void LoadingIndicator_Load(object sender, EventArgs e)
        {
            this.Opacity = 0;
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if(this.Opacity < 0.92)
            {
                this.Opacity += 0.05;
            }
            else
            {
                timer.Stop();
            }
        }
    }
}
