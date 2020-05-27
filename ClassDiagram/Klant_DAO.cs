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
    public class Klant_DAO : Base
    {
        public List<Klant> DB_Krijg_Alle_Klanten()
        {
            string query = "SELECT klantID FROM [klant]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        private List<Klant> ReadTables(DataTable dataTable)
        {
            List<Klant> klanten = new List<Klant>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Klant klant = new Klant()
                {
                    ID = (int)dr["klantID"],
                };
                klanten.Add(klant);
            }
            return klanten;
        }
    }
}
