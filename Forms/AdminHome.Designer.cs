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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminHome));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listPanel = new System.Windows.Forms.Panel();
            this.CategoryPanel = new System.Windows.Forms.Panel();
            this.btnHome = new Krypton.Toolkit.KryptonCheckButton();
            this.gameDesc1 = new GameServer_Management.Controller.GameDesc();
            this.gameDesc4 = new GameServer_Management.Controller.GameDesc();
            this.gameDesc2 = new GameServer_Management.Controller.GameDesc();
            this.gameDesc3 = new GameServer_Management.Controller.GameDesc();
            this.listPanel.SuspendLayout();
            this.CategoryPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(14, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Recently Uploaded";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(1054, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 31);
            this.label2.TabIndex = 6;
            this.label2.Text = "Category";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // listPanel
            // 
            this.listPanel.Controls.Add(this.gameDesc1);
            this.listPanel.Controls.Add(this.gameDesc4);
            this.listPanel.Controls.Add(this.gameDesc2);
            this.listPanel.Controls.Add(this.gameDesc3);
            this.listPanel.Location = new System.Drawing.Point(20, 66);
            this.listPanel.Name = "listPanel";
            this.listPanel.Size = new System.Drawing.Size(1031, 810);
            this.listPanel.TabIndex = 9;
            // 
            // CategoryPanel
            // 
            this.CategoryPanel.Controls.Add(this.btnHome);
            this.CategoryPanel.Location = new System.Drawing.Point(1057, 63);
            this.CategoryPanel.Name = "CategoryPanel";
            this.CategoryPanel.Size = new System.Drawing.Size(266, 663);
            this.CategoryPanel.TabIndex = 8;
            // 
            // btnHome
            // 
            this.btnHome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHome.ButtonStyle = Krypton.Toolkit.ButtonStyle.LowProfile;
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.Location = new System.Drawing.Point(3, 3);
            this.btnHome.Name = "btnHome";
            this.btnHome.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.btnHome.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.btnHome.Size = new System.Drawing.Size(263, 53);
            this.btnHome.StateCheckedNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(115)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
            this.btnHome.StateCheckedNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(115)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
            this.btnHome.StateCheckedNormal.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnHome.StateCheckedNormal.Border.Color1 = System.Drawing.Color.Transparent;
            this.btnHome.StateCheckedNormal.Border.Color2 = System.Drawing.Color.Transparent;
            this.btnHome.StateCheckedNormal.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnHome.StateCheckedNormal.Content.AdjacentGap = 20;
            this.btnHome.StateCheckedNormal.Content.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.btnHome.StateCheckedNormal.Content.Image.ImageV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.btnHome.StateCheckedNormal.Content.Padding = new System.Windows.Forms.Padding(19, -1, 0, -1);
            this.btnHome.StateCheckedNormal.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
            this.btnHome.StateCheckedNormal.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
            this.btnHome.StateCheckedNormal.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.StateCheckedNormal.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.btnHome.StateCheckedNormal.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.btnHome.StateCheckedNormal.Content.ShortText.Trim = Krypton.Toolkit.PaletteTextTrim.Character;
            this.btnHome.StateCheckedPressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(115)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
            this.btnHome.StateCheckedPressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(115)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
            this.btnHome.StateCheckedPressed.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnHome.StateCheckedPressed.Content.AdjacentGap = 20;
            this.btnHome.StateCheckedPressed.Content.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.btnHome.StateCheckedPressed.Content.Image.ImageV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.btnHome.StateCheckedPressed.Content.Padding = new System.Windows.Forms.Padding(19, -1, 0, -1);
            this.btnHome.StateCheckedPressed.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
            this.btnHome.StateCheckedPressed.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
            this.btnHome.StateCheckedPressed.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.StateCheckedPressed.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.btnHome.StateCheckedPressed.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.btnHome.StateCheckedPressed.Content.ShortText.Trim = Krypton.Toolkit.PaletteTextTrim.Word;
            this.btnHome.StateCheckedTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(115)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
            this.btnHome.StateCheckedTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(115)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
            this.btnHome.StateCheckedTracking.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnHome.StateCheckedTracking.Content.AdjacentGap = 20;
            this.btnHome.StateCheckedTracking.Content.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.btnHome.StateCheckedTracking.Content.Image.ImageV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.btnHome.StateCheckedTracking.Content.Padding = new System.Windows.Forms.Padding(19, -1, 0, -1);
            this.btnHome.StateCheckedTracking.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
            this.btnHome.StateCheckedTracking.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
            this.btnHome.StateCheckedTracking.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.StateCheckedTracking.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.btnHome.StateCheckedTracking.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.btnHome.StateCheckedTracking.Content.ShortText.Trim = Krypton.Toolkit.PaletteTextTrim.Word;
            this.btnHome.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.btnHome.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.btnHome.StateNormal.Content.AdjacentGap = 20;
            this.btnHome.StateNormal.Content.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.btnHome.StateNormal.Content.Image.ImageV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.btnHome.StateNormal.Content.Padding = new System.Windows.Forms.Padding(19, -1, 0, -1);
            this.btnHome.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnHome.StateNormal.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnHome.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.StateNormal.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.btnHome.StateNormal.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.btnHome.StateNormal.Content.ShortText.Trim = Krypton.Toolkit.PaletteTextTrim.Word;
            this.btnHome.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(115)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
            this.btnHome.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(115)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
            this.btnHome.StatePressed.Border.Color1 = System.Drawing.Color.Transparent;
            this.btnHome.StatePressed.Border.Color2 = System.Drawing.Color.Transparent;
            this.btnHome.StatePressed.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnHome.StatePressed.Content.AdjacentGap = 20;
            this.btnHome.StatePressed.Content.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.btnHome.StatePressed.Content.Image.ImageV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.btnHome.StatePressed.Content.Padding = new System.Windows.Forms.Padding(19, -1, 0, -1);
            this.btnHome.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
            this.btnHome.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
            this.btnHome.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.StatePressed.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.btnHome.StatePressed.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.btnHome.StatePressed.Content.ShortText.Trim = Krypton.Toolkit.PaletteTextTrim.Word;
            this.btnHome.StateTracking.Back.Color1 = System.Drawing.Color.DimGray;
            this.btnHome.StateTracking.Back.Color2 = System.Drawing.Color.DimGray;
            this.btnHome.StateTracking.Border.Color1 = System.Drawing.Color.Transparent;
            this.btnHome.StateTracking.Border.Color2 = System.Drawing.Color.Transparent;
            this.btnHome.StateTracking.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnHome.StateTracking.Content.AdjacentGap = 20;
            this.btnHome.StateTracking.Content.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.btnHome.StateTracking.Content.Image.ImageV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.btnHome.StateTracking.Content.Padding = new System.Windows.Forms.Padding(19, -1, 0, -1);
            this.btnHome.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnHome.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnHome.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.StateTracking.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.btnHome.StateTracking.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.btnHome.StateTracking.Content.ShortText.Trim = Krypton.Toolkit.PaletteTextTrim.Word;
            this.btnHome.TabIndex = 1;
            // 
            // gameDesc1
            // 
            this.gameDesc1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.gameDesc1.Category = null;
            this.gameDesc1.GName = "Game Name";
            this.gameDesc1.id = 0;
            this.gameDesc1.Location = new System.Drawing.Point(19, 21);
            this.gameDesc1.Name = "gameDesc1";
            this.gameDesc1.Pic = ((System.Drawing.Image)(resources.GetObject("gameDesc1.Pic")));
            this.gameDesc1.Price = "$";
            this.gameDesc1.Size = new System.Drawing.Size(211, 366);
            this.gameDesc1.TabIndex = 2;
            // 
            // gameDesc4
            // 
            this.gameDesc4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.gameDesc4.Category = null;
            this.gameDesc4.GName = "Game Name";
            this.gameDesc4.id = 0;
            this.gameDesc4.Location = new System.Drawing.Point(751, 21);
            this.gameDesc4.Name = "gameDesc4";
            this.gameDesc4.Pic = ((System.Drawing.Image)(resources.GetObject("gameDesc4.Pic")));
            this.gameDesc4.Price = "$";
            this.gameDesc4.Size = new System.Drawing.Size(211, 366);
            this.gameDesc4.TabIndex = 5;
            // 
            // gameDesc2
            // 
            this.gameDesc2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.gameDesc2.Category = null;
            this.gameDesc2.GName = "Game Name";
            this.gameDesc2.id = 0;
            this.gameDesc2.Location = new System.Drawing.Point(263, 21);
            this.gameDesc2.Name = "gameDesc2";
            this.gameDesc2.Pic = ((System.Drawing.Image)(resources.GetObject("gameDesc2.Pic")));
            this.gameDesc2.Price = "$";
            this.gameDesc2.Size = new System.Drawing.Size(211, 366);
            this.gameDesc2.TabIndex = 3;
            // 
            // gameDesc3
            // 
            this.gameDesc3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.gameDesc3.Category = null;
            this.gameDesc3.GName = "Game Name";
            this.gameDesc3.id = 0;
            this.gameDesc3.Location = new System.Drawing.Point(508, 21);
            this.gameDesc3.Name = "gameDesc3";
            this.gameDesc3.Pic = ((System.Drawing.Image)(resources.GetObject("gameDesc3.Pic")));
            this.gameDesc3.Price = "$";
            this.gameDesc3.Size = new System.Drawing.Size(211, 366);
            this.gameDesc3.TabIndex = 4;
            // 
            // AdminHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(1322, 715);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listPanel);
            this.Controls.Add(this.CategoryPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminHome";
            this.Load += new System.EventHandler(this.AdminHome_Load);
            this.listPanel.ResumeLayout(false);
            this.CategoryPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private Controller.GameDesc gameDesc1;
        private Controller.GameDesc gameDesc2;
        private Controller.GameDesc gameDesc3;
        private Controller.GameDesc gameDesc4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel listPanel;
        public System.Windows.Forms.Panel CategoryPanel;
        private Krypton.Toolkit.KryptonCheckButton btnHome;
    }
}