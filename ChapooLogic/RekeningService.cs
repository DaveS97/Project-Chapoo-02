using ChapooDAL;
using ChapooModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChapooLogic
{
    public class RekeningService
    {
        public Rekening_DAO rekening_DAO = new Rekening_DAO();
        public List<Rekening> GetRekening(int klantID)
        {
            try
            {
                List<Rekening> rekeningen = rekening_DAO.DB_Krijg_Rekeningen(klantID);
                return rekeningen;
            }
            catch (Exception e)
            {
                List<Rekening> rekenings = new List<Rekening>();

                MessageBox.Show("Chapoo couldn't connect to the database! " + e.Message);
                return rekenings;
            }
        }

    }
}
