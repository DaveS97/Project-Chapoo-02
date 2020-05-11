namespace ChapooUI
{
    partial class Chapoo
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.HomeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.homeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.werknemersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.klantenToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_Welkom = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DarkBlue;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HomeToolStripMenuItem,
            this.klantenToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1039, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // HomeToolStripMenuItem
            // 
            this.HomeToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.HomeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem1,
            this.werknemersToolStripMenuItem});
            this.HomeToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.HomeToolStripMenuItem.Name = "HomeToolStripMenuItem";
            this.HomeToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.HomeToolStripMenuItem.Text = "Home";
            // 
            // homeToolStripMenuItem1
            // 
            this.homeToolStripMenuItem1.Name = "homeToolStripMenuItem1";
            this.homeToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.homeToolStripMenuItem1.Text = "Home";
            this.homeToolStripMenuItem1.Click += new System.EventHandler(this.homeToolStripMenuItem1_Click);
            // 
            // werknemersToolStripMenuItem
            // 
            this.werknemersToolStripMenuItem.Name = "werknemersToolStripMenuItem";
            this.werknemersToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.werknemersToolStripMenuItem.Text = "Werknemers";
            this.werknemersToolStripMenuItem.Click += new System.EventHandler(this.werknemersToolStripMenuItem_Click);
            // 
            // klantenToolStripMenuItem1
            // 
            this.klantenToolStripMenuItem1.BackColor = System.Drawing.Color.White;
            this.klantenToolStripMenuItem1.ForeColor = System.Drawing.Color.Black;
            this.klantenToolStripMenuItem1.Name = "klantenToolStripMenuItem1";
            this.klantenToolStripMenuItem1.Size = new System.Drawing.Size(159, 24);
            this.klantenToolStripMenuItem1.Text = "Restaurant Overzicht";
            // 
            // lbl_Welkom
            // 
            this.lbl_Welkom.AutoSize = true;
            this.lbl_Welkom.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Welkom.Location = new System.Drawing.Point(187, 229);
            this.lbl_Welkom.Name = "lbl_Welkom";
            this.lbl_Welkom.Size = new System.Drawing.Size(635, 31);
            this.lbl_Welkom.TabIndex = 1;
            this.lbl_Welkom.Text = "Welkom bij het restaurant bestelsysteem van Chapoo.";
            // 
            // Chapoo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(1039, 550);
            this.Controls.Add(this.lbl_Welkom);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Chapoo";
            this.Text = "Chapoo";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem HomeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem klantenToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem werknemersToolStripMenuItem;
        private System.Windows.Forms.Label lbl_Welkom;
    }
}

