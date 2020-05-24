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
using ChapooModel;
using MenuItem2 = ChapooModel.MenuItem2;
using ChapooUI;

namespace ChapooUI
{
    public partial class VoorraadForm : Form
    {
        public VoorraadForm()
        {
            InitializeComponent();
            pnlVoorraad.Hide();
        }
       
        private void lvVoorraad_SelectedIndexChanged(object sender, EventArgs e)
        {
            pnlVoorraad.Show();
            MenuItem2_Service service = new MenuItem2_Service();
            List<MenuItem2> items = service.GetMenuItems();
            foreach (MenuItem2 item in items)
            {

            }
        }
        private void keukenOverzichtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KeukenOverzichtForm from = new KeukenOverzichtForm();
            from.ShowDialog();
        }
        private void MaakCollommen()
        {
            lvVoorraad.Columns.Add("omschrijving", 200);
            lvVoorraad.Columns.Add("ID", 50);
            lvVoorraad.Columns.Add("prijs", 50);
            lvVoorraad.Columns.Add("aantal", 50);
            lvVoorraad.Columns.Add("menu kaart", 50);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            MenuItem2_Service service = new MenuItem2_Service();
            if (RBLunch.Checked)
            {
                lvVoorraad.Clear();
                MaakCollommen();
                List<MenuItem2> lunchItems = service.GetLunchMenu();

                foreach (MenuItem2 menuItem in lunchItems)
                {
                    ListViewItem li = new ListViewItem(menuItem.ItemNaam);
                    li.SubItems.Add(menuItem.ID.ToString());
                    li.SubItems.Add(menuItem.Prijs.ToString());
                    li.SubItems.Add(menuItem.Aantal.ToString());
                    li.SubItems.Add(menuItem.menu.ToString());
                    lvVoorraad.Items.Add(li);
                }
            }
            else if (RBDinner.Checked)
            {
                lvVoorraad.Clear();
                MaakCollommen();
                List<MenuItem2> dinnerItems = service.GetDinnerMenu();
                foreach (MenuItem2 menuItem in dinnerItems)
                {
                    ListViewItem li = new ListViewItem(menuItem.ItemNaam);
                    li.SubItems.Add(menuItem.ID.ToString());
                    li.SubItems.Add(menuItem.Prijs.ToString());
                    li.SubItems.Add(menuItem.Aantal.ToString());
                    li.SubItems.Add(menuItem.menu.ToString());
                    lvVoorraad.Items.Add(li);
                }
            }
            else if (RBDranken.Checked)
            {
                lvVoorraad.Clear();
                MaakCollommen();
                List<MenuItem2> drankItems = service.GetDrinkMenu();
                foreach (MenuItem2 menuItem in drankItems)
                {
                    ListViewItem li = new ListViewItem(menuItem.ItemNaam);
                    li.SubItems.Add(menuItem.ID.ToString());
                    li.SubItems.Add(menuItem.Prijs.ToString());
                    li.SubItems.Add(menuItem.Aantal.ToString());
                    li.SubItems.Add(menuItem.menu.ToString());
                    lvVoorraad.Items.Add(li);
                }
            }
            else
            {
                lvVoorraad.Clear();
                MaakCollommen();
                List<MenuItem2> allItems = service.GetMenuItems();
                foreach (MenuItem2 menuItem in allItems)
                {
                    ListViewItem li = new ListViewItem(menuItem.ItemNaam);
                    li.SubItems.Add(menuItem.ID.ToString());
                    li.SubItems.Add(menuItem.Prijs.ToString());
                    li.SubItems.Add(menuItem.Aantal.ToString());
                    li.SubItems.Add(menuItem.menu.ToString());
                    lvVoorraad.Items.Add(li);
                }
            }
        }


        private void button4_Click(object sender, EventArgs e)
        {
            MenuItem2 item = new MenuItem2();
            lblOmschrijving.Text = lvVoorraad.SelectedItems[0].SubItems[0].Text;///trycatch
            tbAantal.Text = lvVoorraad.SelectedItems[0].SubItems[3].Text;
        }

        private void VoorraadForm_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //opslaan
        }
    }
}
