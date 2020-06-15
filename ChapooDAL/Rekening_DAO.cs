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
            string query = "SELECT T.tafelID, BE.menuItemID, MI.prijs, MI.omschrijving " +
                "FROM Tafels AS T JOIN Klanten AS K ON K.TafelID = T.tafelID  " +
                "JOIN Bestellingen AS B ON B.bestellingID = K.klantID " +
                "JOIN Bevat AS BE ON BE.bestellingID = B.bestellingID " +
                "JOIN MenuItem AS MI ON MI.menuItemID = BE.menuItemID " +
                "WHERE K.tafelID = @tafelID";

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
