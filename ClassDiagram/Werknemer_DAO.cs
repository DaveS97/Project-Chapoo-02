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
    public class Werknemer_DAO : Base
    {
        public List<Werknemer> DB_Krijg_Alle_Werknemers()
        {
            string query = "SELECT werknemerID, werknemerType, werknemerNaam FROM [Werknemers]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        private List<Werknemer> ReadTables(DataTable dataTable)
        {
            List<Werknemer> werknemers = new List<Werknemer>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Werknemer werknemer = new Werknemer()
                {
                    ID = (int)dr["werknemerID"],
                    Type = (int)dr["werknemerType"],
                    Naam = (string)dr["werknemerNaam"].ToString()
                };
                werknemers.Add(werknemer);
            }
            return werknemers;
        }
    }
}
