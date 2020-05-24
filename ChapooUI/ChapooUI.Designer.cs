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
            this.MS1 = new System.Windows.Forms.MenuStrip();
            this.HomeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MS1I_Home = new System.Windows.Forms.ToolStripMenuItem();
            this.MS_RO = new System.Windows.Forms.ToolStripMenuItem();
            this.MS_BO = new System.Windows.Forms.ToolStripMenuItem();
            this.MS_KO = new System.Windows.Forms.ToolStripMenuItem();
            this.MS_Beheer = new System.Windows.Forms.ToolStripMenuItem();
            this.MS1I_Inkomsten = new System.Windows.Forms.ToolStripMenuItem();
            this.MS1I_Voorraad = new System.Windows.Forms.ToolStripMenuItem();
            this.MS1I_MenuKaartOpties = new System.Windows.Forms.ToolStripMenuItem();
            this.MS1I_Werknemers = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_Welkom = new System.Windows.Forms.Label();
            this.MS1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MS1
            // 
            this.MS1.BackColor = System.Drawing.Color.DarkBlue;
            this.MS1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MS1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MS1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HomeToolStripMenuItem,
            this.MS_RO,
            this.MS_BO,
            this.MS_KO,
            this.MS_Beheer});
            this.MS1.Location = new System.Drawing.Point(0, 0);
            this.MS1.Name = "MS1";
            this.MS1.Size = new System.Drawing.Size(1039, 28);
            this.MS1.TabIndex = 0;
            this.MS1.Text = "menuStrip1";
            // 
            // HomeToolStripMenuItem
            // 
            this.HomeToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.HomeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MS1I_Home});
            this.HomeToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.HomeToolStripMenuItem.Name = "HomeToolStripMenuItem";
            this.HomeToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.HomeToolStripMenuItem.Text = "Home";
            // 
            // MS1I_Home
            // 
            this.MS1I_Home.Name = "MS1I_Home";
            this.MS1I_Home.Size = new System.Drawing.Size(133, 26);
            this.MS1I_Home.Text = "Home";
            this.MS1I_Home.Click += new System.EventHandler(this.MS1I_Home_Click);
            // 
            // MS_RO
            // 
            this.MS_RO.BackColor = System.Drawing.Color.White;
            this.MS_RO.ForeColor = System.Drawing.Color.Black;
            this.MS_RO.Name = "MS_RO";
            this.MS_RO.Size = new System.Drawing.Size(159, 24);
            this.MS_RO.Text = "Restaurant Overzicht";
            // 
            // MS_BO
            // 
            this.MS_BO.BackColor = System.Drawing.Color.White;
            this.MS_BO.Name = "MS_BO";
            this.MS_BO.Size = new System.Drawing.Size(111, 24);
            this.MS_BO.Text = "Bar Overzicht";
            // 
            // MS_KO
            // 
            this.MS_KO.BackColor = System.Drawing.Color.White;
            this.MS_KO.Name = "MS_KO";
            this.MS_KO.Size = new System.Drawing.Size(137, 24);
            this.MS_KO.Text = "Keuken Overzicht";
            this.MS_KO.Click += new System.EventHandler(this.MS_KO_Click);
            // 
            // MS_Beheer
            // 
            this.MS_Beheer.BackColor = System.Drawing.Color.White;
            this.MS_Beheer.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MS1I_Inkomsten,
            this.MS1I_Voorraad,
            this.MS1I_MenuKaartOpties,
            this.MS1I_Werknemers});
            this.MS_Beheer.Name = "MS_Beheer";
            this.MS_Beheer.Size = new System.Drawing.Size(69, 24);
            this.MS_Beheer.Text = "Beheer";
            // 
            // MS1I_Inkomsten
            // 
            this.MS1I_Inkomsten.Name = "MS1I_Inkomsten";
            this.MS1I_Inkomsten.Size = new System.Drawing.Size(215, 26);
            this.MS1I_Inkomsten.Text = "Inkomsten";
            this.MS1I_Inkomsten.Click += new System.EventHandler(this.MS1I_Inkomsten_Click);
            // 
            // MS1I_Voorraad
            // 
            this.MS1I_Voorraad.Name = "MS1I_Voorraad";
            this.MS1I_Voorraad.Size = new System.Drawing.Size(215, 26);
            this.MS1I_Voorraad.Text = "Voorraad";
            this.MS1I_Voorraad.Click += new System.EventHandler(this.MS1I_Voorraad_Click);
            // 
            // MS1I_MenuKaartOpties
            // 
            this.MS1I_MenuKaartOpties.Name = "MS1I_MenuKaartOpties";
            this.MS1I_MenuKaartOpties.Size = new System.Drawing.Size(215, 26);
            this.MS1I_MenuKaartOpties.Text = "Menu Kaart Opties";
            // 
            // MS1I_Werknemers
            // 
            this.MS1I_Werknemers.Name = "MS1I_Werknemers";
            this.MS1I_Werknemers.Size = new System.Drawing.Size(215, 26);
            this.MS1I_Werknemers.Text = "Werknemers";
            this.MS1I_Werknemers.Click += new System.EventHandler(this.MS1I_Werknemers_Click);
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
            this.Controls.Add(this.MS1);
            this.MainMenuStrip = this.MS1;
            this.Name = "Chapoo";
            this.Text = "Chapoo";
            this.MS1.ResumeLayout(false);
            this.MS1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MS1;
        private System.Windows.Forms.ToolStripMenuItem HomeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MS_RO;
        private System.Windows.Forms.ToolStripMenuItem MS1I_Home;
        private System.Windows.Forms.Label lbl_Welkom;
        private System.Windows.Forms.ToolStripMenuItem MS_BO;
        private System.Windows.Forms.ToolStripMenuItem MS_KO;
        private System.Windows.Forms.ToolStripMenuItem MS_Beheer;
        private System.Windows.Forms.ToolStripMenuItem MS1I_Inkomsten;
        private System.Windows.Forms.ToolStripMenuItem MS1I_Voorraad;
        private System.Windows.Forms.ToolStripMenuItem MS1I_MenuKaartOpties;
        private System.Windows.Forms.ToolStripMenuItem MS1I_Werknemers;
    }
}

