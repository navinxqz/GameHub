namespace GameServer_Management.Forms
{
    partial class AddGames
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddGames));
            this.cancelbtn = new CuoreUI.Controls.cuiButton();
            this.btnAdd = new CuoreUI.Controls.cuiButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new Krypton.Toolkit.KryptonTextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.DateSelect = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRelDate = new Krypton.Toolkit.KryptonTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrice = new Krypton.Toolkit.KryptonTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDesc = new Krypton.Toolkit.KryptonTextBox();
            this.cbCat = new Krypton.Toolkit.KryptonComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbCat)).BeginInit();
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
            this.cancelbtn.Location = new System.Drawing.Point(616, 573);
            this.cancelbtn.Name = "cancelbtn";
            this.cancelbtn.NormalBackground = System.Drawing.Color.Transparent;
            this.cancelbtn.NormalOutline = System.Drawing.Color.White;
            this.cancelbtn.OutlineThickness = 1.6F;
            this.cancelbtn.PressedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(77)))));
            this.cancelbtn.PressedImageTint = System.Drawing.Color.White;
            this.cancelbtn.PressedOutline = System.Drawing.Color.White;
            this.cancelbtn.Rounding = new System.Windows.Forms.Padding(15);
            this.cancelbtn.Size = new System.Drawing.Size(147, 54);
            this.cancelbtn.TabIndex = 59;
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
            this.btnAdd.Location = new System.Drawing.Point(464, 573);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.NormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(48)))));
            this.btnAdd.NormalOutline = System.Drawing.Color.Transparent;
            this.btnAdd.OutlineThickness = 1.6F;
            this.btnAdd.PressedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(77)))));
            this.btnAdd.PressedImageTint = System.Drawing.Color.White;
            this.btnAdd.PressedOutline = System.Drawing.Color.White;
            this.btnAdd.Rounding = new System.Windows.Forms.Padding(15);
            this.btnAdd.Size = new System.Drawing.Size(137, 54);
            this.btnAdd.TabIndex = 58;
            this.btnAdd.TextOffset = new System.Drawing.Point(0, 0);
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MediumPurple;
            this.label3.Location = new System.Drawing.Point(61, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 23);
            this.label3.TabIndex = 57;
            this.label3.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.CornerRoundingRadius = 30F;
            this.txtName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtName.Location = new System.Drawing.Point(43, 169);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(337, 51);
            this.txtName.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(53)))), ((int)(((byte)(58)))));
            this.txtName.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(53)))), ((int)(((byte)(58)))));
            this.txtName.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtName.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txtName.StateCommon.Border.Rounding = 30F;
            this.txtName.StateCommon.Content.Color1 = System.Drawing.Color.White;
            this.txtName.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.TabIndex = 56;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.ForeColor = System.Drawing.Color.White;
            this.labelName.Location = new System.Drawing.Point(32, 48);
            this.labelName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(277, 61);
            this.labelName.TabIndex = 55;
            this.labelName.Text = "Add Game";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 40;
            this.bunifuElipse1.TargetControl = this;
            // 
            // DateSelect
            // 
            this.DateSelect.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateSelect.Location = new System.Drawing.Point(350, 589);
            this.DateSelect.Margin = new System.Windows.Forms.Padding(2);
            this.DateSelect.MaxDate = new System.DateTime(3000, 12, 31, 0, 0, 0, 0);
            this.DateSelect.MinDate = new System.DateTime(1971, 12, 1, 0, 0, 0, 0);
            this.DateSelect.Name = "DateSelect";
            this.DateSelect.Size = new System.Drawing.Size(18, 20);
            this.DateSelect.TabIndex = 69;
            this.DateSelect.ValueChanged += new System.EventHandler(this.DateSelect_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.MediumPurple;
            this.label5.Location = new System.Drawing.Point(61, 547);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 23);
            this.label5.TabIndex = 68;
            this.label5.Text = "Release Date";
            // 
            // txtRelDate
            // 
            this.txtRelDate.CornerRoundingRadius = 30F;
            this.txtRelDate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtRelDate.Location = new System.Drawing.Point(43, 573);
            this.txtRelDate.Name = "txtRelDate";
            this.txtRelDate.ReadOnly = true;
            this.txtRelDate.Size = new System.Drawing.Size(337, 51);
            this.txtRelDate.StateActive.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRelDate.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(53)))), ((int)(((byte)(58)))));
            this.txtRelDate.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(53)))), ((int)(((byte)(58)))));
            this.txtRelDate.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtRelDate.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txtRelDate.StateCommon.Border.Rounding = 30F;
            this.txtRelDate.StateCommon.Content.Color1 = System.Drawing.Color.White;
            this.txtRelDate.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRelDate.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.txtRelDate.StateDisabled.Border.Color1 = System.Drawing.Color.Transparent;
            this.txtRelDate.StateDisabled.Border.Color2 = System.Drawing.Color.Transparent;
            this.txtRelDate.StateDisabled.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtRelDate.StateDisabled.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRelDate.TabIndex = 67;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(464, 169);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(299, 351);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 66;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.MediumPurple;
            this.label4.Location = new System.Drawing.Point(61, 443);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 23);
            this.label4.TabIndex = 65;
            this.label4.Text = "Price";
            // 
            // txtPrice
            // 
            this.txtPrice.CornerRoundingRadius = 30F;
            this.txtPrice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtPrice.Location = new System.Drawing.Point(43, 469);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(337, 51);
            this.txtPrice.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(53)))), ((int)(((byte)(58)))));
            this.txtPrice.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(53)))), ((int)(((byte)(58)))));
            this.txtPrice.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtPrice.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txtPrice.StateCommon.Border.Rounding = 30F;
            this.txtPrice.StateCommon.Content.Color1 = System.Drawing.Color.White;
            this.txtPrice.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.TabIndex = 64;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MediumPurple;
            this.label2.Location = new System.Drawing.Point(61, 341);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 23);
            this.label2.TabIndex = 63;
            this.label2.Text = "Category";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumPurple;
            this.label1.Location = new System.Drawing.Point(61, 239);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 23);
            this.label1.TabIndex = 61;
            this.label1.Text = "Description";
            // 
            // txtDesc
            // 
            this.txtDesc.CornerRoundingRadius = 30F;
            this.txtDesc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtDesc.Location = new System.Drawing.Point(43, 265);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(337, 51);
            this.txtDesc.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(53)))), ((int)(((byte)(58)))));
            this.txtDesc.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(53)))), ((int)(((byte)(58)))));
            this.txtDesc.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtDesc.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txtDesc.StateCommon.Border.Rounding = 30F;
            this.txtDesc.StateCommon.Content.Color1 = System.Drawing.Color.White;
            this.txtDesc.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesc.TabIndex = 60;
            // 
            // cbCat
            // 
            this.cbCat.CornerRoundingRadius = 30F;
            this.cbCat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbCat.DropBackStyle = Krypton.Toolkit.PaletteBackStyle.ButtonNavigatorMini;
            this.cbCat.DropButtonStyle = Krypton.Toolkit.ButtonStyle.NavigatorMini;
            this.cbCat.DropDownWidth = 317;
            this.cbCat.IntegralHeight = false;
            this.cbCat.Location = new System.Drawing.Point(43, 369);
            this.cbCat.Name = "cbCat";
            this.cbCat.Size = new System.Drawing.Size(337, 50);
            this.cbCat.StateCommon.ComboBox.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(53)))), ((int)(((byte)(58)))));
            this.cbCat.StateCommon.ComboBox.Border.Color1 = System.Drawing.Color.Transparent;
            this.cbCat.StateCommon.ComboBox.Border.Color2 = System.Drawing.Color.Transparent;
            this.cbCat.StateCommon.ComboBox.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cbCat.StateCommon.ComboBox.Border.Rounding = 30F;
            this.cbCat.StateCommon.ComboBox.Content.Color1 = System.Drawing.Color.White;
            this.cbCat.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCat.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.cbCat.TabIndex = 70;
            this.cbCat.SelectedIndexChanged += new System.EventHandler(this.cbCat_SelectedIndexChanged);
            // 
            // AddGames
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(825, 697);
            this.Controls.Add(this.cbCat);
            this.Controls.Add(this.cancelbtn);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.DateSelect);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtRelDate);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDesc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddGames";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddGames";
            this.Load += new System.EventHandler(this.AddGames_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbCat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CuoreUI.Controls.cuiButton cancelbtn;
        private CuoreUI.Controls.cuiButton btnAdd;
        private System.Windows.Forms.Label label3;
        public Krypton.Toolkit.KryptonTextBox txtName;
        private System.Windows.Forms.Label labelName;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.DateTimePicker DateSelect;
        private System.Windows.Forms.Label label5;
        public Krypton.Toolkit.KryptonTextBox txtRelDate;
        private System.Windows.Forms.Label label4;
        public Krypton.Toolkit.KryptonTextBox txtPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public Krypton.Toolkit.KryptonTextBox txtDesc;
        public Krypton.Toolkit.KryptonComboBox cbCat;
        public System.Windows.Forms.PictureBox pictureBox1;
    }
}