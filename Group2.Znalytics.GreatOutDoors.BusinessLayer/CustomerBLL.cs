///////// Done by Apoorva ////////////


using System;


using System.Collections.Generic;

using Group2.Znalytics.GreatOutDoors.EntityLayer;
//using Group2.Znalytics.GreatOutDoors.DataLayer;



namespace Group2.Znalytics.GreatOutDoors.BusinessLayer
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
        /// <summary>
        /// Adding cutomer
        /// </summary>
        /// <param name="customers"></param>

        public void AddCustomer(Customer customers)
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
        public void Age(Customer customers)
        {
            try {


                if (customers.Age >= 18)
                {
                    cdal.(customers);
                }

            }
            catch (Exception ex)
            {
                throw new Exception("Age must be above 18");
            }
        }

            //validation for CustomerName(for signup process)
            public void AddCustomer(Customer customers)
            {
                //Validating customer first name
                if (customer.CustomerName != null)
                {
                    cdal.AddCustomer(customer);

                }
                else
                {
                    throw new Exception("Customer name can't be null");
                }
            }


        }

            //Validation of Mail Id
            public void MailId(Customer customers)
            {
            /*Email validation:
            * 1. No space
            * 2. @ symbol should be present
            * 3. @ should be present only once
            * 4. Some special characters like : , not allowed
            * 5. Ends with .com or .co.in etc.
            */


            //reading email from keyboard
            string email;
            Console.WriteLine("Email: ");
            email = Console.ReadLine();

            //searching for space
            bool spaceFound = email.Contains(" ");

            //searching for @
            bool AtFound = email.Contains("@");

            char[] ch = email.ToCharArray();
            int AtCharCount = 0;
            for (int i = 0; i < ch.Length; i++)
            {
                if (ch[i] == '@')
                {
                    AtCharCount++;
                }
            }

            if (!spaceFound && AtFound && AtCharCount == 1 && (email.EndsWith(".com") || email.EndsWith(".co.in")))
            {
                Console.WriteLine("Valid Email address");
            }
            else
            {
                Console.WriteLine("Email should contain only one @ symbol; no space and also end with .com");
            }


        }
        cdal.AddCustomer(customers);
            }

            //View customer personal detailss
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

