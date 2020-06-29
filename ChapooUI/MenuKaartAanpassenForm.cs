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
            lvMenuKaartAanpassen.Columns.Add("prijs", 40);
            lvMenuKaartAanpassen.Columns.Add("type gerecht", 75);
            lvMenuKaartAanpassen.Columns.Add("menu kaart", 75);
            lvMenuKaartAanpassen.Columns.Add("ID", 20);
        }
        private void btnOpnieuwLaden_Click(object sender, EventArgs e)
        {
            fillist();
        }
        string FormatMenu(MenuItem menuItem)
        {
            //1 = lunch 2 = dinner 3 = drank
            string format = "";
            switch (menuItem.Menu)
            {
                case 1:
                    format = "lunch";
                    break;
                case 2:
                    format = "dinner";
                    break;
                case 3:
                    format = "dranken";
                    break;
                default:
                    MessageBox.Show("error");
                    break;
            }
            return format;
        }
        string FormatType(MenuItem menuItem)
        {
            //1 = voorgerecht, 2 = hoofdgerecht, 3 = nagerecht, 4 = tussengerecht en 5 = drinken
            string format = "";
            switch (menuItem.typeGerecht)
            {
                case 1:
                    format = "voorgerecht";
                    break;
                case 2:
                    format = "hoofdgerecht";
                    break;
                case 3:
                    format = "nagerecht";
                    break;
                case 4:
                    format = "tussengerecht";
                    break;
                case 5:
                    format = "drinken";
                    break;
                default:
                    MessageBox.Show("error");
                    break;
            }
            return format;
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

                string formatType = FormatType(item);
                li.SubItems.Add(formatType);

                string formatMenu = FormatMenu(item);
                li.SubItems.Add(formatMenu);

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
                string type = tbType.Text;
                decimal prijs = decimal.Parse(tbPrijs.Text);
                string menu = tbMenu.Text;
                bool isAlcoholisch = cbIsalcoholisch.Checked;

                int typegerecht = 0;
                int menukaart = 0;
                switch (type)
                {
                    case "voorgerecht":
                        typegerecht = 1;
                        break;
                    case "hoofdgerecht":
                        typegerecht = 2;
                        break;
                    case "nagerecht":
                        typegerecht = 3;
                        break;
                    case "tussengerecht":
                        typegerecht = 4;
                        break;
                    case "drinken":
                        typegerecht = 5;
                        break;
                    default:
                        MessageBox.Show("error");
                        break;
                }
                switch (menu)
                {
                    case "lunch":
                        menukaart = 1;
                        break;
                    case "dinner":
                        menukaart = 2;
                        break;
                    case "dranken":
                        menukaart = 3;
                        break;
                    default:
                        MessageBox.Show("error");
                        break;
                }

                //schrijft user data op in tabel MenuItem
                Voorraad_Service service = new Voorraad_Service();
                service.Write_To_db_toevoegenMenuItem(omschrijving, typegerecht, menukaart, prijs, isAlcoholisch);
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
                string type = tbtypeitem.Text;
                decimal prijs = decimal.Parse(tbprijsitem.Text);
                string menu = tbmenukaartitem.Text;
                int ID = int.Parse(lblIDitem.Text);

                int typegerecht = 0;
                int menukaart = 0;
                switch (type)
                {
                    case "voorgerecht":
                        typegerecht = 1;
                        break;
                    case "hoofdgerecht":
                        typegerecht = 2;
                        break;
                    case "nagerecht":
                        typegerecht = 3;
                        break;
                    case "tussengerecht":
                        typegerecht = 4;
                        break;
                    case "drinken":
                        typegerecht = 5;
                        break;
                    default:
                        MessageBox.Show("error");
                        break;
                }
                switch (menu)
                {
                    case "lunch":
                        menukaart = 1;
                        break;
                    case "dinner":
                        menukaart = 2;
                        break;
                    case "dranken":
                        menukaart = 3;
                        break;
                    default:
                        MessageBox.Show("error");
                        break;
                }

                Voorraad_Service service = new Voorraad_Service();
                service.Write_To_db_MenuKaart(ID, omschrijving, typegerecht, menukaart, prijs);
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
            Chapoo chapoo = Chapoo.GetInstance();
            Hide();
            chapoo.Show();
        }


    }
}
