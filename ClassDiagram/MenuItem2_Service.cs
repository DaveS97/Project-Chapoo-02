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
    public class MenuItem2_Service
    {
        private MenuItem2_DAO menuItem = new MenuItem2_DAO();

        public List<MenuItem2> GetDrinkMenu()
        {
            try
            {
                List<MenuItem2> item = menuItem.GetDrinkMenu();
                return item;
            }
            catch (Exception e)
            {
                MessageBox.Show("Chapoo couldn't connect to the database " + e.Message);
                List<MenuItem2> werknemers = new List<MenuItem2>();
                MenuItem2 item = new MenuItem2();
                item.ID = 1;
                item.Aantal = 0;
                item.ItemNaam = "menuItem";
                item.Prijs = 1.0M;
                item.menu = 1;
                werknemers.Add(item);
                return werknemers;
            }
        }
        public List<MenuItem2> GetDinnerMenu()
        {
            try
            {
                List<MenuItem2> item = menuItem.GetDinnerMenu();
                return item;
            }
            catch (Exception e)
            {
                MessageBox.Show("Chapoo couldn't connect to the database " + e.Message);
                List<MenuItem2> werknemers = new List<MenuItem2>();
                MenuItem2 item = new MenuItem2();
                item.ID = 1;
                item.Aantal = 0;
                item.ItemNaam = "menuItem";
                item.Prijs = 1.0M;
                item.menu = 1;
                werknemers.Add(item);
                return werknemers;
            }
        }

        public List<MenuItem2> GetLunchMenu()
        {
            try
            {
                List<MenuItem2> item = menuItem.GetLunchMenu();
                return item;
            }
            catch (Exception e)
            {
                MessageBox.Show("Chapoo couldn't connect to the database " + e.Message);
                List<MenuItem2> werknemers = new List<MenuItem2>();
                MenuItem2 item = new MenuItem2();
                item.ID = 1;
                item.Aantal = 0;
                item.ItemNaam = "menuItem";
                item.Prijs = 1.0M;
                item.menu = 1;


                werknemers.Add(item);
                return werknemers;
            }
        }
        public List<MenuItem2> GetMenuItems()
        {
            try
            {
                List<MenuItem2> item = menuItem.GetMenuItems();
                return item;
            }
            catch (Exception e)
            {
                MessageBox.Show("Chapoo couldn't connect to the database " + e.Message);
                List<MenuItem2> werknemers = new List<MenuItem2>();
                MenuItem2 item = new MenuItem2();
                item.ID = 1;
                item.Aantal = 0;
                item.ItemNaam = "menuItem";
                item.Prijs = 1.0M;
                item.menu = 1;
                werknemers.Add(item);
                return werknemers;
            }
        }
       
    }
}
