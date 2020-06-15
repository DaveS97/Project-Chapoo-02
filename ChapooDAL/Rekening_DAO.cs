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
    public class Rekening_DAO : Base
    {
        public List<Bon> DB_Krijg_Alle_Rekeningen(int tafelID)
        {
            string query = "";

            SqlParameter[] sqlParameters =
            {
                    new SqlParameter("@tafelID", SqlDbType.Int) { Value = tafelID}
            };

            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        public List<Bon> ReadTables(DataTable dataTable)
        {
            List<Bon> rekeningen = new List<Bon>();

            foreach(DataRow dr in dataTable.Rows)
            {
                Bon bon = new Bon()
                {
                    Prijs = (decimal)dr["prijs"],
                    Omschrijving = (string)dr["omschrijving"],

                    
                };
            }
            return rekeningen;
        }
    }
}
