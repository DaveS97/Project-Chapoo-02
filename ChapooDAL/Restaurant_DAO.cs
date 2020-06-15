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
            string query = "SELECT tafelID, is_bezet " + "from Tafels";
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
                    tafelNummer = (int)dr["tafelID"],
                    tafelBezetting = (bool)(dr["is_bezet"])
                };
                tafelStatuses.Add(tafelStatus);
            }
            return tafelStatuses;

        }

       
    }
}
