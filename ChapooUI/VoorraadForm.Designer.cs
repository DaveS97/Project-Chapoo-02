﻿namespace ChapooUI
{
    partial class VoorraadForm
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lblVoorraad = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RBLunch = new System.Windows.Forms.RadioButton();
            this.RBDinner = new System.Windows.Forms.RadioButton();
            this.RBDranken = new System.Windows.Forms.RadioButton();
            this.lblFlter = new System.Windows.Forms.Label();
            this.pnlVoorraad = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.tbAantal = new System.Windows.Forms.TextBox();
            this.lblOmschrijving = new System.Windows.Forms.Label();
            this.lvVoorraad = new System.Windows.Forms.ListView();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbAlles = new System.Windows.Forms.RadioButton();
            this.menuStrip1.SuspendLayout();
            this.pnlVoorraad.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblVoorraad
            // 
            this.lblVoorraad.AutoSize = true;
            this.lblVoorraad.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVoorraad.Location = new System.Drawing.Point(12, 59);
            this.lblVoorraad.Name = "lblVoorraad";
            this.lblVoorraad.Size = new System.Drawing.Size(292, 36);
            this.lblVoorraad.TabIndex = 1;
            this.lblVoorraad.Text = "Voorraad aanpassen";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(79)))), ((int)(((byte)(110)))));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1080, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // RBLunch
            // 
            this.RBLunch.AutoSize = true;
            this.RBLunch.Location = new System.Drawing.Point(612, 211);
            this.RBLunch.Name = "RBLunch";
            this.RBLunch.Size = new System.Drawing.Size(99, 21);
            this.RBLunch.TabIndex = 6;
            this.RBLunch.TabStop = true;
            this.RBLunch.Text = "lunch kaart";
            this.RBLunch.UseVisualStyleBackColor = true;
            // 
            // RBDinner
            // 
            this.RBDinner.AutoSize = true;
            this.RBDinner.Location = new System.Drawing.Point(612, 248);
            this.RBDinner.Name = "RBDinner";
            this.RBDinner.Size = new System.Drawing.Size(105, 21);
            this.RBDinner.TabIndex = 7;
            this.RBDinner.TabStop = true;
            this.RBDinner.Text = "dinner kaart";
            this.RBDinner.UseVisualStyleBackColor = true;
            // 
            // RBDranken
            // 
            this.RBDranken.AutoSize = true;
            this.RBDranken.Location = new System.Drawing.Point(612, 284);
            this.RBDranken.Name = "RBDranken";
            this.RBDranken.Size = new System.Drawing.Size(117, 21);
            this.RBDranken.TabIndex = 8;
            this.RBDranken.TabStop = true;
            this.RBDranken.Text = "dranken kaart";
            this.RBDranken.UseVisualStyleBackColor = true;
            // 
            // lblFlter
            // 
            this.lblFlter.AutoSize = true;
            this.lblFlter.Location = new System.Drawing.Point(609, 109);
            this.lblFlter.Name = "lblFlter";
            this.lblFlter.Size = new System.Drawing.Size(55, 17);
            this.lblFlter.TabIndex = 9;
            this.lblFlter.Text = "FILTER";
            // 
            // pnlVoorraad
            // 
            this.pnlVoorraad.BackColor = System.Drawing.Color.White;
            this.pnlVoorraad.Controls.Add(this.label1);
            this.pnlVoorraad.Controls.Add(this.lblID);
            this.pnlVoorraad.Controls.Add(this.button2);
            this.pnlVoorraad.Controls.Add(this.tbAantal);
            this.pnlVoorraad.Controls.Add(this.lblOmschrijving);
            this.pnlVoorraad.Location = new System.Drawing.Point(612, 392);
            this.pnlVoorraad.Name = "pnlVoorraad";
            this.pnlVoorraad.Size = new System.Drawing.Size(428, 191);
            this.pnlVoorraad.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "aantal";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(342, 43);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(24, 17);
            this.lblID.TabIndex = 4;
            this.lblID.Text = "....";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(331, 156);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 35);
            this.button2.TabIndex = 3;
            this.button2.Text = "Opslaan";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tbAantal
            // 
            this.tbAantal.Location = new System.Drawing.Point(115, 79);
            this.tbAantal.Name = "tbAantal";
            this.tbAantal.Size = new System.Drawing.Size(100, 22);
            this.tbAantal.TabIndex = 2;
            // 
            // lblOmschrijving
            // 
            this.lblOmschrijving.AutoSize = true;
            this.lblOmschrijving.Location = new System.Drawing.Point(3, 0);
            this.lblOmschrijving.Name = "lblOmschrijving";
            this.lblOmschrijving.Size = new System.Drawing.Size(24, 17);
            this.lblOmschrijving.TabIndex = 0;
            this.lblOmschrijving.Text = "....";
            // 
            // lvVoorraad
            // 
            this.lvVoorraad.HideSelection = false;
            this.lvVoorraad.Location = new System.Drawing.Point(3, 3);
            this.lvVoorraad.MultiSelect = false;
            this.lvVoorraad.Name = "lvVoorraad";
            this.lvVoorraad.Size = new System.Drawing.Size(536, 468);
            this.lvVoorraad.TabIndex = 11;
            this.lvVoorraad.UseCompatibleStateImageBehavior = false;
            this.lvVoorraad.View = System.Windows.Forms.View.Details;
            this.lvVoorraad.SelectedIndexChanged += new System.EventHandler(this.lvVoorraad_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(389, 586);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 31);
            this.button1.TabIndex = 12;
            this.button1.Text = "voorraad ophalen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lvVoorraad);
            this.panel1.Location = new System.Drawing.Point(13, 109);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(542, 474);
            this.panel1.TabIndex = 14;
            // 
            // rbAlles
            // 
            this.rbAlles.AutoSize = true;
            this.rbAlles.Checked = true;
            this.rbAlles.Location = new System.Drawing.Point(612, 170);
            this.rbAlles.Name = "rbAlles";
            this.rbAlles.Size = new System.Drawing.Size(108, 21);
            this.rbAlles.TabIndex = 15;
            this.rbAlles.TabStop = true;
            this.rbAlles.Text = "gehele kaart";
            this.rbAlles.UseVisualStyleBackColor = true;
            // 
            // VoorraadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(169)))), ((int)(((byte)(222)))));
            this.ClientSize = new System.Drawing.Size(1080, 644);
            this.Controls.Add(this.rbAlles);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pnlVoorraad);
            this.Controls.Add(this.lblFlter);
            this.Controls.Add(this.RBDranken);
            this.Controls.Add(this.RBDinner);
            this.Controls.Add(this.RBLunch);
            this.Controls.Add(this.lblVoorraad);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "VoorraadForm";
            this.Text = "VoorraadForm";
            this.Load += new System.EventHandler(this.VoorraadForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlVoorraad.ResumeLayout(false);
            this.pnlVoorraad.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lblVoorraad;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.RadioButton RBLunch;
        private System.Windows.Forms.RadioButton RBDinner;
        private System.Windows.Forms.RadioButton RBDranken;
        private System.Windows.Forms.Label lblFlter;
        private System.Windows.Forms.Panel pnlVoorraad;
        private System.Windows.Forms.ListView lvVoorraad;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblOmschrijving;
        private System.Windows.Forms.TextBox tbAantal;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbAlles;
    }
}