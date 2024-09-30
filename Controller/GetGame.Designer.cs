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
            this.gameRelDate = new CuoreUI.Controls.cuiLabel();
            this.gameprice = new CuoreUI.Controls.cuiLabel();
            this.cancelbtn = new CuoreUI.Controls.cuiButton();
            this.getbtn = new CuoreUI.Controls.cuiButton();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameImg)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-39, -40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(648, 329);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // gameImg
            // 
            this.gameImg.Image = ((System.Drawing.Image)(resources.GetObject("gameImg.Image")));
            this.gameImg.Location = new System.Drawing.Point(3, 184);
            this.gameImg.Name = "gameImg";
            this.gameImg.Size = new System.Drawing.Size(151, 222);
            this.gameImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gameImg.TabIndex = 12;
            this.gameImg.TabStop = false;
            // 
            // gameName
            // 
            this.gameName.Content = "Assassin\'s\\ Creed\\ 3";
            this.gameName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameName.ForeColor = System.Drawing.Color.White;
            this.gameName.HorizontalAlignment = CuoreUI.Controls.cuiLabel.HorizontalAlignments.Left;
            this.gameName.Location = new System.Drawing.Point(177, 264);
            this.gameName.Name = "gameName";
            this.gameName.Size = new System.Drawing.Size(365, 62);
            this.gameName.TabIndex = 14;
            // 
            // gameDesc
            // 
            this.gameDesc.Content = "Assassin\'s\\ Creed\\ 3\\ Description";
            this.gameDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameDesc.ForeColor = System.Drawing.Color.White;
            this.gameDesc.HorizontalAlignment = CuoreUI.Controls.cuiLabel.HorizontalAlignments.Left;
            this.gameDesc.Location = new System.Drawing.Point(177, 332);
            this.gameDesc.Name = "gameDesc";
            this.gameDesc.Size = new System.Drawing.Size(365, 185);
            this.gameDesc.TabIndex = 15;
            // 
            // gamecat
            // 
            this.gamecat.Content = "category";
            this.gamecat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gamecat.ForeColor = System.Drawing.Color.White;
            this.gamecat.HorizontalAlignment = CuoreUI.Controls.cuiLabel.HorizontalAlignments.Left;
            this.gamecat.Location = new System.Drawing.Point(8, 412);
            this.gamecat.Name = "gamecat";
            this.gamecat.Size = new System.Drawing.Size(151, 25);
            this.gamecat.TabIndex = 16;
            // 
            // gameRelDate
            // 
            this.gameRelDate.Content = "Release\\ Date";
            this.gameRelDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameRelDate.ForeColor = System.Drawing.Color.White;
            this.gameRelDate.HorizontalAlignment = CuoreUI.Controls.cuiLabel.HorizontalAlignments.Left;
            this.gameRelDate.Location = new System.Drawing.Point(8, 434);
            this.gameRelDate.Name = "gameRelDate";
            this.gameRelDate.Size = new System.Drawing.Size(151, 25);
            this.gameRelDate.TabIndex = 17;
            // 
            // gameprice
            // 
            this.gameprice.Content = "Pricing";
            this.gameprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameprice.ForeColor = System.Drawing.Color.White;
            this.gameprice.HorizontalAlignment = CuoreUI.Controls.cuiLabel.HorizontalAlignments.Left;
            this.gameprice.Location = new System.Drawing.Point(8, 455);
            this.gameprice.Name = "gameprice";
            this.gameprice.Size = new System.Drawing.Size(151, 25);
            this.gameprice.TabIndex = 18;
            // 
            // cancelbtn
            // 
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
            this.cancelbtn.Location = new System.Drawing.Point(285, 599);
            this.cancelbtn.Name = "cancelbtn";
            this.cancelbtn.NormalBackground = System.Drawing.Color.Transparent;
            this.cancelbtn.NormalOutline = System.Drawing.Color.White;
            this.cancelbtn.OutlineThickness = 1.6F;
            this.cancelbtn.PressedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(77)))));
            this.cancelbtn.PressedImageTint = System.Drawing.Color.White;
            this.cancelbtn.PressedOutline = System.Drawing.Color.White;
            this.cancelbtn.Rounding = new System.Windows.Forms.Padding(15);
            this.cancelbtn.Size = new System.Drawing.Size(147, 54);
            this.cancelbtn.TabIndex = 63;
            this.cancelbtn.TextOffset = new System.Drawing.Point(0, 0);
            this.cancelbtn.Click += new System.EventHandler(this.cancelbtn_Click);
            // 
            // getbtn
            // 
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
            this.getbtn.Image = null;
            this.getbtn.ImageAutoCenter = true;
            this.getbtn.ImageExpand = new System.Drawing.Point(0, 0);
            this.getbtn.ImageOffset = new System.Drawing.Point(0, 0);
            this.getbtn.ImageTint = System.Drawing.Color.White;
            this.getbtn.Location = new System.Drawing.Point(133, 599);
            this.getbtn.Name = "getbtn";
            this.getbtn.NormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(48)))));
            this.getbtn.NormalOutline = System.Drawing.Color.Transparent;
            this.getbtn.OutlineThickness = 1.6F;
            this.getbtn.PressedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(77)))));
            this.getbtn.PressedImageTint = System.Drawing.Color.White;
            this.getbtn.PressedOutline = System.Drawing.Color.White;
            this.getbtn.Rounding = new System.Windows.Forms.Padding(15);
            this.getbtn.Size = new System.Drawing.Size(137, 54);
            this.getbtn.TabIndex = 62;
            this.getbtn.TextOffset = new System.Drawing.Point(0, 0);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 50;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 20;
            this.bunifuElipse2.TargetControl = this.gameImg;
            // 
            // GetGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.cancelbtn);
            this.Controls.Add(this.getbtn);
            this.Controls.Add(this.gameprice);
            this.Controls.Add(this.gameRelDate);
            this.Controls.Add(this.gamecat);
            this.Controls.Add(this.gameDesc);
            this.Controls.Add(this.gameName);
            this.Controls.Add(this.gameImg);
            this.Controls.Add(this.pictureBox1);
            this.Name = "GetGame";
            this.Size = new System.Drawing.Size(569, 692);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameImg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox gameImg;
        private CuoreUI.Controls.cuiLabel gameName;
        private CuoreUI.Controls.cuiLabel gameDesc;
        private CuoreUI.Controls.cuiLabel gamecat;
        private CuoreUI.Controls.cuiLabel gameRelDate;
        private CuoreUI.Controls.cuiLabel gameprice;
        private CuoreUI.Controls.cuiButton cancelbtn;
        private CuoreUI.Controls.cuiButton getbtn;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
    }
}
