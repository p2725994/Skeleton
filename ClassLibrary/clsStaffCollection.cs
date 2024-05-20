using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsStaffCollection
    {
        public clsStaffCollection()
        {
            //variable for the index
            Int32 index = 0;

            //variable to store the record count
            Int32 RecordCount = 0;

            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            
            //execute the stored procedures
            DB.Execute("sproc_tblStaff_SelectAll");
            //get the count of the records
            RecordCount = DB.Count;

            while (index < RecordCount)
            {
                //create a blank address
                clsStaff AStaff = new clsStaff();

                //read in the fields for the current record
                AStaff.StaffNo = Convert.ToInt32(DB.DataTable.Rows[0]["StaffNo"]);
                AStaff.StaffFirstname = Convert.ToString(DB.DataTable.Rows[0]["StaffFirstname"]);
                AStaff.StaffSurname = Convert.ToString(DB.DataTable.Rows[0]["StaffSurname"]);
                AStaff.StaffEmail = Convert.ToString(DB.DataTable.Rows[0]["StaffEmail"]);
                AStaff.StaffPassword = Convert.ToString(DB.DataTable.Rows[0]["StaffPassword"]);
                AStaff.DateJoined = Convert.ToDateTime(DB.DataTable.Rows[0]["DateJoined"]);
                AStaff.IsOnShift = Convert.ToBoolean(DB.DataTable.Rows[0]["IsOnShift"]);

                //add the record to the private data member
                mStaffList.Add(AStaff);

                //point at the next record
                index++;
            }
        }

        //private data member for staff list
        List<clsStaff> mStaffList = new List<clsStaff>();
        //public property for staff list
        public List<clsStaff> StaffList
        {
            get
            {
                //return private data
                return mStaffList;
            }
            set
            { 
                mStaffList = value; 
            }
        }

        //public property for count
        public int Count 
        {
            get 
            {
                return mStaffList.Count;
            }
            set
            {
                //later
            } 
        }

        clsStaff mThisStaff = new clsStaff();
        public clsStaff ThisStaff 
        {
            get 
            {
                //return the private data
                return mThisStaff;
            }
            set 
            {
                //set the private data
                mThisStaff = value;
            }
        }

        public int Add()
        {
            //adds a record to the db based on the values of mThisStaff
            //set the primary key of the new record
            clsDataConnection DB = new clsDataConnection();

            //set the parameters for the stored procedure
            DB.AddParameter("@StaffFirstname", mThisStaff.StaffFirstname);
            DB.AddParameter("@StaffSurname", mThisStaff.StaffSurname);
            DB.AddParameter("@StaffEmail", mThisStaff.StaffEmail);
            DB.AddParameter("@StaffPassword", mThisStaff.StaffPassword);
            DB.AddParameter("@DateJoined", mThisStaff.DateJoined);
            DB.AddParameter("@IsOnShift", mThisStaff.IsOnShift);

            //return PK of the new record
            return DB.Execute("sproc_tblStaff_Insert");
        }

        public void Update()
        {
            //update an existing record based on the values of mThisStaff
            //connect to the database
            clsDataConnection DB = new clsDataConnection();

            //set the parameters for the stored procedure
            DB.AddParameter("@StaffNo", mThisStaff.StaffNo);
            DB.AddParameter("@StaffFirstname", mThisStaff.StaffFirstname);
            DB.AddParameter("@StaffSurname", mThisStaff.StaffSurname);
            DB.AddParameter("@StaffEmail", mThisStaff.StaffEmail);
            DB.AddParameter("@StaffPassword", mThisStaff.StaffPassword);
            DB.AddParameter("@DateJoined", mThisStaff.DateJoined);
            DB.AddParameter("@IsOnShift", mThisStaff.IsOnShift);

            //return PK of the new record
            DB.Execute("sproc_tblStaff_Update");
        }
    }
}