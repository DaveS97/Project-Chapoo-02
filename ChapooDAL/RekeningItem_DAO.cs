using ChapooModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapooDAL
{
    public class RekeningItem_DAO : Base
    {
        public void Write_To_Db_RekeningItem(int rekeningID, int menuItemID)
        {
            string query = "INSERT INTO RekeningItem VALUES (@rekeningID, @menuItemID)";
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@rekeningID", SqlDbType.Int) { Value = rekeningID},
                new SqlParameter("@menuItemID", SqlDbType.Int) { Value = menuItemID}
            };
        }

        public List<RekeningItem> GetRekeningItemsVoorRekeningID(int rekeningID)
        {
            string query = "SELECT rekeningItemID, rID, mItemID FROM RekeningItems WHERE rID = @rekeningID";
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@rekeningID", SqlDbType.Int) { Value = rekeningID}
            };

            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        public List<RekeningItem> ReadTables(DataTable dataTable)
        {
            List<RekeningItem> rekeningItems = new List<RekeningItem>();

            foreach (DataRow dr in dataTable.Rows)
            {
                RekeningItem rekeningItem = new RekeningItem()
                {

                };
            }
            return rekeningItems;
        }
    }
}
