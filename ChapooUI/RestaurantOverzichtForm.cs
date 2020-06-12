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
        }
       
        private void tafelOverzichtVullen()
        {
            ChapooLogic.Restaurant_Service tafelOverzicht = new ChapooLogic.Restaurant_Service();
            List<TafelStatus> tafellist = tafelOverzicht.KrijgTafels();
            listview_TafelOverzicht.View = View.Details;

            listview_TafelOverzicht.Clear();

            listview_TafelOverzicht.Columns.Add("tafelNummmer");
            listview_TafelOverzicht.Columns.Add("bestellingId");
            listview_TafelOverzicht.Columns.Add("bestellingStatus");

            foreach (ChapooModel.TafelStatus s in tafellist)
            {
                ListViewItem li = new ListViewItem(s.tafelNummmer.ToString());

                li.SubItems.Add(s.bestellingId.ToString());
                listview_TafelOverzicht.Items.Add(li);

                if (s.bestellingStatus == true)
                {
                    li.SubItems.Add("Klaar");
                }
                else
                {
                    li.SubItems.Add("Open");
                }
            }

            listview_TafelOverzicht.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

        }
    }
}
