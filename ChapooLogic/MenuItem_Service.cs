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
        private MenuItem_DAO menuItem_DAO = new MenuItem_DAO();

        public List<MenuItem> GetMenuItems()
        {
            try
            {
                List<MenuItem> item = menuItem_DAO.GetMenuItems();
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
        public List<MenuItem> KrijgBeschrijving()
        {
            try
            {
                List<MenuItem> menuItems = menuItem_DAO.Krijg_Bestelling_Beschrijving();
                return menuItems;
            }
            catch (Exception e)
            {
                MessageBox.Show("Chapoo couldn't connect to the database " + e.Message);
                List<MenuItem> menuItems = new List<MenuItem>();
                MenuItem menuItem = new MenuItem();
                menuItem.ID= 1;
                menuItem.ItemNaam = "Biefstuk";
                menuItem.Aantal = 3;
                menuItem.Prijs = 8.5;
                menuItems.Add(menuItem);
                return menuItems;
            }
        }
    }
}
