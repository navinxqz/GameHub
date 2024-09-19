﻿using GameServer_Management.Class;
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
    public partial class GameCatView : Form
    {
        public GameCatView()
        {
            InitializeComponent();
        }
        public void GetData() 
        {
            string query = "select catID, catName from categorytbl where catName like '%"+searchtxtbox.Text+"%' ";
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
            AddCategory c = new AddCategory();
            c.ShowDialog();
            GetData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void searchtxtbox_TextChanged(object sender, EventArgs e)
        {
            GetData();
        }

        private void searchtxtbox_Enter(object sender, EventArgs e)
        {
            if (searchtxtbox.Text == "Search")
            {
                searchtxtbox.StateActive.Content.Color1 = Color.FromArgb(255, 115, 115);
                searchtxtbox.Text = String.Empty;
            }
        }

        private void searchtxtbox_Leave(object sender, EventArgs e)
        {

        }
    }
}
