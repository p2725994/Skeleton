using System;

namespace ClassLibrary
{
    public class clsOrder
    {
        //private data members
        private Int32 mOrderId;
        private decimal mOrderTotal;
        private DateTime mDatePlaced;
        private Boolean mPurchased;
        private string mDeliveryAddress;
        private Int32 mNoOfItems;
        private Boolean mIsGift;

        //public fields
        public int OrderId
        {
            get
            {
                return mOrderId;
            }
            set
            {
                mOrderId = value;
            }
        }
        public decimal OrderTotal
        {
            get
            {
                return mOrderTotal;
            }
            set
            {
                mOrderTotal = value;
            }
        }
        public DateTime DatePlaced
        {
            get
            {
                return mDatePlaced;
            }
            set
            {
                mDatePlaced = value;
            }
        }
        public bool Purchased
        {
            get
            {
                return mPurchased;
            }
            set
            {
                mPurchased = value;
            }
        }
        public string DeliveryAddress
        {
            get
            {
                return mDeliveryAddress;
            }
            set
            {
                mDeliveryAddress = value;
            }
        }
        public int NoOfItems
        {
            get
            {
                return mNoOfItems;
            }
            set
            {
                mNoOfItems = value;
            }
        }
        public bool IsGift 
        {
            get
            {
                return mIsGift;
            }
            set
            {
                mIsGift = value;
            }
        }

        //methods
        public bool Find(int OrderId)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter fro the address id to search from
            DB.AddParameter("@OrderId", OrderId);
            //execute the stored procedure
            DB.Execute("sproc_tblOrder_FilterByOrderId");
            //if one record is found (there should either be one or zero)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mOrderId = Convert.ToInt32(DB.DataTable.Rows[0]["OrderId"]);
                mOrderTotal = Convert.ToDecimal(DB.DataTable.Rows[0]["OrderTotal"]);
                mDatePlaced = Convert.ToDateTime(DB.DataTable.Rows[0]["DatePlaced"]);
                mPurchased = Convert.ToBoolean(DB.DataTable.Rows[0]["Purchased"]);
                mDeliveryAddress = Convert.ToString(DB.DataTable.Rows[0]["DeliveryAddress"]);
                mNoOfItems = Convert.ToInt32(DB.DataTable.Rows[0]["NoOfItems"]);
                mIsGift = Convert.ToBoolean(DB.DataTable.Rows[0]["IsGift"]);
                //return that everything worked OK
                return true;
            }
            //if no record was found 
            else 
            {
                //return false indicating there is a problem
                return false;
            }
        }

    }
}