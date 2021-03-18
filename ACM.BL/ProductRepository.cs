using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class ProductRepository
    {
        public Product Retrive(int productId)
        {

            Product product = new Product(productId);


            if (productId == 1)
            {
                product.ProductName = "Tic-Tac";
                product.ProductDescription = "Candy";
                product.CurrentPrice = 12;

            }
            return product;


        }
        public bool Save(Customer customer)
        {
            return true;
        }
    }
}
