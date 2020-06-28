using ChapooDAL;
using ChapooModel;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ChapooLogic
{
    public class Bevat_Service 
    {
        private Bevat_DAO bevat_DAO = new Bevat_DAO();

        public Dictionary<Bevat, Klant> KrijgDrankjes()
        {
            try
            {
                Dictionary<Bevat, Klant> drankjesEnInfoKlant = bevat_DAO.KrijgDrankjesOpenstaand();
                return drankjesEnInfoKlant;
            }
            catch (Exception e)
            {
                MessageBox.Show("Chapoo couldn't connect to the database " + e.Message);
                return new Dictionary<Bevat, Klant>();
            }
        }
        public Dictionary<Bevat,Klant> AutoBestellingLaden()
        {
            try
            {
                Dictionary<Bevat, Klant> Bestellingen = bevat_DAO.KrijgBestellingen();
                return Bestellingen;
            }
            catch (Exception e)
            {
                MessageBox.Show("Chapoo couldn't connect to the database " + e.Message);
                return new Dictionary<Bevat, Klant>();
            }
        }
        public Dictionary<Bevat, Klant> KrijgBestellingEnMenuItemID()
        {
            try
            {
                Dictionary<Bevat, Klant> IDs = bevat_DAO.KrijgBestellingenEnKlantInfo();
                return IDs;
            }
            catch (Exception e)
            {
                MessageBox.Show("Chapoo couldn't connect to the database " + e.Message);
                return new Dictionary<Bevat, Klant>();
            }
        }
        public Dictionary<Bevat, Klant> KrijgBestellingEnMenuItemIDGereed()
        {
            try
            {
                Dictionary<Bevat, Klant> IDs = bevat_DAO.KrijgIDSGereed();
                return IDs;
            }
            catch (Exception e)
            {
                MessageBox.Show("Chapoo couldn't connect to the database " + e.Message);
                return new Dictionary<Bevat, Klant>();
            }
        }

        public void BestellingGereedZetten(int bestelNummer)
        {
            try
            {
                bevat_DAO.Bestelling_Gereed_Zetten(bestelNummer);
            }
            catch (Exception e)
            {
                MessageBox.Show("Chapoo couldn't connect to the database " + e.Message);
            }
        }
        public void BestellingOngereedZetten(int bestelNummer)
        {
            try
            {
                bevat_DAO.Bestelling_Ongereed_Zetten(bestelNummer);
            }
            catch (Exception e)
            {
                MessageBox.Show("Chapoo couldn't connect to the database " + e.Message);
            }
        }

        public Dictionary<Bevat, Klant> KrijgBeschrijving(string bestellingID)
        {
            try
            {
                Dictionary<Bevat, Klant> klantenInfo = bevat_DAO.Krijg_Bestelling_Beschrijving(bestellingID);
                return klantenInfo;
            }
            catch (Exception e)
            {
                MessageBox.Show("Chapoo couldn't connect to the database " + e.Message);
                return new Dictionary<Bevat, Klant>();
            }
        }

        public void Write_To_Db_Bevat(int menuItemID, int bestellingID, string commentaar, int aantal)
        {
            try
            {
                bevat_DAO.Write_To_Db_Bevat(menuItemID, bestellingID, commentaar, aantal);
            }
            catch (Exception e)
            {
                MessageBox.Show("Chapoo couldn't connect to the database " + e.Message);
            }
        }
    }
}
