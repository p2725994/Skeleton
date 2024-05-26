using System;
using System.IO;
using System.Runtime.Remoting.Channels;

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

        public string Valid(string datePlaced,
                            string deliveryAddress,
                            string orderTotal,
                            string noOfItems)
        {
            //create a string variable to store the error
            string Error = "";
            //create a temporary variable to store the date values
            DateTime DateTemp;
            //create a temporary variable to store decimal values
            decimal TotalTemp;
            //create a temporary variable to store integer values
            Int32 NoOfItemsTemp;

            //create an inastance of DateTime to compare with DateTemp
            //in the if statements
            DateTime DateComp = DateTime.Now.Date;

            //if the DatePlaced is blank
            if (datePlaced.Length == 0)
            {
                //record the error
                Error = Error + "The date placed may not be blank : ";
            }
            try
            {
                //copy the datePlaced value to the DateTemp variable
                DateTemp = Convert.ToDateTime(datePlaced);

                if (DateTemp < DateComp) //compate datePlaced with Date
                {
                    //record the error
                    Error = Error + "The date cannot be in the past : ";
                }
                //check to see if the date is greater than today's date
                if (DateTemp > DateComp)
                {
                    //record the error
                    Error = Error + "The date cannot be in the future : ";
                }
            }
            catch
            {
                //record the error
                Error = Error + "The date was not a valid date : ";
            }

            //if the DeliveryAddress is blank
            if (deliveryAddress.Length == 0)
            {
                //record the error
                Error = Error + "The delivery address may not be blank : ";
            }
            //if the delivery address is greater than 50 characters
            if (deliveryAddress.Length > 50)
            {
                //record the error
                Error = Error + "The delivey address must be less than 51 characters : ";
            }

            /**
            //copy the datePlaced value to the DateTemp variable
            DateTemp = Convert.ToDateTime(datePlaced);
            //check to see if the date is less than today's date
            if (DateTemp < DateTime.Now.Date)
            {
                Error = Error + "The date cannot be in the past : ";
            }
            //check to see if the date is more than today's date
            if (DateTemp > DateTime.Now.Date)
            {
                Error = Error + "The date cannot be in the future : ";
            }

            **/

            //if the OrderTotal is blank
            if (orderTotal.Length == 0)
            {
                //record the error
                Error = Error + "The order total may not be blank : ";
            }
            try
            {
                //copy the orderTotal value to the TotalTemp variable
                TotalTemp = Convert.ToDecimal(orderTotal);
                //round the orderTotal value to two decimal places
                Math.Round(TotalTemp, 2);

                //if the orderTotal is negative
                if (TotalTemp < 0.00m)
                {
                    //record the error
                    Error = Error + "The order total cannot be negative : ";
                }
                //if the order total is above the asigned limit
                if (TotalTemp > 9999999.99m)
                {
                    //record the error
                    Error = Error + "The order total is larger than the decimal limit : ";
                }
            }
            catch
            {
                //record the error
                Error = Error + "The order total was not a valid decimal : ";
            }

            //if the NoOfItems is blank
            if (noOfItems.Length == 0)
            {
                //record the error
                Error = Error + "The No Of Items may not be blank : ";
            }
            try
            {
                //copy the noOfItems value to the NoOfItemsTemp variable
                NoOfItemsTemp = Convert.ToInt32(noOfItems);

                //if the NoOfItems is less than one
                if (NoOfItemsTemp < 1)
                {
                    //record the error
                    Error = Error + "The No Of Items cannot be less than one : ";
                }
                //if the NoOfItems is more than 9999999
                if (NoOfItemsTemp > 9999999)
                {
                    //record the error
                    Error = Error + "The No Of Items cannot be more than 9999999 : ";
                }
            }
            catch
            {
                //record the error
                Error = Error + "The No Of Items was not a valid integer : ";
            }

            //return any error messages
            return Error;
        }
    }
}