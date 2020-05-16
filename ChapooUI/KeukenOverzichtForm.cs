using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChapooUI
{
    public partial class KeukenOverzichtForm : Form
    {
        public KeukenOverzichtForm()
        {
            InitializeComponent();

            //HIER WORDT DE LV_Bestellingen GEVULD
            //bestelling service aanmaken 
            ChapooLogic.Werknemer_Service werknemer_service = new ChapooLogic.Werknemer_Service();
            List<Werknemer> werknemers = werknemer_service.KrijgWerknemers();
            //leeg de kolommen eerst voordat je ze weer vult
            lv_Werknemers.Clear();
            //maak kolommen
            lv_Werknemers.Columns.Add("Werknemer Nummer", 50);
            lv_Werknemers.Columns.Add("Type werknemer", 50);
            lv_Werknemers.Columns.Add("Naam", 100);
            //vul de listview
            foreach (Werknemer werknemer in werknemers)
            {
                ListViewItem li = new ListViewItem(werknemer.ID.ToString());
                li.SubItems.Add(werknemer.Type.ToString());
                li.SubItems.Add(werknemer.Naam.ToString());
                lv_Werknemers.Items.Add(li);
            }

        }
    }
}
