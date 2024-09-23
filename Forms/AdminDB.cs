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
    public partial class AdminDB : Form
    {
        public AdminDB()
        {
            InitializeComponent();
        }
        public void GetData()
        {
            try
            {
                string query = @"select userid, fullname, username from admintbl where username like '%" + searchBox.Text + "%' or fullname like '%" + searchBox.Text + "%'";

                ListBox l = new ListBox();
                l.Items.Add(dgvId);
                l.Items.Add(dgvName);
                l.Items.Add(dgvusername);

                DBconnect.LoadData(query, dataGridView1, l);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load data! {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AdminDB_Load(object sender, EventArgs e)
        {
            GetData();
        }
    }
}
