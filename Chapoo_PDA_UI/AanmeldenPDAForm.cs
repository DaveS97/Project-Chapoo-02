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
            List<Werknemer> werknemers = service.GetBedienerrPins();
            bool CorrectPin = false;
            string naam = "";
            int ID = 0;
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
                MessageBox.Show($"Welkom {naam} ID: {ID}");
                ChapooPDA pda = new ChapooPDA(ID);
                pda.ShowDialog();
            }
            else
            {
                MessageBox.Show("voer een geldige pincode in (alleen bedieners kunnen hier inloggen)");
            }



            
        }
    }
}
