using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
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
    }
}
