using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing2
{
    [TestClass]
    public class tstStaff
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();
            //test to see that it exists
            Assert.IsNotNull(aStaff);
        }

        [TestMethod]
        public void IsOnShiftPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();

            //create test data to assign to the property
            Boolean TestData = true;

            //assign the data to the property
            aStaff.IsOnShift = TestData;

            //test to see that the 2 values are the same
            Assert.AreEqual(aStaff.IsOnShift, TestData);
        }

        [TestMethod]
        public void DateJoinedPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();

            //create test data to assign to the property
            DateTime TestData = DateTime.Now.Date;

            //assign the data to the property
            aStaff.DateJoined = TestData;

            //test to see that the 2 values are the same
            Assert.AreEqual(aStaff.DateJoined, TestData);
        }

        [TestMethod]
        public void StaffNoPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            aStaff.StaffNo = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(aStaff.StaffNo, TestData);
        }

        [TestMethod]
        public void StaffFirstnamePropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();
            //create some test data to assign to the property
            string TestData = "Afnan";
            //assign the data to the property
            aStaff.StaffFirstname = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(aStaff.StaffFirstname, TestData);
        }

        [TestMethod]
        public void StaffSurnamePropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();
            //create some test data to assign to the property
            string TestData = "Khalid";
            //assign the data to the property
            aStaff.StaffSurname = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(aStaff.StaffSurname, TestData);
        }

        [TestMethod]
        public void StaffEmailPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();
            //create some test data to assign to the property
            string TestData = "AfnanKhalid@gmail.com";
            //assign the data to the property
            aStaff.StaffEmail = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(aStaff.StaffEmail, TestData);
        }

        [TestMethod]
        public void StaffPasswordPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();
            //create some test data to assign to the property
            string TestData = "Afnan123";
            //assign the data to the property
            aStaff.StaffPassword = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(aStaff.StaffPassword, TestData);
        }

        /******************FIND METHOD TEST******************/

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();
            //create a Boolean variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 StaffNo = 0;
            //invoke the method
            Found = aStaff.Find(StaffNo);
            //test to see that the two values are the same
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestStaffNoFound()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();

            //create a Boolean variable to store the result of the search
            Boolean Found = false;

            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;

            //create some test data to use with the method
            Int32 StaffNo = 21;

            //invoke the method
            Found = aStaff.Find(StaffNo);

            //check the StaffNo
            if (aStaff.StaffNo != 21)
                {
                    OK = false;
                }

            //test to see that the two values are the same
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStaffFirstnameFound()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();

            //create a Boolean variable to store the result of the search
            Boolean Found = false;

            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;

            //create some test data to use with the method
            Int32 StaffNo = 21;

            //invoke the method
            Found = aStaff.Find(StaffNo);

            //check the StaffNo
            if (aStaff.StaffFirstname != "Afnan")
            {
                OK = false;
            }

            //test to see that the two values are the same
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStaffSurnameFound()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();

            //create a Boolean variable to store the result of the search
            Boolean Found = false;

            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;

            //create some test data to use with the method
            Int32 StaffNo = 21;

            //invoke the method
            Found = aStaff.Find(StaffNo);

            //check the StaffNo
            if (aStaff.StaffSurname != "Khalid")
            {
                OK = false;
            }

            //test to see that the two values are the same
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStaffEmailFound()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();

            //create a Boolean variable to store the result of the search
            Boolean Found = false;

            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;

            //create some test data to use with the method
            Int32 StaffNo = 21;

            //invoke the method
            Found = aStaff.Find(StaffNo);

            //check the StaffNo
            if (aStaff.StaffEmail != "AfnanKhalid@gmail.com")
            {
                OK = false;
            }

            //test to see that the two values are the same
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStaffPasswordFound()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();

            //create a Boolean variable to store the result of the search
            Boolean Found = false;

            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;

            //create some test data to use with the method
            Int32 StaffNo = 21;

            //invoke the method
            Found = aStaff.Find(StaffNo);

            //check the StaffNo
            if (aStaff.StaffPassword != "Afnan123")
            {
                OK = false;
            }

            //test to see that the two values are the same
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDateJoinedFound()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();

            //create a Boolean variable to store the result of the search
            Boolean Found = false;

            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;

            //create some test data to use with the method
            Int32 StaffNo = 21;

            //invoke the method
            Found = aStaff.Find(StaffNo);

            //check the StaffNo
            if (aStaff.DateJoined != Convert.ToDateTime("23/12/2022"))
            {
                OK = false;
            }

            //test to see that the two values are the same
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestIsOnShiftFound()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();

            //create a Boolean variable to store the result of the search
            Boolean Found = false;

            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;

            //create some test data to use with the method
            Int32 StaffNo = 21;

            //invoke the method
            Found = aStaff.Find(StaffNo);

            //check the StaffNo
            if (aStaff.IsOnShift != true)
            {
                OK = false;
            }

            //test to see that the two values are the same
            Assert.IsTrue(OK);
        }
    }
}
