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
    }
}
