using ChapooModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
            string query = "SELECT DISTINCT Be.bestellingID, K.tafelID FROM Bevat AS BE JOIN MenuItem AS MI ON MI.menuItemID = BE.menuItemID JOIN Bestellingen AS B ON B.bestellingID = BE.bestellingID JOIN Klanten AS K ON K.klantID = B.klantID ORDER BY Be.bestellingID;";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private Dictionary<Bevat, Klant> ReadTables(DataTable dataTable)
        {
            Dictionary<Bevat, Klant> ids = new Dictionary<Bevat, Klant>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Bevat bevat = new Bevat()
                {
                    bestellingID = (int)dr["bestellingID"],
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
            string query = "SELECT BE.menuItemID, MI.omschrijving, MI.typeGerecht, BE.bestellingID, K.tafelID, K.klantID FROM Bevat AS BE JOIN MenuItem AS MI ON MI.menuItemID = BE.menuItemID JOIN Bestellingen AS B ON B.bestellingID = BE.bestellingID JOIN Klanten AS K ON K.klantID = B.klantID WHERE BE.bestellingID = @bestellingID;";
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
                    bestellingID = (int)dr["bestellingID"]
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
