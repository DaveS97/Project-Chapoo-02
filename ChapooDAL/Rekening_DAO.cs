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
    public class Rekening_DAO : Base
    {
        public List<Rekening> DB_Krijg_Rekeningen(int klantID)
        {
            string query = "";

            SqlParameter[] sqlParameters =
            {
                    new SqlParameter("@tafelID", SqlDbType.Int) { Value = klantID}
            };

            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        public List<Rekening> ReadTables(DataTable dataTable)
        {
            List<Rekening> rekeningen = new List<Rekening>();

            foreach(DataRow dr in dataTable.Rows)
            {
                Rekening rekening = new Rekening()
                {
                    
                };
            }
            return rekeningen;
        }
    }
}
