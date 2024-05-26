using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsOrderCollection
    {
        //private data member for the list
        List<clsOrder> mOrderList = new List<clsOrder>();
        //private data member for thisOrder
        clsOrder mThisOrder = new clsOrder();

        public List<clsOrder> OrderList 
        { 
            get
            {
                //return the private data
                return mOrderList;
            }
            set 
            {
                //set the private data
                mOrderList = value;
            }
        }
        public int Count 
        {
            get
            {
                //return the count of the list
                return mOrderList.Count;
            }
            set
            {
                //later
            }
        }
        public clsOrder ThisOrder 
        { 
            get
            {
                //return the private data
                return mThisOrder;
            }
            set
            {
                //set the private data
                mThisOrder = value;
            }
        }

        //constructor for the class
        public clsOrderCollection()
        {

            //variable for the index
            Int32 Index = 0;
            //variable to store the record count
            Int32 RecordCount = 0;
            //object for the data connect
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblOrder_SelectAll");
            //get the count of records
            RecordCount = DB.Count;
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank address 
                clsOrder AnOrder = new clsOrder();
                //read in the fields for the current record
                AnOrder.OrderId = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderId"]);
                AnOrder.OrderTotal = Convert.ToDecimal(DB.DataTable.Rows[Index]["OrderTotal"]);
                AnOrder.DatePlaced = Convert.ToDateTime(DB.DataTable.Rows[Index]["DatePlaced"]);
                AnOrder.Purchased = Convert.ToBoolean(DB.DataTable.Rows[Index]["Purchased"]);
                AnOrder.DeliveryAddress = Convert.ToString(DB.DataTable.Rows[Index]["DeliveryAddress"]);
                AnOrder.NoOfItems = Convert.ToInt32(DB.DataTable.Rows[Index]["NoOfItems"]);
                AnOrder.IsGift = Convert.ToBoolean(DB.DataTable.Rows[Index]["IsGift"]);
                //add the record to the private data member
                mOrderList.Add( AnOrder );
                //point at the next record
                Index++;
            }
        }

        public int Add()
        {
            //adds a recod to the database based on the values of mThisAddress
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@OrderTotal", mThisOrder.OrderTotal);
            DB.AddParameter("@DatePlaced", mThisOrder.DatePlaced);
            DB.AddParameter("@Purchased", mThisOrder.Purchased);
            DB.AddParameter("@DeliveryAddress", mThisOrder.DeliveryAddress);
            DB.AddParameter("@NoOfItems", mThisOrder.NoOfItems);
            DB.AddParameter("@IsGift", mThisOrder.IsGift);

            //execute the query returning the primary key value
            return DB.Execute("sproc_tblOrder_Insert");
        }

        public void Update()
        {
            //update an existing record based on the values of ThisOrder
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@OrderId", mThisOrder.OrderId);
            DB.AddParameter("@OrderTotal", mThisOrder.OrderTotal);
            DB.AddParameter("@DatePlaced", mThisOrder.DatePlaced);
            DB.AddParameter("@Purchased", mThisOrder.Purchased);
            DB.AddParameter("@DeliveryAddress", mThisOrder.DeliveryAddress);
            DB.AddParameter("@NoOfItems", mThisOrder.NoOfItems);
            DB.AddParameter("@IsGift", mThisOrder.IsGift);
            //execute the stored procedure
            DB.Execute("sproc_tblOrder_Update");
        }
    }
}