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
            this.pricelbl = new System.Windows.Forms.Label();
            this.gameName = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.GameImg)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // GameImg
            // 
            this.GameImg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GameImg.Image = ((System.Drawing.Image)(resources.GetObject("GameImg.Image")));
            this.GameImg.Location = new System.Drawing.Point(3, -1);
            this.GameImg.Name = "GameImg";
            this.GameImg.Size = new System.Drawing.Size(209, 281);
            this.GameImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.GameImg.TabIndex = 0;
            this.GameImg.TabStop = false;
            this.GameImg.Click += new System.EventHandler(this.GameImg_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pricelbl);
            this.panel1.Controls.Add(this.gameName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 261);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(211, 105);
            this.panel1.TabIndex = 3;
            // 
            // pricelbl
            // 
            this.pricelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pricelbl.ForeColor = System.Drawing.Color.White;
            this.pricelbl.Location = new System.Drawing.Point(4, 77);
            this.pricelbl.Name = "pricelbl";
            this.pricelbl.Size = new System.Drawing.Size(200, 28);
            this.pricelbl.TabIndex = 1;
            this.pricelbl.Text = "$";
            // 
            // gameName
            // 
            this.gameName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameName.ForeColor = System.Drawing.Color.White;
            this.gameName.Location = new System.Drawing.Point(3, 9);
            this.gameName.Name = "gameName";
            this.gameName.Size = new System.Drawing.Size(205, 68);
            this.gameName.TabIndex = 0;
            this.gameName.Text = "Game Name";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.GameImg);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(211, 366);
            this.panel2.TabIndex = 4;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 40;
            this.bunifuElipse1.TargetControl = this.GameImg;
            // 
            // GameDesc
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "GameDesc";
            this.Size = new System.Drawing.Size(211, 366);
            ((System.ComponentModel.ISupportInitialize)(this.GameImg)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox GameImg;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label pricelbl;
        private System.Windows.Forms.Label gameName;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}
