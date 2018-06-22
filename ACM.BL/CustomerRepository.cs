using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class CustomerRepository
    {
        private AddressRepository AddressRepository { get; set; }
        public CustomerRepository()
        {
            AddressRepository = new AddressRepository();
        }
        //retrieve one customer
        public Customer Retrieve(int customerId)
        {
            //create the instance of the customer
            Customer customer = new Customer(customerId);
            customer.AddressList = AddressRepository.RetrieveByCustomerId(customerId).ToList();
            //code that retrieves the difined customer
            //return new Customer();
            //Temporary hard coded values to return a populated customer
            if(customerId == 1)
            {
                customer.EmailAddress = "f.Baggins@hobbiton.me";
                customer.FirstName = "Frodo";
                customer.LastName = "Baggins";
            }
            return customer;
        }
        public List<Customer> Retrieve()
        {
            return new List<Customer>();
        }
        //saves the current customer
        public bool Save(Customer customer)
        {
            var Succes = true;
            if(customer.HasChanges && customer.IsValid)
            {
                if (customer.IsNew)
                {
                    // Call an insert procedure call
                }
                else
                {
                    // Call an update procedure call
                }
            }
            //code that saves the difined customer
            return Succes;
        }
    }
}
