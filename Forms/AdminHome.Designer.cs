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
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panelTop = new CuoreUI.Controls.cuiBorder();
            this.gamePanel = new System.Windows.Forms.FlowLayoutPanel();
            this.cuiBorder1 = new CuoreUI.Controls.cuiBorder();
            this.cuiBorder2 = new CuoreUI.Controls.cuiBorder();
            this.cuiBorder3 = new CuoreUI.Controls.cuiBorder();
            this.cuiBorder4 = new CuoreUI.Controls.cuiBorder();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 50;
            this.bunifuElipse1.TargetControl = this;
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
            this.cuiBorder1.Location = new System.Drawing.Point(43, 292);
            this.cuiBorder1.Name = "cuiBorder1";
            this.cuiBorder1.OutlineThickness = 1F;
            this.cuiBorder1.PanelColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(222)))), ((int)(((byte)(103)))));
            this.cuiBorder1.PanelOutlineColor = System.Drawing.Color.Snow;
            this.cuiBorder1.Rounding = new System.Windows.Forms.Padding(18);
            this.cuiBorder1.Size = new System.Drawing.Size(486, 192);
            this.cuiBorder1.TabIndex = 1;
            // 
            // cuiBorder2
            // 
            this.cuiBorder2.BackColor = System.Drawing.Color.Transparent;
            this.cuiBorder2.Location = new System.Drawing.Point(43, 511);
            this.cuiBorder2.Name = "cuiBorder2";
            this.cuiBorder2.OutlineThickness = 1F;
            this.cuiBorder2.PanelColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.cuiBorder2.PanelOutlineColor = System.Drawing.Color.Snow;
            this.cuiBorder2.Rounding = new System.Windows.Forms.Padding(18);
            this.cuiBorder2.Size = new System.Drawing.Size(229, 192);
            this.cuiBorder2.TabIndex = 2;
            // 
            // cuiBorder3
            // 
            this.cuiBorder3.BackColor = System.Drawing.Color.Transparent;
            this.cuiBorder3.Location = new System.Drawing.Point(303, 511);
            this.cuiBorder3.Name = "cuiBorder3";
            this.cuiBorder3.OutlineThickness = 1F;
            this.cuiBorder3.PanelColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(243)))), ((int)(((byte)(106)))));
            this.cuiBorder3.PanelOutlineColor = System.Drawing.Color.Snow;
            this.cuiBorder3.Rounding = new System.Windows.Forms.Padding(18);
            this.cuiBorder3.Size = new System.Drawing.Size(226, 192);
            this.cuiBorder3.TabIndex = 3;
            // 
            // cuiBorder4
            // 
            this.cuiBorder4.BackColor = System.Drawing.Color.Transparent;
            this.cuiBorder4.Location = new System.Drawing.Point(556, 292);
            this.cuiBorder4.Name = "cuiBorder4";
            this.cuiBorder4.OutlineThickness = 1F;
            this.cuiBorder4.PanelColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(219)))), ((int)(((byte)(252)))));
            this.cuiBorder4.PanelOutlineColor = System.Drawing.Color.Snow;
            this.cuiBorder4.Rounding = new System.Windows.Forms.Padding(18);
            this.cuiBorder4.Size = new System.Drawing.Size(455, 411);
            this.cuiBorder4.TabIndex = 2;
            // 
            // AdminHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(1286, 760);
            this.Controls.Add(this.cuiBorder4);
            this.Controls.Add(this.cuiBorder3);
            this.Controls.Add(this.cuiBorder2);
            this.Controls.Add(this.cuiBorder1);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminHome";
            this.Load += new System.EventHandler(this.AdminHome_Load);
            this.panelTop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private CuoreUI.Controls.cuiBorder panelTop;
        private System.Windows.Forms.FlowLayoutPanel gamePanel;
        private CuoreUI.Controls.cuiBorder cuiBorder4;
        private CuoreUI.Controls.cuiBorder cuiBorder3;
        private CuoreUI.Controls.cuiBorder cuiBorder2;
        private CuoreUI.Controls.cuiBorder cuiBorder1;
    }
}