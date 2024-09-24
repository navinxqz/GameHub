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
            h.Add("@upass", txtPass.Text);

            if (DBconnect.SQL(query, h) > 0)
            {
                MessageBox.Show("Saved Successfully!", "GameServer Management", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
            }
            else
            {
                MessageBox.Show("Error while adding the admin. Please check your inputs and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ClearForm()
        {
            id = 0;
            txtFullName.Clear();
            txtUsername.Clear();
            txtPass.Clear();
            txtFullName.Focus();
        }
    }
}
