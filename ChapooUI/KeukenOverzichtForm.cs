using ChapooModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChapooLogic;
using System.Threading;
using System.Security.Cryptography;
using System.Drawing;
using Chapoo_PDA_UI;

namespace ChapooUI
{

    public partial class KeukenOverzichtForm : Form
    {
        const int VOORGERECHT = 1;
        const int HOOFDGERECHT = 2;
        const int NAGERECHT = 3;
        const int TUSSENGERECHT = 4;
        const int DRINKEN = 5;
        private int Counter = 0;
        private Dictionary<Bevat, Klant> huidigeBestelling;
        private Dictionary<Bevat, Klant> huidigeBestellingGereed;
        private Dictionary<Bevat, Klant> huidigeDrankjes;
        private Dictionary<Bevat, Klant> klantenInfo; //de klant info en zijn bestelling
        private Dictionary<Bevat, Klant> DrinkInfo; // de klant info en zijn drinken
        private Dictionary<Bevat, Klant> klantenInfoGereedPanel; //de klant info en zijn bestelling in het panel gereed
        private Dictionary<Bevat, Klant> KlaargezetteDrankjes;
        private Dictionary<Bevat, Klant> ids; //info klant en bestellingen
        private Dictionary<Bevat, Klant> idsGereed; // info klant en bestellingen van klaarstaande bestellingen
                                                    // private Dictionary<Bevat, Klant> drankjesOpenstaand; // info klant en drankjes
        private Dictionary<Bevat, Klant> drankjesVanKlant; // info klant en drankjes
        private List<Bevat> klanten; //actual bestellingen 
        private List<Bevat> bestellingen; // bestellingen gereed
        private List<Bevat> drinken; //actual drinken

        private static KeukenOverzichtForm uniekeInstantie;

        public static KeukenOverzichtForm GetInstance()
        {
            if (uniekeInstantie == null)
                uniekeInstantie = new KeukenOverzichtForm();
            return uniekeInstantie;
        }
        public void OpenBarOverzicht()
        {
            ShowPanel("baroverzicht");
        }
        private KeukenOverzichtForm()
        {
            klantenInfo = new Dictionary<Bevat, Klant>();
            klantenInfoGereedPanel = new Dictionary<Bevat, Klant>();
            bestellingen = new List<Bevat>();
            klanten = new List<Bevat>();
            ids = new Dictionary<Bevat, Klant>();
            idsGereed = new Dictionary<Bevat, Klant>();
            drankjesVanKlant = new Dictionary<Bevat, Klant>();
            DrinkInfo = new Dictionary<Bevat, Klant>();
            KlaargezetteDrankjes = new Dictionary<Bevat, Klant>();
            huidigeBestelling = new Dictionary<Bevat, Klant>();
            huidigeBestellingGereed = new Dictionary<Bevat, Klant>();
            huidigeDrankjes = new Dictionary<Bevat, Klant>();
            drinken = new List<Bevat>();
            InitializeComponent();
            BestellingenVullen();

        }

        //onderstaand methode vult lvbestellingen door bestellingen uit db te halen
        private void BestellingenVullen()
        {
            ShowPanel("openstaandeBestellingen");
            //bestelling service aanmaken 
            ChapooLogic.Bevat_Service bevat_Service = new ChapooLogic.Bevat_Service();
            ids = bevat_Service.KrijgBestellingEnMenuItemID();
            //bestellingen = bevat_Service.AutoBestellingLaden();
            //leeg de kolommen eerst voordat je ze weer vult
            lv_Bestellingen.Clear();
            //maak kolommen
            lv_Bestellingen.Columns.Add("Tijd van opname");
            lv_Bestellingen.Columns.Add("Bestelling Id");
            lv_Bestellingen.Columns.Add("Tafel Id");
            //vul de listview
            foreach (KeyValuePair<Bevat, Klant> pair in ids)
            {
                ListViewItem li = new ListViewItem(pair.Key.tijdOpname.ToString());
                li.SubItems.Add(pair.Key.bestellingID.ToString());
                li.SubItems.Add(pair.Value.tafelID.ToString());
                lv_Bestellingen.Items.Add(li);
                klanten.Add(pair.Key);
            }
            lv_Bestellingen.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            lv_Bestellingen.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            AutoLaadBestelling();

        }
        private void BestellingenGereed()
        {
            //bestelling service aanmaken 
            Bevat_Service bevat_Service = new Bevat_Service();
            idsGereed = bevat_Service.KrijgBestellingEnMenuItemIDGereed();
            //eerst de listview legen.
            lv_klaarstaandebestellingen.Clear();
            //kolommen toevoegen
            lv_klaarstaandebestellingen.Columns.Add("Tijd van opname", 75);
            lv_klaarstaandebestellingen.Columns.Add("Bestelling Id", 100);
            lv_klaarstaandebestellingen.Columns.Add("Tafel Id", 100);
            //vul de listview
            foreach (KeyValuePair<Bevat, Klant> pair in idsGereed)
            {
                ListViewItem li = new ListViewItem(pair.Key.tijdOpname.ToString());
                li.SubItems.Add(pair.Key.bestellingID.ToString());
                li.SubItems.Add(pair.Value.tafelID.ToString());
                lv_klaarstaandebestellingen.Items.Add(li);
                bestellingen.Add(pair.Key);
            }
            lv_klaarstaandebestellingen.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            lv_klaarstaandebestellingen.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            AutoLaadBestellingGereed();
        }
        private void AutoLaadBestelling()
        {
            LeegmakenLabelsOpenstaand();
            huidigeBestelling.Clear();
            lbl_HuidigeBestelling.Show();
            string bestelNummer = klanten[0].bestellingID.ToString();
            lbl_HuidigeBestelling.Text = $"Bestelling: {bestelNummer}";
            Bevat_Service service = new Bevat_Service();
            huidigeBestelling = service.KrijgBeschrijving(bestelNummer);
            foreach (KeyValuePair<Bevat, Klant> gerecht in huidigeBestelling)
            {
                klantenInfo.Add(gerecht.Key, gerecht.Value);
                switch (gerecht.Key.typeGerecht)
                {
                    case VOORGERECHT:
                        lbl_Voorgerecht.Text += $"{gerecht.Key.Aantal}x {gerecht.Key.menuItemID} {gerecht.Key.menuItemBeschrijving}\n";
                        lbl_opmerkingVoorgerecht.Text += $"{gerecht.Key.Opmerkingen}\n";
                        break;
                    case HOOFDGERECHT:
                        lbl_Hoofdgerecht.Text += $"{gerecht.Key.Aantal}x {gerecht.Key.menuItemID} {gerecht.Key.menuItemBeschrijving}\n";
                        lbl_opmerkingHoofdgerecht.Text += $"{gerecht.Key.Opmerkingen}\n";
                        break;
                    case TUSSENGERECHT:
                        lbl_Voorgerecht.Text += $"{gerecht.Key.Aantal}x {gerecht.Key.menuItemID} {gerecht.Key.menuItemBeschrijving}\n";
                        lbl_opmerkingVoorgerecht.Text += $"{gerecht.Key.Opmerkingen}\n";
                        break;
                    case NAGERECHT:
                        lbl_Nagerecht.Text += $"{gerecht.Key.Aantal}x {gerecht.Key.menuItemID} {gerecht.Key.menuItemBeschrijving}\n";
                        lbl_opmerkingNagerecht.Text += $"{gerecht.Key.Opmerkingen}\n";
                        break;
                }
            }
        }

        private void AutoLaadBestellingGereed()
        {
            LeegmakenLabelsKlaarstaand();
            huidigeBestellingGereed.Clear();
            lbl_huidigeBestellingGEREED.Show();
            string bestelNummer = bestellingen[0].bestellingID.ToString();
            lbl_huidigeBestellingGEREED.Text = $"Bestelling: {bestelNummer}";
            Bevat_Service service = new Bevat_Service();
            huidigeBestellingGereed = service.KrijgBeschrijving(bestelNummer);
            foreach (KeyValuePair<Bevat, Klant> gerecht in huidigeBestellingGereed)
            {
                klantenInfoGereedPanel.Add(gerecht.Key, gerecht.Value);
                switch (gerecht.Key.typeGerecht)
                {
                    case VOORGERECHT:
                        lbl_voorGerechtKlaar.Text += $"{gerecht.Key.Aantal}x {gerecht.Key.menuItemID} {gerecht.Key.menuItemBeschrijving}\n";
                        lbl_opmerkingVoorKLAAR.Text += $"{gerecht.Key.Opmerkingen}\n";
                        break;
                    case HOOFDGERECHT:
                        lbl_hoofdGerechtKlaar.Text += $"{gerecht.Key.Aantal}x {gerecht.Key.menuItemID} {gerecht.Key.menuItemBeschrijving}\n";
                        lbl_opmerkingHoofdKLAAR.Text += $"{gerecht.Key.Opmerkingen}\n";
                        break;
                    case TUSSENGERECHT:
                        lbl_voorGerechtKlaar.Text += $"{gerecht.Key.Aantal}x {gerecht.Key.menuItemID} {gerecht.Key.menuItemBeschrijving}\n";
                        lbl_opmerkingVoorKLAAR.Text += $"{gerecht.Key.Opmerkingen}\n";
                        break;
                    case NAGERECHT:
                        lbl_naGerechtKlaar.Text += $"{gerecht.Key.Aantal}x {gerecht.Key.menuItemID} {gerecht.Key.menuItemBeschrijving}\n";
                        lbl_opmerkingNaKLAAR.Text += $"{gerecht.Key.Opmerkingen}\n";
                        break;
                }
            }
        }
        //onderstaande methode zet de bestelling in de database op gereed
        private void BestellingGereedMeldenDB(int bestelNummer)
        {
            Bevat_Service bevat_Service = new Bevat_Service();
            bevat_Service.BestellingGereedZetten(bestelNummer);
        }

        //tbc
        private void barOverzichtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowPanel("baroverzicht");
        }

        //onderstaand methode toont openstaande bestellingen panel
        private void btn_naarBestellingenOpenstaand_Click(object sender, EventArgs e)
        {
            ShowPanel("openstaandeBestellingen");
        }

        //onderstaande methode laat een panel zien
        private void ShowPanel(string panelName)
        {
            if (panelName == "baroverzicht")
            {
                //verberg alle andere panelen
                pnl_klaarstaandeBestellingen.Hide();
                pnl_openstaandeBestellingen.Hide();
                lbl_opmerkingenDrankjes.Hide();
                //toon juiste panel
                pnl_barOverzicht.Show();
                BarOverzicht();

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
            else if (panelName == "openstaandeBestellingen")
            {
                //verberg andere panels
                pnl_klaarstaandeBestellingen.Hide();
                pnl_barOverzicht.Hide();
                lbl_opmerkingVoorgerecht.Hide();
                lbl_opmerkingHoofdgerecht.Hide();
                lbl_opmerkingNagerecht.Hide();
                //toon de goede
                pnl_openstaandeBestellingen.Show();
            }
        }

        //onderstaande methode haalt alle klaarstaande bestellingen op uit de database
       

        //onderstaande methode toont de aangeklikte bestelling uit de listview van de klaarstaande bestellingen
        private void btn_toonBestellingGereedPanel_Click(object sender, EventArgs e)
        {
            try
            {
                LeegmakenLabelsKlaarstaand();
                //bestellings nummer ophalen
                string bestellingNummer = lv_klaarstaandebestellingen.SelectedItems[0].SubItems[1].Text;
                lbl_huidigeBestellingGEREED.Text = $"Bestelling: {bestellingNummer}";
                //service aanmaken om de beschrijving op te halen
                Bevat_Service bevat_Service = new Bevat_Service();
                klantenInfoGereedPanel = bevat_Service.KrijgBeschrijving(bestellingNummer);
                foreach (KeyValuePair<Bevat, Klant> duo in klantenInfoGereedPanel)
                {
                    switch (duo.Key.typeGerecht)
                    {
                        case VOORGERECHT:
                            lbl_voorGerechtKlaar.Text += VulDeLabels(duo);
                            lbl_opmerkingVoorKLAAR.Text += $"{duo.Key.Opmerkingen}\n";
                            break;
                        case HOOFDGERECHT:
                            lbl_hoofdGerechtKlaar.Text += VulDeLabels(duo);
                            lbl_opmerkingHoofdKLAAR.Text += $"{duo.Key.Opmerkingen}\n";
                            break;
                        case NAGERECHT:
                            lbl_naGerechtKlaar.Text += VulDeLabels(duo);
                            lbl_opmerkingNaKLAAR.Text += $"{duo.Key.Opmerkingen}\n";
                            break;
                        case TUSSENGERECHT:
                            lbl_voorGerechtKlaar.Text += VulDeLabels(duo);
                            lbl_opmerkingVoorKLAAR.Text += $"{duo.Key.Opmerkingen}\n";
                            break;
                        default:
                            MessageBox.Show("kan niet verbinden met de database");
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private string VulDeLabels(KeyValuePair<Bevat, Klant> duo)
        {
            string tekst = $"{duo.Key.Aantal}x {duo.Key.menuItemID} {duo.Key.menuItemBeschrijving}\n";
            return tekst;
        }
        private void LeegmakenLabelsKlaarstaand()
        {
            lbl_opmerkingVoorKLAAR.Show();
            lbl_opmerkingHoofdKLAAR.Show();
            lbl_opmerkingNaKLAAR.Show();
            lbl_voorGerechtKlaar.Text = "";
            lbl_hoofdGerechtKlaar.Text = "";
            lbl_naGerechtKlaar.Text = "";
            lbl_huidigeBestellingGEREED.Text = "";
            lbl_opmerkingVoorKLAAR.Text = "";
            lbl_opmerkingHoofdKLAAR.Text = "";
            lbl_opmerkingNaKLAAR.Text = "";
            klantenInfoGereedPanel.Clear();
        }

        //onderstaande methode zorgt voor het opnieuw ophalen van openstaande bestellingen uit de db
        private void btn_herlaadBestellingen_Click(object sender, EventArgs e)
        {
            BestellingenVullen();
        }

        //onderstaande methode toont de aangeklikte bestelling uit de listview van de openstaande bestellingen
        private void btn_toonBestelling_Click_1(object sender, EventArgs e)
        {
            LeegmakenLabelsOpenstaand();
            try
            {
                //bestellings nummer ophalen
                string bestellingNummer = lv_Bestellingen.SelectedItems[0].SubItems[1].Text;
                lbl_HuidigeBestelling.Text = $"Bestelling: {bestellingNummer}";
                //service aanmaken om de beschrijving op te halen
                Bevat_Service bevat_Service = new Bevat_Service();
                klantenInfo = bevat_Service.KrijgBeschrijving(bestellingNummer);
                int aantalDrankjes = CheckDrinkenInBestelling(klantenInfo);
                Counter += aantalDrankjes;
                foreach (KeyValuePair<Bevat, Klant> duo in klantenInfo)
                {
                    switch (duo.Key.typeGerecht)
                    {
                        case VOORGERECHT:
                            lbl_Voorgerecht.Text += VulDeLabels(duo);
                            lbl_opmerkingVoorgerecht.Text += $"{duo.Key.Opmerkingen}\n";
                            break;
                        case HOOFDGERECHT:
                            lbl_Hoofdgerecht.Text += VulDeLabels(duo);
                            lbl_opmerkingHoofdgerecht.Text += $"{duo.Key.Opmerkingen}\n";
                            break;
                        case NAGERECHT:
                            lbl_Nagerecht.Text += VulDeLabels(duo);
                            lbl_opmerkingNagerecht.Text += $"{duo.Key.Opmerkingen}\n";
                            break;
                        case TUSSENGERECHT:
                            lbl_Voorgerecht.Text += VulDeLabels(duo);
                            lbl_opmerkingVoorgerecht.Text += $"{duo.Key.Opmerkingen}\n";
                            break;
                        default:
                            MessageBox.Show("kan niet verbinden met de database");
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void LeegmakenLabelsOpenstaand()
        {
            //eerst alle labels en de lijst leegmaken
            lbl_opmerkingVoorgerecht.Show();
            lbl_opmerkingHoofdgerecht.Show();
            lbl_opmerkingNagerecht.Show();
            lbl_Voorgerecht.Text = "";
            lbl_Hoofdgerecht.Text = "";
            lbl_Nagerecht.Text = "";
            lbl_HuidigeBestelling.Text = "";
            lbl_opmerkingVoorgerecht.Text = "";
            lbl_opmerkingHoofdgerecht.Text = "";
            lbl_opmerkingNagerecht.Text = "";
            klantenInfo.Clear();
        }
        //onderstaande methode checkt of er drankjes in de bestelling zitten
        private int CheckDrinkenInBestelling(Dictionary<Bevat, Klant> dict)
        {
            int drankjes = 0;
            foreach (KeyValuePair<Bevat, Klant> pair in dict)
            {
                if (pair.Key.typeGerecht == DRINKEN)
                {
                    drankjes++;
                }
            }
            return drankjes;
        }

        //onderstaande methode checkt of het een voorgerecht is en zet deze dan klaar
        private void btn_voorGerechtKlaarzetten_Click_1(object sender, EventArgs e)
        {
            try
            {
                int bestelNummer;
                if (lv_Bestellingen.SelectedItems.Count == 0)
                    bestelNummer = klanten[0].bestellingID;
                else
                    bestelNummer = int.Parse(lv_Bestellingen.SelectedItems[0].SubItems[1].Text);

                foreach (KeyValuePair<Bevat, Klant> duo in klantenInfo)
                {
                    if (duo.Key.typeGerecht == VOORGERECHT || duo.Key.typeGerecht == TUSSENGERECHT)
                    {
                        Counter++;
                        lbl_Voorgerecht.Text = "";
                    }
                }
                BestellingGereedCheck(bestelNummer);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "Klik eerst de bestelling in de lijst aan");
            }
        }

        //onderstaande methode checkt of het een hoofdgerecht is en zet deze dan klaar
        private void btn_hoofdGerechtKlaarzetten_Click_1(object sender, EventArgs e)
        {
            try
            {
                int bestelNummer;
                if (lv_Bestellingen.SelectedItems.Count == 0)
                    bestelNummer = klanten[0].bestellingID;
                else
                    bestelNummer = int.Parse(lv_Bestellingen.SelectedItems[0].SubItems[1].Text);
                foreach (KeyValuePair<Bevat, Klant> duo in klantenInfo)
                {
                    if (duo.Key.typeGerecht == HOOFDGERECHT)
                    {
                        Counter++;
                        lbl_Hoofdgerecht.Text = "";
                    }
                }
                BestellingGereedCheck(bestelNummer);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "Klik eerst de bestelling in de lijst aan");
            }
        }

        //onderstaande methode checkt of het een nagerecht is en zet deze dan klaar
        private void btn_naGerechtKlaarzetten_Click_1(object sender, EventArgs e)
        {
            try
            {
                int bestelNummer;
                if (lv_Bestellingen.SelectedItems.Count == 0)
                    bestelNummer = klanten[0].bestellingID;
                else
                    bestelNummer = int.Parse(lv_Bestellingen.SelectedItems[0].SubItems[1].Text);
                foreach (KeyValuePair<Bevat, Klant> duo in klantenInfo)
                {
                    if (duo.Key.typeGerecht == NAGERECHT)
                    {
                        Counter++;
                        lbl_Nagerecht.Text = "";
                    }
                }
                BestellingGereedCheck(bestelNummer);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "Klik eerst de bestelling in de lijst aan");
            }
        }
        //onderstaande methode checkt eerst of alle gerecht van een bestelling gereed gemeld zijn, zo ja, dan wordt de hele bestelling op klaar gezet
        private void BestellingGereedCheck(int bestelNummer)
        {
            Bevat bestelling = new Bevat();
            if (klantenInfo.Count == Counter)
            {
                foreach (Bevat item in klanten)
                {
                    if (item.bestellingID == bestelNummer)
                        bestelling = item;
                }
                klanten.Remove(bestelling);
                lbl_opmerkingVoorgerecht.Text = "";
                lbl_opmerkingHoofdgerecht.Text = "";
                lbl_opmerkingNagerecht.Text = "";
                lbl_HuidigeBestelling.Text = "";
                BestellingGereedMeldenDB(bestelNummer);
                Counter = 0;
            }
        }

        //onderstaande methode haalt de openstaande drankjes op uit de db
        private void BarOverzicht()
        {
            //listview legen
            lv_drankjes.Clear();
            //kolommen toevoegen
            lv_drankjes.Columns.Add("Tijd van opname", 75);
            lv_drankjes.Columns.Add("Bestelling Id", 75);
            lv_drankjes.Columns.Add("Tafel Id", 75);

            //maak een service om de drankjes uit de db te halen
            Bevat_Service bevat_service = new Bevat_Service();
            drankjesVanKlant = bevat_service.KrijgDrankjes();
            foreach (KeyValuePair<Bevat, Klant> pair in drankjesVanKlant)
            {
                ListViewItem li = new ListViewItem(pair.Key.tijdOpname.ToString());
                li.SubItems.Add(pair.Key.bestellingID.ToString());
                li.SubItems.Add(pair.Value.tafelID.ToString());
                lv_drankjes.Items.Add(li);
                drinken.Add(pair.Key);
            }
            lv_drankjes.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            lv_drankjes.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            AutoLaadDrankjes();
        }
        private void AutoLaadDrankjes()
        {
            LeegmakenLabelsOpenstaand(); //leegmaken drankjes
            huidigeDrankjes.Clear();
            lbl_DrinkBestelling.Show();
            string bestelNummer = drinken[0].bestellingID.ToString();
            lbl_DrinkBestelling.Text = $"Bestelling: {bestelNummer}";
            Bevat_Service service = new Bevat_Service();
            huidigeDrankjes = service.KrijgBeschrijving(bestelNummer);
            foreach (KeyValuePair<Bevat, Klant> gerecht in huidigeDrankjes)
            {
                DrinkInfo.Add(gerecht.Key, gerecht.Value);
                if (gerecht.Key.typeGerecht == DRINKEN)
                {
                    lbl_Drinken.Text += $"{gerecht.Key.Aantal}x {gerecht.Key.menuItemID} {gerecht.Key.menuItemBeschrijving}\n";
                    lbl_opmerkingenDrankjes.Text += $"{gerecht.Key.Opmerkingen}";
                }
            }

        }

        //onderstaande methode filtert naar gereed staande bestellingen
        private void btn_filterNaarGereed_Click_1(object sender, EventArgs e)
        {
            ShowPanel("bestellingenGereed");
        }
        //onderstaande methode toont het baroverzicht
        private void MS_BO_Click(object sender, EventArgs e)
        {
            ShowPanel("baroverzicht");
        }
        //onderstaande methode opent panel openstaande bestellingen
        private void MS_KO_Click(object sender, EventArgs e)
        {
            ShowPanel("openstaandeBestellingen");
        }
        //onderstaande methode toont de bestelling van de bar
        private void btn_toonBestellingBAR_Click(object sender, EventArgs e)
        {
            try
            {
                lbl_Drinken.Show();
                lbl_opmerkingenDrankjes.Show();
                //eerst alle labels en de lijst leegmaken
                DrinkInfo.Clear();
                lbl_DrinkBestelling.Text = "";
                lbl_Drinken.Text = "";
                //bestellings nummer ophalen
                string bestellingNummer = lv_drankjes.SelectedItems[0].SubItems[1].Text;
                lbl_DrinkBestelling.Text = $"Bestelling: {bestellingNummer}";
                //service aanmaken om de beschrijving op te halen
                Bevat_Service bevat_Service = new Bevat_Service();
                DrinkInfo = bevat_Service.KrijgBeschrijving(bestellingNummer);
                foreach (KeyValuePair<Bevat, Klant> duo in DrinkInfo)
                {
                    if (duo.Key.typeGerecht == DRINKEN)
                    {
                        lbl_Drinken.Text += $"{duo.Key.Aantal}x {duo.Key.menuItemID} {duo.Key.menuItemBeschrijving}\n";
                        lbl_opmerkingenDrankjes.Text += $"{duo.Key.Opmerkingen}";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //onderstaande methode zet het drinken klaar voor de desbetreffende bestelling
        private void btn_drinkenKlaarzetten_Click(object sender, EventArgs e)
        {
            lbl_DrinkBestelling.Text = "";
            lbl_opmerkingenDrankjes.Text = "";
            try
            {
                if (lv_drankjes.SelectedItems.Count == 0)
                {
                    lv_drankjes.Items[0].BackColor = Color.Red;
                }
                else
                {
                    lv_drankjes.SelectedItems[0].BackColor = Color.Red;
                }
                lv_drankjes.Refresh();
                lv_drankjes.Update();
                foreach (KeyValuePair<Bevat, Klant> duo in DrinkInfo)
                {
                    if (duo.Key.typeGerecht == DRINKEN)
                    {
                        lbl_Drinken.Text = "";
                        KlaargezetteDrankjes.Add(duo.Key, duo.Value);
                        DrankjesDoorsturen(duo.Key, duo.Value);
                    }
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message} De listview kan pas herladen worden als een drankje gereed gezet is.");
            }

        }

        //onderstaande methode stuurt te klaargezette drankjes door
        private void DrankjesDoorsturen(Bevat drankje, Klant klant)
        {
            ChapooPDA_KlaarstaandeBestellingenOverzicht klaarstaandeBestellingen_service = ChapooPDA_KlaarstaandeBestellingenOverzicht.GetInstance();
            klaarstaandeBestellingen_service.DrankjesOntvangen(drankje, klant);
        }

        //onderstaande methode zet de bestelling niet klaar
        private void btn_bestellingOngereedZetten_Click(object sender, EventArgs e)
        {
            int bestelNummer;
            Bevat bestelling = new Bevat();
            lbl_voorGerechtKlaar.Text = "";
            lbl_hoofdGerechtKlaar.Text = "";
            lbl_naGerechtKlaar.Text = "";
            lbl_opmerkingVoorKLAAR.Text = "";
            lbl_opmerkingHoofdKLAAR.Text = "";
            lbl_opmerkingNaKLAAR.Text = "";
            lbl_huidigeBestellingGEREED.Text = "";
            if (lv_klaarstaandebestellingen.SelectedItems.Count == 0)
                bestelNummer = bestellingen[0].bestellingID;
            else
                bestelNummer = int.Parse(lv_klaarstaandebestellingen.SelectedItems[0].SubItems[1].Text);
            foreach (Bevat item in bestellingen)
            {
                if (item.bestellingID == bestelNummer)
                    bestelling = item;
            }
            bestellingen.Remove(bestelling);
            Bevat_Service bevat = new Bevat_Service();
            bevat.BestellingOngereedZetten(bestelNummer);
        }

        //onderstaande methode herlaad de klaarstaande bestellingen
        private void btn_HerlaadKlaarstaandeBestellingen_Click(object sender, EventArgs e)
        {
            BestellingenGereed();
        }

        private void afmeldenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AfmeldenForm form = new AfmeldenForm();
            Hide();
            form.Show();
        }

        private void openPDAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AanmeldenPDAForm pda = new AanmeldenPDAForm();
            Hide();
            pda.Show();
        }

        private void MS1I_Home_Click(object sender, EventArgs e)
        {
            Chapoo chapoo = Chapoo.GetInstance();
            Hide();
            chapoo.Show();
        }

        private void MS_RO_Click(object sender, EventArgs e)
        {

        }

        private void MS1I_Inkomsten_Click(object sender, EventArgs e)
        {
            InkomstenForm inkomsten = new InkomstenForm();
            Hide();
            inkomsten.Show();
        }

        private void MS1I_Voorraad_Click(object sender, EventArgs e)
        {
            VoorraadForm voorraad = new VoorraadForm();
            Hide();
            voorraad.Show();
        }

        private void MS1I_MenuKaartOpties_Click(object sender, EventArgs e)
        {
            MenuKaartAanpassenForm menukaarten = new MenuKaartAanpassenForm();
            Hide();
            menukaarten.Show();
        }

        private void MS1I_Werknemers_Click(object sender, EventArgs e)
        {
            WerknemersForm werknemers = new WerknemersForm();
            Hide();
            werknemers.Show();
        }
    }
}
