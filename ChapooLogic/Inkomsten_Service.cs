using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapooDAL;
using System.Windows.Forms;
using ChapooModel;

namespace ChapooLogic
{
    public class Inkomsten_Service
    {
        Inkomsten_DAO dao = new Inkomsten_DAO();
        public List<Rekening> GetInkomsten()
        {
            try
            {
                List<Rekening> rekeningen = dao.GetBonnen();
                return rekeningen;
            }
            catch (Exception e)
            {
                MessageBox.Show("Chapoo couldn't connect to the database " + e.Message);
                List<Rekening> rekeningen = new List<Rekening>();
                return rekeningen;
            }
        }
    }
}
