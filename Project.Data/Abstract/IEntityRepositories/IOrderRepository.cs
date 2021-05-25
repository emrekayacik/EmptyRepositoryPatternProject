using Project.Entity.Order;
using System.Collections.Generic;

namespace Project.Data.Abstract
{
    public interface IOrderRepository : IRepository<Order>
    {
        Order GetTotalOrderAmount();
        List<Order> GetMostTenValuableOrdersOfTheMonth();
    }
}
