using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class OrderRepository
    {
        //Retrieve one order.
        public Order Retrieve(int orderId)
        {
            //create the instance of the order class
            //pass in the requested id
            Order order = new Order(orderId);

            //code that retrieves the defined order

            //Temporary hard coded values to return a polulated order
            if(orderId == 10)
            {
                order.OrderDate = new DateTimeOffset();
            }
            return order;
        }

        //Saves the current order
        public bool Save()
        {
            //code that saves the defined order
            return true;
        }
    }
}
