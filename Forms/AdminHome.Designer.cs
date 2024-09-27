namespace GameServer_Management.Forms
{
    partial class AdminHome
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminHome));
            this.label1 = new System.Windows.Forms.Label();
            this.listPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.CategoryPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.searchtxtbox = new Krypton.Toolkit.KryptonTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.loadingtimer = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.cuiLabel1 = new CuoreUI.Controls.cuiLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gameDesc = new CuoreUI.Controls.cuiLabel();
            this.slideImageBox = new System.Windows.Forms.PictureBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.bunifuElipse3 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.slideImgTimer = new System.Windows.Forms.Timer(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse4 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse5 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.loading = new GameServer_Management.Controller.Loading();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.slideImageBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(33, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "You might like";
            // 
            // listPanel
            // 
            this.listPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listPanel.AutoScroll = true;
            this.listPanel.Location = new System.Drawing.Point(24, 238);
            this.listPanel.Name = "listPanel";
            this.listPanel.Size = new System.Drawing.Size(1106, 427);
            this.listPanel.TabIndex = 9;
            // 
            // CategoryPanel
            // 
            this.CategoryPanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CategoryPanel.AutoScroll = true;
            this.CategoryPanel.Location = new System.Drawing.Point(1023, 294);
            this.CategoryPanel.Name = "CategoryPanel";
            this.CategoryPanel.Size = new System.Drawing.Size(284, 514);
            this.CategoryPanel.TabIndex = 10;
            // 
            // searchtxtbox
            // 
            this.searchtxtbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchtxtbox.CornerRoundingRadius = 20F;
            this.searchtxtbox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchtxtbox.Location = new System.Drawing.Point(976, 13);
            this.searchtxtbox.Name = "searchtxtbox";
            this.searchtxtbox.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.searchtxtbox.Size = new System.Drawing.Size(291, 47);
            this.searchtxtbox.StateActive.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.searchtxtbox.StateActive.Border.Color1 = System.Drawing.Color.Transparent;
            this.searchtxtbox.StateActive.Border.Color2 = System.Drawing.Color.Transparent;
            this.searchtxtbox.StateActive.Border.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Local;
            this.searchtxtbox.StateActive.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.searchtxtbox.StateActive.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(71)))), ((int)(((byte)(78)))));
            this.searchtxtbox.StateActive.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchtxtbox.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(53)))), ((int)(((byte)(58)))));
            this.searchtxtbox.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(53)))), ((int)(((byte)(58)))));
            this.searchtxtbox.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.searchtxtbox.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.searchtxtbox.StateCommon.Border.Rounding = 20F;
            this.searchtxtbox.StateCommon.Content.Color1 = System.Drawing.Color.White;
            this.searchtxtbox.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchtxtbox.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.searchtxtbox.StateDisabled.Border.Color1 = System.Drawing.Color.Transparent;
            this.searchtxtbox.StateDisabled.Border.Color2 = System.Drawing.Color.Transparent;
            this.searchtxtbox.StateDisabled.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.searchtxtbox.StateDisabled.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(71)))), ((int)(((byte)(78)))));
            this.searchtxtbox.StateDisabled.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchtxtbox.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.searchtxtbox.TabIndex = 18;
            this.searchtxtbox.TextChanged += new System.EventHandler(this.searchtxtbox_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1218, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(44, 47);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 50;
            this.bunifuElipse1.TargetControl = this;
            // 
            // loadingtimer
            // 
            this.loadingtimer.Enabled = true;
            this.loadingtimer.Interval = 2000;
            this.loadingtimer.Tick += new System.EventHandler(this.loadingtimer_Tick);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.cuiLabel1);
            this.panel1.Controls.Add(this.CategoryPanel);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.listPanel);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(54, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1316, 734);
            this.panel1.TabIndex = 22;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.MediumPurple;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(496, 159);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(144, 30);
            this.panel3.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(37, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Windows";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(187)))), ((int)(((byte)(196)))));
            this.panel4.Controls.Add(this.pictureBox4);
            this.panel4.Controls.Add(this.pictureBox3);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.pictureBox2);
            this.panel4.Location = new System.Drawing.Point(701, 16);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(337, 138);
            this.panel4.TabIndex = 14;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(161, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(73, 138);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 4;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(230, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(112, 147);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.label2.Location = new System.Drawing.Point(14, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Upcoming";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(165, 138);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // cuiLabel1
            // 
            this.cuiLabel1.Content = "Content";
            this.cuiLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuiLabel1.ForeColor = System.Drawing.Color.White;
            this.cuiLabel1.HorizontalAlignment = CuoreUI.Controls.cuiLabel.HorizontalAlignments.Center;
            this.cuiLabel1.Location = new System.Drawing.Point(983, 238);
            this.cuiLabel1.Name = "cuiLabel1";
            this.cuiLabel1.Size = new System.Drawing.Size(287, 57);
            this.cuiLabel1.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(187)))), ((int)(((byte)(196)))));
            this.panel2.Controls.Add(this.gameDesc);
            this.panel2.Controls.Add(this.pictureBox5);
            this.panel2.Controls.Add(this.slideImageBox);
            this.panel2.Controls.Add(this.nameLabel);
            this.panel2.Location = new System.Drawing.Point(24, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(660, 175);
            this.panel2.TabIndex = 10;
            // 
            // gameDesc
            // 
            this.gameDesc.Content = resources.GetString("gameDesc.Content");
            this.gameDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(48)))));
            this.gameDesc.HorizontalAlignment = CuoreUI.Controls.cuiLabel.HorizontalAlignments.Left;
            this.gameDesc.Location = new System.Drawing.Point(211, 61);
            this.gameDesc.Name = "gameDesc";
            this.gameDesc.Size = new System.Drawing.Size(365, 62);
            this.gameDesc.TabIndex = 12;
            // 
            // slideImageBox
            // 
            this.slideImageBox.Image = ((System.Drawing.Image)(resources.GetObject("slideImageBox.Image")));
            this.slideImageBox.Location = new System.Drawing.Point(0, -23);
            this.slideImageBox.Name = "slideImageBox";
            this.slideImageBox.Size = new System.Drawing.Size(148, 234);
            this.slideImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.slideImageBox.TabIndex = 2;
            this.slideImageBox.TabStop = false;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(77)))));
            this.nameLabel.Location = new System.Drawing.Point(172, 16);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(311, 31);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Red Dead Redemption 2";
            // 
            // bunifuElipse3
            // 
            this.bunifuElipse3.ElipseRadius = 50;
            this.bunifuElipse3.TargetControl = this.panel2;
            // 
            // slideImgTimer
            // 
            this.slideImgTimer.Enabled = true;
            this.slideImgTimer.Interval = 5000;
            this.slideImgTimer.Tick += new System.EventHandler(this.slideImgTimer_Tick);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(171, 175);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 50;
            this.bunifuElipse2.TargetControl = this.pictureBox1;
            // 
            // bunifuElipse4
            // 
            this.bunifuElipse4.ElipseRadius = 30;
            this.bunifuElipse4.TargetControl = this.panel3;
            // 
            // bunifuElipse5
            // 
            this.bunifuElipse5.ElipseRadius = 50;
            this.bunifuElipse5.TargetControl = this.panel4;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(274, 80);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(196, 147);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 13;
            this.pictureBox5.TabStop = false;
            // 
            // loading
            // 
            this.loading.BackColor = System.Drawing.Color.WhiteSmoke;
            this.loading.Location = new System.Drawing.Point(517, 317);
            this.loading.Name = "loading";
            this.loading.Size = new System.Drawing.Size(221, 140);
            this.loading.TabIndex = 21;
            // 
            // AdminHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(1322, 715);
            this.Controls.Add(this.loading);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.searchtxtbox);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminHome";
            this.Load += new System.EventHandler(this.AdminHome_Load);
            this.Click += new System.EventHandler(this.AdminHome_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.slideImageBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel listPanel;
        private System.Windows.Forms.FlowLayoutPanel CategoryPanel;
        public Krypton.Toolkit.KryptonTextBox searchtxtbox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Controller.Loading loading;
        private System.Windows.Forms.Timer loadingtimer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse3;
        private System.Windows.Forms.Timer slideImgTimer;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.PictureBox slideImageBox;
        private CuoreUI.Controls.cuiLabel gameDesc;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse4;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse5;
        private CuoreUI.Controls.cuiLabel cuiLabel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
    }
}