using ChapooLogic;
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

namespace Chapoo_PDA_UI
{
    public partial class ChapooPDA_BestellingOpnemenRegistreren : Form
    {
        private int tafelnummer, tafelnummerLabel;
        private int aantal = 1;
        private int minimumAantal = 5;
        private string commentaar = "";
        private string beschrijving = "";
        private List<int> aantallen = new List<int>();
        private List<string> commentaren = new List<string>();
        private ChapooModel.MenuItem item = new ChapooModel.MenuItem();
        private List<ChapooModel.MenuItem> items = new List<ChapooModel.MenuItem>();
        public List<ChapooModel.MenuItem> itemsUitDatabase = new List<ChapooModel.MenuItem>();
        private ChapooModel.Bestelling bestelling = new ChapooModel.Bestelling();
        private int teller = 0;
        private int bedienerID;


        public ChapooPDA_BestellingOpnemenRegistreren(int tafelnummer, int bedienerID)
        {
            this.tafelnummer = tafelnummer;
            tafelnummerLabel = ParseerTafelnummer(tafelnummer);
            this.bedienerID = bedienerID;
            InitializeComponent();
        }

        private void ChapooPDA_BestellingOpnemenRegistreren_Load(object sender, EventArgs e)
        {
            lblTafelnummer.Text = "Tafel " + tafelnummerLabel;
            btnOverzicht.Enabled = false;
            ShowPanelOpnemen();
        }
        private void ShowPanelOpnemen()
        {
            pnlBestellingOpnemen.Show();
            tbAantal.Text = aantal.ToString();
        }

        private void ddMenuItems_DropDown(object sender, EventArgs e)
        {
            MenuItem_Service service = new MenuItem_Service();
            items.Clear();
            ddMenuItems.Items.Clear();
            tbAantal.Text = "1";

            if (rbVoorgerecht.Checked)
            {
                items = service.GetVoorgerechtMenu();
            } else if (rbHoofdgerecht.Checked)
            {
                items = service.GetHoofdgerechtMenu();
            } else if (rbNagerecht.Checked)
            {
                items = service.GetNagerechtMenu();
            } else if (rbDranken.Checked)
            {
                items = service.GetDrinkMenu();
            }
            
            foreach(ChapooModel.MenuItem item in items)
            {
                ddMenuItems.Items.Add(item.ToString());
            }
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            if(aantal < 5)
            {
                aantal++;
                tbAantal.Text = aantal.ToString();
            }
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            if(aantal > 0)
            {
                aantal--;
                tbAantal.Text = aantal.ToString();
            }
        }
        
        private void btnVoegItemToe_Click(object sender, EventArgs e)
        {
            Voorraad_Service service = new Voorraad_Service();
            beschrijving = ddMenuItems.Text;
            aantal = int.Parse(tbAantal.Text);
            aantallen.Add(aantal);
            commentaar = tbCommentaar.Text;
            commentaren.Add(commentaar);
            btnOverzicht.Enabled = true;
            ChapooModel.MenuItem item = GetItem();
            itemsUitDatabase.Add(item);

            Voorraad voorraadItem = service.GetVoorraadVanID(item.ID)[0];

            if(voorraadItem.aantal - aantal <= minimumAantal)
            {
                MessageBox.Show($"Let op! {item.Beschrijving} heeft bijna geen voorraad over! Neem contact op met de voorraadbeheerder.");
            } else if(voorraadItem.aantal - aantal <= 0)
            {
                MessageBox.Show($"{item.Beschrijving} heeft geen voorraad over! Neem contact op met de voorraadbeheerder.");
            }
            MessageBox.Show($"{item.Beschrijving} {commentaar} is {aantal} keer toegevoegd");
            //teller++;
            beschrijving = "";
            aantal = 1;
            commentaar = "";

            ddMenuItems.Text = "";
            tbAantal.Text = aantal.ToString();
            tbCommentaar.Text = "";
        }

        private ChapooModel.MenuItem GetItem()
        {
            MenuItem_Service service = new MenuItem_Service();
            List<ChapooModel.MenuItem> item = service.GetMenuItemForDescription(beschrijving);

            return item[0];
        }

        private void btnOverzicht_Click(object sender, EventArgs e)
        {
            ChapooPDA_BestellingenOpnemenOverzicht overzicht = new ChapooPDA_BestellingenOpnemenOverzicht(itemsUitDatabase, tafelnummer, tafelnummerLabel, aantallen, commentaren, bedienerID);
            overzicht.ShowDialog();
            this.Close();
        }

        private int ParseerTafelnummer(int tafelnummer)
        {
            int n = 0;

            switch (tafelnummer)
            {
                case 1:
                    n = 1;
                    break;
                case 4:
                    n = 2;
                    break;
                case 5:
                    n = 3;
                    break;
                case 6:
                    n = 4;
                    break;
                case 7:
                    n = 5;
                    break;
                case 9:
                    n = 6;
                    break;
                case 10:
                    n = 7;
                    break;
                case 11:
                    n = 8;
                    break;
                case 12:
                    n = 9;
                    break;
                case 13:
                    n = 10;
                    break;
                default: break;
            }
            return n;
        }
    }
}
