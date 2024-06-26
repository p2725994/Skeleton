﻿using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsCustomerCollection
    {
        //constructor for the class
        public clsCustomerCollection()
        {
            //object for the data connect
            clsDataConnection DB = new clsDataConnection();
            //execute the procedure
            DB.Execute("sproc_tblCustomer_SelectAll");
            PopulateArray(DB);
        }





        //private data member for the list
        List<clsCustomer> mCustomerList = new List<clsCustomer>();
        //private member data for thiscustomer
        clsCustomer mThisCustomer = new clsCustomer();
        public List<clsCustomer> CustomerList
        {
            get
            {
                //return the priv data
                return mCustomerList;
            }
            set
            {
                //set the priv data
                mCustomerList = value;
            }
        }
        public int Count 
        { 
            get
            {
                //return the count of the list
                return mCustomerList.Count;
            }
            set
            {
               
            }
        }
        public clsCustomer ThisCustomer
        {
            get
            {
                return mThisCustomer;
            }
            set
            {
                mThisCustomer = value;
            }
        }

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@CustomerFirstname", mThisCustomer.CustomerFirstname);
            DB.AddParameter("@CustomerLastname", mThisCustomer.CustomerLastname);
            DB.AddParameter("@CustomerEmail", mThisCustomer.CustomerEmail);
            DB.AddParameter("@CustomerPhone", mThisCustomer.CustomerPhone);
            DB.AddParameter("@CustomerBirthdate", mThisCustomer.CustomerBirthdate);
            DB.AddParameter("@Verified", mThisCustomer.Verified);

            return DB.Execute("sproc_tblCustomer_Insert");
        }

       

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@CustomerID", mThisCustomer.CustomerID);
            DB.AddParameter("@CustomerFirstname", mThisCustomer.CustomerFirstname);
            DB.AddParameter("@CustomerLastname", mThisCustomer.CustomerLastname);
            DB.AddParameter("@CustomerEmail", mThisCustomer.CustomerEmail);
            DB.AddParameter("@CustomerPhone", mThisCustomer.CustomerPhone);
            DB.AddParameter("@CustomerBirthdate", mThisCustomer.CustomerBirthdate);
            DB.AddParameter("@Verified", mThisCustomer.Verified);
            DB.Execute("sproc_tblCustomer_Update");
        }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@CustomerID", mThisCustomer.CustomerID);
            DB.Execute("sproc_tblCustomer_Delete");
        }

        public void ReportByCustomerFirstname(string CustomerFirstname)
        {
            //filters the parameter based on a full or partial firstname
            //connect to dtabase
            clsDataConnection DB = new clsDataConnection();
            //send the firstnbame parameter to the database
            DB.AddParameter("@CustomerFirstname", CustomerFirstname);
            DB.Execute("sproc_tblCustomers_FilterByCustomerFirstname");
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            //variable for the class
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount = 0;
            //get the count of records
            RecordCount = DB.Count;
            mCustomerList = new List<clsCustomer>();
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank Customer
                clsCustomer ACustomer = new clsCustomer();
                //read in the fields for the current record
                ACustomer.Verified = Convert.ToBoolean(DB.DataTable.Rows[Index]["Verified"]);
                ACustomer.CustomerID = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerID"]);
                ACustomer.CustomerFirstname = Convert.ToString(DB.DataTable.Rows[Index]["CustomerFirstname"]);
                ACustomer.CustomerLastname = Convert.ToString(DB.DataTable.Rows[Index]["CustomerLastname"]);
                ACustomer.CustomerEmail = Convert.ToString(DB.DataTable.Rows[Index]["CustomerEmail"]);
                ACustomer.CustomerPhone = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerPhone"]);
                ACustomer.CustomerBirthdate = Convert.ToDateTime(DB.DataTable.Rows[Index]["CustomerBirthdate"]);
                mCustomerList.Add(ACustomer);
                //point at the next record
                Index++;
            }
        }

    }
}