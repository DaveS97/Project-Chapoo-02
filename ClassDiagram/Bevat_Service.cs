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

        public List<Bevat> KrijgBestellingEnMenuItemID()
        {
            try
            {
                List<Bevat> IDs = bevat_DAO.KrijgIDS();
                return IDs;
            }
            catch (Exception e)
            {
                MessageBox.Show("Chapoo couldn't connect to the database " + e.Message);
                List<Bevat> IDS = new List<Bevat>();
                Bevat bevat = new Bevat();
                bevat.bestellingID = 1;
                bevat.bestellingID = 8;
                IDS.Add(bevat);
                return IDS;
            }
        }
    }
}
