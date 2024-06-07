using System;
using System.IO;
using System.Linq.Expressions;

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

        private float mProduct_Price;
        public float Product_Price
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
                mProduct_Price = (float)Convert.ToDecimal(DB.DataTable.Rows[0]["Product_Price"]);
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

        public string Valid(string product_Description, string product_Name, string product_Expiry, string product_Quantity, string product_Price)
        {
            //create a string variable to store the error
            String Error = "";
            //create a temporary variable to store date values
            DateTime DateTemp;
            //if the product name is blank
            if (product_Name.Length == 0)
            {
                //record the error
                Error = Error + "The product name may not be blank : ";
            }
            //if the hproduct name is greater than 30 characters
            if (product_Name.Length > 30)
            {
                //record the error
                Error = Error + "The product_Name must be less than 30 characters : ";
            }


            if (product_Description.Length == 0)
            {
                //record the error
                Error = Error + "The product description may not be blank : ";
            }

            //if the product description is greater than 50 characters
            if (product_Description.Length > 50)
            {
                //record the error
                Error = Error + "The product description    must be less than 50 characters : ";
            }

            // testing invalid date
            //create an instance of DateTime to compare with DateTemp
            //in the if statements
            DateTime DateComp = DateTime.Now.Date;
            try
            {

                //copy the dateAdded value to the DateTemp variable
                DateTemp = Convert.ToDateTime(product_Expiry);

                if (DateTemp < DateComp) // comnpare product expiry
                {
                    //record the error
                    Error = Error + "The date cannot be in the past : ";
                }
                //check to see if the date is greater than today's date
                if (DateTemp > DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "The date cannot be in the future : ";
                }
            }
            catch
            {
                //record the error
                Error = Error + "The date was not a valid date :";
            }
            //is the product quantity blank
            if (product_Quantity.Length == 0)
            {
                //record the error
                Error = Error + "There sould be some quantity inside: ";
            }
            //if the post code is too long
            if (product_Quantity.Length > 10)
            {
                //record the error
                Error = Error + "There should be less than 10 char: ";
            }

            // Assuming minimum price is £0.00 and maximum price is £99999.99
            if (Convert.ToDecimal(product_Price) < 0.00m)
            {
                Error += "The product price cannot be negative. ";
            }
            if (Convert.ToDecimal(product_Price) > 99999.99m)
            {
                Error += "The product price exceeds the maximum allowed value. ";
            }

            return Error; // Return any validation error





        }

    }
}



