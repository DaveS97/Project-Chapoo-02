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
    public partial class ChapooPDA_BestellingOpnemenMenu : Form
    {
        private int tafelnummer;

        private int ID;
        public ChapooPDA_BestellingOpnemenMenu(int ID)
        {
            InitializeComponent();
            this.ID = ID;
        }

        private void tbTafelnummerBestellingOpnemen_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnNaarBestelling_Click(object sender, EventArgs e)
        {
            try
            {
                tafelnummer = int.Parse(tbTafelnummerBestellingOpnemen.Text);

                if (tafelnummer != 2 || tafelnummer != 3 || tafelnummer != 8 || tafelnummer >= 0 || tafelnummer <= 14)
                {
                    ChapooPDA_BestellingOpnemenRegistreren registreren = new ChapooPDA_BestellingOpnemenRegistreren(tafelnummer);
                    Close();
                    registreren.ShowDialog();
                } else throw new FormatException();  
            }
            catch (FormatException)
            {
                MessageBox.Show("Geen tafelnummer of een foutief tafelnummer ingevoerd");
            }
        }
    }
}
