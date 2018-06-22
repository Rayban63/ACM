using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ACM.BL;


namespace ACM.BLTest
{
    [TestClass]
    public class ProductRepositoryTest
    {
        [TestMethod]
        public void RetriveTest()
        {
            //--Arrange
            var productRepository = new ProductRepository();
            var expected = new Product(2)
            {
                CurrentPrice = 15.96M,
                ProductDesription = "Assorted Size",
                ProductName = "SunFlowers"
            };

            //--Act
            var actual = productRepository.Retrieve(2);

            //--Assert

            Assert.AreEqual(expected.CurrentPrice, actual.CurrentPrice);
            Assert.AreEqual(expected.ProductDesription, actual.ProductDesription);
            Assert.AreEqual(expected.ProductName, actual.ProductName);
        }
    }
}
