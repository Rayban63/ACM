using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Address : EntityBase
    {
        public Address()
        {

        }
        public Address(int addressId)
        {
            this.AddressId = addressId;

        }

        public int AddressId { get; private set; }
        public int AddressType { get; set; }
        public string StreetLine1 { get; set; }
        public string StreetLine2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        //public string ShippingAddress { get; set; }

        public override bool Validate()
        {
            var IsValid = true;
            if (AddressType <1) IsValid = false;
            if (AddressId <1) IsValid = false;
            if (string.IsNullOrWhiteSpace(StreetLine1)) IsValid = false;
            if (string.IsNullOrWhiteSpace(StreetLine2)) IsValid = false;
            if (string.IsNullOrWhiteSpace(City)) IsValid = false;
            if (string.IsNullOrWhiteSpace(State)) IsValid = false;
            if (string.IsNullOrWhiteSpace(PostalCode)) IsValid = false;
            if (string.IsNullOrWhiteSpace(Country)) IsValid = false;
            return IsValid;

        }
    }

}
