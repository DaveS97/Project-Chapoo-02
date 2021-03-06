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
    public partial class ChapooPDA_RestaurantOverzicht : Form
    {
        Restaurant_Service service = new Restaurant_Service();
        List<TafelStatus> tafelStatuses = new List<TafelStatus>();
        private int bedienerID;

        public ChapooPDA_RestaurantOverzicht(int bedienerID)
        {
            InitializeComponent();
            this.bedienerID = bedienerID;
            tafelStatuses = service.KrijgTafels();

            SetStatus();
        }

        //Synchroniseer de tafelstatus met de database
        private void SetStatus()
        {
            foreach (TafelStatus status in tafelStatuses)
            {
                switch (status.tafelNummer)
                {
                    case 1:
                        if (status.tafelBezetting) { pnlTafel1.BackColor = Color.Red; break; }
                        pnlTafel1.BackColor = Color.Green;
                        break;
                    case 4:
                        if (status.tafelBezetting) { pnlTafel2.BackColor = Color.Red; break; }
                        pnlTafel2.BackColor = Color.Green;
                        break;
                    case 5:
                        if (status.tafelBezetting) { pnlTafel3.BackColor = Color.Red; break; }
                        pnlTafel3.BackColor = Color.Green;
                        break;
                    case 6:
                        if (status.tafelBezetting) { pnlTafel4.BackColor = Color.Red; break; }
                        pnlTafel4.BackColor = Color.Green;
                        break;
                    case 7:
                        if (status.tafelBezetting) { pnlTafel5.BackColor = Color.Red; break; }
                        pnlTafel5.BackColor = Color.Green;
                        break;
                    case 9:
                        if (status.tafelBezetting) { pnlTafel6.BackColor = Color.Red; break; }
                        pnlTafel6.BackColor = Color.Green;
                        break;
                    case 10:
                        if (status.tafelBezetting) { pnlTafel7.BackColor = Color.Red; break; }
                        pnlTafel7.BackColor = Color.Green;
                        break;
                    case 11:
                        if (status.tafelBezetting) { pnlTafel8.BackColor = Color.Red; break; }
                        pnlTafel8.BackColor = Color.Green;
                        break;
                    case 12:
                        if (status.tafelBezetting) { pnlTafel9.BackColor = Color.Red; break; }
                        pnlTafel9.BackColor = Color.Green;
                        break;
                    case 13:
                        if (status.tafelBezetting) { pnlTafel10.BackColor = Color.Red; break; }
                        pnlTafel10.BackColor = Color.Green;
                        break;
                    default: throw new FormatException();
                }

                service.Write_To_Db_Set_Status(status.tafelBezetting, status.tafelNummer);
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void btnSetBezet1_Click(object sender, EventArgs e)
        {
            if (!tafelStatuses[0].tafelBezetting)
            {
                tafelStatuses[0].tafelBezetting = true;
            }
            else tafelStatuses[0].tafelBezetting = false;
            SetStatus();
        }

        private void btnSetBezet2_Click(object sender, EventArgs e)
        {
            if (!tafelStatuses[1].tafelBezetting)
            {
                tafelStatuses[1].tafelBezetting = true;
            }
            else tafelStatuses[1].tafelBezetting = false;
            SetStatus();
        }

        private void btnSetBezet3_Click(object sender, EventArgs e)
        {
            if (!tafelStatuses[2].tafelBezetting)
            {
                tafelStatuses[2].tafelBezetting = true;
            }
            else tafelStatuses[2].tafelBezetting = false;
            SetStatus();
        }

        private void btnSetBezet4_Click(object sender, EventArgs e)
        {
            if (!tafelStatuses[3].tafelBezetting)
            {
                tafelStatuses[3].tafelBezetting = true;
            }
            else tafelStatuses[3].tafelBezetting = false;
            SetStatus();
        }

        private void btnSetBezet5_Click(object sender, EventArgs e)
        {
            if (!tafelStatuses[4].tafelBezetting)
            {
                tafelStatuses[4].tafelBezetting = true;
            }
            else tafelStatuses[4].tafelBezetting = false;
            SetStatus();
        }

        private void btnSetBezet6_Click(object sender, EventArgs e)
        {
            if (!tafelStatuses[5].tafelBezetting)
            {
                tafelStatuses[5].tafelBezetting = true;
            }
            else tafelStatuses[5].tafelBezetting = false;
            SetStatus();
        }

        private void btnSetBezet7_Click(object sender, EventArgs e)
        {
            if (!tafelStatuses[6].tafelBezetting)
            {
                tafelStatuses[6].tafelBezetting = true;
            }
            else tafelStatuses[6].tafelBezetting = false;
            SetStatus();
        }

        private void btnSetBezet8_Click(object sender, EventArgs e)
        {
            if (!tafelStatuses[7].tafelBezetting)
            {
                tafelStatuses[7].tafelBezetting = true;
            }
            else tafelStatuses[7].tafelBezetting = false;
            SetStatus();
        }

        private void btnSetBezet9_Click(object sender, EventArgs e)
        {
            if (!tafelStatuses[8].tafelBezetting)
            {
                tafelStatuses[8].tafelBezetting = true;
            }
            else tafelStatuses[8].tafelBezetting = false;
            SetStatus();
        }

        private void btnSetBezet10_Click(object sender, EventArgs e)
        {
            if (!tafelStatuses[9].tafelBezetting)
            {
                tafelStatuses[9].tafelBezetting = true;
            }
            else tafelStatuses[9].tafelBezetting = false;
            SetStatus();
        }

        private void btnOpnemen1_Click(object sender, EventArgs e)
        {
            if (tafelStatuses[0].tafelBezetting)
            {
                ChapooPDA_BestellingOpnemenRegistreren registreren = ChapooPDA_BestellingOpnemenRegistreren.GetInstance(1, bedienerID);
                Hide();
                registreren.ShowDialog();
            }
            else MessageBox.Show("Tafel 1 is nog niet bezet!");            
        }

        private void btnOpnemen2_Click(object sender, EventArgs e)
        {
            if (tafelStatuses[1].tafelBezetting)
            {
                ChapooPDA_BestellingOpnemenRegistreren registreren = ChapooPDA_BestellingOpnemenRegistreren.GetInstance(4, bedienerID);
                Hide();
                registreren.ShowDialog();
            }
            else MessageBox.Show("Tafel 2 is nog niet bezet!");
        }

        private void btnOpnemen3_Click(object sender, EventArgs e)
        {
            if (tafelStatuses[2].tafelBezetting)
            {
                ChapooPDA_BestellingOpnemenRegistreren registreren = ChapooPDA_BestellingOpnemenRegistreren.GetInstance(5, bedienerID);
                Hide();
                registreren.ShowDialog();
            }
            else MessageBox.Show("Tafel 3 is nog niet bezet!");
        }

        private void btnOpnemen4_Click(object sender, EventArgs e)
        {
            if (tafelStatuses[3].tafelBezetting)
            {
                ChapooPDA_BestellingOpnemenRegistreren registreren = ChapooPDA_BestellingOpnemenRegistreren.GetInstance(6, bedienerID);
                Hide();
                registreren.ShowDialog();
            }
            else MessageBox.Show("Tafel 4 is nog niet bezet!");
        }

        private void btnOpnemen5_Click(object sender, EventArgs e)
        {
            if (tafelStatuses[4].tafelBezetting)
            {
                ChapooPDA_BestellingOpnemenRegistreren registreren = ChapooPDA_BestellingOpnemenRegistreren.GetInstance(7, bedienerID);
                Hide();
                registreren.ShowDialog();
            }
            else MessageBox.Show("Tafel 5 is nog niet bezet!");
        }

        private void btnOpnemen6_Click(object sender, EventArgs e)
        {
            if (tafelStatuses[5].tafelBezetting)
            {
                ChapooPDA_BestellingOpnemenRegistreren registreren = ChapooPDA_BestellingOpnemenRegistreren.GetInstance(9, bedienerID);
                Hide();
                registreren.ShowDialog();
            }
            else MessageBox.Show("Tafel 6 is nog niet bezet!");
        }

        private void btnOpnemen7_Click(object sender, EventArgs e)
        {
            if (tafelStatuses[6].tafelBezetting)
            {
                ChapooPDA_BestellingOpnemenRegistreren registreren = ChapooPDA_BestellingOpnemenRegistreren.GetInstance(10, bedienerID);
                Hide();
                registreren.ShowDialog();
            }
            else MessageBox.Show("Tafel 7 is nog niet bezet!");
        }

        private void btnOpnemen8_Click(object sender, EventArgs e)
        {
            if (tafelStatuses[7].tafelBezetting)
            {
                ChapooPDA_BestellingOpnemenRegistreren registreren = ChapooPDA_BestellingOpnemenRegistreren.GetInstance(11, bedienerID);
                Hide();
                registreren.ShowDialog();
            }
            else MessageBox.Show("Tafel 8 is nog niet bezet!");
        }

        private void btnOpnemen9_Click(object sender, EventArgs e)
        {
            if (tafelStatuses[8].tafelBezetting)
            {
                ChapooPDA_BestellingOpnemenRegistreren registreren = ChapooPDA_BestellingOpnemenRegistreren.GetInstance(12, bedienerID);
                Hide();
                registreren.ShowDialog();
            }
            else MessageBox.Show("Tafel 9 is nog niet bezet!");
        }

        private void btnOpnemen10_Click(object sender, EventArgs e)
        {
            if (tafelStatuses[9].tafelBezetting)
            {
                ChapooPDA_BestellingOpnemenRegistreren registreren = ChapooPDA_BestellingOpnemenRegistreren.GetInstance(13, bedienerID);
                Hide();
                registreren.ShowDialog();
            }
            else MessageBox.Show("Tafel 10 is nog niet bezet!");
        }
    }
}
