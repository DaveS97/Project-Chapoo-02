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

        public List<MenuItem> Krijg_Bestelling_Beschrijving(string bestellingID)
        {
            string query = "SELECT BE.menuItemID, MI.omschrijving, MI.typeGerecht FROM Bevat AS BE JOIN MenuItem AS MI ON MI.menuItemID = BE.menuItemID WHERE BE.bestellingID = @bestellingID;";
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@bestellingID", SqlDbType.Int) { Value = bestellingID}
            };
            return ReadTablesBMO(ExecuteSelectQuery(query, sqlParameters));
        }

       
        private List<MenuItem> ReadTablesBMO(DataTable dataTable)
        {
            List<MenuItem> bestellingen = new List<MenuItem>();

            foreach (DataRow dr in dataTable.Rows)
            {
                MenuItem menuItem = new MenuItem()
                {
                    ID = (int)dr["menuItemID"],
                    Beschrijving = (string)dr["omschrijving"],
                    typeGerecht = (int)dr["typeGerecht"]
                };
                bestellingen.Add(menuItem);
            }
            return bestellingen;
        }
        //deel van samuel begint hieronder
        public List<MenuItem> GetDinkMenu()
        {
            string query = "select menuItemID, omschrijving, prijs, typeGerecht from MenuItem where menu = 3";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        public List<MenuItem> GetLunchMenu()
        {
            string query = "select menuItemID, omschrijving, prijs, typeGerecht from MenuItem where menu = 1";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        public List<MenuItem> GetDinnerMenu()
        {
            string query = "select menuItemID, omschrijving, prijs, typeGerecht from MenuItem where menu = 2";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<MenuItem> ReadTables(DataTable table)
        {
            List<MenuItem> items = new List<MenuItem>();

            foreach (DataRow dr in table.Rows)
            {
                MenuItem menuItem = new MenuItem()
                {
                    ID = (int)dr["menuItemID"],
                    Beschrijving = (string)dr["omschrijving"],
                    Prijs = (decimal)dr["prijs"],
                    typeGerecht = (int)dr["typeGerecht"]
                };
                items.Add(menuItem);
            }
            return items;
        }
    }
}
