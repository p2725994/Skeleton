using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class ClsStockCollection
    {
        public List<clsStocks> StockList { get; set; }
        public int Count
        {
            get
            {
                //return the count of the list
                return StockList.Count;
            }
            set
            {
                // we shall know about this later
            }
        }
          
        public clsStocks ThisStock { get; set; }
        // private data member for the list
        List<clsStocks> mStockList = new List<clsStocks>();
      
        // Public property for the address list
        public List<clsStocks> StosckLlist
        {
            get
            {
                //return the private data
                return mStockList;
            }
            set
            {
                //set the private
                mStockList = value;
            }
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
        }
    }
}