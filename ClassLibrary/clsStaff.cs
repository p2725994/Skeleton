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
  

        public bool Find(int StaffNo)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the StaffNo to search for
            DB.AddParameter("@StaffNo", StaffNo);
            //execute the stored procedures
            DB.Execute("sproc_tblStaff_FilterbyStaffNo");
            //if one record is found (there should be either 1 or 0)
            if (DB.Count == 1)
            {
                //set the private data members to the test data value
                mStaffNo = Convert.ToInt32(DB.DataTable.Rows[0]["StaffNo"]);
                mStaffFirstname = Convert.ToString(DB.DataTable.Rows[0]["StaffFirstname"]);
                mStaffSurname = Convert.ToString(DB.DataTable.Rows[0]["StaffSurname"]);
                mStaffEmail = Convert.ToString(DB.DataTable.Rows[0]["StaffEmail"]);
                mStaffPassword = Convert.ToString(DB.DataTable.Rows[0]["StaffPassword"]);
                mDateJoined = Convert.ToDateTime(DB.DataTable.Rows[0]["DateJoined"]);
                mIsOnShift = Convert.ToBoolean(DB.DataTable.Rows[0]["IsOnShift"]);

                //return that everything worked
                return true;

            }

            //if no record was found
            else 
            {
                //return false indicating a problem
                return false;
            }
        }

        public string Valid(string staffFirstname, string staffSurname, string staffEmail, string staffPassword, string dateJoined)
        {
            //create a string variable to store the error
            String Error = "";

            //create a temporary variable to store the date values
            DateTime DateTemp;

            //if the StaffFirstname is blank
            if (staffFirstname.Length == 0)
            {
                //record the error
                Error = Error + "Staff name may not be blank: ";
            }
            //if the StaffFirstname is 30+ char
            if (staffFirstname.Length > 30)
            {
                //record the error
                Error = Error + "Staff name must be less than 30 characters: ";
            }

            //if the StaffSurname is blank
            if (staffSurname.Length == 0)
            {
                //record the error
                Error = Error + "Staff surname may not be blank: ";
            }
            //if the StaffSurname is 20+ char
            if (staffSurname.Length > 20)
            {
                //record the error
                Error = Error + "Staff surname must be less than 20 characters: ";
            }

            //if the StaffEmail is blank
            if (staffEmail.Length == 0)
            {
                //record the error
                Error = Error + "Staff email may not be blank: ";
            }
            //if the StaffEmail is 50+ char
            if (staffEmail.Length > 50)
            {
                //record the error
                Error = Error + "Staff email must be less than 50 characters: ";
            }

            //if the StaffPassword is blank
            if (staffPassword.Length == 0)
            {
                //record the error
                Error = Error + "Staff password may not be blank: ";
            }
            //if the StaffPassword is 16+ char
            if (staffPassword.Length > 16)
            {
                //record the error
                Error = Error + "Staff password must be less than 16 characters: ";
            }


            try
            {
                //copy the DateJoined value to the DateTemp variable
                DateTemp = Convert.ToDateTime(dateJoined);

                //if the DateJoined is less than today's date
                if (DateTemp < DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "The date cannot be in the past: ";
                }
                //if the DateJoined is greater than today's date
                if (DateTemp > DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "The date cannot be in the future: ";
                }
            }
            catch
            {
                //record the error
                Error = Error + "The date was not a valid date: ";
            }

            //return any error messages
            return Error;
        }
    }
}