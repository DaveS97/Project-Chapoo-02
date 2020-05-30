﻿using System;
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
    public partial class ChapooPDA_BestellingOpnemenMenu : Form
    {
        private int tafelnummer;

        public ChapooPDA_BestellingOpnemenMenu()
        {
            InitializeComponent();
        }

        private void tbTafelnummerBestellingOpnemen_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnNaarBestelling_Click(object sender, EventArgs e)
        {
            tafelnummer = int.Parse(tbTafelnummerBestellingOpnemen.Text);
            ChapooPDA_BestellingOpnemenRegistreren registreren = new ChapooPDA_BestellingOpnemenRegistreren(tafelnummer);
            Close();
            registreren.ShowDialog();
        }
    }
}
