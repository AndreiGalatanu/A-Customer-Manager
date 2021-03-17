using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Order
    {

        public Order()
        {

        }
        public Order(int OrderId)
        {
            OrderID = OrderId;
        }
        public int OrderID { get; set; }
        public DateTimeOffset? OrderDate { get; set; }

        // Retrive
        public Order Retrieve(int orderId)
        {


            return new Order();
        }
        //Save
        public bool Save()
        {
            return true;
        }

        //Validate
        public bool Validate()
        {
            var isValid = true;
            if (OrderDate == null) isValid = false;
            return isValid;

        }
    }
}
