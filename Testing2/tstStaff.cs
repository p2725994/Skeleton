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
        public void StaffFirstNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();
            //create some test data to assign to the property
            string TestData = "Afnan";
            //assign the data to the property
            aStaff.StaffFirstName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(aStaff.StaffFirstName, TestData);
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


    }
}
