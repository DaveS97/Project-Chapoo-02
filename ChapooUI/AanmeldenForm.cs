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
        public AanmeldenForm()
        {
            InitializeComponent();
        }

        private void btnAanmelden_Click(object sender, EventArgs e)
        {
            Werknemer_Service service = new Werknemer_Service();
            List<Werknemer> werknemers = service.GetWerknemerPins();
            bool CorrectPin;
            
            if (tbPin.Text.Length != 0)
            {
                int pin = int.Parse(tbPin.Text);
                foreach (Werknemer item in werknemers)
                {
                    if (item.)
                }
            }
            
        }
    }
}
