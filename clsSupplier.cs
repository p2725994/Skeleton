using System;

namespace ClassLibrary
{ 
        public class clsSupplier
        {
            //private data memeber for the supplier id
            private Int32 mSupplierId;

            public Int32 SupplierId
            {
                get
                {
                    return mSupplierId;
                }
                set
                {
                    mSupplierId = value;
                }
            }


            //private data member for the Supplier Name 
            private string mSupplierName;

            public string SupplierName
            {
                get
                {
                    return mSupplierName;
                }
                set
                {
                    mSupplierName = value;
                }
            }

            //private data member for the supplier email 
            private string mSupplierEmail;

            public string SupplierEmail
            {
                get
                {
                    return mSupplierEmail;
                }
                set
                {
                    mSupplierEmail = value;
                }
            }

            //private data member for the supplier email
            private string mSupplierAddress;

            public string SupplierAddress
            {
                get
                {
                    return mSupplierAddress;
                }
                set
                {
                    mSupplierAddress = value;
                }
            }

            //private data member for the supplier Products 
            private string mSupplierProducts;

            public string SupplierProducts
            {
                get
                {
                    return mSupplierProducts;
                }
                set
                {
                    mSupplierProducts = value;
                }
            }

            //private data member for the supplier delivery date
            private DateTime mSupplierDeliveryDate;
            public DateTime SupplierDeliveryDate
            {
                get
                {
                    return mSupplierDeliveryDate;
                }
                set
                {
                    mSupplierDeliveryDate = value;
                }     
            }
            //private data member for the supplier from the UK

            private Boolean mSupplierFromUk;
            public Boolean SupplierFromUk
            {
                get
                {
                    return mSupplierFromUk;
                }
                set
                { 
                    mSupplierFromUk = value;
                }
            }
            /**FIND METHOD***/
            public bool Find (int SupplierId)
            {
                //set the private data members to test data value 
                mSupplierId = 2;
                mSupplierName = "Test name";
                mSupplierEmail = "Test email";
                mSupplierAddress = "XXX XXX";
                mSupplierProducts = "Test Products";
                mSupplierDeliveryDate = Convert.ToDateTime("00/00/0000");
                mSupplierFromUk= true;
                return true;
            }
    }
}
