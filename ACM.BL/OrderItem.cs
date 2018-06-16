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
            this.OrderItemId = orderItemId;

        }
        public int OrderItemId { get; private set; }
        public int OrderQuantity { get; set; }
        public int ProductId { get; set; }
        public Decimal? PurchesPrice { get; set; }

        //Retrieves one order item
        public OrderItem Retrieve(int orderItemId)
        {
            //code that retrieve the defined order item.
            return new OrderItem();
        }

        //saves the current order item
        public bool Save()
        {
            //code that saves the order item
            return true;
        }

        //Validates the order item
        public bool Validate()
        {
            var IsValid = true;
            if (OrderQuantity <= 0) IsValid = false;
            if (ProductId <= 0) IsValid = false;
            if (PurchesPrice == null) IsValid = false;
            return IsValid;

        }
    }
}
