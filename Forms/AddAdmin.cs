using GameServer_Management.Class;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace GameServer_Management.Forms
{
    public partial class AddAdmin : Form
    {
        public int id = 0;
        public AddAdmin()
        {
            InitializeComponent();
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
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
