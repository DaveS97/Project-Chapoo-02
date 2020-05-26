using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapooDAL;
using System.Windows.Forms;
using ChapooModel;

   

namespace ChapooLogic
{
    public class Klant_Service
    {
        public Klant_DAO klant_DAO = new Klant_DAO();

        public List<Klant> KrijgKlanten()
        {
            try
            {
                List<Klant> klanten = klant_DAO.DB_Krijg_Alle_Klanten();
                return klanten;
            }
            catch (Exception e)
            {
                MessageBox.Show("Chapoo couldn't connect to the database " + e.Message);
                List<Klant> klanten = new List<Klant>();
                Klant klant1 = new Klant();
                klant1.ID = 1;
                klanten.Add(klant1);
                return klanten;
            }
        }
    }
}
