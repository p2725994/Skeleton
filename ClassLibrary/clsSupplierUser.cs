using System;
using System.IO;

namespace ClassLibrary
{
    public class clsSupplierUser
    {
        public int UserID { get {return mUserID; } set {mUserID =value ; } }
        public string UserName { get { return mUserName; } set { mUserName = value; } }
        public string Password { get { return mPassword; } set{mPassword = value;} }
        public string Department { get { return mDepartment; } set{ mDepartment = value; } }

        

        private Int32 mUserID;
        //private data member for the user name property
        private string mUserName;
        private string mPassword;
        private string mDepartment;

        public bool FindUser(string UserName, string Password)
        {
            //Create an instance of the dataConnection 
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for hte user username and password to search for
            DB.AddParameter("@UserName", UserName);
            DB.AddParameter("@Password", Password);
            //execute the stored procedure
            DB.Execute("sproc_tblUsers_FindUserNamePW");
            //if one record is found(there should be either one or none)
            if (DB.Count == 1)
            {
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
