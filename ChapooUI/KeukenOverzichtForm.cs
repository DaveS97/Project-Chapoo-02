using ChapooModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChapooLogic;
using System.Security.Permissions;

namespace ChapooUI
{
    public partial class KeukenOverzichtForm : Form
    {
        public KeukenOverzichtForm()
        {
            InitializeComponent();
            BestellingenVullen();
        }
        private void BestellingenVullen()
        {
            //HIER WORDT DE LV_Bestellingen GEVULD
            //bestelling service aanmaken 
            ChapooLogic.Bevat_Service bevat_Service = new ChapooLogic.Bevat_Service();
            List<Bevat> ids = bevat_Service.KrijgBestellingEnMenuItemID();
            //leeg de kolommen eerst voordat je ze weer vult
            lv_Bestellingen.Clear();
            //maak kolommen
            lv_Bestellingen.Columns.Add("Bestelling Id", 100);
            lv_Bestellingen.Columns.Add("Menu item Id", 100);
            //vul de listview
            foreach (Bevat id in ids)
            {
                ListViewItem li = new ListViewItem(id.bestellingID.ToString());
                li.SubItems.Add(id.menuItemID.ToString());
                lv_Bestellingen.Items.Add(li);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lbl_Voorgerecht.Text = "";
            lbl_Hoofdgerecht.Text = "";
            lbl_Nagerecht.Text = "";
            lbl_HuidigeBestelling.Text = "";
            string bestellingNummer = lv_Bestellingen.SelectedItems[0].SubItems[0].Text;
            lbl_HuidigeBestelling.Text = $"Bestelling: {bestellingNummer}";
            List<ChapooModel.MenuItem> menuItems = new List<ChapooModel.MenuItem>();
            menuItems.Clear();
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
    }
}
