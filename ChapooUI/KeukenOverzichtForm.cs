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
            lv_Bestellingen.Columns.Add("Bestelling Id", 50);
            lv_Bestellingen.Columns.Add("Menu item Id", 50);
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
            lbl_Bestelling.Text = "";
            string bestellingNummer = lv_Bestellingen.SelectedItems[0].SubItems[0].Text;
            Dictionary<Bestelling, ChapooModel.MenuItem> menuItems = new Dictionary<Bestelling, ChapooModel.MenuItem>();
            menuItems.Clear();
            //service aanmaken om de beschrijving op te halen
            MenuItem_Service menuItem_Service = new MenuItem_Service();
            menuItems = menuItem_Service.KrijgBeschrijving(bestellingNummer);
            foreach (KeyValuePair<Bestelling, ChapooModel.MenuItem> items in menuItems)
            {
                lbl_Bestelling.Text +=  $"{items.Value.ID} {items.Value.Beschrijving}\n";
            }
        }
    }
}
