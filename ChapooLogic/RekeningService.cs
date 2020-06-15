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
        public List<Bon>GetRekenings(int tafelID)
        {
            try
            {
                List<Bon> rekeningen = rekening_DAO.DB_Krijg_Alle_Rekeningen(tafelID);
                return rekeningen;
            }
            catch (Exception e)
            {
                List<Bon> rekenings = new List<Bon>();
                Bon rekening = new Bon();
                
                rekenings.Add(rekening);
                MessageBox.Show(e.Message);
                return rekenings;
            }
        }

    }
}
