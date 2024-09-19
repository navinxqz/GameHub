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
    public partial class GameCatView : Form
    {
        public GameCatView()
        {
            InitializeComponent();
        }
        public void GetData() 
        {
            string query = "sp_LoadCategory";
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
    }
}
