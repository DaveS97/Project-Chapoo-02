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
    public class Order_Service
    {
        public OrderOverzicht_DAO orderOverzicht_DAO = new OrderOverzicht_DAO();

        public List<OrderStatus> KrijgOrder()
        {
            try
            {
                List<OrderStatus> orderstatus = orderOverzicht_DAO.Db_Get_All_TafelsOrders();
                return orderstatus;
            }
            catch (Exception e)
            {
                MessageBox.Show("Chapoo couldn't connect to the database " + e.ToString());
                List<OrderStatus> orderStatuses = new List<OrderStatus>();
                OrderStatus order_1 = new OrderStatus();
                order_1.tafelNummer = 1;
                order_1.bestellingId = 1;
                order_1.bestellingStatus = false;
                orderStatuses.Add(order_1);
                return orderStatuses;
            }
        }
    }
}
