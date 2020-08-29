///////// Done by Apoorva ////////////


using System;
using System.Text.RegularExpressions;
using Group2.Znalytics.GreatOutDoors.BusinessLogicLayer;
using System.Collections.Generic;
using System.CodeDom;
using Znalytics.Group2.GreatOutDoor.Entity;
using Group2.Znalytics.GreetOutDoors.DataAccessLayer;

namespace Znalytics.Group2.GreatOutDoor.BLL
{
    /// <summary>
    /// Represents Business logic layer of the customer personal details
    /// </summary>
    public class CustomerDetailBLL : ICustomersBLL
    {
        private ICustomerDetailDAL cdal = null;


        public CustomerDetailBLL()
        {
            cdal = new CustomerDAL();
        }


        public void AddCustomer(Customer customer)
        {
            //Validating customer name
            if (customer.CustomerName != null)
            {
                cdal.AddCustomer(customer);

            }
            else
            {
                throw new Exception("Name can't be null,Please Mention your name");
            }

            //Checking Phone number

            if (customer.PhoneNumber != null)
            {
                cdal.AddCustomer(customer);
            }
            else
            {
                throw new Exception("Phone number can't be null,Please enter 10digit Phonenumber");
            }
        }
        //checking age of the customer
        public int ValidateAge(Customer customer)
        {
            DateTime dateOfBirth = Convert.ToDateTime("1998-07-03 7:00 am");
            DateTime presentDate = DateTime.Now;
            TimeSpan timeSpan = presentDate - dateOfBirth;
            int age = Convert.ToInt32(timeSpan.TotalDays / 365);



            if (customer.age >= 18)
            {
                cdal.AddCustomer(customer);
            }
            else
            {
                throw new Exception("Age must be 18 or above");
            }

            return age;
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
        public void ValidateMailId(Customer customer)
        {

            string mail = customer.MailId;
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
            cdal.AddCustomer(customer);
        }

        //View customer personal details
        public List<Customer> GetCustomers()
        {
            return cdal.GetCustomers();
        }

        //Update customer details
        public void UpdateCustomer(Customer customer)
        {

            cdal.UpdateCustomer(customer);
        }
    }
}
