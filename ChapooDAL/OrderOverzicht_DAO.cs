using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Collections.ObjectModel;
using ChapooModel;

namespace ChapooDAL
{
    public class OrderOverzicht_DAO : Base
    {
        public List<OrderStatus> Db_Get_All_TafelsOrders()
        {
            string query = "SELECT t.tafelID, b.bestellingID, b.is_Gereed " +
                "From Tafels as t " +
                "JOIN Bestellingen as b on t.bedienerID = b.bedienerID";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<OrderStatus> ReadTables(DataTable dataTable)
        {
            List<OrderStatus> orderStatuses = new List<OrderStatus>();


            foreach (DataRow dr in dataTable.Rows)
            {

                OrderStatus orderStatus = new OrderStatus()
                {
                    tafelNummer = (int)dr["tafelID"],
                    bestellingId = (int)dr["bestellingID"],
                    bestellingStatus = (bool)(dr["is_Gereed"])
                };
                orderStatuses.Add(orderStatus);
            }
            return orderStatuses;

        }
    }

}
