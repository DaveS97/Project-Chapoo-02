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
        public List<Rekening>GetRekenings(int klantID)
        {
            try
            {
                List<Rekening> rekeningen = rekening_DAO.DB_Krijg_Alle_Rekeningen(tafelID);
                return rekeningen;
            }
            catch (Exception e)
            {
                List<Rekening> rekenings = new List<Rekening>();
                Rekening rekening = new Rekening();
                rekening.omschrijving = "";
                rekening.prijs = 0;
                rekening.tafelID = 1;
                rekenings.Add(rekening);
                MessageBox.Show(e.Message);
                return rekenings;
            }
        }

    }
}
