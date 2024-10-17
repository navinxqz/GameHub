using GameServer_Management.Class;
using System;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;

namespace GameServer_Management.Forms
{
    public partial class GameDB : Form
    {
        public GameDB()
        {
            InitializeComponent();
            this.AutoScaleDimensions = new SizeF(96F, 96F);
            this.AutoScaleMode = AutoScaleMode.Dpi;
            infoPanel.Visible = false;

            Utility.ClickEvent(infoPanel, infoPanel_Click);
        }
        public void GetData()
        {
            try
            {
                string query = @"select g.gameID, g.gameName, g.gameDesc, g.gameprice, g.categoryID, c.catName AS category, g.releaseDate from gamestbl g inner join categorytbl c on c.catID = g.categoryID where g.gameName like '%" + searchBox.Text + "%' ";

                ListBox l = new ListBox();
                l.Items.Add(dgvId);
                l.Items.Add(dgvName);
                l.Items.Add(dgvDesc);
                l.Items.Add(dgvPrice);
                l.Items.Add(dgvCatID);
                l.Items.Add(dgvCat);
                l.Items.Add(dgvRelDate);

                DBconnect.LoadData(query, dataGridView1, l);
                
                games.Text = dataGridView1.Rows.Count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load data! {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void GameDB_Load(object sender, EventArgs e)
        {
            GetData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Utility.BlurBg(new AddGames());
                GetData();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to add game! {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentCell.OwningColumn.Name == "dgvEdit")
            {
                AddGames c = new AddGames();
                c.id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["dgvId"].Value);
                c.catID = Convert.ToInt32(dataGridView1.CurrentRow.Cells["dgvCatID"].Value);

                Utility.BlurBg(c);
                GetData();
            }
            if (dataGridView1.CurrentCell?.OwningColumn?.Name == "dgvDelete")
            {
                if (DialogResult.Yes == MessageBox.Show("Do you want to delete?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                {
                    int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["dgvId"].Value);
                    string query = "sp_deleteGame";

                    Hashtable h = new Hashtable
                    {
                         { "@gameID", id }
                    };
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

        private void infobtn_Click(object sender, EventArgs e)
        {
            infoPanel.Visible = !infoPanel.Visible;
        }

        private void infoPanel_Click(object sender, EventArgs e)
        {
            infoPanel.Visible = false;
        }

        private void searchBox_TextChanged_1(object sender, EventArgs e)
        {
            GetData();
        }
    }
}
