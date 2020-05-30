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
    public class Werknemer_DAO : Base
    {
        public void pasWerknemerAan(int ID, string naam)
        {
            string query = "UPDATE Werknemers SET werknemerNaam= @naam where werknemerID =@ID";
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@naam", SqlDbType.VarChar) { Value = naam},
                new SqlParameter("@ID", SqlDbType.Int) { Value = ID}
            };
            ExecuteEditQuery(query, sqlParameters);
        }

        public void Write_To_db_VerwijderenWerknemer(int ID)
        {
            string query = "update Werknemers Set is_Actief=0 where werknemerID = @ID";
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@ID", SqlDbType.Int) { Value = ID}
            };
            ExecuteEditQuery(query, sqlParameters);
        }
        public void Write_To_db_toevoegenWerknemer(int Type, string Naam, int pin, bool actief)
        {
            string query = "INSERT Werknemers Values (@Type, @naam, @pin, @actief)";
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@Type", SqlDbType.Int) { Value = Type},
                new SqlParameter("@naam", SqlDbType.VarChar) { Value = Naam},
                new SqlParameter("@pin", SqlDbType.Int) { Value = pin},
                new SqlParameter("@actief", SqlDbType.Bit) { Value = actief}
            };
            ExecuteEditQuery(query, sqlParameters);
        }
        public List<Werknemer> DB_Krijg_Alle_Werknemers()
        {
            string query = "SELECT werknemerID, werknemerType, werknemerNaam FROM [Werknemers] Where is_Actief = 1";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        public List<Werknemer> GetWerknemerPINs()
        {
            string query = "SELECT werknemerID, werknemerPin, werknemerNaam FROM [Werknemers] Where is_Actief = 1";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Werknemer> ReadTables(DataTable dataTable)
        {
            List<Werknemer> werknemers = new List<Werknemer>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Werknemer werknemer = new Werknemer()
                {
                    ID = (int)dr["werknemerID"],
                    Type = (int)dr["werknemerType"],
                    Naam = (string)dr["werknemerNaam"].ToString()
                };
                werknemers.Add(werknemer);
            }
            return werknemers;
        }
    }
}
