using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ACM.BL;
using System.Collections.Generic;

namespace ACM.BLTest
{
    [TestClass]
    public class CustomerRepositoryTest
    {
        [TestMethod]
        public void RetrieveValid()
        {
            //--Arrange

            var customerRepository = new CustomerRepository();
            var expected = new Customer(1)
            {

                EmailAddress = "fd@damsd.co",
                FirstName = "Frodo",
                LastName = "Baggins"

            };

            //--Act
            var actual = customerRepository.Retrieve(1);
            //--Assert

            Assert.AreEqual(expected.CustomerId, actual.CustomerId);
            Assert.AreEqual(expected.FirstName, actual.FirstName);
            Assert.AreEqual(expected.LastName, actual.LastName);
            Assert.AreEqual(expected.EmailAddress, actual.EmailAddress);

        }

        [TestMethod]
        public void RetrieveexistingWithAddress()
        {
            //--Arrage
            var customerRepository = new CustomerRepository();
            var expected = new Customer(1)
            {


                EmailAddress = "fd@damsd.co",
                FirstName = "Frodo",
                LastName = "Baggins",
                AddressList = new List<Address>()
                {

                    new Address()
                    {
                        AdressType = 1,
                        StreetLine1 = "Bag end",
                        StreetLine2 = "Bagshot row",
                        City = "Hobbiton",
                        StateProvince = "Shire",
                        Country = "Middle Earth",
                        PostalCode = "144"
                    },
                    new Address()
                    {
                        AdressType = 2,
                        StreetLine1 = "Bag end",
                        StreetLine2 = "Dragons end",
                        City = "Hobsol",
                        StateProvince = "Srere",
                        Country = "Mordor",
                        PostalCode = "1234551"

                    }

                }

            };   //--Act
            var actual = customerRepository.Retrieve(1);

            //-- Assert
            Assert.AreEqual(expected.CustomerId, actual.CustomerId);
            Assert.AreEqual(expected.EmailAddress, actual.EmailAddress);
            Assert.AreEqual(expected.FirstName, actual.FirstName);
            for (int i = 0; i < 1; i++)
            {
                Assert.AreEqual(expected.AddressList[i].AdressType, actual.AddressList[i].AdressType);

            }

        }



    }
}
