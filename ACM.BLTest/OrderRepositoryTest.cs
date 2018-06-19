using System;
using System.Collections.Generic;
using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLTest
{
    [TestClass]
    public class OrderRepositoryTest
    {
        [TestMethod]
        public void RetrieveOrderDisplayTest()
        {
            //--Arrange
            var orderRepository = new OrderRepository();
            var expected = new OrderDisplay()
            {
                FirstName = "Bilbo",
                Lastname = "Baggins",
                OrderDate = new DateTimeOffset(2018, 6, 18, 12, 00, 00, new TimeSpan(07, 0, 0)),
                ShippingAddress = new Address()
                {
                    AddressType = 1,
                    StreetLine1 = "Bag End",
                    StreetLine2 = "Bagshot Row",
                    City = "Hobbiton",
                    State = "Shire",
                    PostalCode = "144",
                    Country = "Middle Earth"
                },
                OderDisplayItemList = new List<OrderDisplayItem>()
                {
                    new OrderDisplayItem()
                    {
                        OderQuantity = 2,
                        ProductName = "SunFlowers",
                        PurchasePrice = 15.99M
                    },
                    new OrderDisplayItem()
                    {
                        OderQuantity = 2,
                        ProductName = "Rake",
                        PurchasePrice = 12.99M,
                    }

                }
            };



            //--Act

            var actual = orderRepository.RetrieveOrderDisplay(10);



            //--Assert
            Assert.AreEqual(expected.FirstName, actual.FirstName);
            Assert.AreEqual(expected.Lastname, actual.Lastname);
            Assert.AreEqual(expected.OrderDate, actual.OrderDate);

            Assert.AreEqual(expected.ShippingAddress.AddressType, actual.ShippingAddress.AddressType);
            Assert.AreEqual(expected.ShippingAddress.StreetLine1, actual.ShippingAddress.StreetLine1);
            Assert.AreEqual(expected.ShippingAddress.StreetLine2, actual.ShippingAddress.StreetLine2);
            Assert.AreEqual(expected.ShippingAddress.State, actual.ShippingAddress.State);
            Assert.AreEqual(expected.ShippingAddress.City, actual.ShippingAddress.City);
            Assert.AreEqual(expected.ShippingAddress.Country, actual.ShippingAddress.Country);
            Assert.AreEqual(expected.ShippingAddress.PostalCode, actual.ShippingAddress.PostalCode);

            for (int i = 0; i < 1; i++)
            {
                Assert.AreEqual(expected.OderDisplayItemList[i].OderQuantity, actual.OderDisplayItemList[i].OderQuantity);
                Assert.AreEqual(expected.OderDisplayItemList[i].ProductName, actual.OderDisplayItemList[i].ProductName);
                Assert.AreEqual(expected.OderDisplayItemList[i].PurchasePrice, actual.OderDisplayItemList[i].PurchasePrice);

            }
        }
    }
}
