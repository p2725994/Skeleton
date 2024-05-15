using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing1
{
    [TestClass]
    public class tstCustomer
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance
            clsCustomer ACustomer = new clsCustomer();
            //test to see if it exists
            Assert.IsNotNull(ACustomer);
        }

        [TestMethod]
        public void IsVerifiedPropertyOK()
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
        public void UserBirthdatePropertOK()
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
        public void UserFirstnamePropertyOK()
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
        public void UserLastnamePropertyOK()
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
        public void UserEmailPropertyOK()
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
        public void UserPhonePropertyOK()
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
        public void UserIDPropertyOK()
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
            if (ACustomer.Verified != true)
            {
                OK = false;
            }
            //test to see if result is correct
            Assert.IsTrue(OK);
        }
    }

}
