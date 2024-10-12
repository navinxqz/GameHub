namespace GameServer_Management.Forms
{
    partial class AddAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddAdmin));
            this.cancelbtn = new CuoreUI.Controls.cuiButton();
            this.btnAdd = new CuoreUI.Controls.cuiButton();
            this.labelName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUsername = new Krypton.Toolkit.KryptonTextBox();
            this.txtFullName = new Krypton.Toolkit.KryptonTextBox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.hide_pass_btn = new CuoreUI.Controls.cuiButton();
            this.show_pass_btn = new CuoreUI.Controls.cuiButton();
            this.txtpass = new Krypton.Toolkit.KryptonTextBox();
            this.SuspendLayout();
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
            this.cancelbtn.Location = new System.Drawing.Point(265, 437);
            this.cancelbtn.Name = "cancelbtn";
            this.cancelbtn.NormalBackground = System.Drawing.Color.Transparent;
            this.cancelbtn.NormalOutline = System.Drawing.Color.White;
            this.cancelbtn.OutlineThickness = 1.6F;
            this.cancelbtn.PressedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(77)))));
            this.cancelbtn.PressedImageTint = System.Drawing.Color.White;
            this.cancelbtn.PressedOutline = System.Drawing.Color.White;
            this.cancelbtn.Rounding = new System.Windows.Forms.Padding(15);
            this.cancelbtn.Size = new System.Drawing.Size(147, 54);
            this.cancelbtn.TabIndex = 74;
            this.cancelbtn.TextOffset = new System.Drawing.Point(0, 0);
            this.cancelbtn.Click += new System.EventHandler(this.cancelbtn_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.CheckButton = false;
            this.btnAdd.Checked = false;
            this.btnAdd.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(106)))), ((int)(((byte)(163)))));
            this.btnAdd.CheckedImageTint = System.Drawing.Color.White;
            this.btnAdd.CheckedOutline = System.Drawing.Color.White;
            this.btnAdd.Content = "Add";
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(187)))), ((int)(((byte)(196)))));
            this.btnAdd.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.btnAdd.HoveredImageTint = System.Drawing.Color.White;
            this.btnAdd.HoverOutline = System.Drawing.Color.Transparent;
            this.btnAdd.Image = null;
            this.btnAdd.ImageAutoCenter = true;
            this.btnAdd.ImageExpand = new System.Drawing.Point(0, 0);
            this.btnAdd.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnAdd.ImageTint = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(113, 437);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.NormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(48)))));
            this.btnAdd.NormalOutline = System.Drawing.Color.Transparent;
            this.btnAdd.OutlineThickness = 1.6F;
            this.btnAdd.PressedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(77)))));
            this.btnAdd.PressedImageTint = System.Drawing.Color.White;
            this.btnAdd.PressedOutline = System.Drawing.Color.White;
            this.btnAdd.Rounding = new System.Windows.Forms.Padding(15);
            this.btnAdd.Size = new System.Drawing.Size(137, 54);
            this.btnAdd.TabIndex = 73;
            this.btnAdd.TextOffset = new System.Drawing.Point(0, 0);
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.ForeColor = System.Drawing.Color.White;
            this.labelName.Location = new System.Drawing.Point(131, 32);
            this.labelName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(284, 61);
            this.labelName.TabIndex = 72;
            this.labelName.Text = "Add Admin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MediumPurple;
            this.label2.Location = new System.Drawing.Point(109, 322);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 23);
            this.label2.TabIndex = 71;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumPurple;
            this.label1.Location = new System.Drawing.Point(109, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 23);
            this.label1.TabIndex = 70;
            this.label1.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MediumPurple;
            this.label3.Location = new System.Drawing.Point(109, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 23);
            this.label3.TabIndex = 69;
            this.label3.Text = "Full Name";
            // 
            // txtUsername
            // 
            this.txtUsername.CornerRoundingRadius = 30F;
            this.txtUsername.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtUsername.Location = new System.Drawing.Point(102, 240);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(337, 51);
            this.txtUsername.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(53)))), ((int)(((byte)(58)))));
            this.txtUsername.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(53)))), ((int)(((byte)(58)))));
            this.txtUsername.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtUsername.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txtUsername.StateCommon.Border.Rounding = 30F;
            this.txtUsername.StateCommon.Content.Color1 = System.Drawing.Color.White;
            this.txtUsername.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.TabIndex = 67;
            // 
            // txtFullName
            // 
            this.txtFullName.CornerRoundingRadius = 30F;
            this.txtFullName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtFullName.Location = new System.Drawing.Point(102, 137);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(337, 51);
            this.txtFullName.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(53)))), ((int)(((byte)(58)))));
            this.txtFullName.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(53)))), ((int)(((byte)(58)))));
            this.txtFullName.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtFullName.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txtFullName.StateCommon.Border.Rounding = 30F;
            this.txtFullName.StateCommon.Content.Color1 = System.Drawing.Color.White;
            this.txtFullName.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFullName.TabIndex = 66;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 40;
            this.bunifuElipse1.TargetControl = this;
            // 
            // hide_pass_btn
            // 
            this.hide_pass_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(53)))), ((int)(((byte)(58)))));
            this.hide_pass_btn.CheckButton = false;
            this.hide_pass_btn.Checked = false;
            this.hide_pass_btn.CheckedBackground = System.Drawing.Color.Transparent;
            this.hide_pass_btn.CheckedImageTint = System.Drawing.Color.White;
            this.hide_pass_btn.CheckedOutline = System.Drawing.Color.Transparent;
            this.hide_pass_btn.Content = "";
            this.hide_pass_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.hide_pass_btn.ForeColor = System.Drawing.Color.White;
            this.hide_pass_btn.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(109)))), ((int)(((byte)(118)))));
            this.hide_pass_btn.HoveredImageTint = System.Drawing.Color.White;
            this.hide_pass_btn.HoverOutline = System.Drawing.Color.White;
            this.hide_pass_btn.Image = ((System.Drawing.Image)(resources.GetObject("hide_pass_btn.Image")));
            this.hide_pass_btn.ImageAutoCenter = true;
            this.hide_pass_btn.ImageExpand = new System.Drawing.Point(5, 5);
            this.hide_pass_btn.ImageOffset = new System.Drawing.Point(0, 0);
            this.hide_pass_btn.ImageTint = System.Drawing.Color.White;
            this.hide_pass_btn.Location = new System.Drawing.Point(386, 365);
            this.hide_pass_btn.Name = "hide_pass_btn";
            this.hide_pass_btn.NormalBackground = System.Drawing.Color.Transparent;
            this.hide_pass_btn.NormalOutline = System.Drawing.Color.Transparent;
            this.hide_pass_btn.OutlineThickness = 1.6F;
            this.hide_pass_btn.PressedBackground = System.Drawing.Color.Coral;
            this.hide_pass_btn.PressedImageTint = System.Drawing.Color.White;
            this.hide_pass_btn.PressedOutline = System.Drawing.Color.White;
            this.hide_pass_btn.Rounding = new System.Windows.Forms.Padding(15);
            this.hide_pass_btn.Size = new System.Drawing.Size(39, 36);
            this.hide_pass_btn.TabIndex = 93;
            this.hide_pass_btn.TextOffset = new System.Drawing.Point(0, 0);
            this.hide_pass_btn.Visible = false;
            this.hide_pass_btn.Click += new System.EventHandler(this.hide_pass_btn_Click);
            // 
            // show_pass_btn
            // 
            this.show_pass_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(53)))), ((int)(((byte)(58)))));
            this.show_pass_btn.CheckButton = false;
            this.show_pass_btn.Checked = false;
            this.show_pass_btn.CheckedBackground = System.Drawing.Color.Transparent;
            this.show_pass_btn.CheckedImageTint = System.Drawing.Color.White;
            this.show_pass_btn.CheckedOutline = System.Drawing.Color.Transparent;
            this.show_pass_btn.Content = "";
            this.show_pass_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.show_pass_btn.ForeColor = System.Drawing.Color.White;
            this.show_pass_btn.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(109)))), ((int)(((byte)(118)))));
            this.show_pass_btn.HoveredImageTint = System.Drawing.Color.White;
            this.show_pass_btn.HoverOutline = System.Drawing.Color.White;
            this.show_pass_btn.Image = ((System.Drawing.Image)(resources.GetObject("show_pass_btn.Image")));
            this.show_pass_btn.ImageAutoCenter = true;
            this.show_pass_btn.ImageExpand = new System.Drawing.Point(5, 5);
            this.show_pass_btn.ImageOffset = new System.Drawing.Point(0, 0);
            this.show_pass_btn.ImageTint = System.Drawing.Color.White;
            this.show_pass_btn.Location = new System.Drawing.Point(386, 365);
            this.show_pass_btn.Name = "show_pass_btn";
            this.show_pass_btn.NormalBackground = System.Drawing.Color.Transparent;
            this.show_pass_btn.NormalOutline = System.Drawing.Color.Transparent;
            this.show_pass_btn.OutlineThickness = 1.6F;
            this.show_pass_btn.PressedBackground = System.Drawing.Color.Coral;
            this.show_pass_btn.PressedImageTint = System.Drawing.Color.White;
            this.show_pass_btn.PressedOutline = System.Drawing.Color.White;
            this.show_pass_btn.Rounding = new System.Windows.Forms.Padding(15);
            this.show_pass_btn.Size = new System.Drawing.Size(39, 36);
            this.show_pass_btn.TabIndex = 94;
            this.show_pass_btn.TextOffset = new System.Drawing.Point(0, 0);
            this.show_pass_btn.Visible = false;
            this.show_pass_btn.Click += new System.EventHandler(this.show_pass_btn_Click);
            // 
            // txtpass
            // 
            this.txtpass.CornerRoundingRadius = 30F;
            this.txtpass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtpass.Location = new System.Drawing.Point(102, 359);
            this.txtpass.Name = "txtpass";
            this.txtpass.PasswordChar = '*';
            this.txtpass.Size = new System.Drawing.Size(337, 51);
            this.txtpass.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(53)))), ((int)(((byte)(58)))));
            this.txtpass.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(53)))), ((int)(((byte)(58)))));
            this.txtpass.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtpass.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txtpass.StateCommon.Border.Rounding = 30F;
            this.txtpass.StateCommon.Content.Color1 = System.Drawing.Color.White;
            this.txtpass.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpass.TabIndex = 92;
            this.txtpass.TextChanged += new System.EventHandler(this.txtpass_TextChanged);
            // 
            // AddAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(541, 523);
            this.Controls.Add(this.hide_pass_btn);
            this.Controls.Add(this.show_pass_btn);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.cancelbtn);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtFullName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddAdmin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CuoreUI.Controls.cuiButton cancelbtn;
        private CuoreUI.Controls.cuiButton btnAdd;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        public Krypton.Toolkit.KryptonTextBox txtUsername;
        public Krypton.Toolkit.KryptonTextBox txtFullName;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        public CuoreUI.Controls.cuiButton hide_pass_btn;
        private CuoreUI.Controls.cuiButton show_pass_btn;
        public Krypton.Toolkit.KryptonTextBox txtpass;
    }
}