using ChapooDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChapooLogic
{
    public class Voorraad_Service
    {
		Voorraad_DAO Voorraad_DAO = new Voorraad_DAO();
        public void Write_To_Db_Voorraad(int id, int aantal)
        {
			try
			{
				Voorraad_DAO.Write_To_Db_Voorraad(id, aantal);
			}
			catch (Exception e)
			{
				MessageBox.Show("Chapoo couldn't connect to the database" + e.Message);
			}
        }
    }
}
