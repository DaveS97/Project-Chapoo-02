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
    public class Rekening_DAO : Base
    {
        public List<Rekening> DB_Krijg_Rekeningen(int klantID, DateTime datum)
        {
            string query = "SELECT rekeningID, kID, datum, totaal, fooi, btw " +
                "FROM Rekening " +
                "WHERE kID = @klantID " +
                "AND datum = @datum";

            SqlParameter[] sqlParameters =
            {
                    new SqlParameter("@klantID", SqlDbType.Int) { Value = klantID},
                    new SqlParameter("@datum", SqlDbType.DateTime) { Value = datum}
            };

            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        public void Write_To_Db_Rekening(int klantID, DateTime datum)
        {
            string query = "INSERT INTO Rekening VALUES (@klantID, @datum, 0, 0, 0)";

            SqlParameter[] sqlParameters =
            {
                    new SqlParameter("@klantID", SqlDbType.Int) { Value = klantID},
                    new SqlParameter("@datum", SqlDbType.DateTime) { Value = datum}
            };

            ExecuteEditQuery(query, sqlParameters);
        }

        public void Update_Db_Rekening(int klantID, DateTime datum, decimal totaalPrijs, decimal fooi, decimal BTW)
        {
            string query = "UPDATE Rekening SET kID = @klantID, " +
                "datum = @datum, totaal = @totaalPrijs, " +
                "fooi = @fooi," +
                "btw = @btw " +
                "WHERE kID = @klantID AND datum = @datum";

            SqlParameter[] sqlParameters =
            {
                    new SqlParameter("@klantID", SqlDbType.Int) { Value = klantID},
                    new SqlParameter("@datum", SqlDbType.DateTime) { Value = datum},
                    new SqlParameter("@totaalPrijs", SqlDbType.Decimal) { Value = totaalPrijs},
                    new SqlParameter("@fooi", SqlDbType.Decimal) { Value = fooi},
                    new SqlParameter("@btw", SqlDbType.Decimal) { Value = BTW}
            };

            ExecuteEditQuery(query, sqlParameters);
        }

        public List<Rekening> ReadTables(DataTable dataTable)
        {
            List<Rekening> rekeningen = new List<Rekening>();

            foreach(DataRow dr in dataTable.Rows)
            {
                Rekening rekening = new Rekening()
                {
                    ID = (int)dr["rekeningID"],
                    KlantID = (int)dr["kID"],
                    Datum = (DateTime)dr["datum"],
                    TotaalPrijs = (decimal)dr["totaal"],
                    Fooi = (decimal)dr["fooi"],
                    BTW = (decimal)dr["btw"]
                };
                rekeningen.Add(rekening);
            }
            return rekeningen;
        }
    }
}
