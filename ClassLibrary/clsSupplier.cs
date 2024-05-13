using System;

namespace ClassLibrary
{
    public class clsSupplier
    {
        public bool Active { get; set; }
        public bool SupplierFromUk { get; set; }
        public DateTime SupplierDeliverydate { get; set; }
        public int SupplierID { get; set; }
        public string SupplierName { get; set; }
        public string SupplierEmail { get; set; }
        public string SupplierAddress { get; set; }
        public string SupplierProducts { get; set; }

        public bool Find(int supplierId)
        {
            SupplierID = 2;
            return true;
        }
        public class ClsSupplier
        {
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
               public class ClsSupplier
        {
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
        
        
        }
    }
}
