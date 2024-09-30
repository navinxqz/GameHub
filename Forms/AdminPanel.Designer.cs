namespace GameServer_Management.Forms
{
    partial class AdminPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPanel));
            this.cuiButton1 = new CuoreUI.Controls.cuiButton();
            this.slidePanel = new System.Windows.Forms.Panel();
            this.userpanel = new System.Windows.Forms.Panel();
            this.usericonbtn = new CuoreUI.Controls.cuiButton();
            this.usertxt = new System.Windows.Forms.Label();
            this.logout = new Krypton.Toolkit.KryptonCheckButton();
            this.kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            this.downloadbtn = new Krypton.Toolkit.KryptonCheckButton();
            this.GameDBbtn = new Krypton.Toolkit.KryptonCheckButton();
            this.categoryBtn = new Krypton.Toolkit.KryptonCheckButton();
            this.btnHome = new Krypton.Toolkit.KryptonCheckButton();
            this.adminDBbtn = new Krypton.Toolkit.KryptonCheckButton();
            this.userDBbtn = new Krypton.Toolkit.KryptonCheckButton();
            this.menubtn = new CuoreUI.Controls.cuiButton();
            this.mainpanel = new System.Windows.Forms.Panel();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.sliderShowTimer = new System.Windows.Forms.Timer(this.components);
            this.sliderHideTimer = new System.Windows.Forms.Timer(this.components);
            this.faddingTimer = new System.Windows.Forms.Timer(this.components);
            this.bunifuElipse3 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.slidePanel.SuspendLayout();
            this.userpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cuiButton1
            // 
            this.cuiButton1.AutoSize = true;
            this.cuiButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cuiButton1.CheckButton = false;
            this.cuiButton1.Checked = false;
            this.cuiButton1.CheckedBackground = System.Drawing.Color.Red;
            this.cuiButton1.CheckedImageTint = System.Drawing.Color.Black;
            this.cuiButton1.CheckedOutline = System.Drawing.Color.Brown;
            this.cuiButton1.Content = "";
            this.cuiButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cuiButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cuiButton1.ForeColor = System.Drawing.Color.White;
            this.cuiButton1.HoverBackground = System.Drawing.Color.Red;
            this.cuiButton1.HoveredImageTint = System.Drawing.Color.White;
            this.cuiButton1.HoverOutline = System.Drawing.Color.White;
            this.cuiButton1.Image = ((System.Drawing.Image)(resources.GetObject("cuiButton1.Image")));
            this.cuiButton1.ImageAutoCenter = true;
            this.cuiButton1.ImageExpand = new System.Drawing.Point(0, 0);
            this.cuiButton1.ImageOffset = new System.Drawing.Point(0, 0);
            this.cuiButton1.ImageTint = System.Drawing.Color.White;
            this.cuiButton1.Location = new System.Drawing.Point(1309, 8);
            this.cuiButton1.Name = "cuiButton1";
            this.cuiButton1.NormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(69)))));
            this.cuiButton1.NormalOutline = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(69)))));
            this.cuiButton1.OutlineThickness = 0F;
            this.cuiButton1.PressedBackground = System.Drawing.Color.Cornsilk;
            this.cuiButton1.PressedImageTint = System.Drawing.Color.White;
            this.cuiButton1.PressedOutline = System.Drawing.Color.Coral;
            this.cuiButton1.Rounding = new System.Windows.Forms.Padding(8);
            this.cuiButton1.Size = new System.Drawing.Size(23, 24);
            this.cuiButton1.TabIndex = 2;
            this.cuiButton1.TextOffset = new System.Drawing.Point(0, 0);
            this.cuiButton1.Click += new System.EventHandler(this.cuiButton1_Click);
            // 
            // slidePanel
            // 
            this.slidePanel.Controls.Add(this.userpanel);
            this.slidePanel.Controls.Add(this.logout);
            this.slidePanel.Controls.Add(this.kryptonPanel1);
            this.slidePanel.Controls.Add(this.menubtn);
            this.slidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.slidePanel.Location = new System.Drawing.Point(0, 0);
            this.slidePanel.Margin = new System.Windows.Forms.Padding(1);
            this.slidePanel.Name = "slidePanel";
            this.slidePanel.Size = new System.Drawing.Size(70, 798);
            this.slidePanel.TabIndex = 3;
            // 
            // userpanel
            // 
            this.userpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.userpanel.Controls.Add(this.usericonbtn);
            this.userpanel.Controls.Add(this.usertxt);
            this.userpanel.Location = new System.Drawing.Point(2, 662);
            this.userpanel.Name = "userpanel";
            this.userpanel.Size = new System.Drawing.Size(230, 53);
            this.userpanel.TabIndex = 8;
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
            this.usericonbtn.HoverBackground = System.Drawing.SystemColors.ControlText;
            this.usericonbtn.HoveredImageTint = System.Drawing.Color.White;
            this.usericonbtn.HoverOutline = System.Drawing.Color.White;
            this.usericonbtn.Image = ((System.Drawing.Image)(resources.GetObject("usericonbtn.Image")));
            this.usericonbtn.ImageAutoCenter = true;
            this.usericonbtn.ImageExpand = new System.Drawing.Point(5, 5);
            this.usericonbtn.ImageOffset = new System.Drawing.Point(0, 0);
            this.usericonbtn.ImageTint = System.Drawing.Color.White;
            this.usericonbtn.Location = new System.Drawing.Point(11, 3);
            this.usericonbtn.Name = "usericonbtn";
            this.usericonbtn.NormalBackground = System.Drawing.Color.SlateGray;
            this.usericonbtn.NormalOutline = System.Drawing.Color.Empty;
            this.usericonbtn.OutlineThickness = 3F;
            this.usericonbtn.PressedBackground = System.Drawing.Color.MediumPurple;
            this.usericonbtn.PressedImageTint = System.Drawing.Color.White;
            this.usericonbtn.PressedOutline = System.Drawing.Color.Empty;
            this.usericonbtn.Rounding = new System.Windows.Forms.Padding(15);
            this.usericonbtn.Size = new System.Drawing.Size(46, 45);
            this.usericonbtn.TabIndex = 9;
            this.usericonbtn.TextOffset = new System.Drawing.Point(0, 0);
            // 
            // usertxt
            // 
            this.usertxt.AutoSize = true;
            this.usertxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usertxt.ForeColor = System.Drawing.Color.White;
            this.usertxt.Location = new System.Drawing.Point(76, 15);
            this.usertxt.Name = "usertxt";
            this.usertxt.Size = new System.Drawing.Size(110, 25);
            this.usertxt.TabIndex = 1;
            this.usertxt.Text = "Username";
            // 
            // logout
            // 
            this.logout.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logout.ButtonStyle = Krypton.Toolkit.ButtonStyle.NavigatorMini;
            this.logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logout.Location = new System.Drawing.Point(1, 731);
            this.logout.Name = "logout";
            this.logout.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.logout.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.logout.Size = new System.Drawing.Size(63, 53);
            this.logout.StateCheckedNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(115)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
            this.logout.StateCheckedNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(115)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
            this.logout.StateCheckedNormal.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.logout.StateCheckedNormal.Content.AdjacentGap = 20;
            this.logout.StateCheckedNormal.Content.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.logout.StateCheckedNormal.Content.Image.ImageV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.logout.StateCheckedNormal.Content.Padding = new System.Windows.Forms.Padding(19, -1, 0, -1);
            this.logout.StateCheckedNormal.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
            this.logout.StateCheckedNormal.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
            this.logout.StateCheckedNormal.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout.StateCheckedNormal.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.logout.StateCheckedNormal.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.logout.StateCheckedNormal.Content.ShortText.Trim = Krypton.Toolkit.PaletteTextTrim.Character;
            this.logout.StateCheckedPressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(115)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
            this.logout.StateCheckedPressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(115)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
            this.logout.StateCheckedPressed.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.logout.StateCheckedPressed.Content.AdjacentGap = 20;
            this.logout.StateCheckedPressed.Content.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.logout.StateCheckedPressed.Content.Image.ImageV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.logout.StateCheckedPressed.Content.Padding = new System.Windows.Forms.Padding(19, -1, 0, -1);
            this.logout.StateCheckedPressed.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
            this.logout.StateCheckedPressed.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
            this.logout.StateCheckedPressed.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout.StateCheckedPressed.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.logout.StateCheckedPressed.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.logout.StateCheckedPressed.Content.ShortText.Trim = Krypton.Toolkit.PaletteTextTrim.Word;
            this.logout.StateCheckedTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(115)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
            this.logout.StateCheckedTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(115)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
            this.logout.StateCheckedTracking.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.logout.StateCheckedTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(29)))), ((int)(((byte)(58)))));
            this.logout.StateCheckedTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(29)))), ((int)(((byte)(58)))));
            this.logout.StateCheckedTracking.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.logout.StateCheckedTracking.Content.AdjacentGap = 20;
            this.logout.StateCheckedTracking.Content.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.logout.StateCheckedTracking.Content.Image.ImageV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.logout.StateCheckedTracking.Content.Padding = new System.Windows.Forms.Padding(19, -1, 0, -1);
            this.logout.StateCheckedTracking.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
            this.logout.StateCheckedTracking.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
            this.logout.StateCheckedTracking.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout.StateCheckedTracking.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.logout.StateCheckedTracking.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.logout.StateCheckedTracking.Content.ShortText.Trim = Krypton.Toolkit.PaletteTextTrim.Word;
            this.logout.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.logout.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.logout.StateNormal.Content.AdjacentGap = 20;
            this.logout.StateNormal.Content.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.logout.StateNormal.Content.Image.ImageV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.logout.StateNormal.Content.Padding = new System.Windows.Forms.Padding(19, -1, 0, -1);
            this.logout.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.logout.StateNormal.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.logout.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout.StateNormal.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.logout.StateNormal.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.logout.StateNormal.Content.ShortText.Trim = Krypton.Toolkit.PaletteTextTrim.Word;
            this.logout.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(115)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
            this.logout.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(115)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
            this.logout.StatePressed.Content.AdjacentGap = 20;
            this.logout.StatePressed.Content.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.logout.StatePressed.Content.Image.ImageV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.logout.StatePressed.Content.Padding = new System.Windows.Forms.Padding(19, -1, 0, -1);
            this.logout.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
            this.logout.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
            this.logout.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout.StatePressed.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.logout.StatePressed.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.logout.StatePressed.Content.ShortText.Trim = Krypton.Toolkit.PaletteTextTrim.Word;
            this.logout.StateTracking.Back.Color1 = System.Drawing.Color.DimGray;
            this.logout.StateTracking.Back.Color2 = System.Drawing.Color.DimGray;
            this.logout.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(29)))), ((int)(((byte)(58)))));
            this.logout.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(29)))), ((int)(((byte)(58)))));
            this.logout.StateTracking.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.logout.StateTracking.Content.AdjacentGap = 20;
            this.logout.StateTracking.Content.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.logout.StateTracking.Content.Image.ImageV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.logout.StateTracking.Content.Padding = new System.Windows.Forms.Padding(19, -1, 0, -1);
            this.logout.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.logout.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.logout.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout.StateTracking.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.logout.StateTracking.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.logout.StateTracking.Content.ShortText.Trim = Krypton.Toolkit.PaletteTextTrim.Word;
            this.logout.TabIndex = 6;
            this.logout.Values.Image = ((System.Drawing.Image)(resources.GetObject("logout.Values.Image")));
            this.logout.Values.Text = "Log Out";
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.kryptonPanel1.Controls.Add(this.downloadbtn);
            this.kryptonPanel1.Controls.Add(this.GameDBbtn);
            this.kryptonPanel1.Controls.Add(this.categoryBtn);
            this.kryptonPanel1.Controls.Add(this.btnHome);
            this.kryptonPanel1.Controls.Add(this.adminDBbtn);
            this.kryptonPanel1.Controls.Add(this.userDBbtn);
            this.kryptonPanel1.Location = new System.Drawing.Point(2, 183);
            this.kryptonPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.PanelBackStyle = Krypton.Toolkit.PaletteBackStyle.TabLowProfile;
            this.kryptonPanel1.Size = new System.Drawing.Size(68, 358);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // downloadbtn
            // 
            this.downloadbtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.downloadbtn.ButtonStyle = Krypton.Toolkit.ButtonStyle.NavigatorMini;
            this.downloadbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.downloadbtn.Location = new System.Drawing.Point(3, 288);
            this.downloadbtn.Name = "downloadbtn";
            this.downloadbtn.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.downloadbtn.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.downloadbtn.Size = new System.Drawing.Size(65, 53);
            this.downloadbtn.StateCheckedNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(115)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
            this.downloadbtn.StateCheckedNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(115)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
            this.downloadbtn.StateCheckedNormal.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.downloadbtn.StateCheckedNormal.Content.AdjacentGap = 20;
            this.downloadbtn.StateCheckedNormal.Content.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.downloadbtn.StateCheckedNormal.Content.Image.ImageV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.downloadbtn.StateCheckedNormal.Content.Padding = new System.Windows.Forms.Padding(19, -1, 0, -1);
            this.downloadbtn.StateCheckedNormal.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
            this.downloadbtn.StateCheckedNormal.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
            this.downloadbtn.StateCheckedNormal.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.downloadbtn.StateCheckedNormal.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.downloadbtn.StateCheckedNormal.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.downloadbtn.StateCheckedNormal.Content.ShortText.Trim = Krypton.Toolkit.PaletteTextTrim.Character;
            this.downloadbtn.StateCheckedPressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(115)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
            this.downloadbtn.StateCheckedPressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(115)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
            this.downloadbtn.StateCheckedPressed.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.downloadbtn.StateCheckedPressed.Content.AdjacentGap = 20;
            this.downloadbtn.StateCheckedPressed.Content.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.downloadbtn.StateCheckedPressed.Content.Image.ImageV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.downloadbtn.StateCheckedPressed.Content.Padding = new System.Windows.Forms.Padding(19, -1, 0, -1);
            this.downloadbtn.StateCheckedPressed.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
            this.downloadbtn.StateCheckedPressed.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
            this.downloadbtn.StateCheckedPressed.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.downloadbtn.StateCheckedPressed.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.downloadbtn.StateCheckedPressed.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.downloadbtn.StateCheckedPressed.Content.ShortText.Trim = Krypton.Toolkit.PaletteTextTrim.Word;
            this.downloadbtn.StateCheckedTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(115)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
            this.downloadbtn.StateCheckedTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(115)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
            this.downloadbtn.StateCheckedTracking.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.downloadbtn.StateCheckedTracking.Content.AdjacentGap = 20;
            this.downloadbtn.StateCheckedTracking.Content.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.downloadbtn.StateCheckedTracking.Content.Image.ImageV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.downloadbtn.StateCheckedTracking.Content.Padding = new System.Windows.Forms.Padding(19, -1, 0, -1);
            this.downloadbtn.StateCheckedTracking.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
            this.downloadbtn.StateCheckedTracking.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
            this.downloadbtn.StateCheckedTracking.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.downloadbtn.StateCheckedTracking.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.downloadbtn.StateCheckedTracking.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.downloadbtn.StateCheckedTracking.Content.ShortText.Trim = Krypton.Toolkit.PaletteTextTrim.Word;
            this.downloadbtn.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.downloadbtn.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.downloadbtn.StateNormal.Content.AdjacentGap = 20;
            this.downloadbtn.StateNormal.Content.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.downloadbtn.StateNormal.Content.Image.ImageV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.downloadbtn.StateNormal.Content.Padding = new System.Windows.Forms.Padding(19, -1, 0, -1);
            this.downloadbtn.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.downloadbtn.StateNormal.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.downloadbtn.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.downloadbtn.StateNormal.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.downloadbtn.StateNormal.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.downloadbtn.StateNormal.Content.ShortText.Trim = Krypton.Toolkit.PaletteTextTrim.Word;
            this.downloadbtn.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(115)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
            this.downloadbtn.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(115)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
            this.downloadbtn.StatePressed.Content.AdjacentGap = 20;
            this.downloadbtn.StatePressed.Content.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.downloadbtn.StatePressed.Content.Image.ImageV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.downloadbtn.StatePressed.Content.Padding = new System.Windows.Forms.Padding(19, -1, 0, -1);
            this.downloadbtn.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
            this.downloadbtn.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
            this.downloadbtn.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.downloadbtn.StatePressed.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.downloadbtn.StatePressed.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.downloadbtn.StatePressed.Content.ShortText.Trim = Krypton.Toolkit.PaletteTextTrim.Word;
            this.downloadbtn.StateTracking.Back.Color1 = System.Drawing.Color.DimGray;
            this.downloadbtn.StateTracking.Back.Color2 = System.Drawing.Color.DimGray;
            this.downloadbtn.StateTracking.Content.AdjacentGap = 20;
            this.downloadbtn.StateTracking.Content.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.downloadbtn.StateTracking.Content.Image.ImageV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.downloadbtn.StateTracking.Content.Padding = new System.Windows.Forms.Padding(19, -1, 0, -1);
            this.downloadbtn.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.downloadbtn.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.downloadbtn.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.downloadbtn.StateTracking.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.downloadbtn.StateTracking.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.downloadbtn.StateTracking.Content.ShortText.Trim = Krypton.Toolkit.PaletteTextTrim.Word;
            this.downloadbtn.TabIndex = 6;
            this.downloadbtn.Values.Image = ((System.Drawing.Image)(resources.GetObject("downloadbtn.Values.Image")));
            this.downloadbtn.Values.Text = "Downloads";
            this.downloadbtn.Click += new System.EventHandler(this.downloadbtn_Click);
            // 
            // GameDBbtn
            // 
            this.GameDBbtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GameDBbtn.ButtonStyle = Krypton.Toolkit.ButtonStyle.NavigatorMini;
            this.GameDBbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GameDBbtn.Location = new System.Drawing.Point(3, 180);
            this.GameDBbtn.Name = "GameDBbtn";
            this.GameDBbtn.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.GameDBbtn.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.GameDBbtn.Size = new System.Drawing.Size(81, 53);
            this.GameDBbtn.StateCheckedNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(115)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
            this.GameDBbtn.StateCheckedNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(115)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
            this.GameDBbtn.StateCheckedNormal.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.GameDBbtn.StateCheckedNormal.Content.AdjacentGap = 20;
            this.GameDBbtn.StateCheckedNormal.Content.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.GameDBbtn.StateCheckedNormal.Content.Image.ImageV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.GameDBbtn.StateCheckedNormal.Content.Padding = new System.Windows.Forms.Padding(19, -1, 0, -1);
            this.GameDBbtn.StateCheckedNormal.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
            this.GameDBbtn.StateCheckedNormal.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
            this.GameDBbtn.StateCheckedNormal.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameDBbtn.StateCheckedNormal.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.GameDBbtn.StateCheckedNormal.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.GameDBbtn.StateCheckedNormal.Content.ShortText.Trim = Krypton.Toolkit.PaletteTextTrim.Character;
            this.GameDBbtn.StateCheckedPressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(115)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
            this.GameDBbtn.StateCheckedPressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(115)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
            this.GameDBbtn.StateCheckedPressed.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.GameDBbtn.StateCheckedPressed.Content.AdjacentGap = 20;
            this.GameDBbtn.StateCheckedPressed.Content.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.GameDBbtn.StateCheckedPressed.Content.Image.ImageV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.GameDBbtn.StateCheckedPressed.Content.Padding = new System.Windows.Forms.Padding(19, -1, 0, -1);
            this.GameDBbtn.StateCheckedPressed.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
            this.GameDBbtn.StateCheckedPressed.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
            this.GameDBbtn.StateCheckedPressed.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameDBbtn.StateCheckedPressed.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.GameDBbtn.StateCheckedPressed.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.GameDBbtn.StateCheckedPressed.Content.ShortText.Trim = Krypton.Toolkit.PaletteTextTrim.Word;
            this.GameDBbtn.StateCheckedTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(115)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
            this.GameDBbtn.StateCheckedTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(115)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
            this.GameDBbtn.StateCheckedTracking.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.GameDBbtn.StateCheckedTracking.Content.AdjacentGap = 20;
            this.GameDBbtn.StateCheckedTracking.Content.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.GameDBbtn.StateCheckedTracking.Content.Image.ImageV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.GameDBbtn.StateCheckedTracking.Content.Padding = new System.Windows.Forms.Padding(19, -1, 0, -1);
            this.GameDBbtn.StateCheckedTracking.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
            this.GameDBbtn.StateCheckedTracking.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
            this.GameDBbtn.StateCheckedTracking.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameDBbtn.StateCheckedTracking.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.GameDBbtn.StateCheckedTracking.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.GameDBbtn.StateCheckedTracking.Content.ShortText.Trim = Krypton.Toolkit.PaletteTextTrim.Word;
            this.GameDBbtn.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.GameDBbtn.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.GameDBbtn.StateNormal.Content.AdjacentGap = 20;
            this.GameDBbtn.StateNormal.Content.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.GameDBbtn.StateNormal.Content.Image.ImageV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.GameDBbtn.StateNormal.Content.Padding = new System.Windows.Forms.Padding(19, -1, 0, -1);
            this.GameDBbtn.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.GameDBbtn.StateNormal.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.GameDBbtn.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameDBbtn.StateNormal.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.GameDBbtn.StateNormal.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.GameDBbtn.StateNormal.Content.ShortText.Trim = Krypton.Toolkit.PaletteTextTrim.Word;
            this.GameDBbtn.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(115)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
            this.GameDBbtn.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(115)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
            this.GameDBbtn.StatePressed.Content.AdjacentGap = 20;
            this.GameDBbtn.StatePressed.Content.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.GameDBbtn.StatePressed.Content.Image.ImageV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.GameDBbtn.StatePressed.Content.Padding = new System.Windows.Forms.Padding(19, -1, 0, -1);
            this.GameDBbtn.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
            this.GameDBbtn.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
            this.GameDBbtn.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameDBbtn.StatePressed.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.GameDBbtn.StatePressed.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.GameDBbtn.StatePressed.Content.ShortText.Trim = Krypton.Toolkit.PaletteTextTrim.Word;
            this.GameDBbtn.StateTracking.Back.Color1 = System.Drawing.Color.DimGray;
            this.GameDBbtn.StateTracking.Back.Color2 = System.Drawing.Color.DimGray;
            this.GameDBbtn.StateTracking.Content.AdjacentGap = 20;
            this.GameDBbtn.StateTracking.Content.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.GameDBbtn.StateTracking.Content.Image.ImageV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.GameDBbtn.StateTracking.Content.Padding = new System.Windows.Forms.Padding(19, -1, 0, -1);
            this.GameDBbtn.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.GameDBbtn.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.GameDBbtn.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameDBbtn.StateTracking.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.GameDBbtn.StateTracking.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.GameDBbtn.StateTracking.Content.ShortText.Trim = Krypton.Toolkit.PaletteTextTrim.Word;
            this.GameDBbtn.TabIndex = 4;
            this.GameDBbtn.Values.Image = ((System.Drawing.Image)(resources.GetObject("GameDBbtn.Values.Image")));
            this.GameDBbtn.Values.Text = "Game Database";
            this.GameDBbtn.Click += new System.EventHandler(this.GameDBbtn_Click);
            // 
            // categoryBtn
            // 
            this.categoryBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.categoryBtn.ButtonStyle = Krypton.Toolkit.ButtonStyle.NavigatorMini;
            this.categoryBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.categoryBtn.Location = new System.Drawing.Point(3, 239);
            this.categoryBtn.Name = "categoryBtn";
            this.categoryBtn.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.categoryBtn.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.categoryBtn.Size = new System.Drawing.Size(65, 53);
            this.categoryBtn.StateCheckedNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(115)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
            this.categoryBtn.StateCheckedNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(115)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
            this.categoryBtn.StateCheckedNormal.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.categoryBtn.StateCheckedNormal.Content.AdjacentGap = 20;
            this.categoryBtn.StateCheckedNormal.Content.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.categoryBtn.StateCheckedNormal.Content.Image.ImageV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.categoryBtn.StateCheckedNormal.Content.Padding = new System.Windows.Forms.Padding(19, -1, 0, -1);
            this.categoryBtn.StateCheckedNormal.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
            this.categoryBtn.StateCheckedNormal.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
            this.categoryBtn.StateCheckedNormal.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryBtn.StateCheckedNormal.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.categoryBtn.StateCheckedNormal.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.categoryBtn.StateCheckedNormal.Content.ShortText.Trim = Krypton.Toolkit.PaletteTextTrim.Character;
            this.categoryBtn.StateCheckedPressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(115)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
            this.categoryBtn.StateCheckedPressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(115)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
            this.categoryBtn.StateCheckedPressed.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.categoryBtn.StateCheckedPressed.Content.AdjacentGap = 20;
            this.categoryBtn.StateCheckedPressed.Content.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.categoryBtn.StateCheckedPressed.Content.Image.ImageV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.categoryBtn.StateCheckedPressed.Content.Padding = new System.Windows.Forms.Padding(19, -1, 0, -1);
            this.categoryBtn.StateCheckedPressed.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
            this.categoryBtn.StateCheckedPressed.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
            this.categoryBtn.StateCheckedPressed.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryBtn.StateCheckedPressed.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.categoryBtn.StateCheckedPressed.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.categoryBtn.StateCheckedPressed.Content.ShortText.Trim = Krypton.Toolkit.PaletteTextTrim.Word;
            this.categoryBtn.StateCheckedTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(115)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
            this.categoryBtn.StateCheckedTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(115)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
            this.categoryBtn.StateCheckedTracking.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.categoryBtn.StateCheckedTracking.Content.AdjacentGap = 20;
            this.categoryBtn.StateCheckedTracking.Content.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.categoryBtn.StateCheckedTracking.Content.Image.ImageV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.categoryBtn.StateCheckedTracking.Content.Padding = new System.Windows.Forms.Padding(19, -1, 0, -1);
            this.categoryBtn.StateCheckedTracking.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
            this.categoryBtn.StateCheckedTracking.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
            this.categoryBtn.StateCheckedTracking.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryBtn.StateCheckedTracking.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.categoryBtn.StateCheckedTracking.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.categoryBtn.StateCheckedTracking.Content.ShortText.Trim = Krypton.Toolkit.PaletteTextTrim.Word;
            this.categoryBtn.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.categoryBtn.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.categoryBtn.StateNormal.Content.AdjacentGap = 20;
            this.categoryBtn.StateNormal.Content.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.categoryBtn.StateNormal.Content.Image.ImageV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.categoryBtn.StateNormal.Content.Padding = new System.Windows.Forms.Padding(19, -1, 0, -1);
            this.categoryBtn.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.categoryBtn.StateNormal.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.categoryBtn.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryBtn.StateNormal.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.categoryBtn.StateNormal.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.categoryBtn.StateNormal.Content.ShortText.Trim = Krypton.Toolkit.PaletteTextTrim.Word;
            this.categoryBtn.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(115)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
            this.categoryBtn.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(115)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
            this.categoryBtn.StatePressed.Content.AdjacentGap = 20;
            this.categoryBtn.StatePressed.Content.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.categoryBtn.StatePressed.Content.Image.ImageV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.categoryBtn.StatePressed.Content.Padding = new System.Windows.Forms.Padding(19, -1, 0, -1);
            this.categoryBtn.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
            this.categoryBtn.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
            this.categoryBtn.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryBtn.StatePressed.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.categoryBtn.StatePressed.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.categoryBtn.StatePressed.Content.ShortText.Trim = Krypton.Toolkit.PaletteTextTrim.Word;
            this.categoryBtn.StateTracking.Back.Color1 = System.Drawing.Color.DimGray;
            this.categoryBtn.StateTracking.Back.Color2 = System.Drawing.Color.DimGray;
            this.categoryBtn.StateTracking.Content.AdjacentGap = 20;
            this.categoryBtn.StateTracking.Content.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.categoryBtn.StateTracking.Content.Image.ImageV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.categoryBtn.StateTracking.Content.Padding = new System.Windows.Forms.Padding(19, -1, 0, -1);
            this.categoryBtn.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.categoryBtn.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.categoryBtn.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryBtn.StateTracking.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.categoryBtn.StateTracking.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.categoryBtn.StateTracking.Content.ShortText.Trim = Krypton.Toolkit.PaletteTextTrim.Word;
            this.categoryBtn.TabIndex = 5;
            this.categoryBtn.Values.Image = ((System.Drawing.Image)(resources.GetObject("categoryBtn.Values.Image")));
            this.categoryBtn.Values.Text = "Category";
            this.categoryBtn.Click += new System.EventHandler(this.categoryBtn_Click);
            // 
            // btnHome
            // 
            this.btnHome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHome.ButtonStyle = Krypton.Toolkit.ButtonStyle.NavigatorMini;
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.Location = new System.Drawing.Point(3, 3);
            this.btnHome.Name = "btnHome";
            this.btnHome.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.btnHome.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.btnHome.Size = new System.Drawing.Size(81, 53);
            this.btnHome.StateCheckedNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(115)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
            this.btnHome.StateCheckedNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(115)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
            this.btnHome.StateCheckedNormal.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
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
            this.btnHome.Values.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Values.Image")));
            this.btnHome.Values.Text = "Home";
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // adminDBbtn
            // 
            this.adminDBbtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.adminDBbtn.ButtonStyle = Krypton.Toolkit.ButtonStyle.NavigatorMini;
            this.adminDBbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.adminDBbtn.Location = new System.Drawing.Point(3, 121);
            this.adminDBbtn.Name = "adminDBbtn";
            this.adminDBbtn.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.adminDBbtn.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.adminDBbtn.Size = new System.Drawing.Size(81, 53);
            this.adminDBbtn.StateCheckedNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(115)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
            this.adminDBbtn.StateCheckedNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(115)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
            this.adminDBbtn.StateCheckedNormal.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.adminDBbtn.StateCheckedNormal.Content.AdjacentGap = 20;
            this.adminDBbtn.StateCheckedNormal.Content.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.adminDBbtn.StateCheckedNormal.Content.Image.ImageV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.adminDBbtn.StateCheckedNormal.Content.Padding = new System.Windows.Forms.Padding(19, -1, 0, -1);
            this.adminDBbtn.StateCheckedNormal.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
            this.adminDBbtn.StateCheckedNormal.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
            this.adminDBbtn.StateCheckedNormal.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminDBbtn.StateCheckedNormal.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.adminDBbtn.StateCheckedNormal.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.adminDBbtn.StateCheckedNormal.Content.ShortText.Trim = Krypton.Toolkit.PaletteTextTrim.Character;
            this.adminDBbtn.StateCheckedPressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(115)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
            this.adminDBbtn.StateCheckedPressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(115)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
            this.adminDBbtn.StateCheckedPressed.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.adminDBbtn.StateCheckedPressed.Content.AdjacentGap = 20;
            this.adminDBbtn.StateCheckedPressed.Content.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.adminDBbtn.StateCheckedPressed.Content.Image.ImageV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.adminDBbtn.StateCheckedPressed.Content.Padding = new System.Windows.Forms.Padding(19, -1, 0, -1);
            this.adminDBbtn.StateCheckedPressed.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
            this.adminDBbtn.StateCheckedPressed.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
            this.adminDBbtn.StateCheckedPressed.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminDBbtn.StateCheckedPressed.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.adminDBbtn.StateCheckedPressed.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.adminDBbtn.StateCheckedPressed.Content.ShortText.Trim = Krypton.Toolkit.PaletteTextTrim.Word;
            this.adminDBbtn.StateCheckedTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(115)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
            this.adminDBbtn.StateCheckedTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(115)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
            this.adminDBbtn.StateCheckedTracking.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.adminDBbtn.StateCheckedTracking.Content.AdjacentGap = 20;
            this.adminDBbtn.StateCheckedTracking.Content.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.adminDBbtn.StateCheckedTracking.Content.Image.ImageV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.adminDBbtn.StateCheckedTracking.Content.Padding = new System.Windows.Forms.Padding(19, -1, 0, -1);
            this.adminDBbtn.StateCheckedTracking.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
            this.adminDBbtn.StateCheckedTracking.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
            this.adminDBbtn.StateCheckedTracking.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminDBbtn.StateCheckedTracking.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.adminDBbtn.StateCheckedTracking.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.adminDBbtn.StateCheckedTracking.Content.ShortText.Trim = Krypton.Toolkit.PaletteTextTrim.Word;
            this.adminDBbtn.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.adminDBbtn.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.adminDBbtn.StateNormal.Content.AdjacentGap = 20;
            this.adminDBbtn.StateNormal.Content.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.adminDBbtn.StateNormal.Content.Image.ImageV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.adminDBbtn.StateNormal.Content.Padding = new System.Windows.Forms.Padding(19, -1, 0, -1);
            this.adminDBbtn.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.adminDBbtn.StateNormal.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.adminDBbtn.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminDBbtn.StateNormal.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.adminDBbtn.StateNormal.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.adminDBbtn.StateNormal.Content.ShortText.Trim = Krypton.Toolkit.PaletteTextTrim.Word;
            this.adminDBbtn.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(115)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
            this.adminDBbtn.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(115)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
            this.adminDBbtn.StatePressed.Content.AdjacentGap = 20;
            this.adminDBbtn.StatePressed.Content.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.adminDBbtn.StatePressed.Content.Image.ImageV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.adminDBbtn.StatePressed.Content.Padding = new System.Windows.Forms.Padding(19, -1, 0, -1);
            this.adminDBbtn.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
            this.adminDBbtn.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
            this.adminDBbtn.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminDBbtn.StatePressed.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.adminDBbtn.StatePressed.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.adminDBbtn.StatePressed.Content.ShortText.Trim = Krypton.Toolkit.PaletteTextTrim.Word;
            this.adminDBbtn.StateTracking.Back.Color1 = System.Drawing.Color.DimGray;
            this.adminDBbtn.StateTracking.Back.Color2 = System.Drawing.Color.DimGray;
            this.adminDBbtn.StateTracking.Content.AdjacentGap = 20;
            this.adminDBbtn.StateTracking.Content.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.adminDBbtn.StateTracking.Content.Image.ImageV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.adminDBbtn.StateTracking.Content.Padding = new System.Windows.Forms.Padding(19, -1, 0, -1);
            this.adminDBbtn.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.adminDBbtn.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.adminDBbtn.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminDBbtn.StateTracking.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.adminDBbtn.StateTracking.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.adminDBbtn.StateTracking.Content.ShortText.Trim = Krypton.Toolkit.PaletteTextTrim.Word;
            this.adminDBbtn.TabIndex = 3;
            this.adminDBbtn.Values.Image = ((System.Drawing.Image)(resources.GetObject("adminDBbtn.Values.Image")));
            this.adminDBbtn.Values.Text = "Admin Database";
            this.adminDBbtn.Click += new System.EventHandler(this.adminDBbtn_Click);
            // 
            // userDBbtn
            // 
            this.userDBbtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userDBbtn.ButtonStyle = Krypton.Toolkit.ButtonStyle.NavigatorMini;
            this.userDBbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.userDBbtn.Location = new System.Drawing.Point(3, 62);
            this.userDBbtn.Name = "userDBbtn";
            this.userDBbtn.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.userDBbtn.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.userDBbtn.Size = new System.Drawing.Size(81, 53);
            this.userDBbtn.StateCheckedNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(115)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
            this.userDBbtn.StateCheckedNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(115)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
            this.userDBbtn.StateCheckedNormal.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.userDBbtn.StateCheckedNormal.Content.AdjacentGap = 20;
            this.userDBbtn.StateCheckedNormal.Content.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.userDBbtn.StateCheckedNormal.Content.Image.ImageV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.userDBbtn.StateCheckedNormal.Content.Padding = new System.Windows.Forms.Padding(19, -1, 0, -1);
            this.userDBbtn.StateCheckedNormal.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
            this.userDBbtn.StateCheckedNormal.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
            this.userDBbtn.StateCheckedNormal.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userDBbtn.StateCheckedNormal.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.userDBbtn.StateCheckedNormal.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.userDBbtn.StateCheckedNormal.Content.ShortText.Trim = Krypton.Toolkit.PaletteTextTrim.Character;
            this.userDBbtn.StateCheckedPressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(115)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
            this.userDBbtn.StateCheckedPressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(115)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
            this.userDBbtn.StateCheckedPressed.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.userDBbtn.StateCheckedPressed.Content.AdjacentGap = 20;
            this.userDBbtn.StateCheckedPressed.Content.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.userDBbtn.StateCheckedPressed.Content.Image.ImageV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.userDBbtn.StateCheckedPressed.Content.Padding = new System.Windows.Forms.Padding(19, -1, 0, -1);
            this.userDBbtn.StateCheckedPressed.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
            this.userDBbtn.StateCheckedPressed.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
            this.userDBbtn.StateCheckedPressed.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userDBbtn.StateCheckedPressed.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.userDBbtn.StateCheckedPressed.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.userDBbtn.StateCheckedPressed.Content.ShortText.Trim = Krypton.Toolkit.PaletteTextTrim.Word;
            this.userDBbtn.StateCheckedTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(115)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
            this.userDBbtn.StateCheckedTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(115)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
            this.userDBbtn.StateCheckedTracking.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.userDBbtn.StateCheckedTracking.Content.AdjacentGap = 20;
            this.userDBbtn.StateCheckedTracking.Content.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.userDBbtn.StateCheckedTracking.Content.Image.ImageV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.userDBbtn.StateCheckedTracking.Content.Padding = new System.Windows.Forms.Padding(19, -1, 0, -1);
            this.userDBbtn.StateCheckedTracking.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
            this.userDBbtn.StateCheckedTracking.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
            this.userDBbtn.StateCheckedTracking.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userDBbtn.StateCheckedTracking.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.userDBbtn.StateCheckedTracking.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.userDBbtn.StateCheckedTracking.Content.ShortText.Trim = Krypton.Toolkit.PaletteTextTrim.Word;
            this.userDBbtn.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.userDBbtn.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.userDBbtn.StateNormal.Content.AdjacentGap = 20;
            this.userDBbtn.StateNormal.Content.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.userDBbtn.StateNormal.Content.Image.ImageV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.userDBbtn.StateNormal.Content.Padding = new System.Windows.Forms.Padding(19, -1, 0, -1);
            this.userDBbtn.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.userDBbtn.StateNormal.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.userDBbtn.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userDBbtn.StateNormal.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.userDBbtn.StateNormal.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.userDBbtn.StateNormal.Content.ShortText.Trim = Krypton.Toolkit.PaletteTextTrim.Word;
            this.userDBbtn.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(115)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
            this.userDBbtn.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(115)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
            this.userDBbtn.StatePressed.Content.AdjacentGap = 20;
            this.userDBbtn.StatePressed.Content.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.userDBbtn.StatePressed.Content.Image.ImageV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.userDBbtn.StatePressed.Content.Padding = new System.Windows.Forms.Padding(19, -1, 0, -1);
            this.userDBbtn.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
            this.userDBbtn.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
            this.userDBbtn.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userDBbtn.StatePressed.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.userDBbtn.StatePressed.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.userDBbtn.StatePressed.Content.ShortText.Trim = Krypton.Toolkit.PaletteTextTrim.Word;
            this.userDBbtn.StateTracking.Back.Color1 = System.Drawing.Color.DimGray;
            this.userDBbtn.StateTracking.Back.Color2 = System.Drawing.Color.DimGray;
            this.userDBbtn.StateTracking.Content.AdjacentGap = 20;
            this.userDBbtn.StateTracking.Content.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.userDBbtn.StateTracking.Content.Image.ImageV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.userDBbtn.StateTracking.Content.Padding = new System.Windows.Forms.Padding(19, -1, 0, -1);
            this.userDBbtn.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.userDBbtn.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.userDBbtn.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userDBbtn.StateTracking.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.userDBbtn.StateTracking.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.userDBbtn.StateTracking.Content.ShortText.Trim = Krypton.Toolkit.PaletteTextTrim.Word;
            this.userDBbtn.TabIndex = 2;
            this.userDBbtn.Values.Image = ((System.Drawing.Image)(resources.GetObject("userDBbtn.Values.Image")));
            this.userDBbtn.Values.Text = "User Database";
            this.userDBbtn.Click += new System.EventHandler(this.userDBbtn_Click);
            // 
            // menubtn
            // 
            this.menubtn.CheckButton = false;
            this.menubtn.Checked = false;
            this.menubtn.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.menubtn.CheckedImageTint = System.Drawing.Color.White;
            this.menubtn.CheckedOutline = System.Drawing.Color.Transparent;
            this.menubtn.Content = "";
            this.menubtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menubtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.menubtn.ForeColor = System.Drawing.Color.Transparent;
            this.menubtn.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.menubtn.HoveredImageTint = System.Drawing.Color.White;
            this.menubtn.HoverOutline = System.Drawing.Color.Transparent;
            this.menubtn.Image = ((System.Drawing.Image)(resources.GetObject("menubtn.Image")));
            this.menubtn.ImageAutoCenter = true;
            this.menubtn.ImageExpand = new System.Drawing.Point(5, 5);
            this.menubtn.ImageOffset = new System.Drawing.Point(0, 0);
            this.menubtn.ImageTint = System.Drawing.Color.White;
            this.menubtn.Location = new System.Drawing.Point(12, 12);
            this.menubtn.Margin = new System.Windows.Forms.Padding(2);
            this.menubtn.Name = "menubtn";
            this.menubtn.NormalBackground = System.Drawing.Color.Transparent;
            this.menubtn.NormalOutline = System.Drawing.Color.Transparent;
            this.menubtn.OutlineThickness = 1.6F;
            this.menubtn.PressedBackground = System.Drawing.Color.Transparent;
            this.menubtn.PressedImageTint = System.Drawing.Color.White;
            this.menubtn.PressedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(109)))), ((int)(((byte)(118)))));
            this.menubtn.Rounding = new System.Windows.Forms.Padding(10);
            this.menubtn.Size = new System.Drawing.Size(40, 40);
            this.menubtn.TabIndex = 1;
            this.menubtn.TextOffset = new System.Drawing.Point(0, 0);
            this.menubtn.Click += new System.EventHandler(this.menubtn_Click);
            // 
            // mainpanel
            // 
            this.mainpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.mainpanel.Location = new System.Drawing.Point(72, 40);
            this.mainpanel.Margin = new System.Windows.Forms.Padding(1);
            this.mainpanel.Name = "mainpanel";
            this.mainpanel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mainpanel.Size = new System.Drawing.Size(1286, 784);
            this.mainpanel.TabIndex = 5;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 40;
            this.bunifuElipse1.TargetControl = this.mainpanel;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 30;
            this.bunifuElipse2.TargetControl = this;
            // 
            // sliderShowTimer
            // 
            this.sliderShowTimer.Interval = 1;
            this.sliderShowTimer.Tick += new System.EventHandler(this.sliderShowTimer_Tick);
            // 
            // sliderHideTimer
            // 
            this.sliderHideTimer.Interval = 2;
            this.sliderHideTimer.Tick += new System.EventHandler(this.sliderHideTimer_Tick);
            // 
            // faddingTimer
            // 
            this.faddingTimer.Interval = 10;
            this.faddingTimer.Tick += new System.EventHandler(this.faddingTimer_Tick);
            // 
            // bunifuElipse3
            // 
            this.bunifuElipse3.ElipseRadius = 50;
            this.bunifuElipse3.TargetControl = this;
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(1355, 798);
            this.Controls.Add(this.mainpanel);
            this.Controls.Add(this.slidePanel);
            this.Controls.Add(this.cuiButton1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminPanel";
            this.Load += new System.EventHandler(this.AdminPanel_Load);
            this.slidePanel.ResumeLayout(false);
            this.userpanel.ResumeLayout(false);
            this.userpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CuoreUI.Controls.cuiButton cuiButton1;
        private System.Windows.Forms.Panel slidePanel;
        private CuoreUI.Controls.cuiButton menubtn;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private System.Windows.Forms.Timer sliderShowTimer;
        private System.Windows.Forms.Timer sliderHideTimer;
        private System.Windows.Forms.Timer faddingTimer;
        private Krypton.Toolkit.KryptonCheckButton userDBbtn;
        private Krypton.Toolkit.KryptonCheckButton GameDBbtn;
        private Krypton.Toolkit.KryptonCheckButton adminDBbtn;
        private Krypton.Toolkit.KryptonCheckButton categoryBtn;
        private Krypton.Toolkit.KryptonCheckButton logout;
        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private Krypton.Toolkit.KryptonCheckButton btnHome;
        private Krypton.Toolkit.KryptonCheckButton downloadbtn;
        private System.Windows.Forms.Panel userpanel;
        private System.Windows.Forms.Label usertxt;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse3;
        private CuoreUI.Controls.cuiButton usericonbtn;
        private System.Windows.Forms.Panel mainpanel;
    }
}