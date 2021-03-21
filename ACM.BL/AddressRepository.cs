using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class AddressRepository
    {


        public Address Retrieve(int addressId)
        {

            Address address = new Address(addressId);
            if (addressId == 1)
            {

                address.AdressType = 1;
                address.StreetLine1 = "Bag end";
                address.StreetLine2 = "Bagshot row";
                address.City = "Hobbiton";
                address.StateProvince = "Shire";
                address.Country = "Middle Earth";
                address.PostalCode = "144";

            }
            return address;

        }
        public IEnumerable<Address> RetrieveByCustomerId(int customerId)
        {
            var addressList = new List<Address>();
            Address address = new Address(1)
            {


                AdressType = 1,
                StreetLine1 = "Bag end",
                StreetLine2 = "Bagshot row",
                City = "Hobbiton",
                StateProvince = "Shire",
                Country = "Middle Earth",
                PostalCode = "144"

            };
            addressList.Add(address);
            address = new Address(2)
            {

                AdressType = 2,
                StreetLine1 = "Bag end",
                StreetLine2 = "Dragons end",
                City = "Hobsol",
                StateProvince = "Srere",
                Country = "Mordor",
                PostalCode = "1234551"

            };
            addressList.Add(address);
            return addressList;
        }

        public bool Save()
        {
            return true;
        }

    }
}
