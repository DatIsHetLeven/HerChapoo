﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using ChapooDAL;
using ChapooModel;

namespace ChapooLogic
{
    public class Order_Service
    {
        Order_DAO Order_DAO = new Order_DAO();
        public List<int> GetMaxId()
        {
            List<int> MaxId;
            MaxId = Order_DAO.GetMaxId();
            return MaxId;
        }
        public void createOrder(int orderId, int tableId, string menuItem, int prijs)
        {
            Order_DAO.InsertOrder(orderId, tableId, menuItem, prijs);
        }

    }
}
