using ChapooLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapoo_PDA_UI
{
    public partial class ChapooPDA_BestellingenOpnemenOverzicht : Form
    {
        private List<ChapooModel.MenuItem> items, voorgerechten, hoofdgerechten, nagerechten, dranken;
        private List<int> aantallen = new List<int>();
        private int tafelnummer;
        
        public ChapooPDA_BestellingenOpnemenOverzicht(List<ChapooModel.MenuItem> items, int tafelnummer, List<int> aantallen)
        {
            InitializeComponent();
            this.items = items;
            this.tafelnummer = tafelnummer;
            this.aantallen = aantallen;
        }

        private void ChapooPDA_BestellingenOpnemenOverzicht_Load(object sender, EventArgs e)
        {
            lblTafelnummer.Text = "Tafel " + tafelnummer;
            ShowPanelOverzicht();
        }

        private void ShowPanelOverzicht()
        {
            pnlOverzicht.Show();
            VulLists();
            VulListViews();
        }
        
        /* verstuur de lijst van menu items door naar de keuken/bar
         * verlaag de voorraad van het artikel en maak de lijsten leeg */
        private void btnVerstuur_Click(object sender, EventArgs e)
        {
            Voorraad_Service service = new Voorraad_Service();

            for (int i = 0; i < items.Count; i++)
            {
                service.Write_To_DB_Set_Nieuw_Aantal(items[i].ID, aantallen[i]);
            }

            items.Clear();
        }

        //splits de megekregen lijst van menu items op per type gerecht
        private void VulLists()
        {
            voorgerechten = new List<ChapooModel.MenuItem>();
            hoofdgerechten = new List<ChapooModel.MenuItem>();
            nagerechten = new List<ChapooModel.MenuItem>();
            dranken = new List<ChapooModel.MenuItem>();

            foreach (ChapooModel.MenuItem item in items)
            {
                switch (item.typeGerecht)
                {
                    case 1:
                        voorgerechten.Add(item);
                        break;
                    case 2:
                        hoofdgerechten.Add(item);
                        break;
                    case 3:
                        nagerechten.Add(item);
                        break;
                    case 4:
                        hoofdgerechten.Add(item);
                        break;
                    case 5:
                        dranken.Add(item);
                        break;
                    default: break;
                }
            }
        }

        //vul de listviews voor het overzicht zodat de volledige bestelling zichtbaar is
        private void VulListViews()
        {
            int teller = 0;
            lvVoorgerechten.Columns.Add("beschrijving", 100);
            lvVoorgerechten.Columns.Add("prijs", 10);
            lvVoorgerechten.Columns.Add("Aantal", 20);

            foreach (ChapooModel.MenuItem item in voorgerechten)
            {
                ListViewItem i = new ListViewItem(item.Beschrijving);
                i.SubItems.Add("€" + item.Prijs.ToString());
                i.SubItems.Add(aantallen[teller].ToString());
                lvVoorgerechten.Items.Add(i);
                teller++;
            }
            lvVoorgerechten.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);

            lvHoofdgerechten.Columns.Add("beschrijving", 100);
            lvHoofdgerechten.Columns.Add("prijs", 10);
            lvHoofdgerechten.Columns.Add("Aantal", 20);
            foreach (ChapooModel.MenuItem item in hoofdgerechten)
            {
                ListViewItem i = new ListViewItem(item.Beschrijving);
                i.SubItems.Add("€" + item.Prijs.ToString());
                i.SubItems.Add(aantallen[teller].ToString());
                lvHoofdgerechten.Items.Add(i);
                teller++;
            }
            lvHoofdgerechten.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);

            lvNagerechten.Columns.Add("beschrijving", 100);
            lvNagerechten.Columns.Add("prijs", 10);
            lvNagerechten.Columns.Add("Aantal", 20);
            foreach (ChapooModel.MenuItem item in nagerechten)
            {
                ListViewItem i = new ListViewItem(item.Beschrijving);
                i.SubItems.Add("€" + item.Prijs.ToString());
                i.SubItems.Add(aantallen[teller].ToString());
                lvNagerechten.Items.Add(i);
                teller++;
            }
            lvNagerechten.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);

            lvDranken.Columns.Add("beschrijving", 100);
            lvDranken.Columns.Add("prijs", 10);
            lvDranken.Columns.Add("Aantal", 20);
            foreach (ChapooModel.MenuItem item in dranken)
            {
                ListViewItem i = new ListViewItem(item.Beschrijving);
                i.SubItems.Add("€" + item.Prijs.ToString());
                i.SubItems.Add(aantallen[teller].ToString());
                lvDranken.Items.Add(i);
                teller++;
            }
            lvDranken.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        }
    }
}
