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
        public List<MenuItem> GetMenuItems()
        {
            string query = "SELECT menuItemID, omschrijving, prijs, menu, aantal FROM MenuItem JOIN Voorraad ON voorraadID = menuItemID";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        public List<MenuItem> GetLunchMenu()
        {
            string query = "SELECT menuItemID, omschrijving, prijs, menu, aantal FROM MenuItem JOIN Voorraad ON voorraadID = menuItemID where menu = 1; ";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        public List<MenuItem> GetDinnerMenu()
        {
            string query = "SELECT menuItemID, omschrijving, prijs, menu, aantal FROM MenuItem JOIN Voorraad ON voorraadID = menuItemID where menu = 2; ";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        public List<MenuItem> GetDrinkMenu()
        {
            string query = "SELECT menuItemID, omschrijving, prijs, menu, aantal FROM MenuItem JOIN Voorraad ON voorraadID = menuItemID where menu = 3;";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        public List<MenuItem> Krijg_Bestelling_Beschrijving()
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
                    Prijs = (decimal)dr["prijs"],
                    Aantal = (int)dr["aantal"],
                    menu = (int)dr["menu"],
                };
                werknemers.Add(werknemer);
            }
            return werknemers;
        }
    }
}
