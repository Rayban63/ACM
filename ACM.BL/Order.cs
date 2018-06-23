using Acme.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Order : EntityBase, ILoggable
    {
        public Order()
        {

        }
        public Order(int orderId)
        {
            this.OrderId = orderId;
        }

        public int CustomerId { get; set; }
        public int ShippingAddressId { get; set; }

        public DateTimeOffset? OrderDate { get; set; }
        public int OrderId { get; private set; }
        public List<OrderItem> OrderItems { get; set; }


       

        //Validate the order data.
        public override bool Validate()
        {
            var IsValid = true;
            if (OrderDate == null) IsValid = false;
            return IsValid;

        }
        public override string ToString()
        {
            return OrderDate.Value.Date + "(" + OrderId+ ")";
        }

        public string Log()
        {
            var LogString = this.OrderId + ": " +
                            "Date: " + this.OrderDate.Value.Date + " " +
                            "Status: " + this.EntityState.ToString();
            return LogString;
        }
    }
}
