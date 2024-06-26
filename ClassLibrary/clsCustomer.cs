﻿using System;

namespace ClassLibrary
{
    public class clsCustomer
    {
        //private data member forn the customer id property
        private Int32 mCustomerID;
        //customer id public property
        public Int32 CustomerID
        {
            get
            {
                //send data out of property
                return mCustomerID;
            }
            set
            {
                //allow data into the property
                mCustomerID = value;
            }
        }

        //private data member for the date added property
        private DateTime mCustomerBirthdate;
        //birthdate public property
        public DateTime CustomerBirthdate
        {
            get
            {
            //this line of code sends data out of the property
            return mCustomerBirthdate;
            }
            set
            {
            //this line of code allows data into the property
             mCustomerBirthdate = value;
            }
         }

        //private data member of verified property
        private string mCustomerFirstname;
        //first name public property
        public string CustomerFirstname
        {
            get
            {
                //this line of code sends data out of the property
                return mCustomerFirstname;
            }
            set
            {
                //this line of code allows data into the property
                mCustomerFirstname = value;
            }
        }


        //private data member of lastname porperty
        private string mCustomerLastname;
        public string CustomerLastname
        {
            get
            {
                //this line of code sends data out of the property
                return mCustomerLastname;
            }
            set
            {
                //this line of code allows data into the property
                mCustomerLastname = value;
            }
        }

        //private data member of email proiperty
        private string mCustomerEmail;
        //public email property
        public string CustomerEmail
        {
            get
            {
                //this line of code sends data out of the property
                return mCustomerEmail;
            }
            set
            {
                //this line of code allows data into the property
                mCustomerEmail = value;
            }
        }

        //private data member of email proiperty
        private Int32 mCustomerPhone;
        //public email property
        public int CustomerPhone
        {
            get
            {
                //this line of code sends data out of the property
                return mCustomerPhone;
            }
            set
            {
                //this line of code allows data into the property
                mCustomerPhone = value;
            }
        }

        //private data member of verified property
        private Boolean mVerified;
        //active public porperty
        public bool Verified
        {
            get
            {
                //sends data out of property
                return mVerified;
            }
            set
            {
                //allows data entry into the property
                mVerified = value;
            }
        }

        /*******FIND METHOD********/
        public bool Find(int CustomerID)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for customer id to search for
            DB.AddParameter("@CustomerID", CustomerID);
            //execute stored procedure
            DB.Execute("sproc_tblCustomer_FilterByCustomerID");
            //if one record is found
            if (DB.Count == 1)
            {
                //set the private data members to the test value
                mCustomerID = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerID"]);
                mCustomerFirstname = Convert.ToString(DB.DataTable.Rows[0]["CustomerFirstname"]);
                mCustomerLastname = Convert.ToString(DB.DataTable.Rows[0]["CustomerLastname"]);
                mCustomerEmail = Convert.ToString(DB.DataTable.Rows[0]["CustomerEmail"]);
                mCustomerPhone = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerPhone"]);
                mCustomerBirthdate = Convert.ToDateTime(DB.DataTable.Rows[0]["CustomerBirthdate"]);
                mVerified = Convert.ToBoolean(DB.DataTable.Rows[0]["Verified"]);

                //always return true
                return true;
            }
            else
            { 
                return false; 
            }
        }

        public string Valid(string customerFirstname, string customerLastname, string customerEmail, string customerBirthdate, string customerPhone)
        {
            //create a string variable to store the error
            String Error = "";
            //create a temporary variable  store the data values
            DateTime DateTemp;
            // define  minimum valid birthdates
            DateTime minBirthdate = DateTime.Now.Date.AddYears(-16); // 16 years ago from today

       
            //if customerfirstname is blank
            if (customerFirstname.Length == 0)
            {
                //record the error
                Error = Error + "The Firstname can not be blank : ";
            }
            //if the lastname is greater than 20 chars
            if (customerFirstname.Length > 20) 
            {
                //record the error
                Error = Error + "The Firstname should not be more than 20 characters : ";
            }

            //if customerlastname is blank
            if (customerLastname.Length == 0)
            {
                //record the error
                Error = Error + "The Lastname can not be blank : ";
            }
            //if the lastname is greater than 20 chars
            if (customerLastname.Length > 20)
            {
                //record the error
                Error = Error + "The Lastname should not be more than 20 characters : ";
            }

            if (customerEmail.Length == 0) 
            {
                Error = Error + "Email can not be blank : ";
            }

            //if email is >50 chars
            if (customerEmail.Length > 50)
            {
                //record the error
                Error = Error + "The Email should not be more than 50 characters : ";
            }

            if (customerPhone.Length == 0)
            {
                Error += "Please enter a valid phone number: ";
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(customerPhone, @"^\d+$"))
            {
                Error += "The phone number should contain only digits: ";
            }

            //copy the customerbirthdate value to the DateTemp variable
            // validate birthdate

            if (!DateTime.TryParse(customerBirthdate, out DateTemp))
            {
                // if the birthdate is not a valid date
                Error += "The Birthdate is not a valid date: ";
            }
            else
            {
                DateTemp = Convert.ToDateTime(customerBirthdate);
                if (DateTemp > minBirthdate)
                {
                    Error = Error + "The customer needs to be minimum 16 years old : ";
                }
            }
            //return any error message
            return Error;
        }
    }
}