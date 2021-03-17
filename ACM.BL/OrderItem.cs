using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class OrderItem
    {
        public OrderItem()
        {

        }
        public OrderItem(int orderItemId)
        {

        }

        public int OrderItemID { get; private set; }
        public int ProductID { get; set; }
        public decimal? PurchasePrice { get; set; }
        public int Quanitity { get; set; }

        // Methods
        public OrderItem Retrieve(int orderItemId)
        {
            return new OrderItem();
        }

        public bool Save()
        {
            return true;

        }

        public bool Validate()
        {
            var isValid = true;
            if (Quanitity <= 0) isValid = false;
            if (ProductID <= 0) isValid = false;
            if (PurchasePrice == null) isValid = false;
            return isValid;
        }
    }
}
