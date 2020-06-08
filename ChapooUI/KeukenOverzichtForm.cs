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

namespace ChapooUI
{

    public partial class KeukenOverzichtForm : Form
    {
        const int VOORGERECHT = 1;
        const int HOOFDGERECHT = 2;
        const int NAGERECHT = 3;
        const int TUSSENGERECHT = 4;
        const int DRINKEN = 5;
        private Dictionary<Bevat, Klant> klantenInfo;
        private Dictionary<Bevat, Klant> klantenInfoGereedPanel;
        private Dictionary<Bevat, Klant> klaargezetteBestellingen;
        private Dictionary<Bevat, Klant> ids = new Dictionary<Bevat, Klant>();
        private List<Klant> klanten = new List<Klant>();
        private List<Bevat> bestellingen = new List<Bevat>();

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
            InitializeComponent();
            BestellingenVullen();
        }

        private void BestellingenVullen()
        {
            pnl_klaarstaandeBestellingen.Hide();
            //HIER WORDT DE LV_Bestellingen GEVULD
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

        private void btn_toonBestelling_Click(object sender, EventArgs e)
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

        private void btn_voorGerechtKlaarzetten_Click(object sender, EventArgs e)
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
                {
                    ids.Remove(bestellingen[i]);
                }
            }
        }

        private void btn_hoofdGerechtKlaarzetten_Click(object sender, EventArgs e)
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
                {
                    ids.Remove(bestellingen[i]);
                }
            }
        }

        private void btn_naGerechtKlaarzetten_Click(object sender, EventArgs e)
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
                {
                    ids.Remove(bestellingen[i]);
                }
            }
        }

        private void barOverzichtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowPanel("baroverzicht");
        }

        private void btn_filterNaarGereed_Click(object sender, EventArgs e)
        {
            ShowPanel("bestellingenGereed");
        }
        private void btn_naarBestellingenOpenstaand_Click(object sender, EventArgs e)
        {
            pnl_klaarstaandeBestellingen.Hide();
        }

        private void ShowPanel(string panelName)
        {
            if (panelName == "baroverzicht")
            {
                //panel.show
                //
            }
            else if (panelName == "bestellingenGereed")
            {
                //verberg alle andere panelen
                //pnl_barOverzicht.Hide();

                //toon de juiste panel
                pnl_klaarstaandeBestellingen.Show();
                //alle klaarstaande bestellingen in een listview opnemen
                //DICT met daarin een bevat en misschien klant.
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
        }

        private void btn_toonBestellingGereedPanel_Click(object sender, EventArgs e)
        {
            //eerst alle labels en de lijst leegmaken
            lbl_voorGerechtKlaar.Text = "";
            lbl_hoofdGerechtKlaar.Text = "";
            lbl_naGerechtKlaar.Text = "";
            lbl_huidigeBestellingKlaar.Text = "";
            klantenInfoGereedPanel.Clear();
            //bestellings nummer ophalen
            string bestellingNummer = lv_klaarstaandebestellingen.SelectedItems[0].SubItems[0].Text;
            lbl_HuidigeBestelling.Text = $"Bestelling: {bestellingNummer}";
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


        private void btn_herlaadBestellingen_Click_1(object sender, EventArgs e)
        {
            lv_Bestellingen.Refresh();
        }

        private void KeukenOverzichtForm_Load(object sender, EventArgs e)
        {

        }
    }
}
