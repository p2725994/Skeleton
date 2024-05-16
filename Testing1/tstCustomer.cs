using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing1
{
    [TestClass]
    public class tstCustomer
    {

        //good test data
        //create some test data to pass the methods
        string CustomerFirstname = "Afnan";
        string CustomerLastname = "Khalid";
        string CustomerEmail = "afnan@yahoo.com";
        string CustomerPhone = "77323232";
        string CustomerBirthdate = DateTime.Now.ToShortDateString();


        [TestMethod]
        public void InstanceOK()
        {
            //create an instance
            clsCustomer ACustomer = new clsCustomer();
            //test to see if it exists
            Assert.IsNotNull(ACustomer);
        }

        [TestMethod]
        public void VerifiedPropertyOK()
        {
            //crete an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign the propert
            Boolean TestData = true;
            //assign the data to property
            ACustomer.Verified = TestData;
            //test to see that the two values are same
            Assert.AreEqual(ACustomer.Verified, TestData);

        }


        [TestMethod]
        public void CustomerBirthdatePropertOK()
        {
            //crete an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign the property
            DateTime TestData = DateTime.Now.Date;
            //set the Birthdate property with the test data
            ACustomer.CustomerBirthdate = TestData;
            //verify that the birthdate porperty was set correctly
            Assert.AreEqual(TestData, ACustomer.CustomerBirthdate);
        }


        [TestMethod]
        public void CustomerFirstnamePropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property
            String TestData = "Ahsan";
            //assign the data to the property
            ACustomer.CustomerFirstname = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.CustomerFirstname, TestData);
        }


        [TestMethod]
        public void CustomerLastnamePropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property
            String TestData = "Ijaz";
            //assign the data to the property
            ACustomer.CustomerLastname = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.CustomerLastname, TestData);
        }


        [TestMethod]
        public void CustomerEmailPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property
            String TestData = "ijazahsan167@gmail.com";
            //assign the data to the property
            ACustomer.CustomerEmail = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.CustomerEmail, TestData);
        }

        [TestMethod]
        public void CustomerPhonePropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property
            int TestData = 077123456;
            //assign the data to the property
            ACustomer.CustomerPhone = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.CustomerPhone, TestData);
        }

        [TestMethod]
        public void CustomerIDPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property
            int TestData = 2;
            //assign the data to the property
            ACustomer.CustomerID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.CustomerID, TestData);
        }

        /*************Find Method Test*************/

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create a Boolean variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 CustomerID = 2;
            //invoke the method
            Found = ACustomer.Find(CustomerID);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }
        
        /***************Property Data Test**********/

        [TestMethod]
        public void TestCustomerIDFound()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //create a boolean vaariable to store search result
            Boolean Found = false;
            //create a boolean variable to record if data is OK
            Boolean OK = true;
            //create some test data to use w record
            Int32 CustomerID = 2;
            //invoke the method
            Found = ACustomer.Find(CustomerID);
            //check the customer ID
            if (ACustomer.CustomerID != 2)
            {
                OK = false; 
            }
            //test to see if result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerFirstnameFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 2;
            //invoke the method
            Found = ACustomer.Find(CustomerID);
            //check the firstname property
            if (ACustomer.CustomerFirstname != "Afnan")
            {
                OK = false;
            }
            //test to see if result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerLastnameFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 2;
            //invoke the method
            Found = ACustomer.Find(CustomerID);
            //check the firstname property
            if (ACustomer.CustomerLastname != "Khalid")
            {
                OK = false;
            }
            //test to see if result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerEmailFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 2;
            //invoke the method
            Found = ACustomer.Find(CustomerID);
            //check the firstname property
            if (ACustomer.CustomerEmail != "afnan@yahoo.com")
            {
                OK = false;
            }
            //test to see if result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerBirthdateFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 2;
            //invoke the method
            Found = ACustomer.Find(CustomerID);
            //check the firstname property
            if (ACustomer.CustomerBirthdate != Convert.ToDateTime("09/12/2003"))
            {
                OK = false;
            }
            //test to see if result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerPhoneFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 2;
            //invoke the method
            Found = ACustomer.Find(CustomerID);
            //check the firstname property
            if (ACustomer.CustomerPhone != 77323232)
            {
                OK = false;
            }
            //test to see if result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestVerifiedFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 2;
            //invoke the method
            Found = ACustomer.Find(CustomerID);
            //check the firstname property
            if (ACustomer.Verified != false)
            {
                OK = false;
            }
            //test to see if result is correct
            Assert.IsTrue(OK);
        }


        /***********Property validation*****/

        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error messages
            String Error = "";
            //invoke the method
            Error = ACustomer.Valid(CustomerFirstname, CustomerLastname, CustomerEmail, CustomerBirthdate, CustomerPhone);
            //test to see that results are correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void CustomerFirstnameMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store error messages
            String Error = "";
            //create some test data to pass the method
            string CustomerFirstname = ""; //should trigger an error
            //invoke the method
            Error = ACustomer.Valid(CustomerFirstname, CustomerLastname, CustomerEmail, CustomerBirthdate, CustomerPhone);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerFirstnameMin()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store error messages
            String Error = "";
            //create some test data to pass the method
            string CustomerFirstname = "a"; //should trigger an error
            //invoke the method
            Error = ACustomer.Valid(CustomerFirstname, CustomerLastname, CustomerEmail, CustomerBirthdate, CustomerPhone);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerFirstnameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store error messages
            String Error = "";
            //create some test data to pass the method
            string CustomerFirstname = "aa"; //should be ok
            //invoke the method
            Error = ACustomer.Valid(CustomerFirstname, CustomerLastname, CustomerEmail, CustomerBirthdate, CustomerPhone);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerFirstnameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store error messages
            String Error = "";
            //create some test data to pass the method
            string CustomerFirstname = "aaaaaaaaaaaaaaaaaaa"; //should be ok
            //invoke the method
            Error = ACustomer.Valid(CustomerFirstname, CustomerLastname, CustomerEmail, CustomerBirthdate, CustomerPhone);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerFirstnameMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store error messages
            String Error = "";
            //create some test data to pass the method
            string CustomerFirstname = "aaaaaaaaaaaaaaaaaaaa"; //should be ok
            //invoke the method
            Error = ACustomer.Valid(CustomerFirstname, CustomerLastname, CustomerEmail, CustomerBirthdate, CustomerPhone);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerFirstnameMid()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store error messages
            String Error = "";
            //create some test data to pass the method
            string CustomerFirstname = "aaaaaaaaaa"; //should be ok
            //invoke the method
            Error = ACustomer.Valid(CustomerFirstname, CustomerLastname, CustomerEmail, CustomerBirthdate, CustomerPhone);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerFirstnameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store error messages
            String Error = "";
            //create some test data to pass the method
            string CustomerFirstname = "aaaaaaaaaaaaaaaaaaaaa"; //should fail
            //invoke the method
            Error = ACustomer.Valid(CustomerFirstname, CustomerLastname, CustomerEmail, CustomerBirthdate, CustomerPhone);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerFirstnameExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store error messages
            String Error = "";
            //create some test data to pass the method
            String CustomerFirstname = "";
            CustomerFirstname = CustomerFirstname.PadRight(500, 'a'); //this should fail
            //invoke the method
            Error = ACustomer.Valid(CustomerFirstname, CustomerLastname, CustomerEmail, CustomerBirthdate, CustomerPhone);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
    }

}
