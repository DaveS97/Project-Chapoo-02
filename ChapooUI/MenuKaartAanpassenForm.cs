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
using MenuItem = ChapooModel.MenuItem;



namespace ChapooUI
{
    public partial class MenuKaartAanpassenForm : Form
    {
        public MenuKaartAanpassenForm()
        {
            InitializeComponent();
            fillist();
            pnlItemToevoegen.Hide();
            pnlItemAanpassen.Hide();
        }
        private void MaakCollommen()
        {
            lvMenuKaartAanpassen.Columns.Add("omschrijving", 250);
            lvMenuKaartAanpassen.Columns.Add("prijs", 50);
            lvMenuKaartAanpassen.Columns.Add("type gerecht", 50);
            lvMenuKaartAanpassen.Columns.Add("menu kaart", 50);
            lvMenuKaartAanpassen.Columns.Add("ID", 25);
        }
        private void btnOpnieuwLaden_Click(object sender, EventArgs e)
        {
            fillist();
        }
        private void fillist()
        {
            lvMenuKaartAanpassen.Clear();
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
                lvMenuKaartAanpassen.Items.Add(li);
            }
        }
        private void btnItemAanpassen_Click(object sender, EventArgs e)
        {
            if (pnlItemToevoegen.Visible)
            {
                pnlItemToevoegen.Hide();
            }
            pnlItemAanpassen.Show();
        }

        private void btnToevoegen_Click(object sender, EventArgs e)
        {
            if (pnlItemAanpassen.Visible)
            {
                pnlItemAanpassen.Hide();
            }
            pnlItemToevoegen.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                //slaat user data op van wanneer er een item word toegevoegd
                string omschrijving = tbOmschrijving.Text;
                int type = int.Parse(tbType.Text);
                decimal prijs = decimal.Parse(tbPrijs.Text);
                int menu = int.Parse(tbMenu.Text);

                //schrijft user data op in tabel MenuItem
                Voorraad_Service service = new Voorraad_Service();
                service.Write_To_db_toevoegenMenuItem(omschrijving, type, menu, prijs);
                fillist();
                pnlItemToevoegen.Hide();
                MessageBox.Show("item toegevogd");
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void MenuKaartAanpassenForm_Load(object sender, EventArgs e)
        {
            pnlItemAanpassen.Hide();
            pnlItemToevoegen.Hide();
        }

        private void btnOpslaan_Click(object sender, EventArgs e)
        {
            //slaat hier op wanneer een menuitem word aangepast
            try
            {
                string omschrijving = tbomschrijvingitem.Text;
                int type = int.Parse(tbtypeitem.Text);
                decimal prijs = decimal.Parse(tbprijsitem.Text);
                int menu = int.Parse(tbmenukaartitem.Text);
                int ID = int.Parse(lblIDitem.Text);

                Voorraad_Service service = new Voorraad_Service();
                service.Write_To_db_MenuKaart(ID, omschrijving, type, menu, prijs);
                fillist();
                pnlItemAanpassen.Hide();
                MessageBox.Show("item opgeslagen");
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
        private void btnVerwijder_Click(object sender, EventArgs e)
        {
            //verwijderd record uit de tabel menuItems
            int ID = int.Parse(lblIDitem.Text);
            Voorraad_Service service = new Voorraad_Service();
            service.Write_To_db_VerwijderenMenuItem(ID);
            pnlItemToevoegen.Hide();
            fillist();
        }
        private void lvMenuKaartAanpassen_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                lbltitel.Text = lvMenuKaartAanpassen.SelectedItems[0].SubItems[0].Text;
                tbomschrijvingitem.Text = lvMenuKaartAanpassen.SelectedItems[0].SubItems[0].Text;
                tbprijsitem.Text = lvMenuKaartAanpassen.SelectedItems[0].SubItems[1].Text;
                tbtypeitem.Text = lvMenuKaartAanpassen.SelectedItems[0].SubItems[2].Text;
                tbmenukaartitem.Text = lvMenuKaartAanpassen.SelectedItems[0].SubItems[3].Text;
                lblIDitem.Text = lvMenuKaartAanpassen.SelectedItems[0].SubItems[4].Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show("hallo" + ex.Message);
            }
        }
        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        
    }
}
