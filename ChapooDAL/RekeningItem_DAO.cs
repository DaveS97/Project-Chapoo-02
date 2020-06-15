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
    }
}
