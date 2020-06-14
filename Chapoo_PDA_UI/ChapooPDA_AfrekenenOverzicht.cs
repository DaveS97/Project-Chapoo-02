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
           //tafel id menITem prijs, omschrijving
        }

        public void vullistview()
        {
            lvRekeningOverzicht.Columns.Add("omschrijving", 150);
            lvRekeningOverzicht.Columns.Add("aantal keer besteld", 150);
            lvRekeningOverzicht.Columns.Add("prijs", 50);



            RekeningService service = new RekeningService();
            List<Bon>  bonnen = service.GetRekenings(tafelnummer);

            foreach (Bon bon in bonnen)
            {
                ListViewItem li = new ListViewItem(bon.omschrijving.ToString());
                li.SubItems.Add(bon.prijs.ToString());
                li.SubItems.Add(bon.Aantal.ToString());

                lvRekeningOverzicht.Items.Add(li);
            }
        }

        private void lvRekeningOverzicht_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
