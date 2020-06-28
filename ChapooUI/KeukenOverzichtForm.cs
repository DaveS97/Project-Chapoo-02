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
        private Dictionary<Bevat, Klant> klantenInfo; //de klant info en zijn bestelling
        private Dictionary<Bevat, Klant> DrinkInfo; // de klant info en zijn drinken
        private Dictionary<Bevat, Klant> klantenInfoGereedPanel; //de klant info en zijn bestelling in het panel gereed
        private Dictionary<Bevat, Klant> klaargezetteBestellingen;
        private Dictionary<Bevat, Klant> KlaargezetteDrankjes;
        private Dictionary<Bevat, Klant> ids; //info klant en bestellingen
        private Dictionary<Bevat, Klant> idsGereed; // info klant en bestellingen van klaarstaande bestellingen
       // private Dictionary<Bevat, Klant> drankjesOpenstaand; // info klant en drankjes
        private Dictionary<Bevat, Klant> drankjesVanKlant; // info klant en drankjes
        private List<Bevat> drankjes;
        private List<Klant> klanten; //klanten 
        private List<Bevat> bestellingen; // bestellingen

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
            klaargezetteBestellingen = new Dictionary<Bevat, Klant>();
            klantenInfoGereedPanel = new Dictionary<Bevat, Klant>();
            bestellingen = new List<Bevat>();
            klanten = new List<Klant>();
            ids = new Dictionary<Bevat, Klant>();
            idsGereed = new Dictionary<Bevat, Klant>();
            //drankjesOpenstaand = new Dictionary<Bevat, Klant>();
            drankjesVanKlant = new Dictionary<Bevat, Klant>();
            drankjes = new List<Bevat>();
            DrinkInfo = new Dictionary<Bevat, Klant>();
            KlaargezetteDrankjes = new Dictionary<Bevat, Klant>();
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
                bestellingen.Add(pair.Key);
                klanten.Add(pair.Value);
            }
            lv_Bestellingen.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            lv_Bestellingen.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

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
                //toon de goede
                pnl_openstaandeBestellingen.Show();
            }
            //else if (panelName == "baroverzichtKlaar")
            //{
            //    //verberg alle andere panels.
            //    pnl_barOverzicht.Hide();
            //    pnl_klaarstaandeBestellingen.Hide();
            //    pnl_openstaandeBestellingen.Hide();
            //    //toon de juiste panel
            //    pnl_baroverzichtKlaar.Show();
            //    BarOverzichtKlaar();
            //}
        }

        //onderstaande methode haalt alle klaarstaande bestellingen op uit de database
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
            }
            lv_klaarstaandebestellingen.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            lv_klaarstaandebestellingen.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        //onderstaande methode toont de aangeklikte bestelling uit de listview van de klaarstaande bestellingen
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
                            lbl_voorGerechtKlaar.Text += $"{duo.Key.menuItemID} {duo.Key.menuItemBeschrijving}\n";
                            break;
                        case HOOFDGERECHT:
                            lbl_hoofdGerechtKlaar.Text += $"{duo.Key.menuItemID} {duo.Key.menuItemBeschrijving}\n";
                            break;
                        case NAGERECHT:
                            lbl_naGerechtKlaar.Text += $"{duo.Key.menuItemID} {duo.Key.menuItemBeschrijving}\n";
                            break;
                        case TUSSENGERECHT:
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

        //onderstaande methode is een vul methode voor bevat class
        private Bevat VulBevat(KeyValuePair<Bevat, Klant> duo)
        {
            Bevat bevat = new Bevat
            {
                bestellingID = duo.Key.bestellingID,
                menuItemBeschrijving = duo.Key.menuItemBeschrijving,
                menuItemID = duo.Key.menuItemID,
                typeGerecht = duo.Key.typeGerecht,
                is_Gereed = duo.Key.is_Gereed
                
            };
            bevat.tijdOpname = duo.Key.tijdOpname;
            return bevat;
        }

        //onderstaande methode is een vul methode voor klant class
        private Klant VulKlant(KeyValuePair<Bevat, Klant> duo)
        {
            Klant klant = new Klant
            {
                ID = duo.Value.ID,
                tafelID = duo.Value.tafelID,
                betaalWijzeType = duo.Value.betaalWijzeType,
                reserveringID = duo.Value.reserveringID,
                bonID = duo.Value.bonID
            };
            return klant;
        }

        private void test()
        {
            //hier kan ik me gedachten ff uiten
        }

        //onderstaande methode zorgt voor het opnieuw ophalen van openstaande bestellingen uit de db
        private void btn_herlaadBestellingen_Click(object sender, EventArgs e)
        {
            BestellingenVullen();
            lbl_HuidigeBestelling.Text = "";
        }

        //onderstaande methode toont de aangeklikte bestelling uit de listview van de openstaande bestellingen
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
                string bestellingNummer = lv_Bestellingen.SelectedItems[0].SubItems[1].Text;
                lbl_HuidigeBestelling.Text = $"Bestelling: {bestellingNummer}";
                //service aanmaken om de beschrijving op te halen
                Bevat_Service bevat_Service = new Bevat_Service();
                klantenInfo = bevat_Service.KrijgBeschrijving(bestellingNummer);
                foreach (KeyValuePair<Bevat, Klant> duo in klantenInfo)
                {
                    switch (duo.Key.typeGerecht)
                    {
                        case VOORGERECHT:
                            lbl_Voorgerecht.Text += $"{duo.Key.menuItemID} {duo.Key.menuItemBeschrijving}\n";
                            break;
                        case HOOFDGERECHT:
                            lbl_Hoofdgerecht.Text += $"{duo.Key.menuItemID} {duo.Key.menuItemBeschrijving}\n";
                            break;
                        case NAGERECHT:
                            lbl_Nagerecht.Text += $"{duo.Key.menuItemID} {duo.Key.menuItemBeschrijving}\n";
                            break;
                        case TUSSENGERECHT:
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

        //onderstaande methode checkt of het een voorgerecht is en zet deze dan klaar
        private void btn_voorGerechtKlaarzetten_Click_1(object sender, EventArgs e)
        {
            
            int bestelNummer = int.Parse(lv_Bestellingen.SelectedItems[0].SubItems[1].Text);
            foreach (KeyValuePair<Bevat, Klant> duo in klantenInfo)
            {
                if (duo.Key.typeGerecht == VOORGERECHT || duo.Key.typeGerecht == TUSSENGERECHT)
                {
                    Bevat bevat = VulBevat(duo);
                    Klant klant = VulKlant(duo);
                    klaargezetteBestellingen.Add(bevat, klant);
                    Counter++;
                    lbl_Voorgerecht.Text = "";
                }
            }
            BestellingGereedCheck(bestelNummer);
        }

        //onderstaande methode checkt of het een hoofdgerecht is en zet deze dan klaar
        private void btn_hoofdGerechtKlaarzetten_Click_1(object sender, EventArgs e)
        {
            int bestelNummer = int.Parse(lv_Bestellingen.SelectedItems[0].SubItems[1].Text);
            foreach (KeyValuePair<Bevat, Klant> duo in klantenInfo)
            {
                if (duo.Key.typeGerecht == HOOFDGERECHT)
                {
                    Bevat bevat = VulBevat(duo);
                    Klant klant = VulKlant(duo);
                    klaargezetteBestellingen.Add(bevat, klant);
                    Counter++;
                    lbl_Hoofdgerecht.Text = "";
                }
            }
            BestellingGereedCheck(bestelNummer);
        }

        //onderstaande methode checkt of het een nagerecht is en zet deze dan klaar
        private void btn_naGerechtKlaarzetten_Click_1(object sender, EventArgs e)
        {
            int bestelNummer = int.Parse(lv_Bestellingen.SelectedItems[0].SubItems[1].Text);
            foreach (KeyValuePair<Bevat, Klant> duo in klantenInfo)
            {
                if (duo.Key.typeGerecht == NAGERECHT)
                {
                    Bevat bevat = VulBevat(duo);
                    Klant klant = VulKlant(duo);
                    klaargezetteBestellingen.Add(bevat, klant);
                    Counter++;
                    lbl_Nagerecht.Text = "";
                }
            }
            BestellingGereedCheck(bestelNummer);
        }

        //onderstaande methode checkt eerst of alle gerecht van een bestelling gereed gemeld zijn, zo ja, dan wordt de hele bestelling op klaar gezet
        private void BestellingGereedCheck(int bestelNummer)
        {
            if (klantenInfo.Count == Counter)
            {
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
            lb_DrankjesVBestelling.AutoSize = true;

            //maak een service om de drankjes uit de db te halen
            Bevat_Service bevat_service = new Bevat_Service();
            drankjesVanKlant = bevat_service.KrijgDrankjes();
            foreach (KeyValuePair<Bevat, Klant> pair in drankjesVanKlant)
            {
                ListViewItem li = new ListViewItem(pair.Key.tijdOpname.ToString());
                li.SubItems.Add(pair.Key.bestellingID.ToString());
                li.SubItems.Add(pair.Value.tafelID.ToString());
                lv_drankjes.Items.Add(li);
            }
            lv_drankjes.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            lv_drankjes.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            //drankjesOpenstaand
        }


        //onderstaande methode filtert naar gereed staande bestellingen
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

        private void btn_toonBestellingBAR_Click(object sender, EventArgs e)
        {
            try
            {
                //eerst alle labels en de lijst leegmaken
                lb_DrankjesVBestelling.Items.Clear();
                DrinkInfo.Clear();
                lbl_DrinkBestelling.Text = "";
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
                        lb_DrankjesVBestelling.Items.Add($"{duo.Key.menuItemID} {duo.Key.menuItemBeschrijving}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void KeukenOverzichtForm_Load(object sender, EventArgs e)
        {

        }
        //onderstaande methode zet het drinken klaar voor de desbetreffende bestelling
        private void btn_drinkenKlaarzetten_Click(object sender, EventArgs e)
        {
            lv_drankjes.SelectedItems[0].BackColor = Color.Red;
            lv_drankjes.Refresh();
            lv_drankjes.Update();
            foreach (KeyValuePair<Bevat, Klant> duo in DrinkInfo)
            {
                if (duo.Key.typeGerecht == DRINKEN)
                {
                    Bevat bevat = VulBevat(duo);
                    Klant klant = VulKlant(duo);
                    KlaargezetteDrankjes.Add(bevat, klant);
                    lb_DrankjesVBestelling.Items.Clear();
                }
            }
            lbl_DrinkBestelling.Text = "";
        }
        private void btn_VoorgerechtOngereedZetten_Click(object sender, EventArgs e)
        {
            int bestelNummer = int.Parse(lv_Bestellingen.SelectedItems[0].SubItems[1].Text);
            Bevat_Service bevat = new Bevat_Service();
            bevat.BestellingOngereedZetten(bestelNummer);
        }
    }
}
