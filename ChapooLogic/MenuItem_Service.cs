﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChapooDAL;
using ChapooModel;
using MenuItem = ChapooModel.MenuItem;

namespace ChapooLogic
{
    public class MenuItem_Service
    {
        private MenuItem_DAO menuItem_DAO = new MenuItem_DAO();

        /*public List<MenuItem> KrijgBestellingIDS()
        {
            try
            {
                List<MenuItem> item = menuItem_DAO.KrijgIDS();
                return item;
            }
            catch (Exception e)
            {
                MessageBox.Show("Chapoo couldn't connect to the database " + e.Message);
                List<MenuItem> werknemers = new List<MenuItem>();
                MenuItem item = new MenuItem();
                item.ID = 1;
                item.Aantal = 0;
                item.Beschrijving = "menuItem";
                item.Prijs = 1.0;

        
                werknemers.Add(item);
                return werknemers;
            }
        }*/



        public List<MenuItem> GetMenu()
        {
            try
            {
                List<MenuItem> menuItems = menuItem_DAO.GetMenu();
                return menuItems;
            }
            catch (Exception e)
            {
                MessageBox.Show("Chapoo couldn't connect to the database " + e.Message);
                List<MenuItem> menuItems = new List<MenuItem>();
                MenuItem menuItem = new MenuItem();
                menuItem.ID = 1;
                menuItems.Add(menuItem);
                return menuItems;
            }
        }

        public Dictionary<Bevat, Klant> KrijgBeschrijving(string bestellingID)
        {
            try
            {
                Dictionary<Bevat, Klant> klantenInfo = menuItem_DAO.Krijg_Bestelling_Beschrijving(bestellingID);
                return klantenInfo;
            }
            catch (Exception e)
            {
                MessageBox.Show("Chapoo couldn't connect to the database " + e.Message);
                Dictionary<Bevat, Klant> klantenInfo = new Dictionary<Bevat, Klant>();
                Bevat info = new Bevat();
                info.bestellingID = 1;
                Klant klant = new Klant();
                klant.ID = 1;
                klantenInfo.Add(info, klant);
                return klantenInfo;
            }
        }
        public List<MenuItem> GetLunchMenu()
        {
            try
            {
                List<MenuItem> menuItems = menuItem_DAO.GetLunchMenu();
                return menuItems;

            }
            catch (Exception e)
            {
                MessageBox.Show("Chapoo couldn't connect to the database " + e.Message);
                List<MenuItem> menuItems = new List<MenuItem>();
                MenuItem menuItem = new MenuItem();
                menuItem.ID = 1;
                menuItems.Add(menuItem);
                return menuItems;
            }
        }
        public List<MenuItem> GetDinnerMenu()
        {
            try
            {
                List<MenuItem> menuItems = menuItem_DAO.GetDinnerMenu();
                return menuItems;

            }
            catch (Exception e)
            {
                MessageBox.Show("Chapoo couldn't connect to the database " + e.Message);
                List<MenuItem> menuItems = new List<MenuItem>();
                MenuItem menuItem = new MenuItem();
                menuItem.ID = 1;
                menuItems.Add(menuItem);
                return menuItems;
            }
        }
        public List<MenuItem> GetDrinkMenu()
        {
            try
            {
                List<MenuItem> menuItems = menuItem_DAO.GetDinkMenu();
                return menuItems;

            }
            catch (Exception e)
            {
                MessageBox.Show("Chapoo couldn't connect to the database " + e.Message);
                List<MenuItem> menuItems = new List<MenuItem>();
                MenuItem menuItem = new MenuItem();
                menuItem.ID = 1;
                menuItems.Add(menuItem);
                return menuItems;
            }
        }

        public List<MenuItem> GetVoorgerechtMenu()
        {
            try
            {
                List<MenuItem> menuItems = menuItem_DAO.GetVoorgerechtMenu();
                return menuItems;
            }
            catch (Exception e)
            {
                MessageBox.Show("Chapoo couldn't connect to the database " + e.Message);
                List<MenuItem> menuItems = new List<MenuItem>();
                MenuItem menuItem = new MenuItem();
                menuItem.ID = 1;
                menuItems.Add(menuItem);
                return menuItems;
            }
        }
        public List<MenuItem> GetHoofdgerechtMenu()
        {
            try
            {
                List<MenuItem> menuItems = menuItem_DAO.GetHoofdgerechtMenu();
                return menuItems;
            }
            catch (Exception e)
            {
                MessageBox.Show("Chapoo couldn't connect to the database " + e.Message);
                List<MenuItem> menuItems = new List<MenuItem>();
                MenuItem menuItem = new MenuItem();
                menuItem.ID = 1;
                menuItems.Add(menuItem);
                return menuItems;
            }
        }
        public List<MenuItem> GetNagerechtMenu()
        {
            try
            {
                List<MenuItem> menuItems = menuItem_DAO.GetNagerechtMenu();
                return menuItems;
            }
            catch (Exception e)
            {
                MessageBox.Show("Chapoo couldn't connect to the database " + e.Message);
                List<MenuItem> menuItems = new List<MenuItem>();
                MenuItem menuItem = new MenuItem();
                menuItem.ID = 1;
                menuItems.Add(menuItem);
                return menuItems;
            }
        }

        public List<MenuItem> GetMenuItemForDescription(string beschrijving)
        {
            try
            {
                List<MenuItem> menuItems = menuItem_DAO.GetMenuItemForDescription(beschrijving);
                return menuItems;
            }
            catch (Exception e)
            {
                MessageBox.Show("Chapoo couldn't connect to the database " + e.Message);
                List<MenuItem> menuItems = new List<MenuItem>();
                MenuItem menuItem = new MenuItem();
                menuItem.ID = 1;
                menuItems.Add(menuItem);
                return menuItems;
            }
        }
    }
}
