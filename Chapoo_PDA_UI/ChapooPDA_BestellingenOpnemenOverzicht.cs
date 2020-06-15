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
        private List<ChapooModel.MenuItem> bestelItems, itemsNaarDatabase;
        private List<int> aantallen = new List<int>();
        private List<string> commentaren = new List<string>(); 
        private List<ChapooModel.BesteldMenuItem> besteldeMenuItems, voorgerechten, hoofdgerechten, nagerechten, dranken;
        private ChapooModel.Klant klant = new ChapooModel.Klant();
        private List<int> aantallenNaarDatabase;
        private List<string> commentarenNaarDatabase;
        private decimal totaalPrijs = 0;
        private decimal totaalBTW = 0;

        private int tafelnummer;
        int bedienerID;

        public ChapooPDA_BestellingenOpnemenOverzicht(List<ChapooModel.MenuItem> items, int tafelnummer, List<int> aantallen, List<string> commentaren, int bedienerID)
        {
            InitializeComponent();
            this.bestelItems = items;
            this.tafelnummer = tafelnummer;
            this.aantallen = aantallen;
            this.commentaren = commentaren;
            this.bedienerID = bedienerID;
            besteldeMenuItems = VulLijstBesteldeMenuItems();
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

        private List<ChapooModel.BesteldMenuItem> VulLijstBesteldeMenuItems()
        {
            List<ChapooModel.BesteldMenuItem> list = new List<ChapooModel.BesteldMenuItem>();

            for (int i = 0; i < bestelItems.Count; i++)
            {
                ChapooModel.BesteldMenuItem bestelItem = new ChapooModel.BesteldMenuItem();

                bestelItem.item = bestelItems[i];
                bestelItem.commentaar = commentaren[i];
                bestelItem.aantal = aantallen[i];

                list.Add(bestelItem);
            }

            return list;
        }
        
        //verstuur de lijst van menu items door naar de keuken/bar en maak de lijsten leeg
        private void btnVerstuur_Click(object sender, EventArgs e)
        {
            Bevat_Service bevat_Service = new Bevat_Service();
            Voorraad_Service voorraadService = new Voorraad_Service();
            
            SchrijfBestellingNaarDatabase();
            VerlaagVoorraadAantal();


            RekeningService rekeningService = new RekeningService();
            RekeningItem_Service rekeningItem_Service = new RekeningItem_Service();

            //maak een nieuwe rekening aan
            DateTime datum = DateTime.Now;
            ChapooModel.Rekening rekening = new ChapooModel.Rekening();
            rekeningService.Write_To_Db_Rekening(klant.ID, datum);
            rekening = rekeningService.GetRekening(klant.ID)[0];
            
            for (int i = 0; i < bestelItems.Count; i++)
            {
                totaalPrijs += bestelItems[i].Prijs;
                totaalBTW += bestelItems[i].BTW;
                rekeningItem_Service.Write_To_Db_RekeningItem(rekening.ID, bestelItems[i].ID, aantallen[i]);
            }

            MessageBox.Show("Bestelling is verzonden!");

            bestelItems.Clear();
            this.Hide();
            ChapooPDA_BestellingOpnemenRegistreren registreren = new ChapooPDA_BestellingOpnemenRegistreren(tafelnummer, bedienerID);

            registreren.ShowDialog();
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

            for (int i = 0; i < bestelItems.Count; i++)
            {
                voorraad_Service.Write_To_DB_Set_Nieuw_Aantal(bestelItems[i].ID, aantallen[i]);
            }
        }

        //schrijf de bestelling uit naar de database om verwerkt te kunnen worden bij bar/keuken
        private void SchrijfBestellingNaarDatabase()
        {
            Bestelling_Service bestelling_Service = new Bestelling_Service();
            Bevat_Service bevat_Service = new Bevat_Service();
            Klant_Service klant_Service = new Klant_Service();
            string dateTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            
            itemsNaarDatabase = VulLijstItemsNaarDatabase();
            aantallenNaarDatabase = VulLijstAantallenNaarDatabase();
            commentarenNaarDatabase = VulLijstCommentarenNaarDatabase();
            klant = klant_Service.KrijgKlantUitTafelID(tafelnummer)[0];

            bestelling_Service.Write_To_Db_Bestelling(bedienerID, klant.ID, dateTime);
            ChapooModel.Bestelling bestelling = bestelling_Service.DB_Krijg_Bestelling_Uit_KlantID(klant.ID, dateTime)[0];

            for (int i = 0; i < bestelItems.Count; i++)
            {
                bevat_Service.Write_To_Db_Bevat(bestelItems[i].ID, bestelling.bestellingID, commentarenNaarDatabase[i], aantallenNaarDatabase[i]);
            }
        }

        //vul een nieuwe lijst met de menu items die in het overzicht staan, voor het geval dat er tussentijds items verwijderd zijn
        private List<ChapooModel.MenuItem> VulLijstItemsNaarDatabase()
        {
            MenuItem_Service service = new MenuItem_Service();
            List<ChapooModel.MenuItem> itemsVoorDatabase = new List<ChapooModel.MenuItem>();
            
            foreach(ChapooModel.BesteldMenuItem i in voorgerechten)
            {
                itemsVoorDatabase.Add(i.item);
            }
            foreach (ChapooModel.BesteldMenuItem i in hoofdgerechten)
            {
                itemsVoorDatabase.Add(i.item);
            }
            foreach (ChapooModel.BesteldMenuItem i in nagerechten)
            {
                itemsVoorDatabase.Add(i.item);
            }
            foreach (ChapooModel.BesteldMenuItem i in dranken)
            {
                itemsVoorDatabase.Add(i.item);
            }

            return itemsVoorDatabase;
        }

        //vul een nieuwe lijst met de aantallen die in het overzicht staan, voor het geval dat er tussentijds items verwijderd zijn
        private List<int> VulLijstAantallenNaarDatabase()
        {
            List<int> aantallenVoorDatabase = new List<int>();

            for (int i = 0; i < lvVoorgerechten.Items.Count; i++)
            {
                aantallenVoorDatabase.Add(int.Parse(lvVoorgerechten.Items[i].SubItems[2].Text));
            }
            for (int i = 0; i < lvHoofdgerechten.Items.Count; i++)
            {
                aantallenVoorDatabase.Add(int.Parse(lvHoofdgerechten.Items[i].SubItems[2].Text));
            }
            for (int i = 0; i < lvNagerechten.Items.Count; i++)
            {
                aantallenVoorDatabase.Add(int.Parse(lvNagerechten.Items[i].SubItems[2].Text));
            }
            for (int i = 0; i < lvDranken.Items.Count; i++)
            {
                aantallenVoorDatabase.Add(int.Parse(lvDranken.Items[i].SubItems[2].Text));
            }

            return aantallenVoorDatabase;
        }

        private List<string> VulLijstCommentarenNaarDatabase()
        {
            List<string> commentarenVoorDatabase = new List<string>();

            for (int i = 0; i < lvVoorgerechten.Items.Count; i++)
            {
                commentarenVoorDatabase.Add(lvVoorgerechten.Items[i].SubItems[3].Text);
            }
            for (int i = 0; i < lvHoofdgerechten.Items.Count; i++)
            {
                commentarenVoorDatabase.Add(lvHoofdgerechten.Items[i].SubItems[3].Text);
            }
            for (int i = 0; i < lvNagerechten.Items.Count; i++)
            {
                commentarenVoorDatabase.Add(lvNagerechten.Items[i].SubItems[3].Text);
            }
            for (int i = 0; i < lvDranken.Items.Count; i++)
            {
                commentarenVoorDatabase.Add(lvDranken.Items[i].SubItems[3].Text);
            }

            return commentarenVoorDatabase;
        }

        //splits de megekregen lijst van menu items op per type gerecht
        private void VulLists()
        {
            voorgerechten = new List<ChapooModel.BesteldMenuItem>();
            hoofdgerechten = new List<ChapooModel.BesteldMenuItem>();
            nagerechten = new List<ChapooModel.BesteldMenuItem>();
            dranken = new List<ChapooModel.BesteldMenuItem>();

            foreach (ChapooModel.BesteldMenuItem i in besteldeMenuItems)
            {
                switch (i.item.typeGerecht)
                {
                    case 1:
                        voorgerechten.Add(i);
                        break;
                    case 2:
                        hoofdgerechten.Add(i);
                        break;
                    case 3:
                        nagerechten.Add(i);
                        break;
                    case 4:
                        hoofdgerechten.Add(i);
                        break;
                    case 5:
                        dranken.Add(i);
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
            lvVoorgerechten.Columns.Add("Opmerking", 64);
            foreach (ChapooModel.BesteldMenuItem item in voorgerechten)
            {
                ListViewItem i = new ListViewItem(item.item.Beschrijving);
                i.SubItems.Add("€" + item.item.Prijs.ToString());
                i.SubItems.Add(item.aantal.ToString());
                i.SubItems.Add(item.commentaar.ToString());
                lvVoorgerechten.Items.Add(i);
                teller++;
            }
            lvVoorgerechten.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            lvVoorgerechten.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

            lvHoofdgerechten.Columns.Add("beschrijving", 100);
            lvHoofdgerechten.Columns.Add("prijs", 10);
            lvHoofdgerechten.Columns.Add("Aantal", 20);
            lvHoofdgerechten.Columns.Add("Opmerking", 64);
            foreach (ChapooModel.BesteldMenuItem item in hoofdgerechten)
            {
                ListViewItem i = new ListViewItem(item.item.Beschrijving);
                i.SubItems.Add("€" + item.item.Prijs.ToString());
                i.SubItems.Add(item.aantal.ToString());
                i.SubItems.Add(item.commentaar.ToString());
                lvHoofdgerechten.Items.Add(i);
                teller++;
            }
            lvHoofdgerechten.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            lvHoofdgerechten.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

            lvNagerechten.Columns.Add("beschrijving", 100);
            lvNagerechten.Columns.Add("prijs", 10);
            lvNagerechten.Columns.Add("Aantal", 20);
            lvNagerechten.Columns.Add("Opmerking", 64);
            foreach (ChapooModel.BesteldMenuItem item in nagerechten)
            {
                ListViewItem i = new ListViewItem(item.item.Beschrijving);
                i.SubItems.Add("€" + item.item.Prijs.ToString());
                i.SubItems.Add(item.aantal.ToString());
                i.SubItems.Add(item.commentaar.ToString());
                lvNagerechten.Items.Add(i);
                teller++;
            }
            lvNagerechten.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            lvNagerechten.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

            lvDranken.Columns.Add("beschrijving", 100);
            lvDranken.Columns.Add("prijs", 10);
            lvDranken.Columns.Add("Aantal", 20);
            lvDranken.Columns.Add("Opmerking", 64);
            foreach (ChapooModel.BesteldMenuItem item in dranken)
            {
                ListViewItem i = new ListViewItem(item.item.Beschrijving);
                i.SubItems.Add("€" + item.item.Prijs.ToString());
                i.SubItems.Add(item.aantal.ToString());
                i.SubItems.Add(item.commentaar.ToString());
                lvDranken.Items.Add(i);
                teller++;
            }
            lvDranken.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            lvDranken.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
    }
}
