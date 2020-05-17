using ChapooDAL;
using ChapooModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChapooLogic
{
    public class Bestelling_Service
    {
        private Bestelling_DAO bestelling = new Bestelling_DAO();

        public List<Bestelling> KrijgBestellingen()
        {
            try
            {
                List<Bestelling> bestellingen = bestelling.DB_Krijg_Alle_Bestellingen();
                return bestellingen;
            }
            catch (Exception e)
            {
                MessageBox.Show("Chapoo couldn't connect to the database " + e.Message);
                List<Bestelling> bestellingen = new List<Bestelling>();
                Bestelling bestelling = new Bestelling();
                bestelling.bedienerID = 1;
                bestelling.bestellingID = 1;
                bestelling.klantID = 1;
                bestellingen.Add(bestelling);
                return bestellingen;
            }
        }
    }
}
