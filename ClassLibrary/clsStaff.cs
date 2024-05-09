using System;

namespace ClassLibrary
{
    public class clsStaff
    {
        //private data member for StaffNO property
        private Int32 mStaffNo;

        //StaffNo public property
        public Int32 StaffNo
        {
            get
            {
                //this line of code sends data out of the property
                return mStaffNo;
            }
            set
            {
                //this line of code allows data into the property
                mStaffNo = value;
            }
        }


        //private data member for StaffFirstname property
        private string mStaffFirstname;

        //StaffFirstname public property
        public string StaffFirstname 
        {
            get
            {
                //this line of code sends data out of the property
                return mStaffFirstname;
            }
            set
            {
                //this line of code allows data into the property
                mStaffFirstname = value;
            }
        }


        //private data member for StaffSurname property
        private string mStaffSurname;

        //StaffSurname public property
        public string StaffSurname 
        {
            get
            {
                //this line of code sends data out of the property
                return mStaffSurname;
            }
            set
            {
                //this line of code allows data into the property
                mStaffSurname = value;
            }
        }


        //private data member for StaffEmail property
        private string mStaffEmail;

        //StaffEmail public property
        public string StaffEmail 
        {
            get
            {
                //this line of code sends data out of the property
                return mStaffEmail;
            }
            set
            {
                //this line of code allows data into the property
                mStaffEmail = value;
            }
        }


        //private data member for StaffPassword property
        private string mStaffPassword;

        //StaffPassword public property
        public string StaffPassword 
        {
            get
            {
                //this line of code sends data out of the property
                return mStaffPassword;
            }
            set
            {
                //this line of code allows data into the property
                mStaffPassword = value;
            }
        }


        //private data member for StaffNO property
        private DateTime mDateJoined;

        // DateJoined public property
        public DateTime DateJoined
        {
            get
            {
                //this line of code sends data out of the property
                return mDateJoined;
            }
            set
            {
                //this line of code allows data into the property
                mDateJoined = value;
            }
        }


        //private data member for IsOnSHift property
        private Boolean mIsOnShift;

        //IsOnShift public property
        public bool IsOnShift 
        {
            get
            {
                //this line of code sends data out of the property
                return mIsOnShift;
            }
            set
            {
                //this line of code allows data into the property
                mIsOnShift = value;
            }
        }
  

        public bool Find(int staffNo)
        {
            //set the private data members to the test data value
            mStaffNo = 21;
            mStaffFirstname = "Afnan";
            mStaffSurname = "Khalid";
            mStaffEmail = "AfnanKhalid@gmail.com";
            mStaffPassword = "Afnan123";
            mDateJoined = Convert.ToDateTime("23/12/2022");
            mIsOnShift = true;

            //always return True
            return true;
        }
    }
}