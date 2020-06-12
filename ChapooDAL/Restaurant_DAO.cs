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
    public class Restaurant_DAO : Base
    {
        public List<TafelStatus> Db_Get_All_Tafels()
        {
            string query = "SELECT t.tafelID, b.bestellingID, b.is_Gereed " +
                "From Tafels as t " +
                "JOIN Bestellingen as b on t.bedienerID = b.bedienerID";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<TafelStatus> ReadTables(DataTable dataTable)
        {
            List<TafelStatus> tafelStatuses = new List<TafelStatus>();


            foreach (DataRow dr in dataTable.Rows)
            {

                TafelStatus tafelStatus = new TafelStatus()
                {
                    tafelNummmer = (int)dr["tafelID"],
                    bestellingId = (int)dr["bestellingID"],
                    bestellingStatus = (bool)(dr["is_Gereed"])
                };
                tafelStatuses.Add(tafelStatus);
            }
            return tafelStatuses;

        }
    }
}
