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
    public class Inkomsten_DAO : Base
    {
        public List<Rekening> GetBonnen()
        {
            string query = "SELECT rekeningID, kID, datum, totaal, fooi, btw FROM Rekening WHERE totaal IS NOT NULL";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        private List<Rekening> ReadTables(DataTable dataTable)
        {
            List<Rekening> rekeningen = new List<Rekening>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Rekening rekening = new Rekening()
                {
                    ID = (int)dr["rekeningID"],
                    Datum = (DateTime)dr["datum"],
                    KlantID = (int)dr["kID"],
                    Fooi = (decimal)dr["fooi"],
                    BTW = (decimal)dr["btw"],
                    TotaalPrijs = (decimal)dr["totaal"],
                };
                rekeningen.Add(rekening);
            }
            return rekeningen;
        }
  

    }
}
