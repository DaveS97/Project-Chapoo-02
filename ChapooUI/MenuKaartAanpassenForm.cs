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
        }
        private void MaakCollommen()
        {
            lvDrank.Columns.Add("omschrijving", 150);
            lvDrank.Columns.Add("prijs", 50);
            lvDrank.Columns.Add("type gerecht", 50);
        }
        private void VULDranken()
        {
            lvDrank.Clear();
            MaakCollommen();
            MenuItem_Service service = new MenuItem_Service();
            List<MenuItem> list = service.GetDrinkMenu();
            foreach (MenuItem item in list)
            {
                ListViewItem li = new ListViewItem(item.Beschrijving);
                li.SubItems.Add(item.Prijs.ToString());
                li.SubItems.Add(item.typeGerecht.ToString());
                lvDrank.Items.Add(li);
            }
        }
        private void VULLUNCH()
        {
            lvLunch.Clear();

            lvLunch.Columns.Add("omschrijving", 200);
            lvLunch.Columns.Add("prijs", 50);
            lvLunch.Columns.Add("type gerecht", 50);

            MenuItem_Service service = new MenuItem_Service();
            List<MenuItem> list = service.GetLunchMenu();
            foreach (MenuItem item in list)
            {
                ListViewItem li = new ListViewItem(item.Beschrijving);
                li.SubItems.Add(item.Prijs.ToString());
                li.SubItems.Add(item.typeGerecht.ToString());
                lvLunch.Items.Add(li);
            }
        }
        private void VULDINNER()
        {
            lvDinner.Clear();

            lvDinner.Columns.Add("omschrijving", 200);
            lvDinner.Columns.Add("prijs", 50);
            lvDinner.Columns.Add("type gerecht", 50);

            MenuItem_Service service = new MenuItem_Service();
            List<MenuItem> list = service.GetDinnerMenu();
            foreach (MenuItem item in list)
            {
                ListViewItem li = new ListViewItem(item.Beschrijving);
                li.SubItems.Add(item.Prijs.ToString());
                li.SubItems.Add(item.typeGerecht.ToString());
                lvDinner.Items.Add(li);
            }
        }
        private void MenuKaartAanpassenForm_Load(object sender, EventArgs e)
        {

        }

        private void btnDrankOphalen_Click(object sender, EventArgs e)
        {
            VULDranken();
        }

        private void btnLunchOphalen_Click(object sender, EventArgs e)
        {
            VULLUNCH();
        }

        private void btnDinnerOphalen_Click(object sender, EventArgs e)
        {
            VULDINNER();
        }

       

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DrankMenuAanpassenForm from = new DrankMenuAanpassenForm();
            from.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
