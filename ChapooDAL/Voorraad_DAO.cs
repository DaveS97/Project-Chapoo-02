﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace ChapooDAL
{
    public class Voorraad_DAO : Base
    {
        public void Write_To_Db_Voorraad(int id, int aantal)
        {
            string query = "UPDATE Voorraad SET aantal = @aantal where voorraadID = @voorraadID ";
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@aantal", SqlDbType.Int) { Value = aantal},
                new SqlParameter("@voorraadID", SqlDbType.Int) { Value = id}
            };
            ExecuteEditQuery(query, sqlParameters);
        }
        public void Write_To_db_MenuKaart(int ID, string omschrijving, int type, int menu, decimal prijs)
        {
            string query = "UPDATE MenuItem SET omschrijving=@omschrijving, prijs =@prijs, menu =@menu ,typeGerecht=@type where menuItemID =@ID";
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@omschrijving", SqlDbType.Text) { Value = omschrijving},
                new SqlParameter("@type", SqlDbType.Int) { Value = type},
                new SqlParameter("@menu", SqlDbType.Int) { Value = menu},
                new SqlParameter("@ID", SqlDbType.Int) { Value = ID},
                new SqlParameter("@prijs", SqlDbType.Decimal) { Value = prijs}
            };
            ExecuteEditQuery(query, sqlParameters);
        }
        public void Write_To_db_ToevoegenMenuItem(string omschrijving, int type, int menu, decimal prijs)
        {
            string query = "INSERT MenuItem VALUES (@omschrijving, @prijs , @menu, @type)";
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@omschrijving", SqlDbType.Text) { Value = omschrijving},
                new SqlParameter("@type", SqlDbType.Int) { Value = type},
                new SqlParameter("@menu", SqlDbType.Int) { Value = menu},
                new SqlParameter("@prijs", SqlDbType.Decimal) { Value = prijs}
            };
            ExecuteEditQuery(query, sqlParameters);
        }
        public void Write_To_Db_verwijderenMenuItem(int ID)
        {
            string query = "DELETE FROM MenuItem WHERE (menuItemID = @ID)";
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@ID", SqlDbType.Int) { Value = ID},
            };
            ExecuteEditQuery(query, sqlParameters);
        }


    }
    
}
