using System;
using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLTest
{
    [TestClass]
    public class CustomerTest
    {
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
    }
}
