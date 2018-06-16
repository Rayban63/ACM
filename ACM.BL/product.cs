using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Product
    {
        public Product()
        {

        }
        public Product(int productId)
        {
            this.ProductId = productId;

        }
        public Decimal? CurrentPrice { get; set; }
        public int ProductId { get; private set; }
        public string ProductDesription { get; set; }
        public string ProductName { get; set; }

        //Retrieve one product.

        public Product Retrieve (int productId)
        {
            //code that retrieves the defined product.
            return new Product();
        }

        //Saves the current product.
        public bool Save()
        {
            //code that saves the defined product.
            return true;

        }

        //Validates the product data.
        public bool Validate()
        {
            var IsValid = true;
            if (string.IsNullOrEmpty(ProductName)) IsValid = false;
            if (CurrentPrice == null) IsValid = false;
            return IsValid;
        }

    }
}
