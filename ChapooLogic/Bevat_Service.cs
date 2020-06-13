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
                Dictionary<Bevat, Klant> lijst = new Dictionary<Bevat, Klant>();
                Bevat bevat = new Bevat();
                bevat.bestellingID = 1;
                bevat.bestellingID = 8;
                Klant klant = new Klant();
                klant.tafelID = 2;
                lijst.Add(bevat, klant);
                return lijst;
            }
        }
        public Dictionary<Bevat, Klant> KrijgBestellingEnMenuItemID()
        {
            try
            {
                Dictionary<Bevat, Klant> IDs = bevat_DAO.KrijgIDS();
                return IDs;
            }
            catch (Exception e)
            {
                MessageBox.Show("Chapoo couldn't connect to the database " + e.Message);
                Dictionary<Bevat, Klant> lijst = new Dictionary<Bevat, Klant>();
                Bevat bevat = new Bevat();
                bevat.bestellingID = 1;
                bevat.bestellingID = 8;
                Klant klant = new Klant();
                klant.tafelID = 2;
                lijst.Add(bevat, klant);
                return lijst;
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
                Dictionary<Bevat, Klant> lijst = new Dictionary<Bevat, Klant>();
                Bevat bevat = new Bevat();
                bevat.bestellingID = 1;
                bevat.bestellingID = 8;
                Klant klant = new Klant();
                klant.tafelID = 2;
                lijst.Add(bevat, klant);
                return lijst;
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
                Dictionary<Bevat, Klant> klantenInfo = new Dictionary<Bevat, Klant>();
                Bevat info = new Bevat();
                info.bestellingID = 1;
                Klant klant = new Klant();
                klant.ID = 1;
                klantenInfo.Add(info, klant);
                return klantenInfo;
            }
        }
    }
}
