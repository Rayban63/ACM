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
        public Order(int orderId)
        {
            this.OrderId = orderId;
        }
        public DateTimeOffset? OrderDate { get; set; }
        public int OrderId { get; private set; }


        //Retrieve one order.
        public Order Retrieve(int orderId)
        {
            //code that retrieves the defined order
            return new Order();
        }

        //Saves the current order
        public bool Save()
        {
            //code that saves the defined order
            return true;
        }

        //Validate the order data.
        public bool Validate()
        {
            var IsValide = true;
            if (OrderDate == null) IsValide = false;
            return IsValide;

        }


    }
}
