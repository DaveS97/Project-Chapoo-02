﻿using ChapooLogic;
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
        private List<ChapooModel.MenuItem> items, voorgerechten, hoofdgerechten, nagerechten, dranken, itemsNaarDatabase;
        private List<int> aantallen = new List<int>();
        private int tafelnummer;
        private ChapooModel.Klant klant = new ChapooModel.Klant();
        
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
        
        //verstuur de lijst van menu items door naar de keuken/bar en maak de lijsten leeg */
        private void btnVerstuur_Click(object sender, EventArgs e)
        {
            Bevat_Service bevat_Service = new Bevat_Service();
            VerlaagVoorraadAantal();
            SchrijfBestellingNaarDatabase();
           
            items.Clear();
        }

        //verwijder het geselecteerde item uit het overzicht en de lijst met items
        private void btnVerwijderUitOverzicht_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lvVoorgerechten.Items.Count; i++)
            {
                if (lvVoorgerechten.Items[i].Selected)
                {
                    voorgerechten.Remove(voorgerechten[i]);
                    lvVoorgerechten.Items.Remove(lvVoorgerechten.Items[i]);
                    return;
                }
            }
            for (int i = 0; i < lvHoofdgerechten.Items.Count; i++)
            {
                if (lvHoofdgerechten.Items[i].Selected)
                {
                    hoofdgerechten.Remove(hoofdgerechten[i]);
                    lvHoofdgerechten.Items.Remove(lvHoofdgerechten.Items[i]);
                    return;
                }
            }
            for (int i = 0; i < lvNagerechten.Items.Count; i++)
            {
                if (lvNagerechten.Items[i].Selected)
                {
                    nagerechten.Remove(nagerechten[i]);
                    lvNagerechten.Items.Remove(lvNagerechten.Items[i]);
                    return;
                }
            }
            for (int i = 0; i < lvDranken.Items.Count; i++)
            {
                if (lvDranken.Items[i].Selected)
                {
                    dranken.Remove(dranken[i]);
                    lvDranken.Items.Remove(lvDranken.Items[i]);
                    return;
                }
            }
        }

        //verlaag de voorraad van het artikel
        private void VerlaagVoorraadAantal()
        {
            Voorraad_Service voorraad_Service = new Voorraad_Service();
            for (int i = 0; i < items.Count; i++)
            {
                voorraad_Service.Write_To_DB_Set_Nieuw_Aantal(items[i].ID, aantallen[i]);
            }
        }

        //schrijf de bestelling uit naar de database om verwerkt te kunnen worden bij bar/keuken
        private void SchrijfBestellingNaarDatabase()
        {
            Bestelling_Service bestelling_Service = new Bestelling_Service();
            Klant_Service klant_Service = new Klant_Service();

            itemsNaarDatabase = VulLijstVoorDatabase();
            klant = klant_Service.KrijgKlantUitTafelID(tafelnummer)[0];
        }

        //vul een nieuwe lijst met de menu items die in het overzicht staan, voor het geval dat er tussentijds items verwijderd zijn
        private List<ChapooModel.MenuItem> VulLijstVoorDatabase()
        {
            items = new List<ChapooModel.MenuItem>();
            
            foreach(ChapooModel.MenuItem item in voorgerechten)
            {
                itemsNaarDatabase.Add(item);
            }
            foreach (ChapooModel.MenuItem item in hoofdgerechten)
            {
                itemsNaarDatabase.Add(item);
            }
            foreach (ChapooModel.MenuItem item in nagerechten)
            {
                itemsNaarDatabase.Add(item);
            }
            foreach (ChapooModel.MenuItem item in dranken)
            {
                itemsNaarDatabase.Add(item);
            }

            return items;
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
            lvVoorgerechten.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

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
            lvHoofdgerechten.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

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
            lvNagerechten.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

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
            lvDranken.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
    }
}
