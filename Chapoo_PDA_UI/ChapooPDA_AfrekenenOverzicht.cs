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
    public partial class ChapooPDA_AfrekenenOverzicht : Form
    {
        private int tafelnummer;

        public ChapooPDA_AfrekenenOverzicht(int tafelnummer)
        {
            this.tafelnummer = tafelnummer;
            InitializeComponent();
        }

        private void ChapooPDA_AfrekenenOverzicht_Load(object sender, EventArgs e)
        {
            ToonRekening();
        }

        private void ToonRekening()
        {
            pnlAfrekenenOverzicht.Show();
            pnlAfrekenenOverzicht.BringToFront();

            //ChapooLogic.RekeningService rekeningService = new ChapooLogic.RekeningService();
            
        }

        private void btnVerstuurRekening_Click(object sender, EventArgs e)
        {

        }

        private void lvRekeningOverzicht_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbl_Betalingswijze_Click(object sender, EventArgs e)
        {

        }
    }
}
