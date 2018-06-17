using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class ProductRepository
    {
        //Retrieve one product.

        public Product Retrieve(int productId)
        {
            //create instance of the product class
            //pass in the productId
            Product product = new Product(productId);

            //code that retrieves the defined product.

            //Temporary hard coded values to return a polulated product
            if(productId == 2)
            {
                product.ProductName = "SunFlowers";
                product.ProductDesription = "Assorted Size";
                product.CurrentPrice = 15.96M;

            }
            return product;
        }

        //Saves the current product.
        public bool Save()
        {
            //code that saves the defined product.
            return true;

        }
    }
}
