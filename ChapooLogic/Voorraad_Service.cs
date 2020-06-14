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

        public List<Voorraad> GetVoorraadVanID(int id)
        {
            try
            {
                return Voorraad_DAO.GetVoorraadVanID(id);
            }
            catch(Exception e)
            {
                MessageBox.Show("Chapoo couldn't connect to the database" + e.Message);
                List<Voorraad> voorraad = new List<Voorraad>();
                return voorraad;
            }
        }

        public void Write_To_DB_Set_Nieuw_Aantal(int id, int aantal)
        {
            try
            {
                Voorraad_DAO.Write_To_DB_Set_Nieuw_Aantal(id, aantal);
            }
            catch(Exception e)
            {
                MessageBox.Show("Chapoo couldn't connect to the database" + e.Message);
            }
        }

        public void Write_To_db_MenuKaart(int ID, string omschrijving, int type, int menu, decimal prijs)
		{
			try
			{
				Voorraad_DAO.Write_To_db_MenuKaart(ID, omschrijving, type, menu, prijs);
			}
			catch (Exception e)
			{
				MessageBox.Show("Chapoo couldn't connect to the database" + e.Message);

			}
		}
		public void Write_To_db_toevoegenMenuItem(string omschrijving, int type, int menu, decimal prijs)
		{
			try
			{
				Voorraad_DAO.Write_To_db_ToevoegenMenuItem(omschrijving, type, menu, prijs);
			}
			catch (Exception e)
			{
				MessageBox.Show("Chapoo couldn't connect to the database" + e.Message);
			}
		}
		public void Write_To_db_VerwijderenMenuItem(int ID)
		{
			try
			{
				Voorraad_DAO.Write_To_Db_verwijderenMenuItem(ID);
			}
			catch (Exception e)
			{
				MessageBox.Show("Chapoo couldn't connect to the database" + e.Message);
			}
		}
	}
}
