using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsSupplierCollection
    {
        public clsSupplierCollection()
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();


            //execute the stored procedures
            DB.Execute("sproc_tblSupplier_SelectAll");

            //get the count of the records
            PopualateArray(DB);
        }

        void PopualateArray(clsDataConnection DB)
        {
            //variable for the index
            Int32 Index = 0;

            //variable to store the record count
            Int32 RecordCount;

            //get the count of the records
            RecordCount = DB.Count;

            mSupplierList = new List<clsSupplier>();

            while (Index < RecordCount)
            {
                //create a blank supplier
                clsSupplier ASupplier = new clsSupplier();

                //read in the fields for the current record
                ASupplier.SupplierId = Convert.ToInt32(DB.DataTable.Rows[Index]["SupplierId"]);
                ASupplier.SupplierName = Convert.ToString(DB.DataTable.Rows[Index]["SupplierName"]);
                ASupplier.SupplierEmail = Convert.ToString(DB.DataTable.Rows[Index]["SupplierEmail"]);
                ASupplier.SupplierAddress = Convert.ToString(DB.DataTable.Rows[Index]["SupplierAddress"]);
                ASupplier.SupplierProducts = Convert.ToString(DB.DataTable.Rows[Index]["SupplierProducts"]);
                ASupplier.SupplierDeliveryDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["SupplierDeliverydate"]);
                ASupplier.SupplierFromUk = Convert.ToBoolean(DB.DataTable.Rows[Index]["SupplierFromUk"]);

                //add the record to the private data member
                mSupplierList.Add(ASupplier);

                //point at the next record
                Index++;
            }
        }



        //private data member for supplier list
        List<clsSupplier> mSupplierList = new List<clsSupplier>();
        clsSupplier mThisSupplier = new clsSupplier();
        //public property for supplier list
        public List<clsSupplier> SupplierList
        {
            get
            {
                //return private data
                return mSupplierList;
            }
            set
            {
                mSupplierList = value;
            }
        }

        //public property for count
        public int Count
        {
            get
            {
                return mSupplierList.Count;
            }
            set
            {
                //later
            }
        }



        public clsSupplier ThisSupplier
        {
            get
            { return mThisSupplier; }

            set
            {
                mThisSupplier = value;
            }
        }

        public int Add()
        {

            //add a record to the database based on the value of mThisSupplier
            //connect to the database 
            clsDataConnection DB = new clsDataConnection();
            //set the parameter for the stored procedure 
            DB.AddParameter("@SupplierName", mThisSupplier.SupplierName);
            DB.AddParameter("@SupplierAddress", mThisSupplier.SupplierAddress);
            DB.AddParameter("@SupplierEmail", mThisSupplier.SupplierEmail);
            DB.AddParameter("@SupplierProducts", mThisSupplier.SupplierProducts);
            DB.AddParameter("@SupplierDeliveryDate", mThisSupplier.SupplierDeliveryDate);
            DB.AddParameter("@SupplierFromUk", mThisSupplier.SupplierFromUk);
            return DB.Execute("sproc_tblSupplier_Insert");

        }
        public void Update()
        {
            //Update a record to the database based on the value of mThisSupplier
            //connect to the database 
            clsDataConnection DB = new clsDataConnection();
            //set the parameter for the stored procedure 
            DB.AddParameter("@SupplierId", mThisSupplier.SupplierId);
            DB.AddParameter("@SupplierName", mThisSupplier.SupplierName);
            DB.AddParameter("@SupplierAddress", mThisSupplier.SupplierAddress);
            DB.AddParameter("@SupplierEmail", mThisSupplier.SupplierEmail);
            DB.AddParameter("@SupplierProducts", mThisSupplier.SupplierProducts);
            DB.AddParameter("@SupplierDeliveryDate", mThisSupplier.SupplierDeliveryDate);
            DB.AddParameter("@SupplierFromUk", mThisSupplier.SupplierFromUk);
            DB.Execute("sproc_tblSupplier_Update");

        }
        public void Delete()
        {
            //deletes the record pointed to by ThisSupplier
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@SupplierId", mThisSupplier.SupplierId);
            DB.Execute("sproc_tblSupplier_Delete");
        }

        public void ReportBySupplierAddress(String SupplierAddress)
        {
            //filters the record based on a afull or partial post code
            //connect to the database
            clsDataConnection DB = new clsDataConnection();

            //set the StaffEmail parameter to the database
            DB.AddParameter("@SupplierAddress", SupplierAddress);

            //execute the procedure
            DB.Execute("sproc_tblSupplier_FilterBySupplierAddress");

            //populate the array list with the data table
            PopualateArray(DB);
        }
    }
}

       

        
   


