using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChapooDAL;
using ChapooModel;
using MenuItem = ChapooModel.MenuItem;

namespace ChapooLogic
{
    public class MenuItem_Service
    {
        private MenuItem_DAO menuItem = new MenuItem_DAO();

        public List<MenuItem> GetMenuItems()
        {
            try
            {
                List<MenuItem> item = menuItem.GetMenuItems();
                return item;
            }
            catch (Exception e)
            {
                MessageBox.Show("Chapoo couldn't connect to the database " + e.Message);
                List<MenuItem> werknemers = new List<MenuItem>();
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
