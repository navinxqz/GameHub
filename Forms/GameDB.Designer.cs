namespace GameServer_Management.Forms
{
    partial class GameDB
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameDB));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.searchBtn = new CuoreUI.Controls.cuiButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.searchtxtbox = new Krypton.Toolkit.KryptonTextBox();
            this.btnAdd = new CuoreUI.Controls.cuiButton();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.dgvSerial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCatID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvRelDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvEdit = new System.Windows.Forms.DataGridViewImageColumn();
            this.dgvDelete = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // searchBtn
            // 
            this.searchBtn.CheckButton = false;
            this.searchBtn.Checked = false;
            this.searchBtn.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.searchBtn.CheckedImageTint = System.Drawing.Color.White;
            this.searchBtn.CheckedOutline = System.Drawing.Color.Transparent;
            this.searchBtn.Content = "";
            this.searchBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.searchBtn.ForeColor = System.Drawing.Color.Transparent;
            this.searchBtn.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.searchBtn.HoveredImageTint = System.Drawing.Color.White;
            this.searchBtn.HoverOutline = System.Drawing.Color.White;
            this.searchBtn.Image = ((System.Drawing.Image)(resources.GetObject("searchBtn.Image")));
            this.searchBtn.ImageAutoCenter = true;
            this.searchBtn.ImageExpand = new System.Drawing.Point(5, 5);
            this.searchBtn.ImageOffset = new System.Drawing.Point(0, 0);
            this.searchBtn.ImageTint = System.Drawing.Color.White;
            this.searchBtn.Location = new System.Drawing.Point(722, 15);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.NormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(115)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
            this.searchBtn.NormalOutline = System.Drawing.Color.Transparent;
            this.searchBtn.OutlineThickness = 1.6F;
            this.searchBtn.PressedBackground = System.Drawing.Color.Transparent;
            this.searchBtn.PressedImageTint = System.Drawing.Color.White;
            this.searchBtn.PressedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(109)))), ((int)(((byte)(118)))));
            this.searchBtn.Rounding = new System.Windows.Forms.Padding(20);
            this.searchBtn.Size = new System.Drawing.Size(48, 51);
            this.searchBtn.TabIndex = 18;
            this.searchBtn.TextOffset = new System.Drawing.Point(0, 0);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersHeight = 60;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvSerial,
            this.dgvId,
            this.dgvName,
            this.dgvDesc,
            this.dgvPrice,
            this.dgvCatID,
            this.dgvCat,
            this.dgvRelDate,
            this.dgvEdit,
            this.dgvDelete});
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.dataGridView1.Location = new System.Drawing.Point(34, 97);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 80;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1293, 641);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // searchtxtbox
            // 
            this.searchtxtbox.CornerRoundingRadius = 30F;
            this.searchtxtbox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchtxtbox.Location = new System.Drawing.Point(399, 13);
            this.searchtxtbox.Name = "searchtxtbox";
            this.searchtxtbox.Size = new System.Drawing.Size(307, 55);
            this.searchtxtbox.StateActive.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.searchtxtbox.StateActive.Border.Color1 = System.Drawing.Color.Transparent;
            this.searchtxtbox.StateActive.Border.Color2 = System.Drawing.Color.Transparent;
            this.searchtxtbox.StateActive.Border.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Local;
            this.searchtxtbox.StateActive.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.searchtxtbox.StateActive.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(71)))), ((int)(((byte)(78)))));
            this.searchtxtbox.StateActive.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchtxtbox.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.searchtxtbox.StateCommon.Border.Rounding = 30F;
            this.searchtxtbox.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.searchtxtbox.StateDisabled.Border.Color1 = System.Drawing.Color.Transparent;
            this.searchtxtbox.StateDisabled.Border.Color2 = System.Drawing.Color.Transparent;
            this.searchtxtbox.StateDisabled.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.searchtxtbox.StateDisabled.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(71)))), ((int)(((byte)(78)))));
            this.searchtxtbox.StateDisabled.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchtxtbox.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.searchtxtbox.TabIndex = 17;
            this.searchtxtbox.TextChanged += new System.EventHandler(this.searchtxtbox_TextChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.CheckButton = false;
            this.btnAdd.Checked = false;
            this.btnAdd.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(106)))), ((int)(((byte)(163)))));
            this.btnAdd.CheckedImageTint = System.Drawing.Color.White;
            this.btnAdd.CheckedOutline = System.Drawing.Color.White;
            this.btnAdd.Content = "Add";
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
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
            this.btnAdd.Location = new System.Drawing.Point(231, 15);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.NormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(48)))));
            this.btnAdd.NormalOutline = System.Drawing.Color.Transparent;
            this.btnAdd.OutlineThickness = 1.6F;
            this.btnAdd.PressedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(77)))));
            this.btnAdd.PressedImageTint = System.Drawing.Color.White;
            this.btnAdd.PressedOutline = System.Drawing.Color.White;
            this.btnAdd.Rounding = new System.Windows.Forms.Padding(15);
            this.btnAdd.Size = new System.Drawing.Size(149, 54);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.TextOffset = new System.Drawing.Point(0, 0);
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(23, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 61);
            this.label1.TabIndex = 15;
            this.label1.Text = "Games";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 40;
            this.bunifuElipse1.TargetControl = this.dataGridView1;
            // 
            // dgvSerial
            // 
            this.dgvSerial.HeaderText = "Serial";
            this.dgvSerial.Name = "dgvSerial";
            this.dgvSerial.ReadOnly = true;
            // 
            // dgvId
            // 
            this.dgvId.HeaderText = "ID";
            this.dgvId.Name = "dgvId";
            this.dgvId.ReadOnly = true;
            // 
            // dgvName
            // 
            this.dgvName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvName.HeaderText = "Name";
            this.dgvName.Name = "dgvName";
            this.dgvName.ReadOnly = true;
            // 
            // dgvDesc
            // 
            this.dgvDesc.HeaderText = "Desc";
            this.dgvDesc.Name = "dgvDesc";
            this.dgvDesc.ReadOnly = true;
            // 
            // dgvPrice
            // 
            this.dgvPrice.HeaderText = "Price";
            this.dgvPrice.Name = "dgvPrice";
            this.dgvPrice.ReadOnly = true;
            // 
            // dgvCatID
            // 
            this.dgvCatID.HeaderText = "CatID";
            this.dgvCatID.Name = "dgvCatID";
            this.dgvCatID.ReadOnly = true;
            this.dgvCatID.Visible = false;
            // 
            // dgvCat
            // 
            this.dgvCat.HeaderText = "Catagory";
            this.dgvCat.Name = "dgvCat";
            this.dgvCat.ReadOnly = true;
            // 
            // dgvRelDate
            // 
            dataGridViewCellStyle3.Format = "d";
            dataGridViewCellStyle3.NullValue = null;
            this.dgvRelDate.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvRelDate.HeaderText = "Release Date";
            this.dgvRelDate.Name = "dgvRelDate";
            this.dgvRelDate.ReadOnly = true;
            // 
            // dgvEdit
            // 
            this.dgvEdit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvEdit.HeaderText = "";
            this.dgvEdit.Image = ((System.Drawing.Image)(resources.GetObject("dgvEdit.Image")));
            this.dgvEdit.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dgvEdit.Name = "dgvEdit";
            this.dgvEdit.ReadOnly = true;
            this.dgvEdit.ToolTipText = "Click to edit";
            // 
            // dgvDelete
            // 
            this.dgvDelete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvDelete.HeaderText = "";
            this.dgvDelete.Image = ((System.Drawing.Image)(resources.GetObject("dgvDelete.Image")));
            this.dgvDelete.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dgvDelete.Name = "dgvDelete";
            this.dgvDelete.ReadOnly = true;
            this.dgvDelete.ToolTipText = "Click to delete";
            // 
            // GameDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(1322, 715);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.searchtxtbox);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GameDB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GameDB";
            this.Load += new System.EventHandler(this.GameDB_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CuoreUI.Controls.cuiButton searchBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Krypton.Toolkit.KryptonTextBox searchtxtbox;
        private CuoreUI.Controls.cuiButton btnAdd;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSerial;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCatID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCat;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvRelDate;
        private System.Windows.Forms.DataGridViewImageColumn dgvEdit;
        private System.Windows.Forms.DataGridViewImageColumn dgvDelete;
    }
}