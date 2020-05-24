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
    public partial class ChapooPDA_AfrekenenMenu : Form
    {
        private int tafelnummer;

        public ChapooPDA_AfrekenenMenu()
        {
            InitializeComponent();
        }

        private void btnPresenteerRekening_Click(object sender, EventArgs e)
        {
            tafelnummer = int.Parse(lblTafelnummer.Text);
        }
    }
}
