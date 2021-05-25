using Project.Data.Abstract;
using Project.Entity.Order;
using System;
using System.Collections.Generic;

namespace Project.Data.Concrete.SQL
{
    public class SQLOrderRepository : IOrderRepository
    {
        public bool Create(Order entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Order entity)
        {
            throw new NotImplementedException();
        }

        public bool Edit(Order entity)
        {
            throw new NotImplementedException();
        }

        public List<Order> GetAll()
        {
            throw new NotImplementedException();
        }

        public Order GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Order> GetMostTenValuableOrdersOfTheMonth()
        {
            throw new NotImplementedException();
        }

        public Order GetTotalOrderAmount()
        {
            throw new NotImplementedException();
        }
    }
}
