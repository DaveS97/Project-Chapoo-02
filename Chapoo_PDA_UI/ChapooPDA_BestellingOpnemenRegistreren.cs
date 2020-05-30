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
            MenuItem_Service service = new MenuItem_Service();
            List<ChapooModel.MenuItem> items = new List<ChapooModel.MenuItem>();

            if (rbDranken.Checked)
            {
                items = service.GetDrinkMenu();
            } else if (rbHoofdgerecht.Checked)
            {
                items = service.GetDinnerMenu();
            } else if (rbNagerecht.Checked)
            {
                items = service.GetLunchMenu();
            }
        }
    }
}
