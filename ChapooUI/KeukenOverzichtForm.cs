using ChapooModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChapooLogic;

namespace ChapooUI
{
    public partial class KeukenOverzichtForm : Form
    {
        public KeukenOverzichtForm()
        {
            InitializeComponent();

            //HIER WORDT DE LV_Bestellingen GEVULD
            //bestelling service aanmaken 
            ChapooLogic.Bestelling_Service bestelling_Service = new ChapooLogic.Bestelling_Service();
            List<Bestelling> bestellingen = bestelling_Service.KrijgBestellingen();
            //leeg de kolommen eerst voordat je ze weer vult
            lv_Bestellingen.Clear();
            //maak kolommen
            lv_Bestellingen.Columns.Add("Bestelling Id", 50);
            lv_Bestellingen.Columns.Add("Menu item Id", 50);
            //vul de listview
            foreach (Bestelling bestelling in bestellingen)
            {
                ListViewItem li = new ListViewItem(bestelling.bestellingID.ToString());
                li.SubItems.Add(bestelling.bedienerID.ToString());
                lv_Bestellingen.Items.Add(li);
            }



            //HIER WORDT DE BESTELLING BESCHRIJVING TOEGEVOEGD
            //eerst de label legen.
            lbl_Bestelling.Text = "";
            //service aanmaken om de beschrijving op te halen
            
        }
    }
}
