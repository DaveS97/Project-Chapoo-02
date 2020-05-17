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
    public class MenuItem_Service
    {
        private MenuItem_DAO menuItem_DAO = new MenuItem_DAO();

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
                menuItem.Prijs = 8.5;
                menuItems.Add(menuItem);
                return menuItems;
            }
        }
    }
}
