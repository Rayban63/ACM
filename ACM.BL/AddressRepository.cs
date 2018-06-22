using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class AddressRepository
    {
        //Retrieve one address.

        public Address Retrieve(int addressId)
        {
            //create instance of the address class
            //pass in the addressId
            Address address = new Address(addressId);

            //code that retrieves the defined address.

            //Temporary hard coded values to return a polulated address
            if (addressId == 1)
            {
                address.StreetLine1 = "Bag End";
                address.StreetLine2 = "Bagshot Row";
                address.City = "Hobbiton";
                address.State = "Shire";
                address.Country = "Middle Earth";
                address.PostalCode = "144";

            }
            return address;
        }
        public IEnumerable<Address> RetrieveByCustomerId(int customerId)
        {
            //code that retrieves the defined addresses for the customer.
            //Temporary hard coded values to return a set of  addresses for a customer
            var addressList = new List<Address>();
            Address address = new Address(1)
            {
                AddressType = 1,
                StreetLine1 = "Bag End",
                StreetLine2 = "Bagshot Row",
                City = "Hobbiton",
                State = "Shire",
                Country = "Middle Earth",
                PostalCode = "144",

            };
            addressList.Add(address);

            address = new Address(2)
            {
                AddressType = 2,
                StreetLine1 = "Green Dragon",
                City = "Bywater",
                State = "Shire",
                Country = "Middle Earth",
                PostalCode = "146",

            };
            addressList.Add(address);
            return addressList;

        }
        //Saves the current address.
        public bool Save(Address address)
        {
            var Succes = true;
            if(address.HasChanges && address.IsValid)
            {
                if (address.IsNew)
                {
                    //call an insert procedure call
                }
                else
                {
                    //call an update procedure call
                }
            }
            //code that saves the defined address.
            return Succes;

        }
    }
}
