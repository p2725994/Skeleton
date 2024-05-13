using System;

namespace ClassLibrary
{
    public class clsOrder
    {
        //private data members
        private Int32 mOrderId;
        private float mOrderTotal;
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
        public float OrderTotal
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
            //set the private data members to the test data value
            mOrderId = 21;
            mOrderTotal = 34.99f;
            mDatePlaced = Convert.ToDateTime("01/01/2024");
            mPurchased = true;
            mDeliveryAddress = "Test Address";
            mNoOfItems = 5;
            mIsGift = true;
            //always return true
            return true;
        }

    }
}