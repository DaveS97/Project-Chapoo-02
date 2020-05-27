using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChapooModel;

namespace ChapooUI
{
    public partial class Chapoo : Form
    {
        public Chapoo()
        {
            InitializeComponent();
        }
        private void MS1I_Home_Click(object sender, EventArgs e) { Show(); }

        private void MS1I_Werknemers_Click(object sender, EventArgs e)
        {
            WerknemersForm werknemersForm = new WerknemersForm();
            werknemersForm.ShowDialog();
            
            //als we nog een form hiervan moeten aanmaken, kunnen we de singlepattern misschien toepassen
        }

        private void MS_KO_Click(object sender, EventArgs e)
        {
            KeukenOverzichtForm keukenOverzicht = new KeukenOverzichtForm();
            keukenOverzicht.ShowDialog();
        }

        private void MS1I_Inkomsten_Click(object sender, EventArgs e)
        {
            InkomstenForm inkomsten = new InkomstenForm();
            inkomsten.ShowDialog();
        }

        private void MS1I_Voorraad_Click(object sender, EventArgs e)
        {
            VoorraadForm voorraad = new VoorraadForm();
            voorraad.ShowDialog();
        }

        private void Chapoo_Load(object sender, EventArgs e)
        {

        }

        private void HomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void MS1I_MenuKaartOpties_Click(object sender, EventArgs e)
        {
            MenuKaartAanpassenForm from = new MenuKaartAanpassenForm();
            from.ShowDialog();
        }
    }
}
