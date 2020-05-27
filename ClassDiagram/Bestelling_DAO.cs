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
    public class Bestelling_DAO : Base
    {
        public List<Bestelling> DB_Krijg_Alle_Bestellingen()
        {
            string query = "SELECT bestellingID, bedienerID, klantID FROM [Bestellingen]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        private List<Bestelling> ReadTables(DataTable dataTable)
        {
            List<Bestelling> bestellingen = new List<Bestelling>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Bestelling bestelling = new Bestelling()
                {
                    bestellingID = (int)dr["bestellingID"],
                    bedienerID = (int)dr["bestellingID"],
                    klantID = (int)dr["klantID"]
                };
                bestellingen.Add(bestelling);
            }
            return bestellingen;
        }
    }
}
