using ChapooModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ChapooDAL
{
    public class Bevat_DAO : Base
    {
        public Dictionary<Bevat, Klant> KrijgIDS()
        {
            string query = "SELECT DISTINCT B.tijdOpname, B.bestellingID, K.tafelID  FROM Bestellingen AS B JOIN Klanten AS K ON K.klantID = B.klantID JOIN Bevat AS BE ON BE.bestellingID = B.bestellingID JOIN MenuItem AS MI ON MI.menuItemID = BE.menuItemID WHERE B.is_Gereed = 0 AND MI.typeGerecht != 5;";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
       
        public Dictionary<Bevat, Klant> KrijgIDSGereed()
        {
            string query = "SELECT DISTINCT B.tijdOpname, B.bestellingID, K.tafelID  FROM Bestellingen AS B JOIN Klanten AS K ON K.klantID = B.klantID JOIN Bevat AS BE ON BE.bestellingID = B.bestellingID JOIN MenuItem AS MI ON MI.menuItemID = BE.menuItemID WHERE B.is_Gereed = 1 AND MI.typeGerecht != 5;";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        public Dictionary<Bevat, Klant> KrijgDrankjesOpenstaand()
        {
            string query = "SELECT DISTINCT BE.bestellingID, B.tijdOpname, K.tafelID FROM Bevat AS BE JOIN MenuItem AS MI ON MI.menuItemID = BE.menuItemID JOIN Bestellingen AS B ON B.bestellingID = BE.bestellingID JOIN Klanten AS K ON K.klantID = B.klantID WHERE MI.typeGerecht = 5;";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        public void Bestelling_Gereed_Zetten(int bestelNummer)
        {
            string query = "UPDATE Bestellingen SET is_Gereed = 1 WHERE bestellingID = @bestelNummer;";
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@bestelNummer", SqlDbType.Int) { Value = bestelNummer}
            };
            ExecuteEditQuery(query, sqlParameters);
        }
        public void Bestelling_Ongereed_Zetten(int bestelNummer)
        {
            string query = "UPDATE Bestellingen SET is_Gereed = 0 WHERE bestellingID = @bestelNummer;";
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@bestelNummer", SqlDbType.Int) { Value = bestelNummer}
            };
            ExecuteEditQuery(query, sqlParameters);
        }

        public void Write_To_Db_Bevat(int menuItemID, int bestellingID, string commentaar, int aantal)
        {
            string query = "INSERT INTO Bevat VALUES (@menuItemID, @bestellingID, @commentaar, @aantal)";
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@menuItemID", SqlDbType.Int) { Value = menuItemID},
                new SqlParameter("@bestellingID", SqlDbType.Int) { Value = bestellingID},
                new SqlParameter("@commentaar", SqlDbType.VarChar) {Value = commentaar},
                new SqlParameter("@aantal", SqlDbType.Int) {Value = aantal}
            };
            ExecuteEditQuery(query, sqlParameters);
        }

        private Dictionary<Bevat, Klant> ReadTables(DataTable dataTable)
        {
            Dictionary<Bevat, Klant> ids = new Dictionary<Bevat, Klant>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Bevat bevat = new Bevat()
                {
                    bestellingID = (int)dr["bestellingID"],
                    tijdOpname = (DateTime)dr["tijdOpname"],
                };
                Klant klant = new Klant()
                {
                    tafelID = (int)dr["tafelID"]
                };
                ids.Add(bevat, klant);
            }
            return ids;
        }

        public Dictionary<Bevat, Klant> Krijg_Bestelling_Beschrijving(string bestellingID)
        {
            string query = "SELECT BE.menuItemID, MI.omschrijving, MI.typeGerecht, BE.bestellingID, B.tijdOpname, BE.commentaar, BE.aantal, K.tafelID, K.klantID FROM Bevat AS BE JOIN MenuItem AS MI ON MI.menuItemID = BE.menuItemID JOIN Bestellingen AS B ON B.bestellingID = BE.bestellingID JOIN Klanten AS K ON K.klantID = B.klantID WHERE BE.bestellingID = @bestellingID;";
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@bestellingID", SqlDbType.Int) { Value = bestellingID}
            };
            return ReadTablesBMO(ExecuteSelectQuery(query, sqlParameters));
        }
        private Dictionary<Bevat, Klant> ReadTablesBMO(DataTable dataTable)
        {
            Dictionary<Bevat, Klant> klantenInfo = new Dictionary<Bevat, Klant>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Bevat info = new Bevat()
                {
                    menuItemID = (int)dr["menuItemID"],
                    menuItemBeschrijving = (string)dr["omschrijving"],
                    typeGerecht = (int)dr["typeGerecht"],
                    bestellingID = (int)dr["bestellingID"],
                    tijdOpname = (DateTime)dr["tijdOpname"],
                    Opmerkingen = (string)dr["commentaar"],
                    Aantal = (int)dr["aantal"]
                };
                Klant klant = new Klant()
                {
                    tafelID = (int)dr["tafelID"],
                    ID = (int)dr["klantID"]
                };
                klantenInfo.Add(info, klant);
            }
            return klantenInfo;
        }
    }
}
