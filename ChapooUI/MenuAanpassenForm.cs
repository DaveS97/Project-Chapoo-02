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
using MenuItem = ChapooModel.MenuItem;

namespace ChapooUI
{
    public partial class MenuAanpassenForm : Form
    {
        public MenuAanpassenForm()
        {
            InitializeComponent();
            panel1.Hide();
            vullijst();
        }
       
        private void MaakCollommen()
        {
            lvDranken.Columns.Add("omschrijving", 250);
            lvDranken.Columns.Add("prijs", 50);
            lvDranken.Columns.Add("type gerecht", 50);
            lvDranken.Columns.Add("menu kaart", 50);
            lvDranken.Columns.Add("ID", 25);

        }
        private void vullijst()
        {
            lvDranken.Clear();
            MaakCollommen();
            MenuItem_Service service = new MenuItem_Service();
            List<MenuItem> list = service.GetMenu();
            foreach (MenuItem item in list)
            {
                ListViewItem li = new ListViewItem(item.Beschrijving);
                li.SubItems.Add(item.Prijs.ToString());
                li.SubItems.Add(item.typeGerecht.ToString());
                li.SubItems.Add(item.Menu.ToString());
                li.SubItems.Add(item.ID.ToString());
                lvDranken.Items.Add(li);
            }
        }

        private void terugToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void DrankMenuAanpassenForm_Load(object sender, EventArgs e)
        {

        }

        private void lvDranken_SelectedIndexChanged(object sender, EventArgs e)
        {
            panel1.Show();
            
            lblOmschrijving.Text = lvDranken.SelectedItems[0].SubItems[0].Text;
            tbOmschrijving.Text = lvDranken.SelectedItems[0].SubItems[0].Text;

            tbPrijs.Text = lvDranken.SelectedItems[0].SubItems[1].Text;
            
            tbType.Text = lvDranken.SelectedItems[0].SubItems[2].Text;

            tbMenu.Text = lvDranken.SelectedItems[0].SubItems[3].Text;

            lblID.Text =  lvDranken.SelectedItems[0].SubItems[4].Text;
        }

        private void btnOpslaan_Click(object sender, EventArgs e)
        {
            string omschrijving = tbOmschrijving.Text;
            int type = int.Parse(tbType.Text);
            decimal prijs = decimal.Parse(tbPrijs.Text);
            int menu = int.Parse(tbMenu.Text);
            int ID = int.Parse(lblID.Text);

            Voorraad_Service service = new Voorraad_Service();
            service.Write_To_db_MenuKaart(ID, omschrijving, type, menu, prijs);
            panel1.Hide();
        }

        private void btnVerwijder_Click(object sender, EventArgs e)
        {
            int ID = int.Parse(lblID.Text);
            Voorraad_Service service = new Voorraad_Service();
            service.Write_To_db_VerwijderenMenuItem(ID);
            panel1.Hide();
            vullijst();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            vullijst();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
