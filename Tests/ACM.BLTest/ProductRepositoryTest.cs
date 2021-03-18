using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ACM.BLTest
{
    [TestClass]
    public class ProductRepositoryTest
    {
        [TestMethod]
        public void RetrieveTest()
        {
            //--Arrange
            var productRepository = new ProductRepository();

            var expected = new Product(1) { };

            expected.ProductName = "Tic-Tac";
            expected.ProductDescription = "Candy";
            expected.CurrentPrice = 12;

            //--Act
            var actual = productRepository.Retrive(1);



            //--Assert
            Assert.AreEqual(expected.ProductName, actual.ProductName);
            Assert.AreEqual(expected.ProductDescription, actual.ProductDescription);

        }
    }
}
