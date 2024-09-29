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
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
            this.AutoScaleDimensions = new SizeF(96F, 96F);
            this.AutoScaleMode = AutoScaleMode.Dpi;
        }

        private void Logoutbtn_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void cuiButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            if (DBconnect.IsValidAdmin(txtUsername.Text,txtpass.Text) == false)
            {
                MessageBox.Show("Invalid Username or password");
            }
            else {
                loading.Visible = true;
                await Task.Delay(1000);

                //MessageBox.Show("Login Successful");
                AdminPanel adminPanel = new AdminPanel(true);
                adminPanel.Show();
                this.Hide();
            }
        }

        private void HidePassBtn_Click(object sender, EventArgs e)
        {
            HidePassBtn.Visible = false;
            showPassBtn.Visible = true;
            txtpass.PasswordChar = '*';
        }

        private void showPassBtn_Click(object sender, EventArgs e)
        {
            HidePassBtn.Visible = true;
            showPassBtn.Visible = false;
            txtpass.PasswordChar = '\0';
        }

        private async void Enter_Key(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)     //Enter key press in action
            {
                loading.Visible = true;
                await Task.Delay(1000);
                btnLogin_Click(sender, e);
            }
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

            //exitbtn.Image = Image.FromFile("img\\x_red.png");
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            string projectDir = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName;
            string imgPath = Path.Combine(projectDir, "asset", "x(39).png");
            exitbtn.Image = Image.FromFile(imgPath); 
            //exitbtn.Image = Image.FromFile("img\\x.png");
        }

        private void AdminLogin_Load(object sender, EventArgs e)
        {
            loading.Visible = false;
        }
    }
}
