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
    public partial class UserDB : Form
    {
        public UserDB()
        {
            InitializeComponent();
            this.AutoScaleDimensions = new SizeF(96F, 96F);
            this.AutoScaleMode = AutoScaleMode.Dpi;
        }
        public void GetData()
        {
            try
            {
                string query = @"select userid, concat(firstname, ' ', lastname), gender, email, username, dob from usertbl where username like '%"+ searchBox.Text+ "%' or firstname like '%"+ searchBox.Text+"%'";

                ListBox l = new ListBox();
                l.Items.Add(dgvId);
                l.Items.Add(dgvName);
                l.Items.Add(dgvGender);
                l.Items.Add(dgvEmail);
                l.Items.Add(dgvusername);
                l.Items.Add(dgvDOB);

                DBconnect.LoadData(query, dataGridView1, l);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load data! {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UserDB_Load(object sender, EventArgs e)
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
                    string query = "sp_DeleteUser";
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
    }
}
