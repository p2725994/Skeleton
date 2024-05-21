using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace ClassLibrary
{
    public class ClsStockCollection
    {

        //private data member for the list
        List<clsStocks> mStockList = new List<clsStocks>();
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
        public List<clsStocks> StockList { get; set; }
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

        public object Public { get; private set; }

        public int Add()
        {
            //adds a record to the database on the value of mThisStock
            //set the primary key value of the new record
            mThisStock.Product_Id = 1;
            //return the primarykey of the new record
            return mThisStock.Product_Id;
        }




        // constructor for the class
        public ClsStockCollection()
        {
            //variable for the index
            Int32 Index = 0;
            // variable to store the record count
            Int32 RecordCount = 0;
            //onject for the data connect
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblstock_SelectAll");
            //get the count of records
            RecordCount = DB.Count;
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank address
                clsStocks Astock = new clsStocks();
                //read in the fields for the current record
                Astock.Available = Convert.ToBoolean(DB.DataTable.Rows[Index]["Available"]);
                Astock.Product_Id = Convert.ToInt32(DB.DataTable.Rows[Index]["Product_Id"]);
                Astock.Product_Name = Convert.ToString(DB.DataTable.Rows[Index]["Product_Name"]);
                Astock.Product_Description = Convert.ToString(DB.DataTable.Rows[Index]["Product_Description"]);
                Astock.Product_Quantity = Convert.ToInt32(DB.DataTable.Rows[Index]["Product_Quantity"]);
                Astock.Product_Price = (float)Convert.ToDecimal(DB.DataTable.Rows[Index]["Product_Price"]);
                Astock.Product_Expiry = Convert.ToDateTime(DB.DataTable.Rows[Index]["Product_Expiry"]);
                //add the record to private data member
                mStockList.Add(Astock);
                //point at the next record
                Index++;



            }

            public void Update()


            {
                //update an existing record based on the values of thisstock
                //connect to the databse
                ClsStockCollection Allstocks = new ClsStockCollection();
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

        }
    }
}