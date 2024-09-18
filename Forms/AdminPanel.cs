﻿using Krypton.Toolkit;
using System;
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
    public partial class AdminPanel : Form
    {
        private KryptonCheckButton cb = new KryptonCheckButton();
        //for more btn...
        public AdminPanel()
        {
            InitializeComponent();
            this.AutoScaleDimensions = new SizeF(96F, 96F);
            this.AutoScaleMode = AutoScaleMode.Dpi;
            cb = btnHome;
            cb.Checked = true;
        }
        public void LoadForm(object Form)
        {
            if (this.mainpanel.Controls.Count > 0)
            {
                this.mainpanel.Controls.RemoveAt(0);
            }
            
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainpanel.Controls.Add(f);
            this.mainpanel.Tag = f;
            f.Visible = true;
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            AdminLogin adminLogin = new AdminLogin();
            adminLogin.Show();
            this.Hide();
        }

        private void cuiButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Buttons(KryptonCheckBox button)
        {

        }

        private void sliderShowTimer_Tick(object sender, EventArgs e)
        {
            if (slidePanel.Size.Width < 222)
            {
                int targetWidth = 230;
                int i = 50;

                if (slidePanel.Size.Width + i > targetWidth)
                {
                    i = targetWidth - slidePanel.Size.Width;
                }
                int x = slidePanel.Size.Width + i;  //increment dynamically
                int y = slidePanel.Size.Height;
                slidePanel.Size = new Size(x, y);

                int a = mainpanel.Size.Width - i;
                int b = mainpanel.Size.Height;
                mainpanel.Size = new Size(a, b);

                int lx = mainpanel.Location.X + i;
                int ly = mainpanel.Location.Y;
                mainpanel.Location = new Point(lx, ly);
            }
            else
            {
                sliderShowTimer.Stop();
            }
        }

        private void sliderHideTimer_Tick(object sender, EventArgs e)
        {
            if (slidePanel.Size.Width > 70)
            {
                int targetWidth = 70;
                int i = 50;

                if (slidePanel.Size.Width - i > targetWidth)
                {
                    i = slidePanel.Size.Width - targetWidth;
                }
                int x = slidePanel.Size.Width - i;  //decrement dynamically
                int y = slidePanel.Size.Height;
                slidePanel.Size = new Size(x, y);

                int a = mainpanel.Size.Width + i;
                int b = mainpanel.Size.Height;
                mainpanel.Size = new Size(a, b);

                int ly = mainpanel.Location.Y;
                int lx = mainpanel.Location.X - i;
                mainpanel.Location = new Point(lx, ly);
            }
            else
            {
                sliderHideTimer.Stop();
            }
        }

        private void menubtn_Click(object sender, EventArgs e)
        {
            if (!sliderShowTimer.Enabled && !sliderHideTimer.Enabled)
            {
                if (slidePanel.Size.Width == 230)
                {
                    sliderHideTimer.Start();
                }
                else if (slidePanel.Size.Width == 70)
                {
                    sliderShowTimer.Start();
                }
            }
        }

        private void AdminPanel_Load(object sender, EventArgs e)
        {
            LoadForm(home);
            this.Opacity = 0;
            faddingTimer.Start();
        }

        private void faddingTimer_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1)
            {
                this.Opacity += 0.05;
            }
            else
            {
                faddingTimer.Stop();
            }
        }
        private void Button(KryptonCheckButton button)
        {
            cb.Checked = false;
            cb = button;
        }
    }
}