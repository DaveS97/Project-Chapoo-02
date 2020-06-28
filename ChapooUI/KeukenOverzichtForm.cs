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
        //test123
        const int VOORGERECHT = 1;
        const int HOOFDGERECHT = 2;
        const int NAGERECHT = 3;
        const int TUSSENGERECHT = 4;
        const int DRINKEN = 5;
        private int Counter = 0;
        private Dictionary<Bevat, Klant> klantenInfo; //de klant info en zijn bestelling
        private Dictionary<Bevat, Klant> DrinkInfo; // de klant info en zijn drinken
        private Dictionary<Bevat, Klant> klantenInfoGereedPanel; //de klant info en zijn bestelling in het panel gereed
        private Dictionary<Bevat, Klant> KlaargezetteDrankjes;
        private Dictionary<Bevat, Klant> ids; //info klant en bestellingen
        private Dictionary<Bevat, Klant> idsGereed; // info klant en bestellingen van klaarstaande bestellingen
                                                    // private Dictionary<Bevat, Klant> drankjesOpenstaand; // info klant en drankjes
        private Dictionary<Bevat, Klant> drankjesVanKlant; // info klant en drankjes
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
            klantenInfoGereedPanel = new Dictionary<Bevat, Klant>();
            bestellingen = new List<Bevat>();
            klanten = new List<Klant>();
            ids = new Dictionary<Bevat, Klant>();
            idsGereed = new Dictionary<Bevat, Klant>();
            drankjesVanKlant = new Dictionary<Bevat, Klant>();
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
                lbl_opmerkingVoorKLAAR.Hide();
                lbl_opmerkingHoofdKLAAR.Hide();
                lbl_opmerkingNaKLAAR.Hide();
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
                            lbl_voorGerechtKlaar.Text += $"{duo.Key.Aantal}x {duo.Key.menuItemID} {duo.Key.menuItemBeschrijving}\n";
                            lbl_opmerkingVoorKLAAR.Text += $"{duo.Key.Opmerkingen}\n";
                            break;
                        case HOOFDGERECHT:
                            lbl_hoofdGerechtKlaar.Text += $"{duo.Key.Aantal}x {duo.Key.menuItemID} {duo.Key.menuItemBeschrijving}\n";
                            lbl_opmerkingHoofdKLAAR.Text += $"{duo.Key.Opmerkingen}\n";
                            break;
                        case NAGERECHT:
                            lbl_naGerechtKlaar.Text += $" {duo.Key.Aantal}x {duo.Key.menuItemID} {duo.Key.menuItemBeschrijving}\n";
                            lbl_opmerkingNaKLAAR.Text += $"{duo.Key.Opmerkingen}\n";
                            break;
                        case TUSSENGERECHT:
                            lbl_voorGerechtKlaar.Text += $"{duo.Key.Aantal}x {duo.Key.menuItemID} {duo.Key.menuItemBeschrijving}\n";
                            lbl_opmerkingVoorKLAAR.Text += $"{duo.Key.Opmerkingen}\n";
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
            klantenInfoGereedPanel.Clear();
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
                LeegmakenLabelsOpenstaand();
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
                            lbl_Voorgerecht.Text += $"{duo.Key.Aantal}x {duo.Key.menuItemID} {duo.Key.menuItemBeschrijving}\n";
                            lbl_opmerkingVoorgerecht.Text += $"{duo.Key.Opmerkingen}\n";
                            break;
                        case HOOFDGERECHT:
                            lbl_Hoofdgerecht.Text += $"{duo.Key.Aantal}x {duo.Key.menuItemID} {duo.Key.menuItemBeschrijving}\n";
                            lbl_opmerkingHoofdgerecht.Text += $"{duo.Key.Opmerkingen}\n";
                            break;
                        case NAGERECHT:
                            lbl_Nagerecht.Text += $"{duo.Key.Aantal}x {duo.Key.menuItemID} {duo.Key.menuItemBeschrijving}\n";
                            lbl_opmerkingNagerecht.Text += $"{duo.Key.Opmerkingen}\n";
                            break;
                        case TUSSENGERECHT:
                            lbl_Voorgerecht.Text += $"{duo.Key.Aantal}x {duo.Key.menuItemID} {duo.Key.menuItemBeschrijving}\n";
                            lbl_opmerkingVoorgerecht.Text += $"{duo.Key.Opmerkingen}\n";
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

            int bestelNummer = int.Parse(lv_Bestellingen.SelectedItems[0].SubItems[1].Text);
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

        //onderstaande methode checkt of het een hoofdgerecht is en zet deze dan klaar
        private void btn_hoofdGerechtKlaarzetten_Click_1(object sender, EventArgs e)
        {
            int bestelNummer = int.Parse(lv_Bestellingen.SelectedItems[0].SubItems[1].Text);
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

        //onderstaande methode checkt of het een nagerecht is en zet deze dan klaar
        private void btn_naGerechtKlaarzetten_Click_1(object sender, EventArgs e)
        {
            int bestelNummer = int.Parse(lv_Bestellingen.SelectedItems[0].SubItems[1].Text);
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

        //onderstaande methode checkt eerst of alle gerecht van een bestelling gereed gemeld zijn, zo ja, dan wordt de hele bestelling op klaar gezet
        private void BestellingGereedCheck(int bestelNummer)
        {
            if (klantenInfo.Count == Counter)
            {
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
            try
            {
                lv_drankjes.SelectedItems[0].BackColor = Color.Red;
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
                lbl_DrinkBestelling.Text = "";
                lbl_opmerkingenDrankjes.Text = "";
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
            lbl_voorGerechtKlaar.Text = "";
            lbl_hoofdGerechtKlaar.Text = "";
            lbl_naGerechtKlaar.Text = "";
            lbl_opmerkingVoorKLAAR.Text = "";
            lbl_opmerkingHoofdKLAAR.Text = "";
            lbl_opmerkingNaKLAAR.Text = "";
            lbl_huidigeBestellingGEREED.Text = "";
            int bestelNummer = int.Parse(lv_klaarstaandebestellingen.SelectedItems[0].SubItems[1].Text);
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
            form.ShowDialog();
        }

        private void openPDAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AanmeldenPDAForm pda = new AanmeldenPDAForm();
            pda.ShowDialog();
        }
    }
}
