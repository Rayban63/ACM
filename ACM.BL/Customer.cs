using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Customer
    {
        public Customer()
        {

        }
        public Customer(int customerId)
        {
            this.CustomerId = customerId;

        }
        public static int InstanceCount { get; set; } //this property belongs to the class and not to the instance of this class
        private string _lastName;

        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                _lastName = value;
            }
        }

        private string _firstName;

        public string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                _firstName = value;
            }
        }
        public string EmailAddress { get; set; }
        public int CustomerId { get; private set; }
        public string FullName
        {
            get
            {
                string fullName = LastName;
                if (!string.IsNullOrWhiteSpace(FirstName))
                {
                    if (!string.IsNullOrWhiteSpace(fullName))
                    {
                        fullName += ", ";
                    }
                    fullName += FirstName;
                }
                return fullName;
            }
        }
       
        public bool Validate()
        {
            var IsValid = true;
            if (string.IsNullOrWhiteSpace(LastName)) IsValid = false;
            if (string.IsNullOrWhiteSpace(FirstName)) IsValid = false;
            if (string.IsNullOrWhiteSpace(EmailAddress)) IsValid = false;

            return IsValid;
        }

    }
}
