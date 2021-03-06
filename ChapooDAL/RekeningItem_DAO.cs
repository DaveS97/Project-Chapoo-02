﻿using ChapooModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapooDAL
{
    public class RekeningItem_DAO : Base
    {
        public void Write_To_Db_RekeningItem(int rekeningID, int menuItemID, int aantal)
        {
            string query = "INSERT INTO RekeningItem VALUES (@rekeningID, @menuItemID, @aantal)";
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@rekeningID", SqlDbType.Int) { Value = rekeningID},
                new SqlParameter("@menuItemID", SqlDbType.Int) { Value = menuItemID},
                new SqlParameter("@aantal", SqlDbType.Int) { Value = aantal}
            };
            ExecuteEditQuery(query, sqlParameters);
        }

        public List<RekeningItem> GetRekeningItemsVoorRekeningID(int rekeningID)
        {
            string query = "SELECT RI.rekeningItemID, RI.rID, RI.mItemID, RI.aantal, MI.omschrijving, MI.prijs " +
                "FROM RekeningItem AS RI " +
                "JOIN MenuItem AS MI ON MI.menuItemID = RI.mItemID " +
                "WHERE RI.rID = @rekeningID";
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@rekeningID", SqlDbType.Int) { Value = rekeningID}
            };

            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        public List<RekeningItem> ReadTables(DataTable dataTable)
        {
            List<RekeningItem> rekeningItems = new List<RekeningItem>();

            foreach (DataRow dr in dataTable.Rows)
            {
                RekeningItem rekeningItem = new RekeningItem()
                {
                    ID = (int)dr["rekeningItemID"],
                    RekeningID = (int)dr["rID"],
                    MenuItemID = (int)dr["mItemID"],
                    Aantal = (int)dr["aantal"],
                    Omschrijving = (string)dr["omschrijving"],
                    Prijs = (decimal)dr["prijs"]
                };
                rekeningItems.Add(rekeningItem);
            }
            return rekeningItems;
        }
    }
}
