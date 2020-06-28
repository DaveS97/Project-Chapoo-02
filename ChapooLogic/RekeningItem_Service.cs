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
    public class RekeningItem_Service
    {
        RekeningItem_DAO rekeningItem = new RekeningItem_DAO();

        public void Write_To_Db_RekeningItem(int rekeningID, int menuItemID, int aantal)
        {
            try
            {
                rekeningItem.Write_To_Db_RekeningItem(rekeningID, menuItemID, aantal);
            }
            catch (Exception e)
            {
                MessageBox.Show("Chapoo couldn't connect to the database " + e.Message);
            }
        }

        public List<RekeningItem> GetRekeningItemsVoorRekeningID(int rekeningID)
        {
            try
            {
                List<RekeningItem> items = rekeningItem.GetRekeningItemsVoorRekeningID(rekeningID);

                return items;
            }
            catch (Exception e)
            {
                List<RekeningItem> items = new List<RekeningItem>();
                MessageBox.Show("Chapoo couldn't connect to the database " + e.Message);

                return items;
            }
        }
    }
}
