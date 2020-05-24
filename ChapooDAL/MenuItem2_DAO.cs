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
    public class MenuItem2_DAO : Base
    {
        public List<MenuItem2> GetMenuItems()
        {
            string query = "SELECT menuItemID, omschrijving, prijs, menu, aantal FROM MenuItem JOIN Voorraad ON voorraadID = menuItemID";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables2(ExecuteSelectQuery(query, sqlParameters));
        }
        public List<MenuItem2> GetLunchMenu()
        {
            string query = "SELECT menuItemID, omschrijving, prijs, menu, aantal FROM MenuItem JOIN Voorraad ON voorraadID = menuItemID where menu = 1; ";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables2(ExecuteSelectQuery(query, sqlParameters));
        }
        public List<MenuItem2> GetDinnerMenu()
        {
            string query = "SELECT menuItemID, omschrijving, prijs, menu, aantal FROM MenuItem JOIN Voorraad ON voorraadID = menuItemID where menu = 2; ";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables2(ExecuteSelectQuery(query, sqlParameters));
        }
        public List<MenuItem2> GetDrinkMenu()
        {
            string query = "SELECT menuItemID, omschrijving, prijs, menu, aantal FROM MenuItem JOIN Voorraad ON voorraadID = menuItemID where menu = 3;";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables2(ExecuteSelectQuery(query, sqlParameters));
        }

        public List<MenuItem2> Krijg_Bestelling_Beschrijving()
        {
            string query = "";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables2(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<MenuItem2> ReadTables2(DataTable dataTable)
        {
            List<MenuItem2> items = new List<MenuItem2>();

            foreach (DataRow dr in dataTable.Rows)
            {
                MenuItem2 item = new MenuItem2()
                {
                    ID = (int)dr["menuItemID"],
                    ItemNaam = (string)dr["omschrijving"],
                    Prijs = (decimal)dr["prijs"],
                    Aantal = (int)dr["aantal"],
                    menu = (int)dr["menu"],
                };
                items.Add(item);
            }
            return items;
        }
    }
}
