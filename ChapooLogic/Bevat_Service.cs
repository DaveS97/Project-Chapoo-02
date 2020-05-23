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
    public class Bevat_Service : Base
    {
        private Bevat_DAO bevat_DAO = new Bevat_DAO();

        public Dictionary<Bevat> KrijgBestellingEnMenuItemID()
        {
            try
            {
                Dictionary<Bevat> IDs = bevat_DAO.GetMenuItems();
                return IDs;
            }
            catch (Exception e)
            {
                MessageBox.Show("Chapoo couldn't connect to the database " + e.Message);
                Dictionary<MenuItem> werknemers = new Dictionary<MenuItem>();
                MenuItem item = new MenuItem();
                item.ID = 1;
                item.Aantal = 0;
                item.ItemNaam = "menuItem";
                item.Prijs = 1.0;


                werknemers.Add(item);
                return werknemers;
            }
        }
    }
}
