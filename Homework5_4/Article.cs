using System;
using System.Collections.Generic;
using System.Text;

namespace Homework5_4
{
    class Article
    {
        string productName;
        string shopName;

        int productCost;

        public Article(string productName, string shopName, int productCost)
        {
            this.productName = productName;
            this.shopName = shopName;
            this.productCost = productCost;
        }

        public string ProductName
        { 
            get
            {
                return productName;
            }
        }

        public string ShopName
        {
            get
            {
                return shopName;
            }
        }

        public int ProductCoast
        {
            get
            {
                return productCost;
            }
        }
    }
}
