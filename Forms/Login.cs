﻿using GameServer_Management.Class;
using System;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameServer_Management.Forms
{
    public partial class Login : Form
    {
        public static string username { get; private set; }
        private string redExitImgPath;
        private string exitImgPath;

        public Login()
        {
            InitializeComponent();
            this.AutoScaleDimensions = new SizeF(96F, 96F);
            this.AutoScaleMode = AutoScaleMode.Dpi;

            //img paths preloaded
            string projectDir = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName;
            redExitImgPath = Path.Combine(projectDir, "asset", "x_red(39).png");
            exitImgPath = Path.Combine(projectDir, "asset", "x(39).png");
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            AdminLogin adminLogin = new AdminLogin();
            adminLogin.Show();
            this.Hide();
        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ExitBtnImg(string imgPath)
        {
            if (File.Exists(imgPath))
            {
                exitbtn.Image = Image.FromFile(imgPath);
            }
        }

        private void exitbtn_MouseHover(object sender, EventArgs e)
        {
            ExitBtnImg(redExitImgPath);
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            ExitBtnImg(exitImgPath);
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            if (DBconnect.IsValidUser(txtUsername.Text, txtpass.Text) == false)
            {
                MessageBox.Show("Invalid Username or password","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                loading.Visible = true;
                await Task.Delay(1000);

                //MessageBox.Show("Login Successful");
                username = txtUsername.Text;
                AdminPanel ap = new AdminPanel(false,username);
                ap.Show();
                this.Hide();
            }
        }

        private void createbtn_Click(object sender, EventArgs e)
        {
            try
            {
                Utility.BlurBg(new SignUp());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to signup! {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void showPassBtn_Click_1(object sender, EventArgs e)
        {
            HidePassBtn.Visible = true;
            showPassBtn.Visible = false;
            txtpass.PasswordChar = '\0';
        }

        private void HidePassBtn_Click_1(object sender, EventArgs e)
        {
            HidePassBtn.Visible = false;
            showPassBtn.Visible = true;
            txtpass.PasswordChar = '*';
        }

        private async void Enter_Key(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                loading.Visible = true;
                await Task.Delay(1000);

                btnLogin_Click(sender, e);
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            loading.Visible = false;
        }
        //e.Graphics.DrawString("Click to close", new Font("Arial", 10, FontStyle.Underline), Brushes.Blue, new Point(10, 10));
    }
}