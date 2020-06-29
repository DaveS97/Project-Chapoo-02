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
            pnlToevoegen.Hide();
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
                string type = "";
                switch (werknemer.Type) // 1=  bediener 2= barman  3= kok  4= eigenaar
                {
                    case 1:
                        type = "bediener";
                        break;
                    case 2:
                        type = "barman";
                        break;
                    case 3:
                        type = "kok";
                        break;
                    case 4:
                        type = "eigenaar";
                        break;
                    default:
                        MessageBox.Show("error");
                        break;
                }
                ListViewItem li = new ListViewItem(werknemer.Naam.ToString());
                li.SubItems.Add(werknemer.ID.ToString());
                li.SubItems.Add(type);
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
        private void btnOpslaan_Click(object sender, EventArgs e)
        {
            int PIN = 0;
            int ID = 0;
            string naam = "";
            try
            {
                PIN = int.Parse(tbPinAanpassenWerknemer.Text);
                ID = int.Parse(lblID.Text);
                naam = tbNaam.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show("je moet eerst de geldige waarden invoeren " + ex.Message);
            }
            Werknemer_Service service = new Werknemer_Service();
            service.AanpassenWerknemer(ID, naam, PIN);
            tbPinAanpassenWerknemer.Clear();
            panel1.Hide();
            WerknemersVullen();
            MessageBox.Show("opgeslagen");
        }

        private void btnVerwijder_Click(object sender, EventArgs e)
        {
            //verwijderd werknemer uit werknemers
            int ID = int.Parse(lblID.Text);
            Werknemer_Service service = new Werknemer_Service();
            service.Write_to_db_verwijderenWerknemer(ID);
            MessageBox.Show("werknemer word verwijderd");
            WerknemersVullen();
            panel1.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lv_Werknemers.Clear();
            WerknemersVullen();
        }

        private void lv_Werknemers_SelectedIndexChanged(object sender, EventArgs e)
        {
            //vult items vanuit tabel naar pannel. 
            panel1.Show();
            pnlToevoegen.Hide();
            try
            {
                tbNaam.Text = lv_Werknemers.SelectedItems[0].SubItems[0].Text;
                lblID.Text = lv_Werknemers.SelectedItems[0].SubItems[1].Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnWerknemerToevoegen_Click(object sender, EventArgs e)
        {
            panel1.Hide();
            pnlToevoegen.Show();
        }

        private void btnVoegToe_Click(object sender, EventArgs e)
        {
            //schrijft hier naar de database tabel werkenemers, en voegt een werknemer toe
            Werknemer_Service service = new Werknemer_Service();
            string naam = tbNaamToevoegen.Text;
            string type = tbTypeToevoegen.Text;
            int pin = int.Parse(tbPinToevoegen.Text);
            bool actief = cbIs_Actief.Checked;

            int werknemertype = 0;
            switch (type) // 1=  bediener 2= barman  3= kok  4= eigenaar
            {
                case "bediener":
                    werknemertype = 1;
                    break;
                case "barman":
                    werknemertype = 2;
                    break;
                case "kok":
                    werknemertype = 3;
                    break;
                case "eigenaar":
                    werknemertype = 4;
                    break;
                default:
                    MessageBox.Show("error");
                    break;
            }
            service.Write_To_db_ToevoegenWerknemer(werknemertype, naam, pin, actief);
            pnlToevoegen.Hide();
            WerknemersVullen();
        }

        private void cbIs_Actief_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void HomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Chapoo chapoo = Chapoo.GetInstance();
            this.Close();
            chapoo.Show();
        }
    }
}
