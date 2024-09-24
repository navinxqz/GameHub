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

namespace GameServer_Management.Forms
{
    public partial class AdminDB : Form
    {
        public AdminDB()
        {
            InitializeComponent();
            this.AutoScaleDimensions = new SizeF(96F, 96F);
            this.AutoScaleMode = AutoScaleMode.Dpi;
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

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            GetData();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentCell?.OwningColumn?.Name == "dgvDelete")
            {
                if (DialogResult.Yes == MessageBox.Show("Do you want to delete?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                {
                    int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["dgvId"].Value);
                    string query = "sp_DeleteAdmin";
                    Hashtable h = new Hashtable();
                    h.Add("@userid", id);

                    if (DBconnect.SQL(query, h) > 0)
                    {
                        MessageBox.Show("Deleted Successfully", "GameServer Management", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        GetData();
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                DBconnect.BlurBg(new AddAdmin());
                GetData();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to add the admin! {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
