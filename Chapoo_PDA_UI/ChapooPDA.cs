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
    public partial class ChapooPDA : Form
    {
        public ChapooPDA()
        {
            InitializeComponent();
        }

        private void btnRestaurantOverzicht_Click(object sender, EventArgs e)
        {
            ChapooPDA_RestaurantOverzicht overzicht = new ChapooPDA_RestaurantOverzicht();
            overzicht.ShowDialog();
        }

        private void btnKlaarstaandeBestellingen_Click(object sender, EventArgs e)
        {
            ChapooPDA_KlaarstaandeBestellingenOverzicht overzicht = new ChapooPDA_KlaarstaandeBestellingenOverzicht();
            overzicht.ShowDialog();
        }

        private void btnBestellingOpnemen_Click(object sender, EventArgs e)
        {
            ChapooPDA_BestellingOpnemenMenu menu = new ChapooPDA_BestellingOpnemenMenu();
            menu.ShowDialog();
        }

        private void btnAfrekenen_Click(object sender, EventArgs e)
        {
            ChapooPDA_AfrekenenMenu menu = new ChapooPDA_AfrekenenMenu();
            menu.ShowDialog();
        }

        private void ChapooPDA_Load(object sender, EventArgs e)
        {

        }
    }
}
