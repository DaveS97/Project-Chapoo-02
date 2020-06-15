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
        public List<Inkomsten> GetBonnen()
        {
            string query = "select rekeningID, kID, datum, totaal from Rekening";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        private List<Inkomsten> ReadTables(DataTable dataTable)
        {
            List<Inkomsten> rekeningen = new List<Inkomsten>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Inkomsten rekening = new Inkomsten()
                {
                    BonID = (int)dr["bonID"],
                    BedienerID = (int)dr["bedienerID"],
                    Fooi = (int)dr["fooi"],
                    BTW = (int)dr["btw"],
                    Totaal = (int)dr["totaal"],
                };
                rekeningen.Add(rekening);
            }
            return rekeningen;
        }
  

    }
}
