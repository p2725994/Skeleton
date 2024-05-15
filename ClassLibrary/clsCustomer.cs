using System;

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



        public string CustomerLastname { get; set; }
        public string CustomerEmail { get; set; }
        public int CustomerPhone { get; set; }

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
            //set the private data members to the test value
            mCustomerID = 1;
            //always return true
            return true;
        }

    }
}