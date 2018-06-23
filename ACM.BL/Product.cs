using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Acme.Common;

namespace ACM.BL
{
    public class Product : EntityBase
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
        
        private string _ProductName;

        public string ProductName
        {
            get {
                var StringHandler = new StringHandler();
                return StringHandler.InsertSpaces(_ProductName);
            }
            set { _ProductName = value; }
        }




        //Validates the product data.
        public override bool Validate()
        {
            var IsValid = true;
            if (string.IsNullOrEmpty(ProductName)) IsValid = false;
            if (CurrentPrice == null) IsValid = false;
            return IsValid;
        }
        public override string ToString()
        {
            return ProductName;
        }

    }
}
