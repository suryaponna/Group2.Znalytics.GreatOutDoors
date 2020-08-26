﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using Znalytics.Group2.GreatOutdoors.Entities;
namespace Znalytics.Group2.GreatOutdoors.DataAccessLayer
{
    public class CustDataLayer
    {
        static List<Customer> _customers = new List<Customer>();/// <summary>
                                                                /// creating CustomersList///
                                                                /// </summary>
                                                                /// <param name="c"></param>
        public void AddCustomer(Customer c) //calling Add Customer method from Business Logic Layer//
        {
            _customers.Add(c);///adding values to customers list///
        }

        public List<Customer> GetCustomers()
        {
            return _customers;
        }
        public void UpdateCustomer(Customer c)
        {
            ///updating deatils based on cust id///
            Customer cu = _customers.Find(temp => temp.CustomerId == c.CustomerId);
            if (cu != null)
            {
                cu.Country = c.Country;
            }
        }
        public List<Customer> GetCust()
        {
            return _customers;
        }
        public void DeleteCustomer(Customer c)
        {
            Customer t = _customers.Find((temp => temp.CustomerName == c.CustomerName));
            _customers.Clear();//deleting customers deatils based on given condition//
        }
    }
}