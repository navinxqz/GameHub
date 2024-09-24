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
    public partial class GameCatView : Form
    {
        public GameCatView()
        {
            InitializeComponent();
            this.AutoScaleDimensions = new SizeF(96F, 96F);
            this.AutoScaleMode = AutoScaleMode.Dpi;
        }
        public void GetData() 
        {
            string query = @"select catID, catName from categorytbl where catName like '%"+searchtxtbox.Text+"%' ";
            ListBox l = new ListBox();
            l.Items.Add(dgvId);
            l.Items.Add(dgvName);

            DBconnect.LoadData(query, dataGridView1, l);
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {

        }

        private void catbtn_Click(object sender, EventArgs e)
        {

        }

        private void GameCatView_Load(object sender, EventArgs e)
        {
            GetData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //AddCategory c = new AddCategory();
            //c.ShowDialog();
            DBconnect.BlurBg(new AddCategory());
            GetData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void searchtxtbox_TextChanged(object sender, EventArgs e)
        {
            GetData();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dataGridView1.CurrentCell.OwningColumn.Name == "dgvEdit")
            {
                AddCategory c = new AddCategory();
                c.id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["dgvId"].Value);
                c.txtCat.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["dgvName"].Value);
                
                DBconnect.BlurBg(c);
                GetData();
            }
            if (dataGridView1.CurrentCell?.OwningColumn?.Name == "dgvDelete") 
            {
                if(DialogResult.Yes == MessageBox.Show("Do you want to delete?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                {
                    int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["dgvId"].Value);
                    string query = "sp_DeleteCategory";
                    Hashtable h = new Hashtable();
                    h.Add("@catID", id);

                    //DBconnect.SQL(query, h);
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

        private void searchtxtbox_TextChanged_1(object sender, EventArgs e)
        {
            GetData();
        }
    }
}
