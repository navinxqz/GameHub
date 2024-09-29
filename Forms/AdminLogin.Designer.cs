namespace GameServer_Management.Forms
{
    partial class AdminLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminLogin));
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUsername = new Krypton.Toolkit.KryptonTextBox();
            this.txtpass = new Krypton.Toolkit.KryptonTextBox();
            this.btnLogin = new CuoreUI.Controls.cuiButton();
            this.Logoutbtn = new System.Windows.Forms.Button();
            this.HidePassBtn = new CuoreUI.Controls.cuiButton();
            this.showPassBtn = new CuoreUI.Controls.cuiButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.exitbtn = new CuoreUI.Controls.cuiButton();
            this.loading = new GameServer_Management.Controller.Loading();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.MediumPurple;
            this.label4.Location = new System.Drawing.Point(1046, 305);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 23);
            this.label4.TabIndex = 16;
            this.label4.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MediumPurple;
            this.label3.Location = new System.Drawing.Point(1039, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 23);
            this.label3.TabIndex = 15;
            this.label3.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(812, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(337, 21);
            this.label2.TabIndex = 14;
            this.label2.Text = "Please enter your username and password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(865, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 38);
            this.label1.TabIndex = 13;
            this.label1.Text = "Welcome Admin!";
            // 
            // txtUsername
            // 
            this.txtUsername.CornerRoundingRadius = 30F;
            this.txtUsername.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtUsername.Location = new System.Drawing.Point(816, 239);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(333, 51);
            this.txtUsername.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(53)))), ((int)(((byte)(58)))));
            this.txtUsername.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(53)))), ((int)(((byte)(58)))));
            this.txtUsername.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtUsername.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txtUsername.StateCommon.Border.Rounding = 30F;
            this.txtUsername.StateCommon.Content.Color1 = System.Drawing.Color.White;
            this.txtUsername.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.TabIndex = 17;
            // 
            // txtpass
            // 
            this.txtpass.CornerRoundingRadius = 30F;
            this.txtpass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtpass.Location = new System.Drawing.Point(816, 344);
            this.txtpass.Name = "txtpass";
            this.txtpass.PasswordChar = '*';
            this.txtpass.Size = new System.Drawing.Size(333, 51);
            this.txtpass.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(53)))), ((int)(((byte)(58)))));
            this.txtpass.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(53)))), ((int)(((byte)(58)))));
            this.txtpass.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtpass.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txtpass.StateCommon.Border.Rounding = 30F;
            this.txtpass.StateCommon.Content.Color1 = System.Drawing.Color.White;
            this.txtpass.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpass.TabIndex = 18;
            this.txtpass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Enter_Key);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnLogin.CheckButton = false;
            this.btnLogin.Checked = false;
            this.btnLogin.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(106)))), ((int)(((byte)(163)))));
            this.btnLogin.CheckedImageTint = System.Drawing.Color.White;
            this.btnLogin.CheckedOutline = System.Drawing.Color.White;
            this.btnLogin.Content = "Login";
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.btnLogin.HoveredImageTint = System.Drawing.Color.White;
            this.btnLogin.HoverOutline = System.Drawing.Color.Transparent;
            this.btnLogin.Image = null;
            this.btnLogin.ImageAutoCenter = true;
            this.btnLogin.ImageExpand = new System.Drawing.Point(0, 0);
            this.btnLogin.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnLogin.ImageTint = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(816, 429);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.NormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(48)))));
            this.btnLogin.NormalOutline = System.Drawing.Color.Transparent;
            this.btnLogin.OutlineThickness = 1.6F;
            this.btnLogin.PressedBackground = System.Drawing.Color.SlateGray;
            this.btnLogin.PressedImageTint = System.Drawing.Color.White;
            this.btnLogin.PressedOutline = System.Drawing.Color.Empty;
            this.btnLogin.Rounding = new System.Windows.Forms.Padding(20);
            this.btnLogin.Size = new System.Drawing.Size(333, 50);
            this.btnLogin.TabIndex = 19;
            this.btnLogin.TextOffset = new System.Drawing.Point(0, 0);
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // Logoutbtn
            // 
            this.Logoutbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Logoutbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Logoutbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logoutbtn.ForeColor = System.Drawing.Color.MediumPurple;
            this.Logoutbtn.Image = ((System.Drawing.Image)(resources.GetObject("Logoutbtn.Image")));
            this.Logoutbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Logoutbtn.Location = new System.Drawing.Point(872, 496);
            this.Logoutbtn.Name = "Logoutbtn";
            this.Logoutbtn.Padding = new System.Windows.Forms.Padding(27, 0, 0, 0);
            this.Logoutbtn.Size = new System.Drawing.Size(228, 41);
            this.Logoutbtn.TabIndex = 20;
            this.Logoutbtn.Text = "        Back to previous";
            this.Logoutbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Logoutbtn.UseVisualStyleBackColor = true;
            this.Logoutbtn.Click += new System.EventHandler(this.Logoutbtn_Click);
            // 
            // HidePassBtn
            // 
            this.HidePassBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(53)))), ((int)(((byte)(58)))));
            this.HidePassBtn.CheckButton = false;
            this.HidePassBtn.Checked = false;
            this.HidePassBtn.CheckedBackground = System.Drawing.Color.Transparent;
            this.HidePassBtn.CheckedImageTint = System.Drawing.Color.White;
            this.HidePassBtn.CheckedOutline = System.Drawing.Color.Transparent;
            this.HidePassBtn.Content = "";
            this.HidePassBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.HidePassBtn.ForeColor = System.Drawing.Color.White;
            this.HidePassBtn.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(109)))), ((int)(((byte)(118)))));
            this.HidePassBtn.HoveredImageTint = System.Drawing.Color.White;
            this.HidePassBtn.HoverOutline = System.Drawing.Color.White;
            this.HidePassBtn.Image = ((System.Drawing.Image)(resources.GetObject("HidePassBtn.Image")));
            this.HidePassBtn.ImageAutoCenter = true;
            this.HidePassBtn.ImageExpand = new System.Drawing.Point(5, 5);
            this.HidePassBtn.ImageOffset = new System.Drawing.Point(0, 0);
            this.HidePassBtn.ImageTint = System.Drawing.Color.White;
            this.HidePassBtn.Location = new System.Drawing.Point(1103, 351);
            this.HidePassBtn.Name = "HidePassBtn";
            this.HidePassBtn.NormalBackground = System.Drawing.Color.Transparent;
            this.HidePassBtn.NormalOutline = System.Drawing.Color.Transparent;
            this.HidePassBtn.OutlineThickness = 1.6F;
            this.HidePassBtn.PressedBackground = System.Drawing.Color.Coral;
            this.HidePassBtn.PressedImageTint = System.Drawing.Color.White;
            this.HidePassBtn.PressedOutline = System.Drawing.Color.White;
            this.HidePassBtn.Rounding = new System.Windows.Forms.Padding(15);
            this.HidePassBtn.Size = new System.Drawing.Size(39, 36);
            this.HidePassBtn.TabIndex = 23;
            this.HidePassBtn.TextOffset = new System.Drawing.Point(0, 0);
            this.HidePassBtn.Click += new System.EventHandler(this.HidePassBtn_Click);
            // 
            // showPassBtn
            // 
            this.showPassBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(53)))), ((int)(((byte)(58)))));
            this.showPassBtn.CheckButton = false;
            this.showPassBtn.Checked = false;
            this.showPassBtn.CheckedBackground = System.Drawing.Color.Transparent;
            this.showPassBtn.CheckedImageTint = System.Drawing.Color.White;
            this.showPassBtn.CheckedOutline = System.Drawing.Color.Transparent;
            this.showPassBtn.Content = "";
            this.showPassBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.showPassBtn.ForeColor = System.Drawing.Color.White;
            this.showPassBtn.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(109)))), ((int)(((byte)(118)))));
            this.showPassBtn.HoveredImageTint = System.Drawing.Color.White;
            this.showPassBtn.HoverOutline = System.Drawing.Color.White;
            this.showPassBtn.Image = ((System.Drawing.Image)(resources.GetObject("showPassBtn.Image")));
            this.showPassBtn.ImageAutoCenter = true;
            this.showPassBtn.ImageExpand = new System.Drawing.Point(5, 5);
            this.showPassBtn.ImageOffset = new System.Drawing.Point(0, 0);
            this.showPassBtn.ImageTint = System.Drawing.Color.White;
            this.showPassBtn.Location = new System.Drawing.Point(1103, 351);
            this.showPassBtn.Name = "showPassBtn";
            this.showPassBtn.NormalBackground = System.Drawing.Color.Transparent;
            this.showPassBtn.NormalOutline = System.Drawing.Color.Transparent;
            this.showPassBtn.OutlineThickness = 1.6F;
            this.showPassBtn.PressedBackground = System.Drawing.Color.Coral;
            this.showPassBtn.PressedImageTint = System.Drawing.Color.White;
            this.showPassBtn.PressedOutline = System.Drawing.Color.White;
            this.showPassBtn.Rounding = new System.Windows.Forms.Padding(15);
            this.showPassBtn.Size = new System.Drawing.Size(39, 36);
            this.showPassBtn.TabIndex = 22;
            this.showPassBtn.TextOffset = new System.Drawing.Point(0, 0);
            this.showPassBtn.Click += new System.EventHandler(this.showPassBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1181, 665);
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseHover += new System.EventHandler(this.pictureBox1_MouseHover);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 30;
            this.bunifuElipse1.TargetControl = this;
            // 
            // exitbtn
            // 
            this.exitbtn.AutoSize = true;
            this.exitbtn.BackColor = System.Drawing.Color.Transparent;
            this.exitbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.exitbtn.CheckButton = false;
            this.exitbtn.Checked = false;
            this.exitbtn.CheckedBackground = System.Drawing.Color.Transparent;
            this.exitbtn.CheckedImageTint = System.Drawing.Color.Transparent;
            this.exitbtn.CheckedOutline = System.Drawing.Color.Transparent;
            this.exitbtn.Content = "";
            this.exitbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.exitbtn.ForeColor = System.Drawing.Color.Transparent;
            this.exitbtn.HoverBackground = System.Drawing.Color.Transparent;
            this.exitbtn.HoveredImageTint = System.Drawing.Color.White;
            this.exitbtn.HoverOutline = System.Drawing.Color.Transparent;
            this.exitbtn.Image = ((System.Drawing.Image)(resources.GetObject("exitbtn.Image")));
            this.exitbtn.ImageAutoCenter = true;
            this.exitbtn.ImageExpand = new System.Drawing.Point(5, 5);
            this.exitbtn.ImageOffset = new System.Drawing.Point(0, 0);
            this.exitbtn.ImageTint = System.Drawing.Color.White;
            this.exitbtn.Location = new System.Drawing.Point(1134, 6);
            this.exitbtn.Name = "exitbtn";
            this.exitbtn.NormalBackground = System.Drawing.Color.Transparent;
            this.exitbtn.NormalOutline = System.Drawing.Color.Transparent;
            this.exitbtn.OutlineThickness = 0F;
            this.exitbtn.PressedBackground = System.Drawing.Color.Transparent;
            this.exitbtn.PressedImageTint = System.Drawing.Color.White;
            this.exitbtn.PressedOutline = System.Drawing.Color.Transparent;
            this.exitbtn.Rounding = new System.Windows.Forms.Padding(20);
            this.exitbtn.Size = new System.Drawing.Size(40, 36);
            this.exitbtn.TabIndex = 25;
            this.exitbtn.TextOffset = new System.Drawing.Point(0, 0);
            this.exitbtn.Click += new System.EventHandler(this.exitbtn_Click);
            this.exitbtn.MouseHover += new System.EventHandler(this.exitbtn_MouseHover);
            // 
            // loading
            // 
            this.loading.BackColor = System.Drawing.Color.WhiteSmoke;
            this.loading.Location = new System.Drawing.Point(474, 243);
            this.loading.Name = "loading";
            this.loading.Size = new System.Drawing.Size(221, 144);
            this.loading.TabIndex = 26;
            // 
            // AdminLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1181, 665);
            this.Controls.Add(this.loading);
            this.Controls.Add(this.exitbtn);
            this.Controls.Add(this.showPassBtn);
            this.Controls.Add(this.HidePassBtn);
            this.Controls.Add(this.Logoutbtn);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminLogin";
            this.Load += new System.EventHandler(this.AdminLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Krypton.Toolkit.KryptonTextBox txtUsername;
        private Krypton.Toolkit.KryptonTextBox txtpass;
        private CuoreUI.Controls.cuiButton btnLogin;
        private System.Windows.Forms.Button Logoutbtn;
        private CuoreUI.Controls.cuiButton HidePassBtn;
        private CuoreUI.Controls.cuiButton showPassBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private CuoreUI.Controls.cuiButton exitbtn;
        private Controller.Loading loading;
    }
}