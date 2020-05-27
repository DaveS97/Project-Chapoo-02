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
        }
    }
}
