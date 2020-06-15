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

namespace ChapooUI
{
    public partial class AanmeldenForm : Form
    {
        private AanmeldenForm()
        {
            InitializeComponent();
        }
        private static AanmeldenForm Instance;
        public static AanmeldenForm GetInstance()
        {
            if (Instance == null)
                Instance = new AanmeldenForm();

            return Instance;
        }
        private void btnAanmelden_Click(object sender, EventArgs e)
        {
            Werknemer_Service service = new Werknemer_Service(); 
            List<Werknemer> werknemers = service.GetWerknemerPins();
            bool CorrectPin = false;
            string naam = "";
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
                MessageBox.Show($"Welkom {naam} jij bent een {types} ");
                Chapoo form = Chapoo.GetInstance();
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("voer een geldige pincode in");
            }

        }

        private void AanmeldenForm_Load(object sender, EventArgs e)
        {

        }
    }
}
