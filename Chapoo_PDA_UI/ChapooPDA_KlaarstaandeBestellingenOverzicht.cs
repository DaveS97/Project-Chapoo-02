using ChapooModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChapooLogic;

namespace Chapoo_PDA_UI
{
    //Deze hele class is geschreven door Ruben
    public partial class ChapooPDA_KlaarstaandeBestellingenOverzicht : Form
    {
        private const int VOORGERECHT = 1;
        private const int HOOFDGERECHT = 2;
        private const int NAGERECHT = 3;
        private const int TUSSENGERECHT = 4;
        private const int DRINKEN = 5;
        private Dictionary<Bevat, Klant> klaarstaandeDrankjes; //dit zijn de drankjes die zijn klaargezet
        private static ChapooPDA_KlaarstaandeBestellingenOverzicht uniekeInstantie;

        private ChapooPDA_KlaarstaandeBestellingenOverzicht()
        {
            InitializeComponent();
            LabelsHiden();
            ShowPanel("klaarstaandeBestellingen");
            klaarstaandeDrankjes = new Dictionary<Bevat, Klant>();
        }
        //singleton pattern
        public static ChapooPDA_KlaarstaandeBestellingenOverzicht GetInstance()
        {
            if (uniekeInstantie == null)
                uniekeInstantie = new ChapooPDA_KlaarstaandeBestellingenOverzicht();
            return uniekeInstantie;
        }
        //onderstaande methode hide een aantal labels
        private void LabelsHiden()
        {
            lbl_drinkBestellingPDA.Text = "";
            lbl_BestellingPDA.Text = "";
            lbl_drinkBestellingPDA.Hide();
            lbl_huidigeDrankBestellingPDA.Hide();
            lblopmerkingPDAdrink.Hide();
            lbl_opmerkingDrinkenPDA.Hide();
            lbl_opmerkingenVoorgerechtPDA.Hide();
            lbl_opmerkingHoofdgerechtPDA.Hide();
            lbl_opmerkingNagerechtPDA.Hide();
            lbl_VoorgerechtPDA.Hide();
            lbl_hoofdgerechtPDA.Hide();
            lbl_nagerechtPDA.Hide();
        }
        //onderstaande methode toont de juiste panel of niet
        private void ShowPanel(string panelName)
        {
            if (panelName == "klaarstaandeBestellingen")
            {
                pnl_klaarstaandeBestellingenPDA.Show();
                VulKlaarstaandeBestellingen();
            }
            else
            {
                pnl_klaarstaandeBestellingenPDA.Hide();
            }
        }
        //onderstaande methode vult de listview met klaarstaande bestellingen
        private void VulKlaarstaandeBestellingen()
        {
            //leeg de listview voordat die weer gevult wordt
            lv_KlaarstaandeBestellingenPDA.Clear();
            //maak kolommen
            lv_KlaarstaandeBestellingenPDA.Columns.Add("Tafel Id");
            lv_KlaarstaandeBestellingenPDA.Columns.Add("Bestelling Id");
            Bevat_Service bevat_service = new Bevat_Service();
            Dictionary<Bevat, Klant> bestellingenKlaar = bevat_service.KrijgBestellingEnMenuItemIDGereed();
            foreach (KeyValuePair<Bevat, Klant> pair in bestellingenKlaar)
            {
                ListViewItem li = new ListViewItem(pair.Value.tafelID.ToString());
                li.SubItems.Add(pair.Key.bestellingID.ToString());
                lv_KlaarstaandeBestellingenPDA.Items.Add(li);
            }
            lv_KlaarstaandeBestellingenPDA.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            lv_KlaarstaandeBestellingenPDA.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
        //onderstaande methode vult de listview klaarstaande drankjes met klaarstaandeDrankjes
        private void KlaarstaandeDrankjesOphalen()
        {
            //eerst de listview legen voordat die opniew gevult wordt
            lv_klaarstaandeDrankjesPDA.Clear();
            //maak kolommen aan voor de listview
            lv_klaarstaandeDrankjesPDA.Columns.Add("Tafel Id");
            lv_klaarstaandeDrankjesPDA.Columns.Add("Bestelling Id");
            foreach (KeyValuePair<Bevat, Klant> pair in klaarstaandeDrankjes)
            {
                ListViewItem li = new ListViewItem(pair.Value.tafelID.ToString());
                li.SubItems.Add(pair.Key.bestellingID.ToString());
                lv_klaarstaandeDrankjesPDA.Items.Add(li);
            }
            lv_klaarstaandeDrankjesPDA.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            lv_klaarstaandeDrankjesPDA.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
        //onderstaande methode ontvangt drankjes en klanten info van drankjes die klaar staan
        public void DrankjesOntvangen(Bevat drankje, Klant klant)
        {
            klaarstaandeDrankjes.Add(drankje, klant);
        }

        //onderstaande methode herlaad de listview
        private void btn_HerlaadDrankjesPDA_Click(object sender, EventArgs e)
        {
            KlaarstaandeDrankjesOphalen();
        }

        //onderstaande methode toont de drankjes in de bestelling die aangeklikt is in de listview
        private void btn_toonDrankjesPDA_Click(object sender, EventArgs e)
        {
            try
            {
                string bestellingNummer = lv_klaarstaandeDrankjesPDA.SelectedItems[0].SubItems[1].Text;
                lbl_huidigeDrankBestellingPDA.Text = $"Bestelling: {bestellingNummer}";
                //service aanmaken om de beschrijving op te halen
                Bevat_Service bevat_Service = new Bevat_Service();
                Dictionary<Bevat, Klant> bescrhijvingDrankjes = bevat_Service.KrijgBeschrijving(bestellingNummer);
                DrankjesLabelsTonen(bescrhijvingDrankjes);
                foreach (KeyValuePair<Bevat, Klant> duo in bescrhijvingDrankjes)
                {
                    if (duo.Key.typeGerecht == DRINKEN)
                    {
                        lbl_drinkBestellingPDA.Text += $"{duo.Key.Aantal}x {duo.Key.menuItemID} {duo.Key.menuItemBeschrijving}\n";
                        lbl_opmerkingDrinkenPDA.Text += $"{duo.Key.Opmerkingen}";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //onderstaande methode toont de labels van de huidige drankjes
        private void DrankjesLabelsTonen(Dictionary<Bevat, Klant> bescrhijvingDrankjes)
        {
            //toon de juiste labels
            lbl_drinkBestellingPDA.Text = "";
            lbl_opmerkingDrinkenPDA.Text = "";
            lbl_drinkBestellingPDA.Show();
            lbl_huidigeDrankBestellingPDA.Show();
            foreach (KeyValuePair<Bevat, Klant> pair in bescrhijvingDrankjes)
            {
                if (pair.Key.Opmerkingen.Length > 0)
                {
                    lblopmerkingPDAdrink.Show();
                    lbl_opmerkingDrinkenPDA.Show();
                }
            }
        }
        //onderstaande methode cleart de huidige selectie
        private void btn_SelectieLegenPDA_Click(object sender, EventArgs e)
        {
            LabelsHiden();
        }

        //onderstaande methode toont de geselecteerde bestelling
        private void btn_ToonGerechtenPDA_Click(object sender, EventArgs e)
        {
            try
            {
                //bestellings nummer ophalen
                string bestellingNummer = lv_KlaarstaandeBestellingenPDA.SelectedItems[0].SubItems[1].Text;
                lbl_BestellingPDA.Text = $"Bestelling: {bestellingNummer}";
                //service aanmaken om de beschrijving op te halen
                Bevat_Service bevat_Service = new Bevat_Service();
                Dictionary<Bevat, Klant> klaarstaandeBestellingen = bevat_Service.KrijgBeschrijving(bestellingNummer);
                LeegmakenLabelsKlaarstaand(klaarstaandeBestellingen);
                foreach (KeyValuePair<Bevat, Klant> duo in klaarstaandeBestellingen)
                {
                    switch (duo.Key.typeGerecht)
                    {
                        case VOORGERECHT:
                            lbl_VoorgerechtPDA.Text += $"{duo.Key.Aantal}x {duo.Key.menuItemID} {duo.Key.menuItemBeschrijving}\n";
                            lbl_opmerkingenVoorgerechtPDA.Text += $"{duo.Key.Opmerkingen}\n";
                            break;
                        case HOOFDGERECHT:
                            lbl_hoofdgerechtPDA.Text += $"{duo.Key.Aantal}x {duo.Key.menuItemID} {duo.Key.menuItemBeschrijving}\n";
                            lbl_opmerkingHoofdgerechtPDA.Text += $"{duo.Key.Opmerkingen}\n";
                            break;
                        case NAGERECHT:
                            lbl_nagerechtPDA.Text += $" {duo.Key.Aantal}x {duo.Key.menuItemID} {duo.Key.menuItemBeschrijving}\n";
                            lbl_opmerkingNagerechtPDA.Text += $"{duo.Key.Opmerkingen}\n";
                            break;
                        case TUSSENGERECHT:
                            lbl_VoorgerechtPDA.Text += $"{duo.Key.Aantal}x {duo.Key.menuItemID} {duo.Key.menuItemBeschrijving}\n";
                            lbl_opmerkingenVoorgerechtPDA.Text += $"{duo.Key.Opmerkingen}\n";
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //onderstaande methode toont de juiste labels
        private void LeegmakenLabelsKlaarstaand(Dictionary<Bevat, Klant> klaarstaandeBestellingen)
        {
            lbl_VoorgerechtPDA.Show();
            lbl_hoofdgerechtPDA.Show();
            lbl_nagerechtPDA.Show();
            lbl_VoorgerechtPDA.Text = "";
            lbl_hoofdgerechtPDA.Text = "";
            lbl_nagerechtPDA.Text = "";
            lbl_opmerkingenVoorgerechtPDA.Text = "";
            lbl_opmerkingHoofdgerechtPDA.Text = "";
            lbl_opmerkingNagerechtPDA.Text = "";
            foreach (KeyValuePair<Bevat, Klant> pair in klaarstaandeBestellingen)
            {
                if (pair.Key.Opmerkingen.Length > 0)
                {
                    lbl_opmerkingenVoorgerechtPDA.Show();
                    lbl_opmerkingHoofdgerechtPDA.Show();
                    lbl_opmerkingNagerechtPDA.Show();
                }
            }
        }
        //onderstaande methode cleart de huidige selectie
        private void btn_SelectieLegenGerechtenPDA_Click(object sender, EventArgs e)
        {
            LabelsHiden();
        }

        private void btn_HerlaadBestellingenPDA_Click(object sender, EventArgs e)
        {
            VulKlaarstaandeBestellingen();
        }

        private void btn_NaarKlaarstaandeBestellingenPDA_Click(object sender, EventArgs e)
        {
            ShowPanel("klaarstaandeBestellingen");
        }

        private void btn_naarKlaarstaandeDrankjes_Click(object sender, EventArgs e)
        {
            ShowPanel("");
        }
    }
}
