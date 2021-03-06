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
        public void pasWerknemerAan(int ID, string naam, int PIN)
        {
            string query = "UPDATE Werknemers SET werknemerNaam= @naam, werknemerPin = @PIN where werknemerID =@ID";
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@naam", SqlDbType.VarChar) { Value = naam},
                new SqlParameter("@ID", SqlDbType.Int) { Value = ID},
                new SqlParameter("@PIN", SqlDbType.Int) { Value = PIN}
            };
            ExecuteEditQuery(query, sqlParameters);
        }

        public void Write_To_db_VerwijderenWerknemer(int ID)
        {
            string query = "update Werknemers Set is_Actief=0 where werknemerID = @ID";
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@ID", SqlDbType.Int) { Value = ID}
            };
            ExecuteEditQuery(query, sqlParameters);
        }
        public void Write_To_db_toevoegenWerknemer(int Type, string Naam, int pin, bool actief)
        {
            string query = "INSERT Werknemers Values (@Type, @naam, @pin, @actief)";
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@Type", SqlDbType.Int) { Value = Type},
                new SqlParameter("@naam", SqlDbType.VarChar) { Value = Naam},
                new SqlParameter("@pin", SqlDbType.Int) { Value = pin},
                new SqlParameter("@actief", SqlDbType.Bit) { Value = actief}
            };
            ExecuteEditQuery(query, sqlParameters);
        }
        public List<Werknemer> DB_Krijg_Alle_Werknemers()
        {
            string query = "SELECT werknemerID, werknemerType, werknemerNaam FROM [Werknemers] Where is_Actief = 1";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        public List<Werknemer> GetWerknemerPINs()
        {
            string query = "SELECT werknemerID, werknemerPin, werknemerNaam , werknemerType FROM [Werknemers] Where is_Actief = 1";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables2(ExecuteSelectQuery(query, sqlParameters));
        }
        public List<Werknemer> GetBedienerPINs()
        {
            string query = "SELECT werknemerID, werknemerPin, werknemerNaam , werknemerType FROM [Werknemers] Where is_Actief = 1 AND werknemerType = 1";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables2(ExecuteSelectQuery(query, sqlParameters));
        }

        public List<Bediener> GetBedienersVanWerknemerID(int werknemerID)
        {
            string query = "SELECT bedienerID FROM Bedieners WHERE werknemerID = " + werknemerID;
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTablesBediener(ExecuteSelectQuery(query, sqlParameters));
        }

        public List<Werknemer> GetWerknemerVanBedienerID(int bedienerID)
        {
            string query = "select W.werknemerID, W.werknemerNaam " +
                "from Werknemers AS W " +
                "join Bedieners AS B ON B.werknemerID = W.werknemerID " +
                "where B.bedienerID = " + bedienerID;
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables3(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Werknemer> ReadTables3(DataTable dataTable)
        {
            List<Werknemer> werknemers = new List<Werknemer>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Werknemer werknemer = new Werknemer()
                {
                    ID = (int)dr["werknemerID"],
                    Naam = (string)dr["werknemerNaam"].ToString()
                };
                werknemers.Add(werknemer);
            }
            return werknemers;
        }

        private List<Werknemer> ReadTables2(DataTable dataTable)
        {
            List<Werknemer> werknemers = new List<Werknemer>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Werknemer werknemer = new Werknemer()
                {
                    ID = (int)dr["werknemerID"],
                    Type = (int)dr["werknemerType"],
                    Naam = (string)dr["werknemerNaam"],
                    PIN = (int)dr["werknemerPin"]
                };
                werknemers.Add(werknemer);
            }
            return werknemers;
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
        private List<Bediener> ReadTablesBediener(DataTable dataTable)
        {
            List<Bediener> bedieners = new List<Bediener>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Bediener bediener = new Bediener()
                {
                    BedienerID = (int)dr["bedienerID"]
                };
                bedieners.Add(bediener);
            }
            return bedieners;
        }
    }
}
