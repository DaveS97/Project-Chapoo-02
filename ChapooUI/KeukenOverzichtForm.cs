﻿using ChapooModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChapooLogic;
using System.Threading;
using System.Security.Cryptography;

namespace ChapooUI
{

    public partial class KeukenOverzichtForm : Form
    {
        const int VOORGERECHT = 1;
        const int HOOFDGERECHT = 2;
        const int NAGERECHT = 3;
        const int TUSSENGERECHT = 4;
        const int DRINKEN = 5;
        private Dictionary<Bevat, Klant> klantenInfo; //de klant info en zijn bestelling
        private Dictionary<Bevat, Klant> klantenInfoGereedPanel; //de klant info en zijn bestelling in het panel gereed
        private Dictionary<Bevat, Klant> klaargezetteBestellingen;
        private Dictionary<Bevat, Klant> ids; //info klant en bestellingen
        private List<Klant> klanten; //klanten 
        private List<Bevat> bestellingen; // bestellingen

        private static KeukenOverzichtForm uniekeInstantie;
        public static KeukenOverzichtForm GetInstance()
        {
            if (uniekeInstantie == null)
                uniekeInstantie = new KeukenOverzichtForm();
            return uniekeInstantie;
        }
        private KeukenOverzichtForm()
        {
            klantenInfo = new Dictionary<Bevat, Klant>();
            klaargezetteBestellingen = new Dictionary<Bevat, Klant>();
            klantenInfoGereedPanel = new Dictionary<Bevat, Klant>();
            bestellingen = new List<Bevat>();
            klanten = new List<Klant>();
            ids = new Dictionary<Bevat, Klant>();
            InitializeComponent();
            BestellingenVullen();
            BarOverzicht();
        }

        private void BestellingenVullen()
        {
            ShowPanel("openstaandeBestellingen");
            //bestelling service aanmaken 
            ChapooLogic.Bevat_Service bevat_Service = new ChapooLogic.Bevat_Service();
            ids = bevat_Service.KrijgBestellingEnMenuItemID();
            //leeg de kolommen eerst voordat je ze weer vult
            lv_Bestellingen.Clear();
            //maak kolommen
            lv_Bestellingen.Columns.Add("Bestelling Id", 100);
            lv_Bestellingen.Columns.Add("Tafel Id", 75);
            //vul de listview
            foreach (KeyValuePair<Bevat, Klant> pair in ids)
            {
                ListViewItem li = new ListViewItem(pair.Key.bestellingID.ToString());
                li.SubItems.Add(pair.Value.tafelID.ToString());
                lv_Bestellingen.Items.Add(li);
                bestellingen.Add(pair.Key);
                klanten.Add(pair.Value);
            }
        }

        private void BestellingVerwijderen()
        {
            //code?
        }

        private void barOverzichtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowPanel("baroverzicht");
        }

        private void btn_naarBestellingenOpenstaand_Click(object sender, EventArgs e)
        {
            ShowPanel("openstaandeBestellingen");
        }

        private void ShowPanel(string panelName)
        {
            if (panelName == "baroverzicht")
            {
                //verberg alle andere panelen
                pnl_klaarstaandeBestellingen.Hide();
                pnl_openstaandeBestellingen.Hide();
                
                lv_drankjes.Hide();
                //lb_Opmerkingen.Hide();
                lbl_openstaandeBestellingenBAR.Hide();
                //toon juiste panel
                pnl_barOverzicht.Show();
                
            }
            else if (panelName == "bestellingenGereed")
            {
                //verberg alle andere panelen
                pnl_barOverzicht.Hide();
                pnl_openstaandeBestellingen.Hide();
                //toon de juiste panel
                pnl_klaarstaandeBestellingen.Show();
                //alle klaarstaande bestellingen in een listview opnemen
                BestellingenGereed();
            }
            else if(panelName == "openstaandeBestellingen")
            {
                //verberg andere panels
                pnl_klaarstaandeBestellingen.Hide();
                pnl_barOverzicht.Hide();
                //toon de goede
                pnl_openstaandeBestellingen.Show();
            }
        }

        private void BestellingenGereed()
        {
            //eerst de listview legen.
            lv_klaarstaandebestellingen.Clear();
            //kolommen toevoegen
            lv_klaarstaandebestellingen.Columns.Add("Bestelling Id", 100);
            lv_klaarstaandebestellingen.Columns.Add("Menu Item Id", 100);
            lv_klaarstaandebestellingen.Columns.Add("Tafel Id", 100);
            //vul de listview
            foreach (KeyValuePair<Bevat, Klant> pair in klaargezetteBestellingen)
            {
                ListViewItem li = new ListViewItem(pair.Key.bestellingID.ToString());
                li.SubItems.Add(pair.Key.menuItemID.ToString());
                li.SubItems.Add(pair.Value.tafelID.ToString());
                lv_klaarstaandebestellingen.Items.Add(li);
            }
        }

        private void btn_toonBestellingGereedPanel_Click(object sender, EventArgs e)
        {
            try
            {
                //eerst alle labels en de lijst leegmaken
                lbl_voorGerechtKlaar.Text = "";
                lbl_hoofdGerechtKlaar.Text = "";
                lbl_naGerechtKlaar.Text = "";
                lbl_huidigeBestellingGEREED.Text = "";
                klantenInfoGereedPanel.Clear();
                //bestellings nummer ophalen
                string bestellingNummer = lv_klaarstaandebestellingen.SelectedItems[0].SubItems[0].Text;
                lbl_huidigeBestellingGEREED.Text = $"Bestelling: {bestellingNummer}";
                //service aanmaken om de beschrijving op te halen
                Bevat_Service bevat_Service = new Bevat_Service();
                klantenInfoGereedPanel = bevat_Service.KrijgBeschrijving(bestellingNummer);
                foreach (KeyValuePair<Bevat, Klant> duo in klantenInfoGereedPanel)
                {
                    switch (duo.Key.typeGerecht)
                    {
                        case 1:
                            lbl_voorGerechtKlaar.Text += $"{duo.Key.menuItemID} {duo.Key.menuItemBeschrijving}\n";
                            break;
                        case 2:
                            lbl_hoofdGerechtKlaar.Text += $"{duo.Key.menuItemID} {duo.Key.menuItemBeschrijving}\n";
                            break;
                        case 3:
                            lbl_naGerechtKlaar.Text += $"{duo.Key.menuItemID} {duo.Key.menuItemBeschrijving}\n";
                            break;
                        case 4:
                            lbl_voorGerechtKlaar.Text += $"{duo.Key.menuItemID} {duo.Key.menuItemBeschrijving}\n";
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private Bevat VulBevat(KeyValuePair<Bevat, Klant> duo)
        {
            Bevat bevat = new Bevat
            {
                bestellingID = duo.Key.bestellingID,
                menuItemBeschrijving = duo.Key.menuItemBeschrijving,
                menuItemID = duo.Key.menuItemID,
                typeGerecht = duo.Key.typeGerecht
            };
            return bevat;
        }

        private Klant VulKlant(KeyValuePair<Bevat, Klant> duo)
        {
            Klant klant = new Klant
            {
                ID = duo.Value.ID,
                tafelID = duo.Value.tafelID
            };
            return klant;
        }

        private void test()
        {
            //hier kan ik me gedachten ff uiten
        }

        private void btn_herlaadBestellingen_Click(object sender, EventArgs e)
        {
            ShowPanel("openstaandeBestellingen");
        }

        private void btn_toonBestelling_Click_1(object sender, EventArgs e)
        {
            try
            {
                //eerst alle labels en de lijst leegmaken
                lbl_Voorgerecht.Text = "";
                lbl_Hoofdgerecht.Text = "";
                lbl_Nagerecht.Text = "";
                lbl_HuidigeBestelling.Text = "";
                klantenInfo.Clear();
                //bestellings nummer ophalen
                string bestellingNummer = lv_Bestellingen.SelectedItems[0].SubItems[0].Text;
                lbl_HuidigeBestelling.Text = $"Bestelling: {bestellingNummer}";
                //service aanmaken om de beschrijving op te halen
                Bevat_Service bevat_Service = new Bevat_Service();
                klantenInfo = bevat_Service.KrijgBeschrijving(bestellingNummer);
                foreach (KeyValuePair<Bevat, Klant> duo in klantenInfo)
                {
                    switch (duo.Key.typeGerecht)
                    {
                        case 1:
                            lbl_Voorgerecht.Text += $"{duo.Key.menuItemID} {duo.Key.menuItemBeschrijving}\n";
                            break;
                        case 2:
                            lbl_Hoofdgerecht.Text += $"{duo.Key.menuItemID} {duo.Key.menuItemBeschrijving}\n";
                            break;
                        case 3:
                            lbl_Nagerecht.Text += $"{duo.Key.menuItemID} {duo.Key.menuItemBeschrijving}\n";
                            break;
                        case 4:
                            lbl_Voorgerecht.Text += $"{duo.Key.menuItemID} {duo.Key.menuItemBeschrijving}\n";
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);                
            }
        }

        private void btn_voorGerechtKlaarzetten_Click_1(object sender, EventArgs e)
        {
            int bestelNummer = int.Parse(lv_Bestellingen.SelectedItems[0].Text);
            foreach (KeyValuePair<Bevat, Klant> duo in klantenInfo)
            {
                if (duo.Key.typeGerecht == VOORGERECHT || duo.Key.typeGerecht == TUSSENGERECHT)
                {
                    Bevat bevat = VulBevat(duo);
                    Klant klant = VulKlant(duo);
                    klaargezetteBestellingen.Add(bevat, klant);

                    lbl_Voorgerecht.Text = "";
                }
            }
            for (int i = 0; i < bestellingen.Count; i++)
            {
                if (bestelNummer == bestellingen[i].bestellingID)
                    ids.Remove(bestellingen[i]);
            }
        }

        private void btn_hoofdGerechtKlaarzetten_Click_1(object sender, EventArgs e)
        {
            int bestelNummer = int.Parse(lv_Bestellingen.SelectedItems[0].Text);
            foreach (KeyValuePair<Bevat, Klant> duo in klantenInfo)
            {
                if (duo.Key.typeGerecht == HOOFDGERECHT)
                {
                    Bevat bevat = VulBevat(duo);
                    Klant klant = VulKlant(duo);
                    klaargezetteBestellingen.Add(bevat, klant);
                    lbl_Hoofdgerecht.Text = "";
                }
            }
            for (int i = 0; i < bestellingen.Count; i++)
            {
                if (bestelNummer == bestellingen[i].bestellingID)
                    ids.Remove(bestellingen[i]);
            }
        }

        private void btn_naGerechtKlaarzetten_Click_1(object sender, EventArgs e)
        {
            int bestelNummer = int.Parse(lv_Bestellingen.SelectedItems[0].Text);
            foreach (KeyValuePair<Bevat, Klant> duo in klantenInfo)
            {
                if (duo.Key.typeGerecht == NAGERECHT)
                {
                    Bevat bevat = VulBevat(duo);
                    Klant klant = VulKlant(duo);
                    klaargezetteBestellingen.Add(bevat, klant);
                    lbl_Nagerecht.Text = "";
                }
            }
            for (int i = 0; i < bestellingen.Count; i++)
            {
                if (bestelNummer == bestellingen[i].bestellingID)
                    ids.Remove(bestellingen[i]);
            }
        }

        private void BarOverzicht()
        {
            //listview legen
            lv_drankjes.Items.Clear();
            lv_drankjes.Columns.Add("Bestelling Id", 75);
            lv_drankjes.Columns.Add("Tafel Id", 75);
            //listbox test:
            lb_Opmerkingen.Items.Clear();
            lb_Opmerkingen.Items.Add("Hier zie je alle opmerkingen staan.");
        }

        private void btn_filterNaarGereed_Click_1(object sender, EventArgs e)
        {
            ShowPanel("bestellingenGereed");
        }

        private void MS_BO_Click(object sender, EventArgs e)
        {
            ShowPanel("baroverzicht");
        }
        
        private void MS_KO_Click(object sender, EventArgs e)
        {
            ShowPanel("openstaandeBestellingen");
        }

        private void btn_OpenstaandeBestellingenBAR_Click(object sender, EventArgs e)
        {
            lv_drankjes.Show();
            lbl_openstaandeBestellingenBAR.Show();
        }

        private void btn_bestellingGeschiedenisBAR_Click(object sender, EventArgs e)
        {

        }

        private void btn_klaarstaandeBestellingenBAR_Click(object sender, EventArgs e)
        {

        }

        private void btn_selectieGereedMeldenBAR_Click(object sender, EventArgs e)
        {

        }

        
    }
}
