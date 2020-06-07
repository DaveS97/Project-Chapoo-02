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
        private int tafelnummer;

        public ChapooPDA_BestellingenOpnemenOverzicht(List<ChapooModel.MenuItem> items, int tafelnummer)
        {
            InitializeComponent();
            this.items = items;
            this.tafelnummer = tafelnummer;
        }

        private void ChapooPDA_BestellingenOpnemenOverzicht_Load(object sender, EventArgs e)
        {
            lblTafelnummer.Text = "Tafel " + tafelnummer;
            ShowPanelOverzicht();
        }

        void ShowPanelOverzicht()
        {
            pnlOverzicht.Show();
            VulLists();
        }

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
            items.Clear();
        }
    }
}
