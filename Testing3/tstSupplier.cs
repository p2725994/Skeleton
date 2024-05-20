using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework.Internal;
using System;
using System.IO;
using System.Linq.Expressions;
using Xunit.Sdk;

namespace Testing3
{
    [TestClass]
    public class tstSupplier
    {
        //create some test data to pass the method 
        string SupplierName = "RedBull";
        string SupplierEmail = "RedBull@gmail.com";
        string SupplierAddress = "293 TBH";
        string SupplierProducts = "RedBull Energy";
        string SupplierDeliveryDate = DateTime.Now.ToShortDateString();

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
            ASupplier.SupplierName = TestData;
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
            Int32 SupplierId = 1;

            Found = ASupplier.Find(SupplierId);
            Assert.IsTrue(Found);
        }
        [TestMethod]

        public void TestSupplierIdFound()
        {
            clsSupplier ASupplier = new clsSupplier();
            // create a boolean variable to store the result of the serach 
            Boolean Found = false;
            // create a boolean varaible to record if he data is ok
            Boolean OK = true;
            //create some test data to use with the method 
            Int32 SupplierId = 1;
            Found = ASupplier.Find(SupplierId);
            if (ASupplier.SupplierId != 1)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestSupplierNameFound()
        {
            clsSupplier ASupplier = new clsSupplier();
            // create a boolean variable to store the result of the serach 
            Boolean Found = false;
            // create a boolean varaible to record if he data is ok
            Boolean OK = true;
            //create some test data to use with the method 
            Int32 SupplierId = 1;
            Found = ASupplier.Find(SupplierId);
            if (ASupplier.SupplierName != "RedBull")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestSupplierEmailFound()
        {
            clsSupplier ASupplier = new clsSupplier();
            // create a boolean variable to store the result of the serach 
            Boolean Found = false;
            // create a boolean varaible to record if he data is ok
            Boolean OK = true;
            //create some test data to use with the method 
            Int32 SupplierId = 1;
            Found = ASupplier.Find(SupplierId);
            if (ASupplier.SupplierEmail != "Redbull@gmail.com")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestSupplierAddressFound()
        {
            clsSupplier ASupplier = new clsSupplier();
            // create a boolean variable to store the result of the serach 
            Boolean Found = false;
            // create a boolean varaible to record if he data is ok
            Boolean OK = true;
            //create some test data to use with the method 
            Int32 SupplierId = 1;
            Found = ASupplier.Find(SupplierId);
            if (ASupplier.SupplierAddress != "293 TBH")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestSupplierProductsFound()
        {
            clsSupplier ASupplier = new clsSupplier();
            // create a boolean variable to store the result of the serach 
            Boolean Found = false;
            // create a boolean varaible to record if he data is ok
            Boolean OK = true;
            //create some test data to use with the method 
            Int32 SupplierId = 1;
            Found = ASupplier.Find(SupplierId);
            if (ASupplier.SupplierProducts != "Redbull Energy")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestSupplierDeliveryDateFound()
        {
            clsSupplier ASupplier = new clsSupplier();
            // create a boolean variable to store the result of the serach 
            Boolean Found = false;
            // create a boolean varaible to record if he data is ok
            Boolean OK = true;
            //create some test data to use with the method 
            Int32 SupplierId = 1;
            Found = ASupplier.Find(SupplierId);
            if (ASupplier.SupplierDeliveryDate != Convert.ToDateTime("29/02/2024"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestSupplierFromUk()
        {
            clsSupplier ASupplier = new clsSupplier();
            // create a boolean variable to store the result of the serach 
            Boolean Found = false;
            // create a boolean varaible to record if he data is ok
            Boolean OK = true;
            //create some test data to use with the method 
            Int32 SupplierId = 1;
            Found = ASupplier.Find(SupplierId);
            if (ASupplier.SupplierFromUk != true)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void ValidMethodOK()
        {
            clsSupplier ASupplier = new clsSupplier();
            String Error = "";
            Error = ASupplier.Valid(SupplierName, SupplierEmail, SupplierProducts, SupplierAddress, SupplierDeliveryDate);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }
        [TestMethod]

        public void SupplierNameMinLessOne()
        {
            //create an instance of the class we want
            clsSupplier ASupplier = new clsSupplier();
            String Error = "";
            string SupplierName = "";
            //invoke the method
            Error = ASupplier.Valid(SupplierName, SupplierEmail, SupplierProducts, SupplierAddress, SupplierDeliveryDate);
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]

        public void SupplierNameMin()
        {
            //create an instance of the class we want
            clsSupplier ASupplier = new clsSupplier();
            String Error = "";
            string SupplierName = "a";
            //invoke the method
            Error = ASupplier.Valid(SupplierName, SupplierEmail, SupplierProducts, SupplierAddress, SupplierDeliveryDate);
            Assert.AreEqual(Error, "");

        }
        [TestMethod]

        public void SupplierNameMinPlusOne()
        {
            //create an instance of the class we want
            clsSupplier ASupplier = new clsSupplier();
            string Error = "";
            string SupplierName = "a";
            //invoke the method
            Error = ASupplier.Valid(SupplierName, SupplierEmail, SupplierProducts, SupplierAddress, SupplierDeliveryDate);
            Assert.AreEqual(Error, "");

        }
        [TestMethod]

        public void SupplierNameMaxLessOne()
        {
            //create an instance of the class we want
            clsSupplier ASupplier = new clsSupplier();
            string Error = "";
            string SupplierName = "aa";
            //invoke the method
            Error = ASupplier.Valid(SupplierName, SupplierEmail, SupplierProducts, SupplierAddress, SupplierDeliveryDate);
            Assert.AreEqual(Error, "");

        }
        [TestMethod]

        public void SupplierNameMax()
        {
            //create an instance of the class we want
            clsSupplier ASupplier = new clsSupplier();
            string Error = "";
            string SupplierName = "aaaaaa";
            //invoke the method
            Error = ASupplier.Valid(SupplierName, SupplierEmail, SupplierProducts, SupplierAddress, SupplierDeliveryDate);
            Assert.AreEqual(Error, "");

        }
        [TestMethod]

        public void SupplierNameMaxPlusOne()
        {
            //create an instance of the class we want
            clsSupplier ASupplier = new clsSupplier();
            string Error = "";
            string SupplierName = "aaaaaaa";
            //invoke the method
            Error = ASupplier.Valid(SupplierName, SupplierEmail, SupplierProducts, SupplierAddress, SupplierDeliveryDate);
            Assert.AreEqual(Error, "");

        }
        [TestMethod]

        public void SupplierNameExtremeMax()
        {
            //create an instance of the class we want
            clsSupplier ASupplier = new clsSupplier();
            string Error = "";
            string SupplierName = "";
            SupplierName = SupplierName.PadRight(500, 'a');
            //invoke the method
            Error = ASupplier.Valid(SupplierName, SupplierEmail, SupplierProducts, SupplierAddress, SupplierDeliveryDate);
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]

        public void SupplierDeliveryDateExtremeMin()
        {
            //create an instance of the class we want
            clsSupplier ASupplier = new clsSupplier();
            string Error = "";

            DateTime TestDate;
            //set the date to todays date 
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(-100);
            //convert the date variable to a string variable
            string SupplierDeliveryDate = TestDate.ToString();
            //invoke the method
            Error = ASupplier.Valid(SupplierName, SupplierEmail, SupplierProducts, SupplierAddress, SupplierDeliveryDate);
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]

        public void SupplierDeliveryDateMinLessOne()
        {
            //create an instance of the class we want
            clsSupplier ASupplier = new clsSupplier();
            string Error = "";

            DateTime TestDate;
            //set the date to todays date 
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(-1);
            //convert the date variable to a string variable
            string SupplierDeliveryDate = TestDate.ToString();
            //invoke the method
            Error = ASupplier.Valid(SupplierName, SupplierEmail, SupplierProducts, SupplierAddress, SupplierDeliveryDate);
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]

        public void SupplierDeliveryDateMin()
        {
            //create an instance of the class we want
            clsSupplier ASupplier = new clsSupplier();
            String Error = "";

            DateTime TestDate;
            //set the date to todays date 
            TestDate = DateTime.Now.Date;


            //convert the date variable to a string variable
            string SupplierDeliveryDate = TestDate.ToString();
            //invoke the method
            Error = ASupplier.Valid(SupplierName, SupplierEmail, SupplierProducts, SupplierAddress, SupplierDeliveryDate);
            Assert.AreEqual(Error, "");

        }
        [TestMethod]

        public void SupplierDeliveryDateMinPlusOne()
        {
            //create an instance of the class we want
            clsSupplier ASupplier = new clsSupplier();
            string Error = "";

            DateTime TestDate;
            //set the date to todays date 
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 1 day
            TestDate = TestDate.AddYears(1);
            //convert the date variable to a string variable
            string SupplierDeliveryDate = TestDate.ToString();
            //invoke the method
            Error = ASupplier.Valid(SupplierName, SupplierEmail, SupplierProducts, SupplierAddress, SupplierDeliveryDate);
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]

        public void SupplierDeliveryDateExtremeMax()
        {
            //create an instance of the class we want
            clsSupplier ASupplier = new clsSupplier();
            string Error = "";

            DateTime TestDate;
            //set the date to todays date 
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(100);
            //convert the date variable to a string variable
            string SupplierDeliveryDate = TestDate.ToString();
            //invoke the method
            Error = ASupplier.Valid(SupplierName, SupplierEmail, SupplierProducts, SupplierAddress, SupplierDeliveryDate);
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]

        public void SupplierDeliveryDateInvalidDate()
        {
            //create an instance of the class we want
            clsSupplier ASupplier = new clsSupplier();
            String Error = "";

            //convert the date variable to a string variable
            string SupplierDeliveryDate = "this is not a date";
            //invoke the method
            Error = ASupplier.Valid(SupplierName, SupplierEmail, SupplierProducts, SupplierAddress, SupplierDeliveryDate);
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void SupplierEmailMinLessOne()
        {
            //create an instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string SupplierEmail = "";
            //invoke the method
            Error = ASupplier.Valid(SupplierName, SupplierEmail, SupplierProducts, SupplierAddress, SupplierDeliveryDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void SupplierEmailMin()
        {
            //create an instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string SupplierEmail = "a";
            //invoke the method
            Error = ASupplier.Valid(SupplierName, SupplierEmail, SupplierProducts, SupplierAddress, SupplierDeliveryDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void SupplierEmailMinPlusOne()
        {
            //create an instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string SupplierEmail = "aa";
            //invoke the method
            Error = ASupplier.Valid(SupplierName, SupplierEmail, SupplierProducts, SupplierAddress, SupplierDeliveryDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void SupplierEmailMaxLessOne()
        {
            //create an instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string SupplierEmail = "a";
            SupplierEmail = SupplierEmail.PadRight(39, 'a');
            //invoke the method
            Error = ASupplier.Valid(SupplierName, SupplierEmail, SupplierProducts, SupplierAddress, SupplierDeliveryDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void SupplierEmailMax()
        {
            //create an instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string SupplierEmail = "a";
            SupplierEmail = SupplierEmail.PadRight(40, 'a');
            //invoke the method
            Error = ASupplier.Valid(SupplierName, SupplierEmail, SupplierProducts, SupplierAddress, SupplierDeliveryDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void SupplierEmailMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string SupplierEmail = "a";
            SupplierEmail = SupplierEmail.PadRight(41, 'a');
            //invoke the method
            Error = ASupplier.Valid(SupplierName, SupplierEmail, SupplierProducts, SupplierAddress, SupplierDeliveryDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void SupplierEmailMid()
        {
            //create an instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string SupplierEmail = "a";
            SupplierEmail = SupplierEmail.PadRight(20, 'a');
            //invoke the method
            Error = ASupplier.Valid(SupplierName, SupplierEmail, SupplierProducts, SupplierAddress, SupplierDeliveryDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void SupplierAddressLessOne()
        {
            //create an instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string SupplierAddress = "";
            //invoke the method
            Error = ASupplier.Valid(SupplierName, SupplierEmail, SupplierProducts, SupplierAddress, SupplierDeliveryDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void SupplierAddressMin()
        {
            //create an instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string SupplierAddress = "a";
            //invoke the method
            Error = ASupplier.Valid(SupplierName, SupplierEmail, SupplierProducts, SupplierAddress, SupplierDeliveryDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void SupplierAddrressMinPlusOne()
        {
            //create an instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string SupplierAddress = "aa";
            //invoke the method
            Error = ASupplier.Valid(SupplierName, SupplierEmail, SupplierProducts, SupplierAddress, SupplierDeliveryDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void SupplierAddressMaxLessOne()
        {
            //create an instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string SupplierAddress = "a";
            SupplierAddress = SupplierAddress.PadRight(9, 'a');
            //invoke the method
            Error = ASupplier.Valid(SupplierName, SupplierEmail, SupplierProducts, SupplierAddress, SupplierDeliveryDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void SupplierAddressMax()
        {
            //create an instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string SupplierAddress = "a";
            SupplierAddress = SupplierAddress.PadRight(10, 'a');
            //invoke the method
            Error = ASupplier.Valid(SupplierName, SupplierEmail, SupplierProducts, SupplierAddress, SupplierDeliveryDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void SupplierAddressMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string SupplierAddress = "a";
            SupplierAddress = SupplierAddress.PadRight(11, 'a');
            //invoke the method
            Error = ASupplier.Valid(SupplierName, SupplierEmail, SupplierProducts, SupplierAddress, SupplierDeliveryDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void SupplierAddressMid()
        {
            //create an instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string SupplierAddress = "a";
            SupplierAddress = SupplierAddress.PadRight(5, 'a');
            //invoke the method
            Error = ASupplier.Valid(SupplierName, SupplierEmail, SupplierProducts, SupplierAddress, SupplierDeliveryDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SupplierProdcutsMinLessOne()
        {
            //create an instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string SupplierProducts = "";
            //invoke the method
            Error = ASupplier.Valid(SupplierName, SupplierEmail, SupplierProducts, SupplierAddress, SupplierDeliveryDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void SupplierProductsMin()
        {
            //create an instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string SupplierProducts = "a";
            //invoke the method
            Error = ASupplier.Valid(SupplierName, SupplierEmail, SupplierProducts, SupplierAddress, SupplierDeliveryDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void SupplierProductsMinPlusOne()
        {
            //create an instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string SupplierProducts = "aa";
            //invoke the method
            Error = ASupplier.Valid(SupplierName, SupplierEmail, SupplierProducts, SupplierAddress, SupplierDeliveryDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void SupplierProductsMaxLessOne()
        {
            //create an instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string SupplierProducts = "a";
            SupplierProducts = SupplierProducts.PadRight(49, 'a');
            //invoke the method
            Error = ASupplier.Valid(SupplierName, SupplierEmail, SupplierProducts, SupplierAddress, SupplierDeliveryDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void SupplierProductsMax()
        {
            //create an instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string SupplierProducts = "a";
            SupplierProducts = SupplierProducts.PadRight(50, 'a');
            //invoke the method
            Error = ASupplier.Valid(SupplierName, SupplierEmail, SupplierProducts, SupplierAddress, SupplierDeliveryDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void SupplierProductsMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string SupplierProducts = "a";
            SupplierProducts = SupplierProducts.PadRight(51, 'a');
            //invoke the method
            Error = ASupplier.Valid(SupplierName, SupplierEmail, SupplierProducts, SupplierAddress, SupplierDeliveryDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void SupplierProductsMid()
        {
            //create an instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string SupplierProducts = "a";
            SupplierProducts = SupplierProducts.PadRight(25, 'a');
            //invoke the method
            Error = ASupplier.Valid(SupplierName, SupplierEmail, SupplierProducts, SupplierAddress, SupplierDeliveryDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
    }
}









