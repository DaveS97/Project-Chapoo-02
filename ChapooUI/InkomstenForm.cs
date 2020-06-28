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
    public partial class InkomstenForm : Form
    {
        public InkomstenForm()
        {
            InitializeComponent();
            //colommen worden gemaakt
            lvInkomsten.Columns.Add("ID", 100);
            lvInkomsten.Columns.Add("BTW", 100);
            lvInkomsten.Columns.Add("Fooi", 100);
            lvInkomsten.Columns.Add("Totaal", 100);
            lvInkomsten.Columns.Add("datum", 150);
            //haalt data uit de rekening tabel
            Inkomsten_Service service = new Inkomsten_Service();
            List<Rekening> rekeningen = service.GetInkomsten();
            foreach (Rekening item in rekeningen)
            {
                ListViewItem li = new ListViewItem(item.ID.ToString());
                li.SubItems.Add(item.BTW.ToString());
                li.SubItems.Add(item.Fooi.ToString());
                li.SubItems.Add(item.TotaalPrijs.ToString());
                li.SubItems.Add(item.Datum.ToString());
                lvInkomsten.Items.Add(li);
            }
        }

        private void InkomstenForm_Load(object sender, EventArgs e)
        {
            //haalt data uit de rekening tabel
            Inkomsten_Service service = new Inkomsten_Service();
            List<Rekening> rekeningen = service.GetInkomsten();
            foreach (Rekening item in rekeningen)
            {
                ListViewItem li = new ListViewItem(item.ID.ToString());
                li.SubItems.Add(item.BTW.ToString());
                li.SubItems.Add(item.Fooi.ToString());
                li.SubItems.Add(item.TotaalPrijs.ToString());
                li.SubItems.Add(item.Datum.ToString());
                lvInkomsten.Items.Add(li);
            }
        }

        private void terugToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
