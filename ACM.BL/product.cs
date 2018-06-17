﻿using System;
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
