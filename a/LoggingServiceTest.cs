using System;
using System.Collections.Generic;
using ACM.BL;
using Acme.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace a
{
    [TestClass]
    public class LoggingServiceTest
    {
        [TestMethod]
        public void WriteToFileTest()
        {
            //--Arrange
            var ChangedItems = new List<ILoggable>();

            var customer = new Customer(1)
            {
                EmailAddress = "fbaggins@hobbiton.me",
                FirstName = "Frodo",
                LastName = "Baggins",
                AddressList = null
            };
            ChangedItems.Add(customer as ILoggable);

            var product = new Product(2)
            {
                ProductName = "Rake",
                ProductDesription = "Garden Rake with stealhead",
                CurrentPrice = 6M
            };
            ChangedItems.Add(product as ILoggable);

            //--Act
            LoggingService.WriteToFile(ChangedItems);

            //--Assert
            //nothing to assert
        }
    }
}
