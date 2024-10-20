﻿using GameServer_Management.Class;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace GameServer_Management.Controller
{
    public partial class GameDesc : UserControl
    {
        public GameDesc()
        {
            InitializeComponent();
            Utility.ClickEvent(panel1, Panel1_Click);
            this.MouseClick += GameImg_MouseClick;  
        }
        public event EventHandler onSelect; // = null

        public int id { get;set; }
        public string desc 
        {
            get { return desclbl.Text; }
            set { desclbl.Text = value; }
        }
        public string GName 
        {
            get { return gameName.Text; }
            set { gameName.Text = value; }
        }
        public string Price
        {
            get { return pricelbl.Text; }
            set { pricelbl.Text = value; }
        }
        public Image Pic
        {
            get { return GameImg.Image; }
            set { GameImg.Image = value; }
        }
        public string Category 
        {
            get { return catName.Text; }
            set { catName.Text = value; }
        }
        public string Date
        {
            get { return gameRelease.Text; }
            set { gameRelease.Text = value; }
        }

        private void GameImg_MouseClick(object sender, MouseEventArgs e)
        {
            onSelect?.Invoke(this, e);
        }

        private void Panel1_Click(object sender, EventArgs e)
        {
            onSelect?.Invoke(this, e);
        }
    }
}
