using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Security.Cryptography.X509Certificates;

namespace ClassLibrary

{
    public class ClsStockCollection
    {
        // constructor for the class
        public ClsStockCollection()
        {
            //object for the data connect
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblstock_SelectAll");
            // populate the array list with the data table
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            //populates the array list on the data table in the parameter DB
            //Variable for the index
            Int32 Index = 0;
            //variable to store the record count
            Int32 RecordCount;
            //get the count of records
            RecordCount = DB.Count;
            //Clear the private array List
            mStockList = new List<clsStocks>();
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank stock object
                clsStocks AStock = new clsStocks();
                //read in the fields from the current record
                //read in the fields for the current record

                AStock.Product_Id = Convert.ToInt32(DB.DataTable.Rows[Index]["Product_Id"]);
                AStock.Product_Description = Convert.ToString(DB.DataTable.Rows[Index]["Product_Description"]);
                AStock.Product_Name = Convert.ToString(DB.DataTable.Rows[Index]["Product_Name"]);
                AStock.Product_Expiry = Convert.ToDateTime(DB.DataTable.Rows[Index]["Product_Expiry"]);
                AStock.Product_Quantity = Convert.ToInt32(DB.DataTable.Rows[Index]["Product_Quantity"]);
                AStock.Product_Price = (float)Convert.ToDecimal(DB.DataTable.Rows[Index]["Product_Price"]);
                AStock.Available = Convert.ToBoolean(DB.DataTable.Rows[Index]["Available"]);
                //add the record to private data member
                mStockList.Add(AStock);
                //point at the next record
                Index++;
            }
        }
   
        //private member data for ThisStock
        clsStocks mThisStock = new clsStocks();
        public clsStocks ThisStock
        {
            get
            {
                //return the private data
                return mThisStock;
            }

            set
            {
                //set the private data
                mThisStock = value;
            }
        }

        //private data member for the list
        List<clsStocks> mStockList = new List<clsStocks>();
        public List<clsStocks> StockList 
        {
            get 
            {
                //return the private data
                return mStockList;
            }
            set 
            {
                //set the private data
                mStockList = value;
            } 
        }
        public int Count
        {
            get
            {
                //return the count of the list
                return mStockList.Count;
            }
            set
            {
                // we shall know about this later
            }
        }


        public int Add()
        {
            //adds a record to the database on the value of mThisStock
            //set the primary key value of the new record
            mThisStock.Product_Id = 1;
            //return the primarykey of the new record
            return mThisStock.Product_Id;
        }

        public void Update()
        {
            //update an existing record based on the values of thisstock
            //connect to the databse
            ClsStockCollection Allstocks = new ClsStockCollection();
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the new stored procedure
            DB.AddParameter("@Product_Id", mThisStock.Product_Id);
            DB.AddParameter("@Product_Name", mThisStock.Product_Name);
            DB.AddParameter("@Product_Description", mThisStock.Product_Description);
            DB.AddParameter("@Product_Quantity", mThisStock.Product_Quantity);
            DB.AddParameter("@Product_Price", mThisStock.Product_Price);
            DB.AddParameter("@Product_Expiry", mThisStock.Product_Expiry);
            DB.AddParameter("@Available", mThisStock.Available);

            //execute the stored procedure
            DB.Execute("sproc_tblStock_Update");
        }

        public void Delete()
        {
            //deletes the record pointed to by this stock
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@Product_Id", mThisStock.Product_Id);
            // execute the stored procedure
            DB.Execute("sproc_tblstock_Delete");
        }

        public void ReportByProduct_Name(string Product_Name)
        {
            //filters the records based on a full or partial Product Name
            //connect to the databse
            clsDataConnection DB = new clsDataConnection();
            //send the Product Name parameter to the database
            DB.AddParameter("@Product_Name", Product_Name);
            //execute the stored procedure
            DB.Execute("sproc_tblstock_FilterByProduct_Name");
            //populate the array list with the data table
            PopulateArray(DB);

        }      
    }
}
    

     

