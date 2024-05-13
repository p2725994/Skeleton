using System;
namespace ClassLibrary
{
    public class clsStocks
    {
        private Int32 mProduct_Id;
        public Int32 Product_Id
        {
            get
            {
                return mProduct_Id;
            }
            set
            {
                mProduct_Id = value;
            }


        }

        private string mProduct_Name;
        public string Product_Name
        {
            get
            {
                return mProduct_Name;

            }
            set
            {
                mProduct_Name = value;
            }
        }

        private string mProduct_Description;
        public string Product_Description
        {
            get
            {
                return mProduct_Description;
            }
            set
            {
                mProduct_Description = value;
            }
        }

        private Int32 mProduct_Quantity;
        public Int32 Product_Quantity
        {
            get
            {
                return mProduct_Quantity;

            }
            set
            {
                mProduct_Quantity = value;
            }
        }

        private Double mProduct_Price;
        public double Product_Price
        {
            get
            {
                return mProduct_Price;
            }
            set
            {
                mProduct_Price = value;
            }
        }


        private DateTime mProduct_Expiry;
        public DateTime Product_Expiry
        {
            get
            {
                return mProduct_Expiry;
            }
            set
            {
                mProduct_Expiry = value;
            }
        }

        private Boolean mAvailable;
        public bool Available
        {
            get
            {
                return mAvailable;
            }
            set
            {
                mAvailable = value;
            }
        }

        public bool Find(int Product_Id)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the StaffNo to search for
            DB.AddParameter("@Product_Id", Product_Id);
            //execute the stored procedures
            DB.Execute("sproc_tblstock_FilterbyProduct_Id");
            //if one record is found (there should be either 1 or 0)
            if (DB.Count == 1)
            {
                //set the private data members to the test data value
                mProduct_Id = Convert.ToInt32(DB.DataTable.Rows[0]["Product_Id"]);
                mProduct_Name = Convert.ToString(DB.DataTable.Rows[0]["Product_Name"]);
                mProduct_Description = Convert.ToString(DB.DataTable.Rows[0]["Product_Description"]);
                mProduct_Quantity = Convert.ToInt32(DB.DataTable.Rows[0]["Product_Quantity"]);
                mProduct_Price = Convert.ToDouble(DB.DataTable.Rows[0]["Product_Price"]);
                mProduct_Expiry = Convert.ToDateTime(DB.DataTable.Rows[0]["Product_Expiry"]);
                mAvailable = Convert.ToBoolean(DB.DataTable.Rows[0]["Available"]);

                //return that everything worked
                return true;

            }

            //if no record was found
            else
            {
                //return false indicating a problem
                return false;
            }
        }
    }
}
