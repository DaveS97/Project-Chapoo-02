using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChapooDAL;
using MenuItem = ChapooModel.MenuItem;

namespace ChapooLogic
{
    public class MenuItem_Service
    {
        private MenuItem_DAO menuItem_DAO = new MenuItem_DAO();
        private MenuItem_DAO menuItem = new MenuItem_DAO();

        public List<MenuItem> GetDrinkMenu()
        {
            try
            {
                List<MenuItem> item = menuItem.GetDrinkMenu();
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
                item.Prijs = 1.0M;
                item.menu = 1;
                werknemers.Add(item);
                return werknemers;
            }
        }
        public List<MenuItem> GetDinnerMenu()
        {
            try
            {
                List<MenuItem> item = menuItem.GetDinnerMenu();
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
                item.Prijs = 1.0M;
                item.menu = 1;
                werknemers.Add(item);
                return werknemers;
            }
        }

        public List<MenuItem> GetLunchMenu()
        {
            try
            {
                List<MenuItem> item = menuItem.GetLunchMenu();
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
                item.Prijs = 1.0M;
                item.menu = 1;


                werknemers.Add(item);
                return werknemers;
            }
        }
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
                item.Prijs = 1.0M;
                item.menu = 1;
                werknemers.Add(item);
                return werknemers;
            }
        }
        public List<ChapooModel.MenuItem> KrijgBeschrijving()
        {
            try
            {
                List<ChapooModel.MenuItem> menuItems = menuItem_DAO.Krijg_Bestelling_Beschrijving();
                return menuItems;
            }
            catch (Exception e)
            {
                MessageBox.Show("Chapoo couldn't connect to the database " + e.Message);
                List<ChapooModel.MenuItem> menuItems = new List<ChapooModel.MenuItem>();
                ChapooModel.MenuItem menuItem = new ChapooModel.MenuItem();
                menuItem.ID= 1;
                menuItem.ItemNaam = "Biefstuk";
                menuItem.Aantal = 3;
                menuItem.Prijs = 8.5M;
                menuItem.menu = 1;
                menuItems.Add(menuItem);
                return menuItems;
            }
        }
    }
}
