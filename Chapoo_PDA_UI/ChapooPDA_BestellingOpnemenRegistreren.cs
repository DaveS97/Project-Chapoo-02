using ChapooLogic;
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
        private int tafelnummer;
        private int aantal = 1;
        private string commentaar = "";
        private List<ChapooModel.MenuItem> items = new List<ChapooModel.MenuItem>();

        public ChapooPDA_BestellingOpnemenRegistreren(int tafelnummer)
        {
            this.tafelnummer = tafelnummer;
            InitializeComponent();
        }

        private void ChapooPDA_BestellingOpnemenRegistreren_Load(object sender, EventArgs e)
        {
            ShowPanelOpnemen();
        }

        private void ShowPanelOpnemen()
        {
            pnlBestellingOpnemen.Show();
            lblTafelnummer.Text = "Tafel " + tafelnummer;
            tbAantal.Text = aantal.ToString();
        }

        private void ddMenuItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void ddMenuItems_DropDown(object sender, EventArgs e)
        {
            MenuItem_Service service = new MenuItem_Service();
            items.Clear();
            ddMenuItems.Items.Clear();

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

        }
    }
}
