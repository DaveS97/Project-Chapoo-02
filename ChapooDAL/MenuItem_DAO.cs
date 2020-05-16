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
    class MenuItem_DAO : Base
    {
        public List<MenuItem> GetMenuItems()
        {
            string query = "";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        
        private List<MenuItem> ReadTables(DataTable dataTable)
        {
            List<MenuItem> werknemers = new List<MenuItem>();

            foreach (DataRow dr in dataTable.Rows)
            {
                MenuItem werknemer = new MenuItem()
                {
                    ID = (int)dr["menuItemID"],
                    ItemNaam = (string)dr["omschrijving"],
                    Prijs = (double)dr["prijs"],
                    Aantal = (int)dr["aantal"],

                };
                werknemers.Add(werknemer);
            }
            return werknemers;
        }
    }
}
