using ChapooModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChapooLogic;
using System.Threading;

namespace ChapooUI
{
    
    public partial class KeukenOverzichtForm : Form
    {
        const int VOORGERECHT = 1;
        const int HOOFDGERECHT = 2;
        const int NAGERECHT = 3;
        const int TUSSENGERECHT = 4;
        const int DRINKEN = 5;
        private List<ChapooModel.MenuItem> menuItems;
        private List<ChapooModel.MenuItem> klaargezetteBestellingen;

        public KeukenOverzichtForm()
        {
            menuItems = new List<ChapooModel.MenuItem>();
            klaargezetteBestellingen = new List<ChapooModel.MenuItem>();
            InitializeComponent();
            BestellingenVullen();
        }
        
        private void BestellingenVullen()
        {
            //HIER WORDT DE LV_Bestellingen GEVULD
            //bestelling service aanmaken 
            ChapooLogic.Bevat_Service bevat_Service = new ChapooLogic.Bevat_Service();
            Dictionary<Bevat, Klant> ids = bevat_Service.KrijgBestellingEnMenuItemID();
            //leeg de kolommen eerst voordat je ze weer vult
            lv_Bestellingen.Clear();
            //maak kolommen
            lv_Bestellingen.Columns.Add("Bestelling Id", 100);
            lv_Bestellingen.Columns.Add("Menu item Id", 100);
            lv_Bestellingen.Columns.Add("Tafel Id", 75);
            //vul de listview
            foreach (KeyValuePair<Bevat, Klant> pair in ids)
            {
                ListViewItem li = new ListViewItem(pair.Key.bestellingID.ToString());
                li.SubItems.Add(pair.Key.menuItemID.ToString());
                li.SubItems.Add(pair.Value.tafelID.ToString());
                lv_Bestellingen.Items.Add(li);
            }
        }

        private void btn_toonBestelling_Click(object sender, EventArgs e)
        {
            lbl_Voorgerecht.Text = "";
            lbl_Hoofdgerecht.Text = "";
            lbl_Nagerecht.Text = "";
            lbl_HuidigeBestelling.Text = "";
            menuItems.Clear();
            string bestellingNummer = lv_Bestellingen.SelectedItems[0].SubItems[0].Text;
            lbl_HuidigeBestelling.Text = $"Bestelling: {bestellingNummer}";
            //service aanmaken om de beschrijving op te halen
            MenuItem_Service menuItem_Service = new MenuItem_Service();
            menuItems = menuItem_Service.KrijgBeschrijving(bestellingNummer);
            foreach (ChapooModel.MenuItem item in menuItems)
            {
                switch (item.typeGerecht)
                {
                    case 1:
                        lbl_Voorgerecht.Text +=  $"{item.ID} {item.Beschrijving}\n";                        
                        break;
                    case 2:
                        lbl_Hoofdgerecht.Text += $"{item.ID} {item.Beschrijving}\n";
                        break;
                    case 3:
                        lbl_Nagerecht.Text += $"{item.ID} {item.Beschrijving}\n";
                        break;
                    case 4:
                        lbl_Voorgerecht.Text += $"{item.ID} {item.Beschrijving}\n";
                        break;
                }
            } 
        }

        private void btn_voorGerechtKlaarzetten_Click(object sender, EventArgs e)
        {
            foreach (ChapooModel.MenuItem item in menuItems)
            {
                if (item.typeGerecht == VOORGERECHT || item.typeGerecht == TUSSENGERECHT)
                {
                    klaargezetteBestellingen.Add(item);
                    lbl_Voorgerecht.Text = "";
                }
            }
            lv_Bestellingen.SelectedItems.Clear();
        }

        private void btn_hoofdGerechtKlaarzetten_Click(object sender, EventArgs e)
        {
            foreach (ChapooModel.MenuItem item in menuItems)
            {
                if (item.typeGerecht == HOOFDGERECHT)
                {
                    klaargezetteBestellingen.Add(item);
                    lbl_Hoofdgerecht.Text = "";
                }
            } 
        }

        private void btn_naGerechtKlaarzetten_Click(object sender, EventArgs e)
        {
            foreach (ChapooModel.MenuItem item in menuItems)
            {
                if (item.typeGerecht == NAGERECHT)
                {
                    klaargezetteBestellingen.Add(item);
                    lbl_Nagerecht.Text = "";
                }
            }
        }

        private void barOverzichtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowPanel("baroverzicht");
        }

        private void ShowPanel(string panelName)
        {
            if (panelName == "baroverzicht")
            {
                //panel.show
                //alle klaarstaande bestellingen in een listview opnemen
                //DICT met daarin een bevat en misschien klant.
            }
        }
    }
}
