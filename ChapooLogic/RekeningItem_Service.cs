using ChapooDAL;
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
    }
}
