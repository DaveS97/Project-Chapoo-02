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
            string query = "SELECT Be.bestellingID, BE.menuItemID, K.tafelID FROM Bevat AS BE JOIN MenuItem AS MI ON MI.menuItemID = BE.menuItemID JOIN Bestellingen AS B ON B.bestellingID = BE.bestellingID JOIN Klanten AS K ON K.klantID = B.klantID ORDER BY Be.bestellingID;";
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
                    menuItemID = (int)dr["menuItemID"],
                };
                Klant klant = new Klant()
                {
                    tafelID = (int)dr["tafelID"]
                };
                ids.Add(bevat, klant);
            }
            return ids;
        }
    }
}
