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
        public List<Rekening> DB_Krijg_Alle_Rekeningen()
        {
            string query = "SELECT T.tafelID, BE.menuItemID, MI.prijs, MI.omschrijving " + 
                "FROM Tafels AS T " + 
                "JOIN Klanten AS K ON K.TafelID = T.tafelID " +
                "JOIN Bestellingen AS B ON B.bestellingID = K.klantID " +
                "JOIN Bevat AS BE ON BE.bestellingID = B.bestellingID " +
                "JOIN MenuItem AS MI ON MI.menuItemID = BE.menuItemID";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        public List<Rekening> ReadTables(DataTable dataTable)
        {
            List<Rekening> rekeningen = new List<Rekening>();

            foreach(DataRow dr in dataTable.Rows)
            {
                Rekening rekening = new Rekening()
                {
                    tafelID = (int)dr["tafelID"],
                    prijs = (float)dr["prijs"],
                    omschrijving = (string)dr["omschrijving"]
                };
            }
            return rekeningen;
        }
    }
}
