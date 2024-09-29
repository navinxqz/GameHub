using GameServer_Management.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameServer_Management.Forms
{
    public partial class Login : Form
    {
        public static string username { get; private set; }

        public Login()
        {
            InitializeComponent();
            this.AutoScaleDimensions = new SizeF(96F, 96F);
            this.AutoScaleMode = AutoScaleMode.Dpi;
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

        private void exitbtn_MouseHover(object sender, EventArgs e)
        {
            string projectDir = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName;
            string imgPath = Path.Combine(projectDir, "asset", "x_red(39).png");
            exitbtn.Image = Image.FromFile(imgPath);
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            string projectDir = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName;
            string imgPath = Path.Combine(projectDir, "asset", "x(39).png");
            exitbtn.Image = Image.FromFile(imgPath);
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            if (DBconnect.IsValidUser(txtUsername.Text, txtpass.Text) == false)
            {
                MessageBox.Show("Invalid Username or password");
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
                DBconnect.BlurBg(new SignUp());
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
    }
}