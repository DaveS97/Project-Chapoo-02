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
using Chapoo_PDA_UI;

namespace ChapooUI
{
    public partial class Chapoo : Form
    {
        private Chapoo()
        {
            InitializeComponent();
        }
        private static Chapoo Instance;
        public static Chapoo GetInstance()
        {
            if (Instance == null)
            {
                Instance = new Chapoo();
            }
            return Instance;
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
            //singleton patern toegepast
            KeukenOverzichtForm keukenOverzicht = KeukenOverzichtForm.GetInstance();
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

        private void MS1I_MenuKaartOpties_Click(object sender, EventArgs e)
        {
            MenuKaartAanpassenForm from = new MenuKaartAanpassenForm();
            from.ShowDialog();
        }

        private void itemAanpassenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuAanpassenForm form = new MenuAanpassenForm();
            form.ShowDialog();
        }

        private void afmeldenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AfmeldenForm form = new AfmeldenForm();
            form.ShowDialog();
        }

        private void openPDAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AanmeldenPDAForm pda = new AanmeldenPDAForm();
            pda.ShowDialog();
        }

        private void Chapoo_Load(object sender, EventArgs e)
        {

        }

        private void MS_BO_Click(object sender, EventArgs e)
        {
            KeukenOverzichtForm keukenOverzicht = KeukenOverzichtForm.GetInstance();
            keukenOverzicht.OpenBarOverzicht();
            keukenOverzicht.ShowDialog();
            
        }
    }
}
