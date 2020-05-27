using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChapooDAL;
using ChapooModel;

namespace ChapooLogic
{
    public class Werknemer_Service
    {
        private Werknemer_DAO werknemer = new Werknemer_DAO();

        public void AanpassenWerknemer(int id, string naam)
        {
            try
            {
                werknemer.pasWerknemerAan(id, naam);
            }
            catch (Exception e)
            {
                MessageBox.Show("Chapoo couldn't connect to the database" + e.Message);
            }
        }
        public List<Werknemer> KrijgWerknemers()
        {
            try
            {
                List<Werknemer> werknemers = werknemer.DB_Krijg_Alle_Werknemers();
                return werknemers;
            }
            catch (Exception e)
            {
                MessageBox.Show("Chapoo couldn't connect to the database " + e.Message);
                List<Werknemer> werknemers = new List<Werknemer>();
                Werknemer werknemer = new Werknemer();
                werknemer.ID = 1;
                werknemers.Add(werknemer);
                return werknemers;
            }
        }
    }
}
