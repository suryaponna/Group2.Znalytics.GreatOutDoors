///////// Done by Apoorva ////////////


using System;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;
using Group2.Znalytics.GreatOutDoors.BusinessLogicLayer;
using System.Collections.Generic;


namespace Znalytics.Group2.GreatOutDoor.Entity
{
    /// <summary>
    /// Represents Business logic layer of the customer personal details
    /// </summary>
    public class CustomerDetailBLL : ICustomerDetailBLL
    {
        private ICustomerDetailDAL cdal = null;


        public CustomerDetailBLL()
        {
            cdal = new CustomerDetailDAL();
        }


        public void AddCustomer(CustomerDetail customer)
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
        //Checking Aadharcard
        
      
        //Validation of Mail Id
        public void ValidateMailId(CustomerDetail customer)
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
        public void UpdateCustomer(CustomerDetail customer)
        {

            cdal.UpdateCustomer(customer);
        }
    }
}
