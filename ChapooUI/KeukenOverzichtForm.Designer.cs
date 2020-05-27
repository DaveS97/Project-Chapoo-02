﻿namespace ChapooUI
{
    partial class KeukenOverzichtForm
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
            this.barOverzichtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MS_Beheer = new System.Windows.Forms.ToolStripMenuItem();
            this.MS1I_Inkomsten = new System.Windows.Forms.ToolStripMenuItem();
            this.MS1I_Voorraad = new System.Windows.Forms.ToolStripMenuItem();
            this.MS1I_MenuKaartOpties = new System.Windows.Forms.ToolStripMenuItem();
            this.MS1I_Werknemers = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_bestellingKopje = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_KeukenOverzicht = new System.Windows.Forms.Label();
            this.lbl_opmerkingen = new System.Windows.Forms.Label();
            this.lbl_Voorgerecht = new System.Windows.Forms.Label();
            this.lv_Bestellingen = new System.Windows.Forms.ListView();
            this.btn_toonBestelling = new System.Windows.Forms.Button();
            this.lbl_HuidigeBestelling = new System.Windows.Forms.Label();
            this.lbl_Hoofdgerecht = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_Nagerecht = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_voorGerechtKlaarzetten = new System.Windows.Forms.Button();
            this.btn_hoofdGerechtKlaarzetten = new System.Windows.Forms.Button();
            this.btn_naGerechtKlaarzetten = new System.Windows.Forms.Button();
            this.MS1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MS1
            // 
            this.MS1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(79)))), ((int)(((byte)(110)))));
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
            this.MS1.TabIndex = 1;
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
            this.MS_KO.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.barOverzichtToolStripMenuItem});
            this.MS_KO.Name = "MS_KO";
            this.MS_KO.Size = new System.Drawing.Size(137, 24);
            this.MS_KO.Text = "Keuken Overzicht";
            // 
            // barOverzichtToolStripMenuItem
            // 
            this.barOverzichtToolStripMenuItem.Name = "barOverzichtToolStripMenuItem";
            this.barOverzichtToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.barOverzichtToolStripMenuItem.Text = "Bar Overzicht";
            this.barOverzichtToolStripMenuItem.Click += new System.EventHandler(this.barOverzichtToolStripMenuItem_Click);
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
            // 
            // MS1I_Voorraad
            // 
            this.MS1I_Voorraad.Name = "MS1I_Voorraad";
            this.MS1I_Voorraad.Size = new System.Drawing.Size(215, 26);
            this.MS1I_Voorraad.Text = "Voorraad";
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
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(757, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "Opmerkingen:";
            // 
            // lbl_bestellingKopje
            // 
            this.lbl_bestellingKopje.AutoSize = true;
            this.lbl_bestellingKopje.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_bestellingKopje.ForeColor = System.Drawing.Color.White;
            this.lbl_bestellingKopje.Location = new System.Drawing.Point(400, 128);
            this.lbl_bestellingKopje.Name = "lbl_bestellingKopje";
            this.lbl_bestellingKopje.Size = new System.Drawing.Size(125, 24);
            this.lbl_bestellingKopje.TabIndex = 8;
            this.lbl_bestellingKopje.Text = "Voorgerecht: \r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(51, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Openstaande bestellingen";
            // 
            // lbl_KeukenOverzicht
            // 
            this.lbl_KeukenOverzicht.AutoSize = true;
            this.lbl_KeukenOverzicht.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_KeukenOverzicht.ForeColor = System.Drawing.Color.White;
            this.lbl_KeukenOverzicht.Location = new System.Drawing.Point(425, 38);
            this.lbl_KeukenOverzicht.Name = "lbl_KeukenOverzicht";
            this.lbl_KeukenOverzicht.Size = new System.Drawing.Size(201, 24);
            this.lbl_KeukenOverzicht.TabIndex = 6;
            this.lbl_KeukenOverzicht.Text = "KEUKEN OVERZICHT";
            // 
            // lbl_opmerkingen
            // 
            this.lbl_opmerkingen.AutoSize = true;
            this.lbl_opmerkingen.BackColor = System.Drawing.Color.White;
            this.lbl_opmerkingen.Location = new System.Drawing.Point(666, 399);
            this.lbl_opmerkingen.Name = "lbl_opmerkingen";
            this.lbl_opmerkingen.Size = new System.Drawing.Size(0, 17);
            this.lbl_opmerkingen.TabIndex = 10;
            // 
            // lbl_Voorgerecht
            // 
            this.lbl_Voorgerecht.AutoSize = true;
            this.lbl_Voorgerecht.BackColor = System.Drawing.Color.White;
            this.lbl_Voorgerecht.Location = new System.Drawing.Point(401, 169);
            this.lbl_Voorgerecht.Name = "lbl_Voorgerecht";
            this.lbl_Voorgerecht.Size = new System.Drawing.Size(0, 17);
            this.lbl_Voorgerecht.TabIndex = 11;
            // 
            // lv_Bestellingen
            // 
            this.lv_Bestellingen.HideSelection = false;
            this.lv_Bestellingen.Location = new System.Drawing.Point(55, 128);
            this.lv_Bestellingen.Name = "lv_Bestellingen";
            this.lv_Bestellingen.Size = new System.Drawing.Size(304, 354);
            this.lv_Bestellingen.TabIndex = 12;
            this.lv_Bestellingen.UseCompatibleStateImageBehavior = false;
            this.lv_Bestellingen.View = System.Windows.Forms.View.Details;
            // 
            // btn_toonBestelling
            // 
            this.btn_toonBestelling.Location = new System.Drawing.Point(55, 489);
            this.btn_toonBestelling.Name = "btn_toonBestelling";
            this.btn_toonBestelling.Size = new System.Drawing.Size(104, 49);
            this.btn_toonBestelling.TabIndex = 13;
            this.btn_toonBestelling.Text = "Toon bestelling";
            this.btn_toonBestelling.UseVisualStyleBackColor = true;
            this.btn_toonBestelling.Click += new System.EventHandler(this.btn_toonBestelling_Click);
            // 
            // lbl_HuidigeBestelling
            // 
            this.lbl_HuidigeBestelling.AutoSize = true;
            this.lbl_HuidigeBestelling.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_HuidigeBestelling.ForeColor = System.Drawing.Color.White;
            this.lbl_HuidigeBestelling.Location = new System.Drawing.Point(400, 82);
            this.lbl_HuidigeBestelling.Name = "lbl_HuidigeBestelling";
            this.lbl_HuidigeBestelling.Size = new System.Drawing.Size(91, 24);
            this.lbl_HuidigeBestelling.TabIndex = 14;
            this.lbl_HuidigeBestelling.Text = "Bestelling";
            // 
            // lbl_Hoofdgerecht
            // 
            this.lbl_Hoofdgerecht.AutoSize = true;
            this.lbl_Hoofdgerecht.BackColor = System.Drawing.Color.White;
            this.lbl_Hoofdgerecht.Location = new System.Drawing.Point(401, 291);
            this.lbl_Hoofdgerecht.Name = "lbl_Hoofdgerecht";
            this.lbl_Hoofdgerecht.Size = new System.Drawing.Size(0, 17);
            this.lbl_Hoofdgerecht.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(400, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 24);
            this.label2.TabIndex = 16;
            this.label2.Text = "Hoofdgerecht:";
            // 
            // lbl_Nagerecht
            // 
            this.lbl_Nagerecht.AutoSize = true;
            this.lbl_Nagerecht.BackColor = System.Drawing.Color.White;
            this.lbl_Nagerecht.Location = new System.Drawing.Point(401, 410);
            this.lbl_Nagerecht.Name = "lbl_Nagerecht";
            this.lbl_Nagerecht.Size = new System.Drawing.Size(0, 17);
            this.lbl_Nagerecht.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(400, 363);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 24);
            this.label5.TabIndex = 18;
            this.label5.Text = "Nagerecht:";
            // 
            // btn_voorGerechtKlaarzetten
            // 
            this.btn_voorGerechtKlaarzetten.Location = new System.Drawing.Point(651, 489);
            this.btn_voorGerechtKlaarzetten.Name = "btn_voorGerechtKlaarzetten";
            this.btn_voorGerechtKlaarzetten.Size = new System.Drawing.Size(99, 49);
            this.btn_voorGerechtKlaarzetten.TabIndex = 19;
            this.btn_voorGerechtKlaarzetten.Text = "Voorgerecht klaarzetten";
            this.btn_voorGerechtKlaarzetten.UseVisualStyleBackColor = true;
            this.btn_voorGerechtKlaarzetten.Click += new System.EventHandler(this.btn_voorGerechtKlaarzetten_Click);
            // 
            // btn_hoofdGerechtKlaarzetten
            // 
            this.btn_hoofdGerechtKlaarzetten.Location = new System.Drawing.Point(774, 489);
            this.btn_hoofdGerechtKlaarzetten.Name = "btn_hoofdGerechtKlaarzetten";
            this.btn_hoofdGerechtKlaarzetten.Size = new System.Drawing.Size(114, 49);
            this.btn_hoofdGerechtKlaarzetten.TabIndex = 20;
            this.btn_hoofdGerechtKlaarzetten.Text = "Hoofdgerecht klaarzetten";
            this.btn_hoofdGerechtKlaarzetten.UseVisualStyleBackColor = true;
            this.btn_hoofdGerechtKlaarzetten.Click += new System.EventHandler(this.btn_hoofdGerechtKlaarzetten_Click);
            // 
            // btn_naGerechtKlaarzetten
            // 
            this.btn_naGerechtKlaarzetten.Location = new System.Drawing.Point(916, 489);
            this.btn_naGerechtKlaarzetten.Name = "btn_naGerechtKlaarzetten";
            this.btn_naGerechtKlaarzetten.Size = new System.Drawing.Size(99, 49);
            this.btn_naGerechtKlaarzetten.TabIndex = 21;
            this.btn_naGerechtKlaarzetten.Text = "Nagerecht klaarzetten";
            this.btn_naGerechtKlaarzetten.UseVisualStyleBackColor = true;
            this.btn_naGerechtKlaarzetten.Click += new System.EventHandler(this.btn_naGerechtKlaarzetten_Click);
            // 
            // KeukenOverzichtForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(169)))), ((int)(((byte)(222)))));
            this.ClientSize = new System.Drawing.Size(1039, 550);
            this.Controls.Add(this.btn_naGerechtKlaarzetten);
            this.Controls.Add(this.btn_hoofdGerechtKlaarzetten);
            this.Controls.Add(this.btn_voorGerechtKlaarzetten);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbl_Nagerecht);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_Hoofdgerecht);
            this.Controls.Add(this.lbl_HuidigeBestelling);
            this.Controls.Add(this.btn_toonBestelling);
            this.Controls.Add(this.lv_Bestellingen);
            this.Controls.Add(this.lbl_Voorgerecht);
            this.Controls.Add(this.lbl_opmerkingen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_bestellingKopje);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_KeukenOverzicht);
            this.Controls.Add(this.MS1);
            this.Name = "KeukenOverzichtForm";
            this.Text = "KeukenOverzichtForm";
            this.MS1.ResumeLayout(false);
            this.MS1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MS1;
        private System.Windows.Forms.ToolStripMenuItem HomeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MS1I_Home;
        private System.Windows.Forms.ToolStripMenuItem MS_RO;
        private System.Windows.Forms.ToolStripMenuItem MS_BO;
        private System.Windows.Forms.ToolStripMenuItem MS_KO;
        private System.Windows.Forms.ToolStripMenuItem MS_Beheer;
        private System.Windows.Forms.ToolStripMenuItem MS1I_Inkomsten;
        private System.Windows.Forms.ToolStripMenuItem MS1I_Voorraad;
        private System.Windows.Forms.ToolStripMenuItem MS1I_MenuKaartOpties;
        private System.Windows.Forms.ToolStripMenuItem MS1I_Werknemers;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_bestellingKopje;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_KeukenOverzicht;
        private System.Windows.Forms.Label lbl_opmerkingen;
        private System.Windows.Forms.Label lbl_Voorgerecht;
        private System.Windows.Forms.ListView lv_Bestellingen;
        private System.Windows.Forms.Button btn_toonBestelling;
        private System.Windows.Forms.Label lbl_HuidigeBestelling;
        private System.Windows.Forms.ToolStripMenuItem barOverzichtToolStripMenuItem;
        private System.Windows.Forms.Label lbl_Hoofdgerecht;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_Nagerecht;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_voorGerechtKlaarzetten;
        private System.Windows.Forms.Button btn_hoofdGerechtKlaarzetten;
        private System.Windows.Forms.Button btn_naGerechtKlaarzetten;
    }
}