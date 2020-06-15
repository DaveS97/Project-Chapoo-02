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
        public List<Inkomsten> GetInkomsten()
        {
            try
            {
                List<Inkomsten> bonnen = dao.GetBonnen();
                return bonnen;
            }
            catch (Exception e)
            {
                MessageBox.Show("Chapoo couldn't connect to the database " + e.Message);
                List < Inkomsten > bonnen = new List<Inkomsten>();
                Inkomsten inkomsten = new Inkomsten();
                inkomsten.BedienerID = 1;
                inkomsten.RekeningID = 1;
                inkomsten.BTW = 1.5;
                inkomsten.Fooi = 10;
                inkomsten.Totaal = 100;
                return bonnen;
            }
        }
    }
}
