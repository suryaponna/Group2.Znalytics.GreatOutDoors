///////// Done by Apoorva ////////////


using System;


using System.Collections.Generic;

using Znalytics.Group2.GreatOutDoor.Entity;
using Znalytics.Group2.GreatOutDoor.DAL;
using System.CodeDom.Compiler;
using System.Linq.Expressions;

namespace Znalytics.Group2.GreatOutDoors.BLL
{
    /// <summary>
    /// Represents Business logic layer of the customer personal details
    /// </summary>
    public class CustomerBLL : ICustomersBLL//interface of bussinesslogic layer
    {
        private CustomerDAL cdal;//datalayer object


        public CustomerBLL()//constructor for bussiness layer
        {
            cdal = new CustomerDAL();//object creation for dataacesslayer
        }


        public void AddCustomer(Customer customer)
        {
            //Validating customer name
            if (customers.CustomerName != null)
            {
                cdal.Add(customers);

            }
            else
            {
                throw new Exception("Name can't be null,Please Mention your name");
            }

            //Checking Phone number

            if (customers.CustomerPhoneNumber != null)
            {
                cdal.AddCustomer(customers);
            }
            else
            {
                throw new Exception("Phone number can't be null,Please enter 10digit Phonenumber");
            }
        }
        //checking age of the customer
        public int ValidateAge(Customer customers)
        {
            try {


                if (customers.age >= 18)
                {
                    cdal.(customers);
                }
                else

                { return 0; }

            }
            catch (Exception ex)
            {
                throw new Exception("Age must be above 18");
            }

            //validation for firstname(for signup process)
            public void AddCustomer(Customer customer)
            {
                //Validating customer first name
                if (customer.FirstName != null)
                {
                    cdal.AddCustomer(customer);

                }
                else
                {
                    throw new Exception("First name can't be null");
                }
            }

            //Validation of Mail Id
            public void ValidateMailId(Customer customers)
            {

                string mail = customer.CustomerMailId;
                //searching for space
                bool spaceFound = mail.Contains(" ");

                //searching for @
                bool AtFound = mail.Contains("@");

                char[] ch = mail.ToCharArray();
                int AtCharCount = 0;
                for (int i = 0; i < ch.Length; i++)
                {
                    if (ch[i] == '@')
                    {
                        AtCharCount++;
                    }
                }
                cdal.AddCustomer(customers);
            }

            //View customer personal details
            public List<Customer> GetCustomers()
            {
                return cdal.GetCustomers();
            }

            //Update customer details

            public void UpdateCustomer(Customer customers)
            {

                cdal.UpdateCustomer(customers);
            }
            public void DeleteCustomer(Customer customers)
            {
                try
                {
                    if (CustomerName != null) && (CustomerID != null)
                   {
                        cdal.DeleteCustomer(customers);
                    }
                    catch (Exception ex)
                {
                    throw new Exception("Customer Name and ID cannot be null);
                }
            }
        }
    }
}

