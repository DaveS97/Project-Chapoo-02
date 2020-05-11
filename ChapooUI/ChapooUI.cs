using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChapooModel;

namespace ChapooUI
{
    public partial class Chapoo : Form
    {
        public Chapoo()
        {
            InitializeComponent();
            
        }
        private void homeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Show();
        }

        private void werknemersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WerknemersForm werknemersForm = new WerknemersForm();
            werknemersForm.ShowDialog();
            //als we nog een form hiervan moeten aanmaken, kunnen we de singlepattern misschien toepassen
        }
    }
}
