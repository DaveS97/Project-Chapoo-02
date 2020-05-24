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
        public List<Bevat> KrijgIDS()
        {
            string query = "SELECT Be.bestellingID, BE.menuItemID FROM Bevat AS BE JOIN MenuItem AS MI ON MI.menuItemID = BE.menuItemID ORDER BY Be.bestellingID;";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Bevat> ReadTables(DataTable dataTable)
        {
            List<Bevat> ids = new List<Bevat>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Bevat bevat = new Bevat()
                {
                    bestellingID = (int)dr["bestellingID"],
                    menuItemID = (int)dr["menuItemID"],
                };
                ids.Add(bevat);
            }
            return ids;
        }
    }
}
