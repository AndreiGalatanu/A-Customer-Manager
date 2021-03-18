using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ACM.BL;
namespace ACM.BLTest
{
    [TestClass]
    public class OrderRepositoryTest
    {
        [TestMethod]
        public void ValidRetrive()
        {
            //--Arrange
            var orderRepository = new OrderRepository();
            var expected = new Order(2)
            {

                OrderDate = new DateTimeOffset(DateTime.Now.Year, 4, 14, 10, 10, 10,
                                                        new TimeSpan(7, 0, 0))
            };

            //--Act

            var actual = orderRepository.Retrieve(2);

            //--Assert

            Assert.AreEqual(expected.OrderDate, actual.OrderDate);




        }
    }
}
