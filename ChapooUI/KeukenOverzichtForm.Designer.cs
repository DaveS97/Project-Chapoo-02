namespace ChapooUI
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
            this.btn_filterNaarGereed = new System.Windows.Forms.Button();
            this.pnl_klaarstaandeBestellingen = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_naGerechtKlaar = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl_hoofdGerechtKlaar = new System.Windows.Forms.Label();
            this.lbl_voorGerechtKlaar = new System.Windows.Forms.Label();
            this.label56 = new System.Windows.Forms.Label();
            this.btn_naarBestellingenOpenstaand = new System.Windows.Forms.Button();
            this.btn_toonBestellingGereedPanel = new System.Windows.Forms.Button();
            this.lv_klaarstaandebestellingen = new System.Windows.Forms.ListView();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_huidigeBestellingKlaar = new System.Windows.Forms.Label();
            this.btn_herlaadBestellingen = new System.Windows.Forms.Button();
            this.MS1.SuspendLayout();
            this.pnl_klaarstaandeBestellingen.SuspendLayout();
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
            this.barOverzichtToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
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
            this.label3.Location = new System.Drawing.Point(683, 164);
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
            // btn_filterNaarGereed
            // 
            this.btn_filterNaarGereed.Location = new System.Drawing.Point(916, 38);
            this.btn_filterNaarGereed.Name = "btn_filterNaarGereed";
            this.btn_filterNaarGereed.Size = new System.Drawing.Size(99, 68);
            this.btn_filterNaarGereed.TabIndex = 22;
            this.btn_filterNaarGereed.Text = "Filter: Bestellingen openstaand";
            this.btn_filterNaarGereed.UseVisualStyleBackColor = true;
            this.btn_filterNaarGereed.Click += new System.EventHandler(this.btn_filterNaarGereed_Click);
            // 
            // pnl_klaarstaandeBestellingen
            // 
            this.pnl_klaarstaandeBestellingen.Controls.Add(this.label6);
            this.pnl_klaarstaandeBestellingen.Controls.Add(this.lbl_naGerechtKlaar);
            this.pnl_klaarstaandeBestellingen.Controls.Add(this.label8);
            this.pnl_klaarstaandeBestellingen.Controls.Add(this.lbl_hoofdGerechtKlaar);
            this.pnl_klaarstaandeBestellingen.Controls.Add(this.lbl_voorGerechtKlaar);
            this.pnl_klaarstaandeBestellingen.Controls.Add(this.label56);
            this.pnl_klaarstaandeBestellingen.Controls.Add(this.btn_naarBestellingenOpenstaand);
            this.pnl_klaarstaandeBestellingen.Controls.Add(this.btn_toonBestellingGereedPanel);
            this.pnl_klaarstaandeBestellingen.Controls.Add(this.lv_klaarstaandebestellingen);
            this.pnl_klaarstaandeBestellingen.Controls.Add(this.label4);
            this.pnl_klaarstaandeBestellingen.Location = new System.Drawing.Point(0, 32);
            this.pnl_klaarstaandeBestellingen.Name = "pnl_klaarstaandeBestellingen";
            this.pnl_klaarstaandeBestellingen.Size = new System.Drawing.Size(1039, 433);
            this.pnl_klaarstaandeBestellingen.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(400, 331);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 24);
            this.label6.TabIndex = 29;
            this.label6.Text = "Nagerecht:";
            // 
            // lbl_naGerechtKlaar
            // 
            this.lbl_naGerechtKlaar.AutoSize = true;
            this.lbl_naGerechtKlaar.BackColor = System.Drawing.Color.White;
            this.lbl_naGerechtKlaar.Location = new System.Drawing.Point(401, 378);
            this.lbl_naGerechtKlaar.Name = "lbl_naGerechtKlaar";
            this.lbl_naGerechtKlaar.Size = new System.Drawing.Size(0, 17);
            this.lbl_naGerechtKlaar.TabIndex = 28;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(400, 209);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(130, 24);
            this.label8.TabIndex = 27;
            this.label8.Text = "Hoofdgerecht:";
            // 
            // lbl_hoofdGerechtKlaar
            // 
            this.lbl_hoofdGerechtKlaar.AutoSize = true;
            this.lbl_hoofdGerechtKlaar.BackColor = System.Drawing.Color.White;
            this.lbl_hoofdGerechtKlaar.Location = new System.Drawing.Point(401, 259);
            this.lbl_hoofdGerechtKlaar.Name = "lbl_hoofdGerechtKlaar";
            this.lbl_hoofdGerechtKlaar.Size = new System.Drawing.Size(0, 17);
            this.lbl_hoofdGerechtKlaar.TabIndex = 26;
            // 
            // lbl_voorGerechtKlaar
            // 
            this.lbl_voorGerechtKlaar.AutoSize = true;
            this.lbl_voorGerechtKlaar.BackColor = System.Drawing.Color.White;
            this.lbl_voorGerechtKlaar.Location = new System.Drawing.Point(401, 137);
            this.lbl_voorGerechtKlaar.Name = "lbl_voorGerechtKlaar";
            this.lbl_voorGerechtKlaar.Size = new System.Drawing.Size(0, 17);
            this.lbl_voorGerechtKlaar.TabIndex = 25;
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label56.ForeColor = System.Drawing.Color.White;
            this.label56.Location = new System.Drawing.Point(400, 96);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(125, 24);
            this.label56.TabIndex = 24;
            this.label56.Text = "Voorgerecht: \r\n";
            // 
            // btn_naarBestellingenOpenstaand
            // 
            this.btn_naarBestellingenOpenstaand.Location = new System.Drawing.Point(916, 6);
            this.btn_naarBestellingenOpenstaand.Name = "btn_naarBestellingenOpenstaand";
            this.btn_naarBestellingenOpenstaand.Size = new System.Drawing.Size(99, 68);
            this.btn_naarBestellingenOpenstaand.TabIndex = 23;
            this.btn_naarBestellingenOpenstaand.Text = "Filter: Bestellingen gereed\r\n";
            this.btn_naarBestellingenOpenstaand.UseVisualStyleBackColor = true;
            this.btn_naarBestellingenOpenstaand.Click += new System.EventHandler(this.btn_naarBestellingenOpenstaand_Click);
            // 
            // btn_toonBestellingGereedPanel
            // 
            this.btn_toonBestellingGereedPanel.Location = new System.Drawing.Point(55, 457);
            this.btn_toonBestellingGereedPanel.Name = "btn_toonBestellingGereedPanel";
            this.btn_toonBestellingGereedPanel.Size = new System.Drawing.Size(104, 49);
            this.btn_toonBestellingGereedPanel.TabIndex = 14;
            this.btn_toonBestellingGereedPanel.Text = "Toon bestelling";
            this.btn_toonBestellingGereedPanel.UseVisualStyleBackColor = true;
            this.btn_toonBestellingGereedPanel.Click += new System.EventHandler(this.btn_toonBestellingGereedPanel_Click);
            // 
            // lv_klaarstaandebestellingen
            // 
            this.lv_klaarstaandebestellingen.HideSelection = false;
            this.lv_klaarstaandebestellingen.Location = new System.Drawing.Point(55, 96);
            this.lv_klaarstaandebestellingen.Name = "lv_klaarstaandebestellingen";
            this.lv_klaarstaandebestellingen.Size = new System.Drawing.Size(304, 355);
            this.lv_klaarstaandebestellingen.TabIndex = 1;
            this.lv_klaarstaandebestellingen.UseCompatibleStateImageBehavior = false;
            this.lv_klaarstaandebestellingen.View = System.Windows.Forms.View.Details;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(57, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(225, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "Klaarstaande bestellingen";
            // 
            // lbl_huidigeBestellingKlaar
            // 
            this.lbl_huidigeBestellingKlaar.AutoSize = true;
            this.lbl_huidigeBestellingKlaar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_huidigeBestellingKlaar.ForeColor = System.Drawing.Color.White;
            this.lbl_huidigeBestellingKlaar.Location = new System.Drawing.Point(400, 82);
            this.lbl_huidigeBestellingKlaar.Name = "lbl_huidigeBestellingKlaar";
            this.lbl_huidigeBestellingKlaar.Size = new System.Drawing.Size(91, 24);
            this.lbl_huidigeBestellingKlaar.TabIndex = 30;
            this.lbl_huidigeBestellingKlaar.Text = "Bestelling";
            // 
            // btn_herlaadBestellingen
            // 
            this.btn_herlaadBestellingen.Location = new System.Drawing.Point(178, 490);
            this.btn_herlaadBestellingen.Name = "btn_herlaadBestellingen";
            this.btn_herlaadBestellingen.Size = new System.Drawing.Size(104, 48);
            this.btn_herlaadBestellingen.TabIndex = 31;
            this.btn_herlaadBestellingen.Text = "Herlaad bestellingen";
            this.btn_herlaadBestellingen.UseVisualStyleBackColor = true;
            this.btn_herlaadBestellingen.Click += new System.EventHandler(this.btn_herlaadBestellingen_Click_1);
            // 
            // KeukenOverzichtForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(169)))), ((int)(((byte)(222)))));
            this.ClientSize = new System.Drawing.Size(1039, 550);
            this.Controls.Add(this.btn_herlaadBestellingen);
            this.Controls.Add(this.lbl_huidigeBestellingKlaar);
            this.Controls.Add(this.pnl_klaarstaandeBestellingen);
            this.Controls.Add(this.btn_filterNaarGereed);
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
            this.pnl_klaarstaandeBestellingen.ResumeLayout(false);
            this.pnl_klaarstaandeBestellingen.PerformLayout();
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
        private System.Windows.Forms.Button btn_filterNaarGereed;
        private System.Windows.Forms.Panel pnl_klaarstaandeBestellingen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_toonBestellingGereedPanel;
        private System.Windows.Forms.ListView lv_klaarstaandebestellingen;
        private System.Windows.Forms.Button btn_naarBestellingenOpenstaand;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_naGerechtKlaar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbl_hoofdGerechtKlaar;
        private System.Windows.Forms.Label lbl_voorGerechtKlaar;
        private System.Windows.Forms.Label label56;
        private System.Windows.Forms.Label lbl_huidigeBestellingKlaar;
        private System.Windows.Forms.Button btn_herlaadBestellingen;
    }
}