﻿using System;
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
    public partial class AanmeldenPDAForm : Form
    {
        public AanmeldenPDAForm()
        {
            InitializeComponent();
        }

        private void AanmeldenForm_Load(object sender, EventArgs e)
        {

        }
        private void btnAanmelden_Click(object sender, EventArgs e)
        {
            Werknemer_Service service = new Werknemer_Service();
            List<Werknemer> werknemers = service.GetWerknemerPins();
            bool CorrectPin = false;
            string naam = "";
            int ID = 0;
            string types = "";
            int type = 0; // 1=  bediener 2= barman  3= kok  4= eigenaar

            if (tbPin.Text.Length != 0)
            {
                int pin = int.Parse(tbPin.Text);
                foreach (Werknemer item in werknemers)
                {
                    if (item.PIN == pin)
                    {
                        CorrectPin = true;
                        ID = item.ID;
                        naam = item.Naam;
                        type = item.Type;
                        break;
                    }
                    else
                    {
                        CorrectPin = false;
                    }
                }
            }
            if (CorrectPin)
            {
                if (type != 1)
                {
                    MessageBox.Show("jij bent geen bediener dus hier hoef je niet aan te melden");
                }
                switch (type)
                {
                    case 1:
                        types = "bediener";
                        break;
                    case 2:
                        types = "barman";
                        break;
                    case 3:
                        types = "kok";
                        break;
                    case 4:
                        types = "eigenaar";
                        break;
                    default:
                        MessageBox.Show("error");
                        break;
                }
                MessageBox.Show($"Welkom {naam} jij bent een {types}\nID: {ID}");
                ChapooPDA pda = new ChapooPDA(ID);

                this.Hide();
                pda.ShowDialog();
            }
            else
            {
                MessageBox.Show("voer een geldige pincode in");
            }



            
        }
    }
}
