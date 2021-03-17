using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ACM.BL;
namespace ACM.BLTest
{
    [TestClass]
    public class ProductTest
    {
        [TestMethod]
        public void ValidateProductPriceEmpty()
        {


            Product product = new Product()
            {
                ProductName = "des",


            };
            var expected = false;
            //-- Act
            var actual = product.Validate();
            //-- Assert

            Assert.AreEqual(expected, actual);



        }
    }
}
