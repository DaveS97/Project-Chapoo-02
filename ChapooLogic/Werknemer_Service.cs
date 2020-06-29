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

        public void AanpassenWerknemer(int id, string naam, int PIN)
        {
            try
            {
                werknemer.pasWerknemerAan(id, naam, PIN);
            }
            catch (Exception e)
            {
                MessageBox.Show("Chapoo couldn't connect to the database" + e.Message);
            }
        }
        public void Write_to_db_verwijderenWerknemer(int ID)
        {
            try
            {
                werknemer.Write_To_db_VerwijderenWerknemer(ID);
            }
            catch (Exception e)
            {
                MessageBox.Show("Chapoo couldn't connect to the database" + e.Message);
            }
        }
        public void Write_To_db_ToevoegenWerknemer(int Type, string naam, int pin, bool actief)
        {
            try
            {
                werknemer.Write_To_db_toevoegenWerknemer(Type, naam, pin, actief);
            }
            catch (Exception e)
            {
                MessageBox.Show("Chapoo couldn't connect to the database" + e.Message);
            }
        }
        public List<Werknemer> GetWerknemerPins()
        {
            try
            {
                List<Werknemer> werknemers = werknemer.GetWerknemerPINs();
                return werknemers;
            }
            catch (Exception e)
            {
                MessageBox.Show("Chapoo couldn't connect to the database" + e.Message);
                List<Werknemer> werknemers = new List<Werknemer>();
                Werknemer werknemer = new Werknemer();
                werknemer.ID = 1;
                werknemers.Add(werknemer);
                return werknemers;
            }
        }
        public List<Werknemer> GetBedienerrPins()
        {
            try
            {
                List<Werknemer> bedieners = werknemer.GetBedienerPINs();
                return bedieners;
            }
            catch (Exception e)
            {
                MessageBox.Show("Chapoo couldn't connect to the database" + e.Message);
                List<Werknemer> werknemers = new List<Werknemer>();
                Werknemer werknemer = new Werknemer();
                werknemer.ID = 1;
                werknemers.Add(werknemer);
                return werknemers;
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
        public List<Bediener> GetBedienersVanWerknemerID(int werknemerID)
        {
            try
            {
                List<Bediener> bedieners = werknemer.GetBedienersVanWerknemerID(werknemerID);
                return bedieners;
            }
            catch (Exception e)
            {
                MessageBox.Show("Chapoo couldn't connect to the database" + e.Message);
                List<Bediener> bedieners = new List<Bediener>();
                return bedieners;
            }
        }

        public List<Werknemer> GetWerknemerVanBedienerID(int bedienerID)
        {
            try
            {
                List<Werknemer> werknemers = werknemer.GetWerknemerVanBedienerID(bedienerID);
                return werknemers;
            }
            catch (Exception e)
            {
                MessageBox.Show("Chapoo couldn't connect to the database" + e.Message);
                List<Werknemer> werknemers = new List<Werknemer>();
                return werknemers;
            }
        }
    }
}
