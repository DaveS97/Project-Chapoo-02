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
        public List<Rekening> DB_Krijg_Rekeningen(int klantID)
        {
            string query = "geeft 1 rekening terug met een bepaald klat id";

            SqlParameter[] sqlParameters =
            {
                    new SqlParameter("@kID", SqlDbType.Int) { Value = klantID}
            };
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        public List<Rekening> ReadTables(DataTable dataTable)
        {
            List<Rekening> rekeningen = new List<Rekening>();

            foreach(DataRow dr in dataTable.Rows)
            {
                Rekening rekening = new Rekening()
                {
                    ID = (int)dr[""],
                    KlantID = (int)dr[""],
                    Datum = (DateTime)dr[""],
                    TotaalPrijs = (decimal)dr[""],
                    fooi = (decimal)dr[""],
                    BTW = (decimal)dr[""],
                };
            }
            return rekeningen;
        }
    }
}
