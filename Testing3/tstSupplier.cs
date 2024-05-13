using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq.Expressions;
using Xunit.Sdk;

namespace Testing3
{
    [TestClass]
    public class tstSupplier
    {
        [TestMethod]
        public void InstaneOK()
        {
            //create an instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();
            //test to see that it exists
            Assert.IsNotNull(ASupplier);
     
        }

        [TestMethod]
        public void SupplierFromUkOK()
        {
            //create an instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();

            //create test data to assign to the property
            Boolean TestData = true;

            //assign the data to the property
            ASupplier.SupplierFromUk = TestData;

            //test to see that the 2 values are the same
            Assert.AreEqual(ASupplier.SupplierFromUk, TestData);
        }

        [TestMethod]
        public void SupplierDeliveryDatePropertyOK()
        {
            //create an instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();

            //create test data to assign to the property
            DateTime TestData = DateTime.Now.Date;

            //assign the data to the property
            ASupplier.SupplierDeliveryDate = TestData;

            //test to see that the 2 values are the same
            Assert.AreEqual(ASupplier.SupplierDeliveryDate, TestData);
        }

        [TestMethod]
        public void SupplierIdPropertyOK()
        {
            //create an instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            ASupplier.SupplierId = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ASupplier.SupplierId, TestData);
        }
        [TestMethod]
        public void SupplierNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();
            //create some test data to assign to the property
            string TestData = "RedBull";
            //assign the data to the property
            ASupplier .SupplierName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ASupplier.SupplierName, TestData);
        }
        [TestMethod]
        public void SupplierEmailPropertyOK()
        {
            //create an instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();
            //create some test data to assign to the property
            string TestData = "RedBull@gmail.com";
            //assign the data to the property
            ASupplier.SupplierEmail = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ASupplier.SupplierEmail, TestData);
        }

        [TestMethod]
        public void SupplierAddressPropertyOK()
        {
            //create an instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();
            //create some test data to assign to the property
            string TestData = "293 TBH";
            //assign the data to the property
            ASupplier.SupplierAddress = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ASupplier.SupplierAddress, TestData);
        }
        [TestMethod]
        public void SupplierProductsPropertyOK()
        {
            //create an instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();
            //create some test data to assign to the property
            string TestData = "Redbull Energy";
            //assign the data to the property
            ASupplier.SupplierProducts = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ASupplier.SupplierProducts, TestData);
        }
        [TestMethod]
        public void FindMethodOK()
        {
            clsSupplier ASupplier = new clsSupplier();
            Boolean Found = false;
            Int32 SupplierId = 2;

            Found = ASupplier.Find(SupplierId);
            Assert.IsTrue(Found);
        }

        public void TestSupplierIdFound()
        {
            clsSupplier ASupplier = new clsSupplier();
            // create a boolean variable to store the result of the serach 
            Boolean Found = false;
            // create a boolean varaible to record if he data is ok
            Boolean OK = true;
            //create some test data to use with the method 
            Int32 SupplierId = 3;
            Found = ASupplier.Find(SupplierId);
            if(ASupplier.SupplierId != 2)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        public void TestSupplierNameFound()
        {
            clsSupplier ASupplier = new clsSupplier();
            // create a boolean variable to store the result of the serach 
            Boolean Found = false;
            // create a boolean varaible to record if he data is ok
            Boolean OK = true;
            //create some test data to use with the method 
            Int32 SupplierId = 2;
            Found = ASupplier.Find(SupplierId);
            if (ASupplier.SupplierName != "Test Name")
            {
            }
            else
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        public void TestSupplierEmailFound()
        {
            clsSupplier ASupplier = new clsSupplier();
            // create a boolean variable to store the result of the serach 
            Boolean Found = false;
            // create a boolean varaible to record if he data is ok
            Boolean OK = true;
            //create some test data to use with the method 
            Int32 SupplierId = 2;
            Found = ASupplier.Find(SupplierId);
            if (ASupplier.SupplierEmail != "Test Email")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        public void TestSupplierAddressFound()
        {
            clsSupplier ASupplier = new clsSupplier();
            // create a boolean variable to store the result of the serach 
            Boolean Found = false;
            // create a boolean varaible to record if he data is ok
            Boolean OK = true;
            //create some test data to use with the method 
            Int32 SupplierId = 2;
            Found = ASupplier.Find(SupplierId);
            if (ASupplier.SupplierAddress != "XXX XXX")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        public void TestSupplierProductsFound()
        {
            clsSupplier ASupplier = new clsSupplier();
            // create a boolean variable to store the result of the serach 
            Boolean Found = false;
            // create a boolean varaible to record if he data is ok
            Boolean OK = true;
            //create some test data to use with the method 
            Int32 SupplierId = 2;
            Found = ASupplier.Find(SupplierId);
            if (ASupplier.SupplierProducts != "Test Products")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        private DateTime mSupplierDeliveryDate;
        public DateTime SupplierDeliveryDate
        {
            get
            { return mSupplierDeliveryDate; }
            set { mSupplierDeliveryDate = value;
            }       
        }

        private Boolean mSupplierFromUk;

        public bool SupplierFromuk
        { get { return mSupplierFromUk; } set {  mSupplierFromUk = value; } }

    }

}



