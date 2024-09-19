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
    public partial class GameDB : Form
    {
        public GameDB()
        {
            InitializeComponent();
        }
        public void GetData()
        {
            string query = @"select g.gameID, g.gameName, g.gameDesc, g.gameprice,g.category, g.categoryID, g.releaseDate from gamestbl g inner join categorytbl c on c.catID = g.categoryID where g.gameName like '%" + searchtxtbox.Text + "%' ";
            ListBox l = new ListBox();
            l.Items.Add(dgvId);
            l.Items.Add(dgvName);
            l.Items.Add(dgvDesc);
            l.Items.Add(dgvPrice);
            l.Items.Add(dgvCatID);
            l.Items.Add(dgvCat);
            l.Items.Add(dgvRelDate);

            DBconnect.LoadData(query, dataGridView1, l);
        }
        private void GameDB_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DBconnect.BlurBg(new AddGames());
            GetData();
        }

        private void searchtxtbox_TextChanged(object sender, EventArgs e)
        {
            GetData();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentCell.OwningColumn.Name == "dgvEdit")
            {
                AddGames c = new AddGames();
                c.id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["dgvId"].Value);
                c.txtName.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["dgvName"].Value);
                c.txtDesc.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["dgvDesc"].Value);
                c.txtPrice.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["dgvPrice"].Value);
                c.cbCat.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["dgvCat"].Value);
                c.txtRelDate.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["dgvRelDate"].Value);

                DBconnect.BlurBg(c);
                GetData();
            }
            if (dataGridView1.CurrentCell?.OwningColumn?.Name == "dgvDelete")
            {
                if (DialogResult.Yes == MessageBox.Show("Do you want to delete?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                {
                    int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["dgvId"].Value);
                    string query = "sp_deleteGame";
                    Hashtable h = new Hashtable();
                    h.Add("@gameID", id);

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
    }
}
