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

        public void Write_To_Db_Bestelling(int bedienerID, int klantID, string dateTime)
        {
            string query = $"INSERT INTO Bestellingen VALUES (@bedienerID, @klantID, 0, @dateTime)";
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@bedienerID", SqlDbType.Int) { Value = bedienerID},
                new SqlParameter("@klantID", SqlDbType.Int) { Value = klantID},
                new SqlParameter("@dateTime", SqlDbType.DateTime) { Value = dateTime}
            };
            ExecuteEditQuery(query, sqlParameters);
        }

        public List<Bestelling> DB_Krijg_Bestelling_Voor_Klant(int klantID, string dateTime)
        {
            string query = $"SELECT bestellingID, bedienerID, klantID FROM [Bestellingen] WHERE klantID = {klantID} AND tijdOpname = '{dateTime}'";
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
                    bedienerID = (int)dr["bedienerID"],
                    klantID = (int)dr["klantID"]
                };
                bestellingen.Add(bestelling);
            }
            return bestellingen;
        }
    }
}
