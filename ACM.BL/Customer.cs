﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Customer
    {
        //Constructor
        public Customer()
        {

        }
        public Customer(int customerId)
        {
            CustomerId = customerId;
        }
        public int CustomerId { get; private set; }
        public string EmailAddress { get; set; }
        public string FirstName { get; set; }
        public string FullName
        {
            get
            {
                string fullName = LastName;
                if (!string.IsNullOrWhiteSpace(FirstName))
                {
                    if (!string.IsNullOrWhiteSpace(fullName))
                    {
                        fullName += ", ";
                    }
                    fullName += FirstName;
                }
                return fullName;
            }
        }
        private string _lastName;
        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                _lastName = value;
            }
        }



        public static int InstanceCount { get; set; }

        // Validate the customer data.
        public bool Validate()
        {
            var isValid = true;
            if (string.IsNullOrWhiteSpace(LastName)) isValid = false;
            if (string.IsNullOrWhiteSpace(EmailAddress)) isValid = false;
            return isValid;
        }

        //Retrieve one customer
        public Customer Retriever(int customerId)
        { //code that retrive the defined customer
            return new Customer();
        }

        //Save Customer
        public bool Save()
        {
            return true;
        }

        //Retrive all customers
        public List<Customer> Retrive()
        {
            //Code to retrive all the costumers
            return new List<Customer>();
        }

    }

}

