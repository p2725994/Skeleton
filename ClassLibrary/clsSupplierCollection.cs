using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsSupplierCollection
    {
        public clsSupplierCollection()
        {
            //variable for the index
            Int32 Index = 0;

            //variable to store the record count
            Int32 RecordCount = 0;

            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();

            //execute the stored procedures
            DB.Execute("sproc_tblSupplier_SelectAll");
            //get the count of the records
            RecordCount = DB.Count;

            while (Index < RecordCount)
            {
                //create a blank supplier
                clsSupplier ASupplier = new clsSupplier();

                //read in the fields for the current record
                ASupplier.SupplierId = Convert.ToInt32(DB.DataTable.Rows[0]["SupplierId"]);
                ASupplier.SupplierName = Convert.ToString(DB.DataTable.Rows[0]["SupplierName"]);
                ASupplier.SupplierEmail = Convert.ToString(DB.DataTable.Rows[0]["SupplierEmail"]);
                ASupplier.SupplierAddress = Convert.ToString(DB.DataTable.Rows[0]["SupplierAddress"]);
                ASupplier.SupplierProducts = Convert.ToString(DB.DataTable.Rows[0]["SupplierProducts"]);
                ASupplier.SupplierDeliveryDate = Convert.ToDateTime(DB.DataTable.Rows[0]["SupplierDeliveryDate"]);
                ASupplier.SupplierFromUk = Convert.ToBoolean(DB.DataTable.Rows[0]["SupplierFromUk"]);

                //add the record to the private data member
                mSupplierList.Add(ASupplier);

                //point at the next record
                Index++;
            }
        }

        //private data member for supplier list
        List<clsSupplier> mSupplierList = new List<clsSupplier>();
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
        public clsSupplier ThisSupplier { get; set; }
    }
}

