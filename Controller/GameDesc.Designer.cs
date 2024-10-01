namespace GameServer_Management.Controller
{
    partial class GameDesc
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameDesc));
            this.GameImg = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelcat = new System.Windows.Forms.Panel();
            this.catName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pricelbl = new System.Windows.Forms.Label();
            this.gameName = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.desclbl = new CuoreUI.Controls.cuiLabel();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse3 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse4 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.gameRelease = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GameImg)).BeginInit();
            this.panel1.SuspendLayout();
            this.panelcat.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // GameImg
            // 
            this.GameImg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GameImg.Image = ((System.Drawing.Image)(resources.GetObject("GameImg.Image")));
            this.GameImg.Location = new System.Drawing.Point(-22, -8);
            this.GameImg.Name = "GameImg";
            this.GameImg.Size = new System.Drawing.Size(258, 320);
            this.GameImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.GameImg.TabIndex = 0;
            this.GameImg.TabStop = false;
            this.GameImg.MouseClick += new System.Windows.Forms.MouseEventHandler(this.GameImg_MouseClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panelcat);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pricelbl);
            this.panel1.Controls.Add(this.gameName);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 261);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(211, 105);
            this.panel1.TabIndex = 3;
            // 
            // panelcat
            // 
            this.panelcat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.panelcat.Controls.Add(this.catName);
            this.panelcat.Location = new System.Drawing.Point(92, 62);
            this.panelcat.Name = "panelcat";
            this.panelcat.Size = new System.Drawing.Size(110, 32);
            this.panelcat.TabIndex = 4;
            // 
            // catName
            // 
            this.catName.BackColor = System.Drawing.Color.Transparent;
            this.catName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(171)))), ((int)(((byte)(174)))));
            this.catName.Location = new System.Drawing.Point(0, 2);
            this.catName.Name = "catName";
            this.catName.Size = new System.Drawing.Size(114, 27);
            this.catName.TabIndex = 2;
            this.catName.Text = "category";
            this.catName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(10, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "$";
            // 
            // pricelbl
            // 
            this.pricelbl.BackColor = System.Drawing.Color.Transparent;
            this.pricelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pricelbl.ForeColor = System.Drawing.Color.White;
            this.pricelbl.Location = new System.Drawing.Point(25, 67);
            this.pricelbl.Name = "pricelbl";
            this.pricelbl.Size = new System.Drawing.Size(60, 29);
            this.pricelbl.TabIndex = 1;
            this.pricelbl.Text = "9.99";
            // 
            // gameName
            // 
            this.gameName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameName.ForeColor = System.Drawing.Color.White;
            this.gameName.Location = new System.Drawing.Point(3, 9);
            this.gameName.Name = "gameName";
            this.gameName.Size = new System.Drawing.Size(205, 58);
            this.gameName.TabIndex = 0;
            this.gameName.Text = "Game Name";
            this.gameName.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gameName_MouseClick);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Teal;
            this.panel3.Location = new System.Drawing.Point(7, 52);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(68, 38);
            this.panel3.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.GameImg);
            this.panel2.Controls.Add(this.desclbl);
            this.panel2.Controls.Add(this.gameRelease);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(211, 366);
            this.panel2.TabIndex = 4;
            // 
            // desclbl
            // 
            this.desclbl.Content = "Your\\ text\\ here!";
            this.desclbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 2.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desclbl.HorizontalAlignment = CuoreUI.Controls.cuiLabel.HorizontalAlignments.Center;
            this.desclbl.Location = new System.Drawing.Point(14, 123);
            this.desclbl.Name = "desclbl";
            this.desclbl.Size = new System.Drawing.Size(32, 19);
            this.desclbl.TabIndex = 1;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 40;
            this.bunifuElipse1.TargetControl = this.GameImg;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 40;
            this.bunifuElipse2.TargetControl = this.panel2;
            // 
            // bunifuElipse3
            // 
            this.bunifuElipse3.ElipseRadius = 40;
            this.bunifuElipse3.TargetControl = this;
            // 
            // bunifuElipse4
            // 
            this.bunifuElipse4.ElipseRadius = 20;
            this.bunifuElipse4.TargetControl = this.panelcat;
            // 
            // gameRelease
            // 
            this.gameRelease.AutoSize = true;
            this.gameRelease.Location = new System.Drawing.Point(79, 76);
            this.gameRelease.Name = "gameRelease";
            this.gameRelease.Size = new System.Drawing.Size(35, 13);
            this.gameRelease.TabIndex = 2;
            this.gameRelease.Text = "label2";
            // 
            // GameDesc
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(43)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(0, 0, 20, 10);
            this.Name = "GameDesc";
            this.Size = new System.Drawing.Size(211, 366);
            ((System.ComponentModel.ISupportInitialize)(this.GameImg)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panelcat.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox GameImg;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label pricelbl;
        private System.Windows.Forms.Label gameName;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse3;
        private System.Windows.Forms.Panel panelcat;
        private System.Windows.Forms.Label catName;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse4;
        private CuoreUI.Controls.cuiLabel desclbl;
        private System.Windows.Forms.Label gameRelease;
    }
}
