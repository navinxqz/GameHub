using GameServer_Management.Class;
using System;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;

namespace GameServer_Management.Forms
{
    public partial class AddAdmin : Form
    {
        public int id = 0;
        public AddAdmin()
        {
            InitializeComponent();
            this.AutoScaleDimensions = new SizeF(96F, 96F);
            this.AutoScaleMode = AutoScaleMode.Dpi;
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string query = "";
            if (id == 0){ query = "sp_AddAdmin"; }

            Hashtable h = new Hashtable();
            if (id != 0) { h.Add("@userid", id); }

            h.Add("@fullname", txtFullName.Text);
            h.Add("@username", txtUsername.Text);
            h.Add("@upass", txtpass.Text);

            if (DBconnect.SQL(query, h) > 0)
            {
                MessageBox.Show("Admin saved successfully!", "GameHub", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
            }
            else
            {
                MessageBox.Show("Error! Please check your inputs and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ClearForm()
        {
            id = 0;
            txtFullName.Clear();
            txtUsername.Clear();
            txtpass.Clear();
            txtFullName.Focus();
        }

        private void show_pass_btn_Click(object sender, EventArgs e)
        {
            hide_pass_btn.Visible = true;
            show_pass_btn.Visible = false;
            txtpass.PasswordChar = '*';
        }

        private void hide_pass_btn_Click(object sender, EventArgs e)
        {
            hide_pass_btn.Visible = false;
            show_pass_btn.Visible = true;
            txtpass.PasswordChar = '\0';
        }

        private void txtpass_TextChanged(object sender, EventArgs e)
        {
            hide_pass_btn.Visible = true;
        }
    }
}
