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

        public void Write_To_Db_RekeningItem(int rekeningID, int menuItemID)
        {
            try
            {
                rekeningItem.Write_To_Db_RekeningItem(rekeningID, menuItemID);
            }
            catch (Exception e)
            {
                MessageBox.Show("Chapoo couldn't connect to the database " + e.Message);
            }
        }
        public List<RekeningItem> DB_Get_Rekeningitems(int klantID)
        {
            try
            {
                List<RekeningItem> items = rekeningItem.DB_Get_Rekeningitems(klantID);
                return items;
            }
            catch (Exception e)
            {
                MessageBox.Show("Chapoo couldn't connect to the database " + e.Message);
                List<RekeningItem> items = new List<RekeningItem>();
                return items;
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
