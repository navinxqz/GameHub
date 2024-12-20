﻿using GameServer_Management.Class;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace GameServer_Management.Forms
{
    public partial class AddCategory : Form
    {
        public AddCategory()
        {
            InitializeComponent();
            this.AutoScaleDimensions = new SizeF(96F, 96F);
            this.AutoScaleMode = AutoScaleMode.Dpi;
        }
        public int id = 0;

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string query = "";
            if(id == 0)
            {
                query = "sp_AddCategory"; //insert
            }
            else
            {
                query = "sp_UpdateCategory"; //update
            }
            Hashtable h = new Hashtable();
            h.Add("@catID", id);
            h.Add("@catName", txtCat.Text);

            if(DBconnect.SQL(query,h) > 0)
            {
                MessageBox.Show("Saved Successfully!", "GameHub", MessageBoxButtons.OK, MessageBoxIcon.Information);
                id = 0;
                txtCat.Clear();
                txtCat.Focus();
            }
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
