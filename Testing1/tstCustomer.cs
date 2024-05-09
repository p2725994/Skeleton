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
            int TestData = 0771234567;
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
            int TestData = 1;
            //assign the data to the property
            ACustomer.CustomerID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.CustomerID, TestData);
        }
    }
}
