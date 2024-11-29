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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminHome));
            this.panelTop = new CuoreUI.Controls.cuiBorder();
            this.gamePanel = new System.Windows.Forms.FlowLayoutPanel();
            this.cuiBorder1 = new CuoreUI.Controls.cuiBorder();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.progressBar = new CuoreUI.Controls.cuiCircleProgressBar();
            this.cuiBorder2 = new CuoreUI.Controls.cuiBorder();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cuiBorder3 = new CuoreUI.Controls.cuiBorder();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panelTop.SuspendLayout();
            this.cuiBorder1.SuspendLayout();
            this.cuiBorder2.SuspendLayout();
            this.cuiBorder3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTop.BackColor = System.Drawing.Color.Transparent;
            this.panelTop.Controls.Add(this.gamePanel);
            this.panelTop.Location = new System.Drawing.Point(43, 31);
            this.panelTop.Name = "panelTop";
            this.panelTop.OutlineThickness = 5F;
            this.panelTop.PanelColor = System.Drawing.Color.Transparent;
            this.panelTop.PanelOutlineColor = System.Drawing.Color.Silver;
            this.panelTop.Rounding = new System.Windows.Forms.Padding(18);
            this.panelTop.Size = new System.Drawing.Size(1203, 245);
            this.panelTop.TabIndex = 0;
            this.panelTop.MouseLeave += new System.EventHandler(this.panelTop_MouseLeave);
            this.panelTop.MouseHover += new System.EventHandler(this.panelTop_MouseHover);
            // 
            // gamePanel
            // 
            this.gamePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gamePanel.AutoScroll = true;
            this.gamePanel.Location = new System.Drawing.Point(15, 7);
            this.gamePanel.Name = "gamePanel";
            this.gamePanel.Size = new System.Drawing.Size(1174, 446);
            this.gamePanel.TabIndex = 0;
            // 
            // cuiBorder1
            // 
            this.cuiBorder1.BackColor = System.Drawing.Color.Transparent;
            this.cuiBorder1.Controls.Add(this.label4);
            this.cuiBorder1.Controls.Add(this.label3);
            this.cuiBorder1.Controls.Add(this.progressBar);
            this.cuiBorder1.Location = new System.Drawing.Point(121, 292);
            this.cuiBorder1.Name = "cuiBorder1";
            this.cuiBorder1.OutlineThickness = 1F;
            this.cuiBorder1.PanelColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(222)))), ((int)(((byte)(103)))));
            this.cuiBorder1.PanelOutlineColor = System.Drawing.Color.Snow;
            this.cuiBorder1.Rounding = new System.Windows.Forms.Padding(18);
            this.cuiBorder1.Size = new System.Drawing.Size(486, 192);
            this.cuiBorder1.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(26)))), ((int)(((byte)(36)))));
            this.label4.Location = new System.Drawing.Point(120, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 42);
            this.label4.TabIndex = 3;
            this.label4.Text = "12+";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(26)))), ((int)(((byte)(36)))));
            this.label3.Location = new System.Drawing.Point(40, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 33);
            this.label3.TabIndex = 2;
            this.label3.Text = "Total Games";
            // 
            // progressBar
            // 
            this.progressBar.BorderWidth = 12;
            this.progressBar.Location = new System.Drawing.Point(295, 19);
            this.progressBar.MaximumValue = 100;
            this.progressBar.MinimumSize = new System.Drawing.Size(24, 24);
            this.progressBar.MinimumValue = 0;
            this.progressBar.Name = "progressBar";
            this.progressBar.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(26)))), ((int)(((byte)(36)))));
            this.progressBar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.progressBar.ProgressValue = 50;
            this.progressBar.RoundedEnds = true;
            this.progressBar.Size = new System.Drawing.Size(150, 150);
            this.progressBar.TabIndex = 0;
            // 
            // cuiBorder2
            // 
            this.cuiBorder2.BackColor = System.Drawing.Color.Transparent;
            this.cuiBorder2.Controls.Add(this.label7);
            this.cuiBorder2.Controls.Add(this.label6);
            this.cuiBorder2.Controls.Add(this.label5);
            this.cuiBorder2.Location = new System.Drawing.Point(121, 511);
            this.cuiBorder2.Name = "cuiBorder2";
            this.cuiBorder2.OutlineThickness = 1F;
            this.cuiBorder2.PanelColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.cuiBorder2.PanelOutlineColor = System.Drawing.Color.Snow;
            this.cuiBorder2.Rounding = new System.Windows.Forms.Padding(18);
            this.cuiBorder2.Size = new System.Drawing.Size(229, 192);
            this.cuiBorder2.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(26)))), ((int)(((byte)(36)))));
            this.label7.Location = new System.Drawing.Point(18, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 42);
            this.label7.TabIndex = 5;
            this.label7.Text = "12+";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(26)))), ((int)(((byte)(36)))));
            this.label6.Location = new System.Drawing.Point(19, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 33);
            this.label6.TabIndex = 4;
            this.label6.Text = "Category";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(26)))), ((int)(((byte)(36)))));
            this.label5.Location = new System.Drawing.Point(19, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 33);
            this.label5.TabIndex = 3;
            this.label5.Text = "Total";
            // 
            // cuiBorder3
            // 
            this.cuiBorder3.BackColor = System.Drawing.Color.Transparent;
            this.cuiBorder3.Controls.Add(this.label2);
            this.cuiBorder3.Controls.Add(this.label1);
            this.cuiBorder3.Controls.Add(this.pictureBox1);
            this.cuiBorder3.Location = new System.Drawing.Point(381, 511);
            this.cuiBorder3.Name = "cuiBorder3";
            this.cuiBorder3.OutlineThickness = 1F;
            this.cuiBorder3.PanelColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(243)))), ((int)(((byte)(106)))));
            this.cuiBorder3.PanelOutlineColor = System.Drawing.Color.Snow;
            this.cuiBorder3.Rounding = new System.Windows.Forms.Padding(18);
            this.cuiBorder3.Size = new System.Drawing.Size(226, 192);
            this.cuiBorder3.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(26)))), ((int)(((byte)(36)))));
            this.label2.Location = new System.Drawing.Point(28, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 42);
            this.label2.TabIndex = 2;
            this.label2.Text = "12+";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(26)))), ((int)(((byte)(36)))));
            this.label1.Location = new System.Drawing.Point(17, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Total User";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-16, -66);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(357, 371);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(666, 295);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(455, 408);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(-136, -79);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(1443, 922);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 50;
            this.bunifuElipse1.TargetControl = this.pictureBox2;
            // 
            // AdminHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(26)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(1286, 760);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.cuiBorder3);
            this.Controls.Add(this.cuiBorder2);
            this.Controls.Add(this.cuiBorder1);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.pictureBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminHome";
            this.Load += new System.EventHandler(this.AdminHome_Load);
            this.panelTop.ResumeLayout(false);
            this.cuiBorder1.ResumeLayout(false);
            this.cuiBorder1.PerformLayout();
            this.cuiBorder2.ResumeLayout(false);
            this.cuiBorder2.PerformLayout();
            this.cuiBorder3.ResumeLayout(false);
            this.cuiBorder3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private CuoreUI.Controls.cuiBorder panelTop;
        private System.Windows.Forms.FlowLayoutPanel gamePanel;
        private CuoreUI.Controls.cuiBorder cuiBorder3;
        private CuoreUI.Controls.cuiBorder cuiBorder2;
        private CuoreUI.Controls.cuiBorder cuiBorder1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private CuoreUI.Controls.cuiCircleProgressBar progressBar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}