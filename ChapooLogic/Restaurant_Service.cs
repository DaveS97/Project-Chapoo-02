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
    public class Restaurant_Service
    {
        public Restaurant_DAO restaurant_DAO = new Restaurant_DAO();

        public List<TafelStatus> KrijgTafels()
        {
            try
            {
                List<TafelStatus> tafelstatus = restaurant_DAO.Db_Get_All_Tafels();
                return tafelstatus;
            }
            catch (Exception e)
            {
                MessageBox.Show("Chapoo couldn't connect to the database " + e.ToString());
                List<TafelStatus> tafelStatuses = new List<TafelStatus>();
                TafelStatus tafel_1 = new TafelStatus();
                tafel_1.tafelNummer = 1;
                tafel_1.tafelBezetting = false;
                tafelStatuses.Add(tafel_1);
                return tafelStatuses;
            }
        }

        public void Write_To_Db_Set_Status(bool status, int tafelnummer)
        {
            try
            {
                restaurant_DAO.Write_To_Db_Set_Status(status, tafelnummer);
            }
            catch (Exception e)
            {
                MessageBox.Show("Chapoo couldn't connect to the database " + e.ToString());
            }
        }
    }
}
