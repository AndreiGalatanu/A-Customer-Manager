using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class OrderRepository
    {
        public Order Retrieve(int orderId)
        {
            Order order = new Order(orderId) { };

            if (orderId == 2)
            {
                order.OrderDate = new DateTimeOffset(DateTime.Now.Year, 4, 14, 10, 10, 10,
                                                        new TimeSpan(7, 0, 0));
            }

            return order;

        }

        public bool Save(Order order)
        {
            return true;
        }
    }
}
