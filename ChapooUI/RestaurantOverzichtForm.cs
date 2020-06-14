using ChapooModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChapooLogic;
using System.Threading;
using System.Security.Cryptography;

namespace ChapooUI
{
    public partial class RestaurantOverzichtForm : Form
    {
        public RestaurantOverzichtForm()
        {
            InitializeComponent();
            tafelOverzichtVullen();
            orderOverzichtVullen();
        }
       
        private void tafelOverzichtVullen()
        {
            ChapooLogic.Restaurant_Service tafelOverzicht = new ChapooLogic.Restaurant_Service();
            List<TafelStatus> tafellist = tafelOverzicht.KrijgTafels();
            listview_TafelOverzicht.View = View.Details;

            listview_TafelOverzicht.Clear();

            listview_TafelOverzicht.Columns.Add("tafelNummmer");
            listview_TafelOverzicht.Columns.Add("tafelbezetting");

            string Bezet;
            
            foreach (ChapooModel.TafelStatus s in tafellist)
            {
                ListViewItem li = new ListViewItem(s.tafelNummer.ToString());
                
                if (s.tafelBezetting == true)
                {
                    //li.SubItems.Add("Vrij");
                    Bezet = "Bezet";
                }
                else
                {
                    //li.SubItems.Add("Bezet");
                    Bezet = "Vrij";
                }

                li.SubItems.Add(Bezet);
                listview_TafelOverzicht.Items.Add(li);
            }

            listview_TafelOverzicht.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

        }

        private void orderOverzichtVullen()
        {
            ChapooLogic.Order_Service orderOverzicht = new ChapooLogic.Order_Service();
            List<OrderStatus> orderlist = orderOverzicht.KrijgOrder();
            listview_OrderOverzicht.View = View.Details;

            listview_OrderOverzicht.Clear();

            listview_OrderOverzicht.Columns.Add("tafelNummmer");
            listview_OrderOverzicht.Columns.Add("bestellingId");
            listview_OrderOverzicht.Columns.Add("bestellingStatus");

            foreach (ChapooModel.OrderStatus s in orderlist)
            {
                ListViewItem li = new ListViewItem(s.tafelNummer.ToString());

                li.SubItems.Add(s.bestellingId.ToString());
                listview_OrderOverzicht.Items.Add(li);

                if (s.bestellingStatus == true)
                {
                    li.SubItems.Add("Klaar");
                }
                else
                {
                    li.SubItems.Add("Open");
                }
            }

            listview_OrderOverzicht.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

        }

        private void HomeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void MS1I_Home_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void listview_TafelOverzicht_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void MS_KO_Click(object sender, EventArgs e)
        {
            //singleton patern toegepast
            KeukenOverzichtForm keukenOverzicht = KeukenOverzichtForm.GetInstance();
            keukenOverzicht.ShowDialog();
            this.Hide();
        }

        private void listview_BezettingOverzicht_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void MS_BO_Click(object sender, EventArgs e)
        {
            KeukenOverzichtForm keukenOverzicht = KeukenOverzichtForm.GetInstance();
            keukenOverzicht.OpenBarOverzicht();
            keukenOverzicht.ShowDialog();
            this.Hide();
        }

        private void MS1I_Inkomsten_Click(object sender, EventArgs e)
        {
            InkomstenForm inkomsten = new InkomstenForm();
            inkomsten.ShowDialog();
            this.Hide();
        }

        private void MS1I_Voorraad_Click(object sender, EventArgs e)
        {
            VoorraadForm voorraad = new VoorraadForm();
            voorraad.ShowDialog();
            this.Hide();
        }

        private void MS1I_MenuKaartOpties_Click(object sender, EventArgs e)
        {
            MenuKaartAanpassenForm from = new MenuKaartAanpassenForm();
            from.ShowDialog();
            this.Hide();
        }

        private void MS1I_Werknemers_Click(object sender, EventArgs e)
        {
            WerknemersForm werknemersForm = new WerknemersForm();
            werknemersForm.ShowDialog();
            this.Hide();
        }

        private void afmeldenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AfmeldenForm form = new AfmeldenForm();
            this.Hide();
        }
    }
}
