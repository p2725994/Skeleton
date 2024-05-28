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
        public bool Find(int SupplierId)
        {
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the address id to search for 
            DB.AddParameter("@SupplierId", SupplierId);
            // if one record is found 
            DB.Execute("sproc_tblSupplier_FilterBySupplierId");

            if (DB.Count == 1)
            {
                //set the private data members to test data value 
                mSupplierId = Convert.ToInt32(DB.DataTable.Rows[0]["SupplierId"]);
                mSupplierName = Convert.ToString(DB.DataTable.Rows[0]["SupplierName"]);
                mSupplierEmail = Convert.ToString(DB.DataTable.Rows[0]["SupplierEmail"]);
                mSupplierAddress = Convert.ToString(DB.DataTable.Rows[0]["SupplierAddress"]);
                mSupplierProducts = Convert.ToString(DB.DataTable.Rows[0]["SupplierProducts"]);
                mSupplierDeliveryDate = Convert.ToDateTime(DB.DataTable.Rows[0]["SupplierDeliveryDate"]);
                mSupplierFromUk = Convert.ToBoolean(DB.DataTable.Rows[0]["SupplierFromUk"]);
                return true;
            }
            else
            {
                return false;
            }
        }

        public string Valid(
            string supplierName, 
            string supplierEmail, 
            string supplierProducts,
            string supplierAddress, 
            string supplierDeliveryDate)
        {
            String Error = "";
            DateTime DateTemp;
            if(supplierName.Length == 0)
            {
                Error = Error + "The supplier name can not be left blank :";
            }
            if (supplierName.Length > 30)
            {
                Error = Error + "The supplier name must be less then 30 characters ";

            }
           
            try
            {
                DateTemp = Convert.ToDateTime(supplierDeliveryDate);
                if (DateTemp < DateTime.Now.Date)
                {
                    Error = Error + "The date cannot be in the past";
                }
                if (DateTemp > DateTime.Now.Date)
                {
                    Error = Error + "The date cannot be in the future";
                }
            }
            catch
            {
                Error = Error + "The date was not valid date";
            }
            if (supplierEmail.Length == 0)
            {
                Error = Error + "The email code may not be blank ";
            }
            if (supplierEmail.Length > 40)
            {
                Error = Error + "The post cannot be less then 40 character";
            }
            if (supplierAddress.Length == 0)
            {
                Error = Error + "The email code may not be blank ";
            }
            if (supplierAddress.Length > 10)
            {
                Error = Error + "The post cannot be less then 40 character";
            }
            if (supplierProducts.Length == 0)
            {
                Error = Error + "The email code may not be blank ";
            }
            if (supplierProducts.Length > 50)
            {
                Error = Error + "The post cannot be less then 40 character";
            }


            return Error;
        }


        public void Find(object supplierId)
        {
            throw new NotImplementedException();
        }
    }
}
