﻿namespace ChapooUI
{
    partial class InkomstenForm
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
            this.terugToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lvInkomsten = new System.Windows.Forms.ListView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(79)))), ((int)(((byte)(110)))));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.terugToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(962, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // terugToolStripMenuItem
            // 
            this.terugToolStripMenuItem.Name = "terugToolStripMenuItem";
            this.terugToolStripMenuItem.Size = new System.Drawing.Size(58, 24);
            this.terugToolStripMenuItem.Text = "terug";
            this.terugToolStripMenuItem.Click += new System.EventHandler(this.terugToolStripMenuItem_Click);
            // 
            // lvInkomsten
            // 
            this.lvInkomsten.HideSelection = false;
            this.lvInkomsten.Location = new System.Drawing.Point(13, 93);
            this.lvInkomsten.Name = "lvInkomsten";
            this.lvInkomsten.Size = new System.Drawing.Size(762, 319);
            this.lvInkomsten.TabIndex = 1;
            this.lvInkomsten.UseCompatibleStateImageBehavior = false;
            this.lvInkomsten.View = System.Windows.Forms.View.Details;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 36);
            this.label1.TabIndex = 2;
            this.label1.Text = "overzicht van bonnen";
            // 
            // InkomstenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(169)))), ((int)(((byte)(222)))));
            this.ClientSize = new System.Drawing.Size(962, 482);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvInkomsten);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "InkomstenForm";
            this.Text = "InkomstenForm";
            this.Load += new System.EventHandler(this.InkomstenForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem terugToolStripMenuItem;
        private System.Windows.Forms.ListView lvInkomsten;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label1;
    }
}