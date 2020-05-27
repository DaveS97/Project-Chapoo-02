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
using ChapooDAL;
using ChapooLogic;


namespace ChapooUI
{
    public partial class WerknemersForm : Form
    {
        public WerknemersForm()
        {
            InitializeComponent();
            panel1.Hide();
            WerknemersVullen();

        }
            
        private void WerknemersVullen()
        {
            //HIER WORDT DE LV_WERKNEMERS GEVULD
            //werknemer service aanmaken 
            ChapooLogic.Werknemer_Service werknemer_service = new ChapooLogic.Werknemer_Service();
            List<Werknemer> werknemers = werknemer_service.KrijgWerknemers();
            //leeg de kolommen eerst voordat je ze weer vult
            lv_Werknemers.Clear();
            //maak kolommen
            lv_Werknemers.Columns.Add("Naam", 150);
            lv_Werknemers.Columns.Add("Werknemer Nummer", 100);
            lv_Werknemers.Columns.Add("Type werknemer", 100);


            //vul de listview
            foreach (Werknemer werknemer in werknemers)
            {
                ListViewItem li = new ListViewItem(werknemer.Naam.ToString());
                li.SubItems.Add(werknemer.ID.ToString());
                li.SubItems.Add(werknemer.Type.ToString());
                lv_Werknemers.Items.Add(li);
            }
        }
        private void mts_HomeWerknemersForm_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void WerknemersForm_Load(object sender, EventArgs e)
        {

        }

        private void btnAanpassen_Click(object sender, EventArgs e)
        {
            tbNaam.Text = lv_Werknemers.SelectedItems[0].SubItems[0].Text;
            lblID.Text = lv_Werknemers.SelectedItems[0].SubItems[1].Text;
        }
        private void btnOpslaan_Click(object sender, EventArgs e)
        {
            int ID = int.Parse(lblID.Text);
            string naam = tbNaam.Text;

            Werknemer_Service service = new Werknemer_Service();
            service.AanpassenWerknemer(ID, naam);
            panel1.Hide();
        }

        private void btnVerwijder_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            lv_Werknemers.Clear();
            WerknemersVullen();
        }

        private void lv_Werknemers_SelectedIndexChanged(object sender, EventArgs e)
        {
            panel1.Show();
        }
    }
}
