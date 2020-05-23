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
    public class MenuItem_DAO : Base
    {
        /*public List<MenuItem> KrijgIDS()
        {
            string query = "";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }*/

        public Dictionary<Bestelling, MenuItem> Krijg_Bestelling_Beschrijving(string bestellingID)
        {
            string query = "SELECT Be.bestellingID, BE.menuItemID, MI.omschrijving FROM Bevat AS BE JOIN MenuItem AS MI ON MI.menuItemID = BE.menuItemID WHERE BE.bestellingID = @bestellingID;";
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@bestellingID", SqlDbType.Int) { Value = bestellingID}
            };
            return ReadTablesBMO(ExecuteSelectQuery(query, sqlParameters));
        }

        private Dictionary<Bestelling, MenuItem> ReadTablesBMO(DataTable dataTable)
        {
            Dictionary<Bestelling, MenuItem> bestellingen = new Dictionary<Bestelling, MenuItem>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Bestelling bestelling = new Bestelling()
                {
                    bestellingID = (int)dr["bestellingID"]
                };
                MenuItem menuItem = new MenuItem()
                {
                    ID = (int)dr["menuItemID"],
                    Beschrijving = (string)dr["omschrijving"],
                };
                bestellingen.Add(bestelling, menuItem);
            }
            return bestellingen;
        }
    }
}
