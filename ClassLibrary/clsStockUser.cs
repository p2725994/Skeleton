using System;

namespace ClassLibrary
{
    public class clsStockUser
    {
        //private data member for the user id property
        private Int32 mUserID;
        //public property for user id
        public int UserID
        {
            get
            {
                //return the private data
                return mUserID;
            }
            set
            {
                //set the private data
                mUserID = value;
            }
        }


        //private data member for the user name property
        private string mUserName;
        //public pro[erty for user name
        public string UserName
        {
            get
            {
                //return the private data
                return mUserName;
            }
            set
            {
                //set the private data
                mUserName = value;
            }
        }

        //private data member for the user password property
        private string mPassword;
        //public pro[erty for user password
        public string Password
        {
            get
            {
                //return the private data
                return mPassword;
            }
            set
            {
                //set the private data
                mPassword = value;
            }
        }

        //private data member for the department property
        private string mDepartment;
        //public pro[erty for department
        public string Department
        {
            get
            {
                //return the private data
                return mDepartment;
            }
            set
            {
                //set the private data
                mDepartment = value;
            }
        }

        public bool FindUser(string UserName, string Password)
        {

            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();

            //add parameter for UserName and Password to search for
            DB.AddParameter("@UserName", UserName);
            DB.AddParameter("@Password", Password);

            //create some test data to use with the method
            DB.Execute("sproc_tblUsers_FindUserNamePW");

            //if one record is found (it should be either 1 or 0)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mUserID = Convert.ToInt32(DB.DataTable.Rows[0]["UserID"]);
                mUserName = Convert.ToString(DB.DataTable.Rows[0]["UserName"]);
                mPassword = Convert.ToString(DB.DataTable.Rows[0]["Password"]);
                mDepartment = Convert.ToString(DB.DataTable.Rows[0]["Department"]);
                //return true to confirm everything worked ok
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
        