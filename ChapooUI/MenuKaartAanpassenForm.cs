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
            panel1.Hide();
        }
        private void MaakCollommen()
        {
            lvDrank.Columns.Add("omschrijving", 250);
            lvDrank.Columns.Add("prijs", 50);
            lvDrank.Columns.Add("type gerecht", 50);
            lvDrank.Columns.Add("menu kaart", 50);
            lvDrank.Columns.Add("ID", 25);
        }
        private void fillist()
        {
            lvDrank.Clear();
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
                lvDrank.Items.Add(li);
            }
        }
        private void btnDrankOphalen_Click(object sender, EventArgs e)
        {
            fillist();
        }
        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenuAanpassenForm from = new MenuAanpassenForm();
            from.ShowDialog();
        }

        private void btnToevoegen_Click(object sender, EventArgs e)
        {
            panel1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string omschrijving = tbOmschrijving.Text;
            int type = int.Parse(tbType.Text);
            decimal prijs = decimal.Parse(tbPrijs.Text);
            int menu = int.Parse(tbMenu.Text);

            Voorraad_Service service = new Voorraad_Service();
            service.Write_To_db_toevoegenMenuItem(omschrijving, type, menu, prijs);
            fillist();
            panel1.Hide();
        }
    }
}
