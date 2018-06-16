using System;
using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLTest
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void Template()
        {
            //--Arrange

            //--Act


            //--Assert
            

        }
        [TestMethod]
        public void FullNameTestValid()
        {
            //--Arrange
            Customer customer = new Customer();
            customer.FirstName = "Bilbo";
            customer.LastName = "Baggins";

            string expected = "Baggins, Bilbo";
            //--Act
            string actual = customer.FullName;

            //--Assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void FullFirsNameEmpty()
        {
            //--Arrange
            Customer customer = new Customer();
           
            customer.LastName = "Baggins";

            string expected = "Baggins";
            //--Act
            string actual = customer.FullName;

            //--Assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void FullLastNameEmpty()
        {
            //--Arrange
            Customer customer = new Customer();
            customer.FirstName = "Bilbo";
            

            string expected = "Bilbo";
            //--Act
            string actual = customer.FullName;

            //--Assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void StaticTest()
        {
            //--Arrange
            var c1 = new Customer();
            c1.FirstName = "Bilbo";
            Customer.InstanceCount += 1;

            var c2 = new Customer();
            c2.FirstName = "Frodo";
            Customer.InstanceCount += 1;

            var c3 = new Customer();
            c3.FirstName = "Rosie";
            Customer.InstanceCount += 1;

            //--Act


            //--Assert
            Assert.AreEqual(3, Customer.InstanceCount);


        }
        [TestMethod]
        public void ValidateValid()
        {
            //--Arrange
            var customer = new Customer();
            customer.LastName = "Baggings";
            customer.FirstName = "Bilbo";
            customer.EmailAddress = "f.baggins@hobbiton.me";
            var expected = true;

            //--Act
            var actual = customer.Validate();


            //--Assert
            Assert.AreEqual(expected, actual);
            Assert.AreEqual(expected, actual);


        }
        [TestMethod]
        public void ValidateMissingLastname()
        {
            //--Arrange
            var customer = new Customer();
            customer.EmailAddress = "f.baggins@hobbiton.me";
            customer.FirstName = "Bilbo";
            var expected = false;

            //--Act
            var actual = customer.Validate();


            //--Assert
            Assert.AreEqual(expected, actual);
            Assert.AreEqual(expected, actual);


        }
        [TestMethod]
        public void ValidateMissingFirstname()
        {
            //--Arrange
            var customer = new Customer();
            customer.EmailAddress = "f.baggins@hobbiton.me";
            customer.LastName = "Baggins";
            var expected = false;

            //--Act
            var actual = customer.Validate();


            //--Assert
            Assert.AreEqual(expected, actual);
            Assert.AreEqual(expected, actual);


        }
        [TestMethod]
        public void ValidateMissingEmail()
        {
            //--Arrange
            var customer = new Customer();
            customer.LastName = "Baggings";
            customer.FirstName = "Bilbo";
            var expected = false;

            //--Act
            var actual = customer.Validate();


            //--Assert
            Assert.AreEqual(expected, actual);
            Assert.AreEqual(expected, actual);


        }
    }
}
