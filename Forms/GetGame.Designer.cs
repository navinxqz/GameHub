namespace GameServer_Management.Forms
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GetGame));
            this.backbtn = new CuoreUI.Controls.cuiButton();
            this.SuspendLayout();
            // 
            // backbtn
            // 
            this.backbtn.CheckButton = false;
            this.backbtn.Checked = false;
            this.backbtn.CheckedBackground = System.Drawing.Color.Coral;
            this.backbtn.CheckedImageTint = System.Drawing.Color.White;
            this.backbtn.CheckedOutline = System.Drawing.Color.Silver;
            this.backbtn.Content = "";
            this.backbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.backbtn.ForeColor = System.Drawing.Color.White;
            this.backbtn.HoverBackground = System.Drawing.Color.White;
            this.backbtn.HoveredImageTint = System.Drawing.Color.White;
            this.backbtn.HoverOutline = System.Drawing.Color.White;
            this.backbtn.Image = ((System.Drawing.Image)(resources.GetObject("backbtn.Image")));
            this.backbtn.ImageAutoCenter = true;
            this.backbtn.ImageExpand = new System.Drawing.Point(5, 5);
            this.backbtn.ImageOffset = new System.Drawing.Point(0, 0);
            this.backbtn.ImageTint = System.Drawing.Color.White;
            this.backbtn.Location = new System.Drawing.Point(23, 12);
            this.backbtn.Name = "backbtn";
            this.backbtn.NormalBackground = System.Drawing.Color.Transparent;
            this.backbtn.NormalOutline = System.Drawing.Color.Empty;
            this.backbtn.OutlineThickness = 3F;
            this.backbtn.PressedBackground = System.Drawing.Color.MediumPurple;
            this.backbtn.PressedImageTint = System.Drawing.Color.White;
            this.backbtn.PressedOutline = System.Drawing.Color.Empty;
            this.backbtn.Rounding = new System.Windows.Forms.Padding(15);
            this.backbtn.Size = new System.Drawing.Size(40, 38);
            this.backbtn.TabIndex = 25;
            this.backbtn.TextOffset = new System.Drawing.Point(0, 0);
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // GetGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1306, 676);
            this.Controls.Add(this.backbtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GetGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GetGame";
            this.ResumeLayout(false);

        }

        #endregion

        private CuoreUI.Controls.cuiButton backbtn;
    }
}