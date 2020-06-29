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
            Hide();
            werknemersForm.ShowDialog();
            
            //als we nog een form hiervan moeten aanmaken, kunnen we de singlepattern misschien toepassen
        }

        private void MS_KO_Click(object sender, EventArgs e)
        {
            //singleton patern toegepast
            KeukenOverzichtForm keukenOverzicht = KeukenOverzichtForm.GetInstance();
            Hide();
            keukenOverzicht.ShowDialog();
        }

        private void MS1I_Inkomsten_Click(object sender, EventArgs e)
        {
            InkomstenForm inkomsten = new InkomstenForm();
            Hide();
            inkomsten.ShowDialog();
        }

        private void MS1I_Voorraad_Click(object sender, EventArgs e)
        {
            VoorraadForm voorraad = new VoorraadForm();
            Hide();
            voorraad.ShowDialog();
        }

        private void MS1I_MenuKaartOpties_Click(object sender, EventArgs e)
        {
            MenuKaartAanpassenForm from = new MenuKaartAanpassenForm();
            Hide();
            from.ShowDialog();
        }

       

        private void afmeldenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AfmeldenForm form = new AfmeldenForm();
            Hide();
            form.ShowDialog();
        }

        private void openPDAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AanmeldenPDAForm pda = new AanmeldenPDAForm();
            Hide();
            pda.ShowDialog();
        }


        private void MS_BO_Click(object sender, EventArgs e)
        {
            KeukenOverzichtForm keukenOverzicht = KeukenOverzichtForm.GetInstance();
            Hide();
            keukenOverzicht.OpenBarOverzicht();
            keukenOverzicht.ShowDialog();
            
        }

        private void MS_RO_Click(object sender, EventArgs e)
        {
            RestaurantOverzichtForm form = new RestaurantOverzichtForm();
            form.Show();
            this.Hide();
        }
    }
}
