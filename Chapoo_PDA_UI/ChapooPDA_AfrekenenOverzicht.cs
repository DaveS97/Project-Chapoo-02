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

namespace Chapoo_PDA_UI
{
    public partial class ChapooPDA_AfrekenenOverzicht : Form
    {
        private int tafelnummer;
        private RekeningService rekeningService = new RekeningService();
        private MenuItem_Service menuItem_Service = new MenuItem_Service();
        private RekeningItem_Service rekeningItem_Service = new RekeningItem_Service();
        private Klant_Service klant_Service = new Klant_Service();

        public ChapooPDA_AfrekenenOverzicht(int tafelnummer)
        {
            this.tafelnummer = tafelnummer;
            InitializeComponent();
            vullistview();

        }

        private void ChapooPDA_AfrekenenOverzicht_Load(object sender, EventArgs e)
        {

        }
        private void ToonRekening()
        {
            //pnlAfrekenenOverzicht.Show();
            //pnlAfrekenenOverzicht.BringToFront();
            //ChapooLogic.RekeningService rekeningService = new ChapooLogic.RekeningService();
        }
        private void btnVerstuurRekening_Click(object sender, EventArgs e)
        {
            
            menuItem_Service.

            rekeningService.Update_Db_Rekening(klant.ID, datum, totaalPrijs, fooi, totaalBTW, );

            //tafel id menITem prijs, omschrijving
        }

        public void vullistview()
        {
            lvRekeningOverzicht.Columns.Add("omschrijving", 150);
            lvRekeningOverzicht.Columns.Add("aantal keer besteld", 150);
            lvRekeningOverzicht.Columns.Add("prijs", 50);

            Klant klant = klant_Service.KrijgKlantUitTafelID(tafelnummer)[0];
            Rekening rekening = rekeningService.GetRekening(klant.ID)[0];
            List<RekeningItem> rekeningItems = rekeningItem_Service.GetRekeningItemsVoorRekeningID(rekening.ID);


            foreach (RekeningItem item in rekeningItems)
            {
                ListViewItem li = new ListViewItem(item.Omschrijving.ToString());
                li.SubItems.Add(item.Aantal.ToString());
                li.SubItems.Add(item.Prijs.ToString());
                lvRekeningOverzicht.Items.Add(li);
            }
        }

        private void lvRekeningOverzicht_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
