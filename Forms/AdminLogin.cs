using GameServer_Management.Class;
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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (DBconnect.IsValidAdmin(txtUsername.Text,txtpass.Text) == false)
            {
                MessageBox.Show("Invalid Username or password");
            }
            else { 
                //MessageBox.Show("Login Successful");
                AdminPanel adminPanel = new AdminPanel();
                adminPanel.Show();
                this.Hide();
            }
        }

        private void txtpass_TextChanged(object sender, EventArgs e)
        {

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
    }
}
