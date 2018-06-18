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
                order.OrderDate = new DateTimeOffset(2018, 6, 18, 10, 00, 00, new TimeSpan(7, 0, 0));
            }
            return order;
        }
        public OrderDisplay RetrieveOrderDisplay(int orderId)
        {
            OrderDisplay orderDisplay = new OrderDisplay();
            //code that retrieves the defined order fields

            //temporary hard-coded data

            if(orderId == 10)
            {
                orderDisplay.FirstName = "Bilbo";
                orderDisplay.Lastname = "Baggins";
                orderDisplay.OrderDate = new DateTimeOffset(2018, 6, 18, 12, 00, 00, new TimeSpan(07, 0, 0));
                orderDisplay.ShippingAddress = new Address()
                {
                    AddressType = 1,
                    StreetLine1 = "Bag End",
                    StreetLine2 = "Bagshot Row",
                    City = "Hobbiton",
                    State = "Shire",
                    Country = "Middle Earth",
                    PostalCode = "144"
                };
            }
            orderDisplay.OderDisplayItemList = new List<OrderDisplayItem>();
            //code that retrieves the ordered items

            //temporary hard-coded data
            if(orderId == 10)
            {
                var orderDisplayItem = new OrderDisplayItem()
                {
                    ProductName = "SunFlowers",
                    PurchasePrice = 15.99M,
                    OderQuantity = 2
                };
                orderDisplay.OderDisplayItemList.Add(orderDisplayItem);
                orderDisplayItem = new OrderDisplayItem()
                {
                    ProductName = "Rake",
                    PurchasePrice = 56.33M,
                    OderQuantity = 2
                };
                orderDisplay.OderDisplayItemList.Add(orderDisplayItem);
            }
            return orderDisplay;

        }

        //Saves the current order
        public bool Save()
        {
            //code that saves the defined order
            return true;
        }
    }
}
