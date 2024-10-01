namespace GameServer_Management.Controller
{
    partial class GetGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GetGame));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gameImg = new System.Windows.Forms.PictureBox();
            this.gameName = new CuoreUI.Controls.cuiLabel();
            this.gameDesc = new CuoreUI.Controls.cuiLabel();
            this.gamecat = new CuoreUI.Controls.cuiLabel();
            this.gameprice = new CuoreUI.Controls.cuiLabel();
            this.cancelbtn = new CuoreUI.Controls.cuiButton();
            this.getbtn = new CuoreUI.Controls.cuiButton();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel7 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.usericonbtn = new CuoreUI.Controls.cuiButton();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameImg)).BeginInit();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-39, -40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(648, 327);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // gameImg
            // 
            this.gameImg.BackColor = System.Drawing.Color.Transparent;
            this.gameImg.Image = ((System.Drawing.Image)(resources.GetObject("gameImg.Image")));
            this.gameImg.Location = new System.Drawing.Point(11, 199);
            this.gameImg.Name = "gameImg";
            this.gameImg.Size = new System.Drawing.Size(151, 222);
            this.gameImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gameImg.TabIndex = 12;
            this.gameImg.TabStop = false;
            // 
            // gameName
            // 
            this.gameName.BackColor = System.Drawing.Color.Transparent;
            this.gameName.Content = "Assassin’s\\ Creed\\ IV\\ Black\\ Flag";
            this.gameName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameName.ForeColor = System.Drawing.Color.White;
            this.gameName.HorizontalAlignment = CuoreUI.Controls.cuiLabel.HorizontalAlignments.Left;
            this.gameName.Location = new System.Drawing.Point(177, 301);
            this.gameName.Name = "gameName";
            this.gameName.Size = new System.Drawing.Size(365, 62);
            this.gameName.TabIndex = 14;
            // 
            // gameDesc
            // 
            this.gameDesc.BackColor = System.Drawing.Color.Transparent;
            this.gameDesc.Content = resources.GetString("gameDesc.Content");
            this.gameDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameDesc.ForeColor = System.Drawing.Color.Silver;
            this.gameDesc.HorizontalAlignment = CuoreUI.Controls.cuiLabel.HorizontalAlignments.Left;
            this.gameDesc.Location = new System.Drawing.Point(225, 364);
            this.gameDesc.Name = "gameDesc";
            this.gameDesc.Size = new System.Drawing.Size(290, 147);
            this.gameDesc.TabIndex = 15;
            // 
            // gamecat
            // 
            this.gamecat.BackColor = System.Drawing.Color.Transparent;
            this.gamecat.Content = "Action";
            this.gamecat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gamecat.ForeColor = System.Drawing.Color.Silver;
            this.gamecat.HorizontalAlignment = CuoreUI.Controls.cuiLabel.HorizontalAlignments.Left;
            this.gamecat.Location = new System.Drawing.Point(28, 469);
            this.gamecat.Name = "gamecat";
            this.gamecat.Size = new System.Drawing.Size(151, 25);
            this.gamecat.TabIndex = 16;
            // 
            // gameprice
            // 
            this.gameprice.BackColor = System.Drawing.Color.Transparent;
            this.gameprice.Content = "38\\.99";
            this.gameprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameprice.ForeColor = System.Drawing.Color.White;
            this.gameprice.HorizontalAlignment = CuoreUI.Controls.cuiLabel.HorizontalAlignments.Left;
            this.gameprice.Location = new System.Drawing.Point(41, 492);
            this.gameprice.Name = "gameprice";
            this.gameprice.Size = new System.Drawing.Size(73, 25);
            this.gameprice.TabIndex = 18;
            // 
            // cancelbtn
            // 
            this.cancelbtn.BackColor = System.Drawing.Color.Transparent;
            this.cancelbtn.CheckButton = false;
            this.cancelbtn.Checked = false;
            this.cancelbtn.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(106)))), ((int)(((byte)(163)))));
            this.cancelbtn.CheckedImageTint = System.Drawing.Color.White;
            this.cancelbtn.CheckedOutline = System.Drawing.Color.White;
            this.cancelbtn.Content = "Cancel";
            this.cancelbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(187)))), ((int)(((byte)(196)))));
            this.cancelbtn.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.cancelbtn.HoveredImageTint = System.Drawing.Color.White;
            this.cancelbtn.HoverOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cancelbtn.Image = null;
            this.cancelbtn.ImageAutoCenter = true;
            this.cancelbtn.ImageExpand = new System.Drawing.Point(0, 0);
            this.cancelbtn.ImageOffset = new System.Drawing.Point(0, 0);
            this.cancelbtn.ImageTint = System.Drawing.Color.White;
            this.cancelbtn.Location = new System.Drawing.Point(285, 583);
            this.cancelbtn.Name = "cancelbtn";
            this.cancelbtn.NormalBackground = System.Drawing.Color.Transparent;
            this.cancelbtn.NormalOutline = System.Drawing.Color.White;
            this.cancelbtn.OutlineThickness = 1.6F;
            this.cancelbtn.PressedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(77)))));
            this.cancelbtn.PressedImageTint = System.Drawing.Color.White;
            this.cancelbtn.PressedOutline = System.Drawing.Color.White;
            this.cancelbtn.Rounding = new System.Windows.Forms.Padding(15);
            this.cancelbtn.Size = new System.Drawing.Size(159, 54);
            this.cancelbtn.TabIndex = 63;
            this.cancelbtn.TextOffset = new System.Drawing.Point(0, 0);
            this.cancelbtn.Click += new System.EventHandler(this.cancelbtn_Click);
            // 
            // getbtn
            // 
            this.getbtn.BackColor = System.Drawing.Color.Transparent;
            this.getbtn.CheckButton = false;
            this.getbtn.Checked = false;
            this.getbtn.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(106)))), ((int)(((byte)(163)))));
            this.getbtn.CheckedImageTint = System.Drawing.Color.White;
            this.getbtn.CheckedOutline = System.Drawing.Color.White;
            this.getbtn.Content = "Get";
            this.getbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(187)))), ((int)(((byte)(196)))));
            this.getbtn.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.getbtn.HoveredImageTint = System.Drawing.Color.White;
            this.getbtn.HoverOutline = System.Drawing.Color.Transparent;
            this.getbtn.Image = ((System.Drawing.Image)(resources.GetObject("getbtn.Image")));
            this.getbtn.ImageAutoCenter = true;
            this.getbtn.ImageExpand = new System.Drawing.Point(0, 0);
            this.getbtn.ImageOffset = new System.Drawing.Point(0, 0);
            this.getbtn.ImageTint = System.Drawing.Color.White;
            this.getbtn.Location = new System.Drawing.Point(110, 583);
            this.getbtn.Name = "getbtn";
            this.getbtn.NormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(48)))));
            this.getbtn.NormalOutline = System.Drawing.Color.Transparent;
            this.getbtn.OutlineThickness = 1.6F;
            this.getbtn.PressedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(77)))));
            this.getbtn.PressedImageTint = System.Drawing.Color.White;
            this.getbtn.PressedOutline = System.Drawing.Color.White;
            this.getbtn.Rounding = new System.Windows.Forms.Padding(15);
            this.getbtn.Size = new System.Drawing.Size(160, 54);
            this.getbtn.TabIndex = 62;
            this.getbtn.TextOffset = new System.Drawing.Point(0, 0);
            this.getbtn.Click += new System.EventHandler(this.getbtn_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 40;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 20;
            this.bunifuElipse2.TargetControl = this.gameImg;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Transparent;
            this.panel7.Controls.Add(this.label5);
            this.panel7.Controls.Add(this.usericonbtn);
            this.panel7.Location = new System.Drawing.Point(13, 427);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(146, 39);
            this.panel7.TabIndex = 64;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Silver;
            this.label5.Location = new System.Drawing.Point(14, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 18);
            this.label5.TabIndex = 25;
            this.label5.Text = "Platform";
            // 
            // usericonbtn
            // 
            this.usericonbtn.CheckButton = false;
            this.usericonbtn.Checked = false;
            this.usericonbtn.CheckedBackground = System.Drawing.Color.Coral;
            this.usericonbtn.CheckedImageTint = System.Drawing.Color.White;
            this.usericonbtn.CheckedOutline = System.Drawing.Color.Silver;
            this.usericonbtn.Content = "";
            this.usericonbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.usericonbtn.ForeColor = System.Drawing.Color.White;
            this.usericonbtn.HoverBackground = System.Drawing.Color.White;
            this.usericonbtn.HoveredImageTint = System.Drawing.Color.White;
            this.usericonbtn.HoverOutline = System.Drawing.Color.White;
            this.usericonbtn.Image = ((System.Drawing.Image)(resources.GetObject("usericonbtn.Image")));
            this.usericonbtn.ImageAutoCenter = true;
            this.usericonbtn.ImageExpand = new System.Drawing.Point(10, 10);
            this.usericonbtn.ImageOffset = new System.Drawing.Point(0, 0);
            this.usericonbtn.ImageTint = System.Drawing.Color.White;
            this.usericonbtn.Location = new System.Drawing.Point(105, 1);
            this.usericonbtn.Name = "usericonbtn";
            this.usericonbtn.NormalBackground = System.Drawing.Color.SlateGray;
            this.usericonbtn.NormalOutline = System.Drawing.Color.Empty;
            this.usericonbtn.OutlineThickness = 3F;
            this.usericonbtn.PressedBackground = System.Drawing.Color.MediumPurple;
            this.usericonbtn.PressedImageTint = System.Drawing.Color.White;
            this.usericonbtn.PressedOutline = System.Drawing.Color.Empty;
            this.usericonbtn.Rounding = new System.Windows.Forms.Padding(15);
            this.usericonbtn.Size = new System.Drawing.Size(38, 35);
            this.usericonbtn.TabIndex = 24;
            this.usericonbtn.TextOffset = new System.Drawing.Point(0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(25, 491);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 20);
            this.label1.TabIndex = 65;
            this.label1.Text = "$";
            // 
            // GetGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.gameprice);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.cancelbtn);
            this.Controls.Add(this.getbtn);
            this.Controls.Add(this.gamecat);
            this.Controls.Add(this.gameDesc);
            this.Controls.Add(this.gameName);
            this.Controls.Add(this.gameImg);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "GetGame";
            this.Size = new System.Drawing.Size(569, 670);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameImg)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox gameImg;
        private CuoreUI.Controls.cuiLabel gameName;
        private CuoreUI.Controls.cuiLabel gameDesc;
        private CuoreUI.Controls.cuiLabel gamecat;
        private CuoreUI.Controls.cuiLabel gameprice;
        private CuoreUI.Controls.cuiButton cancelbtn;
        private CuoreUI.Controls.cuiButton getbtn;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel7;
        private CuoreUI.Controls.cuiButton usericonbtn;
        private System.Windows.Forms.Label label1;
    }
}
