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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminHome));
            this.label1 = new System.Windows.Forms.Label();
            this.gameDesc1 = new GameServer_Management.Controller.GameDesc();
            this.gameDesc2 = new GameServer_Management.Controller.GameDesc();
            this.gameDesc3 = new GameServer_Management.Controller.GameDesc();
            this.gameDesc4 = new GameServer_Management.Controller.GameDesc();
            this.gameDesc5 = new GameServer_Management.Controller.GameDesc();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(49, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Recently Uploaded";
            // 
            // gameDesc1
            // 
            this.gameDesc1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.gameDesc1.Category = null;
            this.gameDesc1.GName = "Game Name";
            this.gameDesc1.id = 0;
            this.gameDesc1.Location = new System.Drawing.Point(55, 65);
            this.gameDesc1.Name = "gameDesc1";
            this.gameDesc1.Pic = ((System.Drawing.Image)(resources.GetObject("gameDesc1.Pic")));
            this.gameDesc1.Price = "$";
            this.gameDesc1.Size = new System.Drawing.Size(211, 366);
            this.gameDesc1.TabIndex = 2;
            // 
            // gameDesc2
            // 
            this.gameDesc2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.gameDesc2.Category = null;
            this.gameDesc2.GName = "Game Name";
            this.gameDesc2.id = 0;
            this.gameDesc2.Location = new System.Drawing.Point(299, 65);
            this.gameDesc2.Name = "gameDesc2";
            this.gameDesc2.Pic = ((System.Drawing.Image)(resources.GetObject("gameDesc2.Pic")));
            this.gameDesc2.Price = "$";
            this.gameDesc2.Size = new System.Drawing.Size(211, 366);
            this.gameDesc2.TabIndex = 3;
            // 
            // gameDesc3
            // 
            this.gameDesc3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.gameDesc3.Category = null;
            this.gameDesc3.GName = "Game Name";
            this.gameDesc3.id = 0;
            this.gameDesc3.Location = new System.Drawing.Point(544, 65);
            this.gameDesc3.Name = "gameDesc3";
            this.gameDesc3.Pic = ((System.Drawing.Image)(resources.GetObject("gameDesc3.Pic")));
            this.gameDesc3.Price = "$";
            this.gameDesc3.Size = new System.Drawing.Size(211, 366);
            this.gameDesc3.TabIndex = 4;
            // 
            // gameDesc4
            // 
            this.gameDesc4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.gameDesc4.Category = null;
            this.gameDesc4.GName = "Game Name";
            this.gameDesc4.id = 0;
            this.gameDesc4.Location = new System.Drawing.Point(787, 65);
            this.gameDesc4.Name = "gameDesc4";
            this.gameDesc4.Pic = ((System.Drawing.Image)(resources.GetObject("gameDesc4.Pic")));
            this.gameDesc4.Price = "$";
            this.gameDesc4.Size = new System.Drawing.Size(211, 366);
            this.gameDesc4.TabIndex = 5;
            // 
            // gameDesc5
            // 
            this.gameDesc5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.gameDesc5.Category = null;
            this.gameDesc5.GName = "Game Name";
            this.gameDesc5.id = 0;
            this.gameDesc5.Location = new System.Drawing.Point(1031, 65);
            this.gameDesc5.Name = "gameDesc5";
            this.gameDesc5.Pic = ((System.Drawing.Image)(resources.GetObject("gameDesc5.Pic")));
            this.gameDesc5.Price = "$";
            this.gameDesc5.Size = new System.Drawing.Size(211, 366);
            this.gameDesc5.TabIndex = 6;
            // 
            // AdminHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(1322, 715);
            this.Controls.Add(this.gameDesc5);
            this.Controls.Add(this.gameDesc4);
            this.Controls.Add(this.gameDesc3);
            this.Controls.Add(this.gameDesc2);
            this.Controls.Add(this.gameDesc1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminHome";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private Controller.GameDesc gameDesc1;
        private Controller.GameDesc gameDesc2;
        private Controller.GameDesc gameDesc3;
        private Controller.GameDesc gameDesc4;
        private Controller.GameDesc gameDesc5;
    }
}