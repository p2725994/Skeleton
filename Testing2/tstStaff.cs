using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing2
{
    [TestClass]
    public class tstStaff
    {
        //good test data
        //create some test data to pass method
        string StaffFirstname = "Afnan";
        string StaffSurname = "Khalid";
        string StaffEmail = "AfnanKhalid@gmail.com";
        string StaffPassword = "Afnan123";
        string DateJoined = DateTime.Now.ToShortDateString();


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
            Int32 StaffNo = 1;
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
            Int32 StaffNo = 1;

            //invoke the method
            Found = aStaff.Find(StaffNo);

            //check the StaffNo
            if (aStaff.StaffNo != 1)
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
            Int32 StaffNo = 1;

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
            Int32 StaffNo = 1;

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
            Int32 StaffNo = 1;

            //invoke the method
            Found = aStaff.Find(StaffNo);

            //check the StaffNo
            if (aStaff.StaffEmail != "afnankhalid@gmail.com")
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
            Int32 StaffNo = 1;

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
            Int32 StaffNo = 1;

            //invoke the method
            Found = aStaff.Find(StaffNo);

            //check the StaffNo
            if (aStaff.DateJoined != Convert.ToDateTime("01/01/2011"))
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
            Int32 StaffNo = 1;

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

        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();

            //string variable to store any error messsage
            String Error = "";

            //invoke method
            Error = aStaff.Valid(StaffFirstname, StaffSurname, StaffEmail, StaffPassword, DateJoined);

            //test to see that the result is true
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void StaffFirstnameMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();

            //string variable to store any error messsage
            String Error = "";

            //create some test data to pass the method
            string StaffFirstname = "";

            //invoke method
            Error = aStaff.Valid(StaffFirstname, StaffSurname, StaffEmail, StaffPassword, DateJoined);

            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void StaffFirstnameMin()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();

            //string variable to store any error messsage
            String Error = "";

            //create some test data to pass the method
            string StaffFirstname = "A";

            //invoke method
            Error = aStaff.Valid(StaffFirstname, StaffSurname, StaffEmail, StaffPassword, DateJoined);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void StaffFirstnameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();

            //string variable to store any error messsage
            String Error = "";

            //create some test data to pass the method
            string StaffFirstname = "Af";

            //invoke method
            Error = aStaff.Valid(StaffFirstname, StaffSurname, StaffEmail, StaffPassword, DateJoined);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void StaffFirstnameMid()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();

            //string variable to store any error messsage
            String Error = "";

            //create some test data to pass the method
            string StaffFirstname = "AfnanAfnanAfnan";

            //invoke method
            Error = aStaff.Valid(StaffFirstname, StaffSurname, StaffEmail, StaffPassword, DateJoined);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void StaffFirstnameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();

            //string variable to store any error messsage
            String Error = "";

            //create some test data to pass the method
            string StaffFirstname = "Afnanafnanafnanafnanafnanafna";

            //invoke method
            Error = aStaff.Valid(StaffFirstname, StaffSurname, StaffEmail, StaffPassword, DateJoined);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void StaffFirstnameMax()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();

            //string variable to store any error messsage
            String Error = "";

            //create some test data to pass the method
            string StaffFirstname = "AfnanAfnanAfnanAfnanAfnanAfnan";

            //invoke method
            Error = aStaff.Valid(StaffFirstname, StaffSurname, StaffEmail, StaffPassword, DateJoined);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void StaffFirstnameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();

            //string variable to store any error messsage
            String Error = "";

            //create some test data to pass the method
            string StaffFirstname = "AfnanAfnanAfnanAfnanAfnanAfnanA";

            //invoke method
            Error = aStaff.Valid(StaffFirstname, StaffSurname, StaffEmail, StaffPassword, DateJoined);

            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void StaffFirstnameExtremeMax()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();

            //string variable to store any error messsage
            String Error = "";

            //create some test data to pass the method
            string StaffFirstname = "";
            StaffFirstname = StaffFirstname.PadRight(500, 'a');
            //invoke method
            Error = aStaff.Valid(StaffFirstname, StaffSurname, StaffEmail, StaffPassword, DateJoined);

            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void StaffSurnameMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();

            //string variable to store any error messsage
            String Error = "";

            //create some test data to pass the method
            string StaffSurname = "";

            //invoke method
            Error = aStaff.Valid(StaffFirstname, StaffSurname, StaffEmail, StaffPassword, DateJoined);

            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void StaffSurnameMin()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();

            //string variable to store any error messsage
            String Error = "";

            //create some test data to pass the method
            string StaffSurname = "A";

            //invoke method
            Error = aStaff.Valid(StaffFirstname, StaffSurname, StaffEmail, StaffPassword, DateJoined);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void StaffSurnameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();

            //string variable to store any error messsage
            String Error = "";

            //create some test data to pass the method
            string StaffSurname = "Af";

            //invoke method
            Error = aStaff.Valid(StaffFirstname, StaffSurname, StaffEmail, StaffPassword, DateJoined);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void StaffSurnameMid()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();

            //string variable to store any error messsage
            String Error = "";

            //create some test data to pass the method
            string StaffSurname = "AfnanAfnan";

            //invoke method
            Error = aStaff.Valid(StaffFirstname, StaffSurname, StaffEmail, StaffPassword, DateJoined);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void StaffSurnameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();

            //string variable to store any error messsage
            String Error = "";

            //create some test data to pass the method
            string StaffSurname = "AfnanAfnanAfnanAfna";

            //invoke method
            Error = aStaff.Valid(StaffFirstname, StaffSurname, StaffEmail, StaffPassword, DateJoined);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void StaffSurnameMax()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();

            //string variable to store any error messsage
            String Error = "";

            //create some test data to pass the method
            string StaffSurname = "AfnanAfnanAfnanAfnan";

            //invoke method
            Error = aStaff.Valid(StaffFirstname, StaffSurname, StaffEmail, StaffPassword, DateJoined);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void StaffSurnameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();

            //string variable to store any error messsage
            String Error = "";

            //create some test data to pass the method
            string StaffSurname = "AfnanAfnanAfnanAfnanA";

            //invoke method
            Error = aStaff.Valid(StaffFirstname, StaffSurname, StaffEmail, StaffPassword, DateJoined);

            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void StaffSurnameExtremeMax()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();

            //string variable to store any error messsage
            String Error = "";

            //create some test data to pass the method
            string StaffSurname = "";
            StaffSurname = StaffSurname.PadRight(400, 'a');
            //invoke method
            Error = aStaff.Valid(StaffFirstname, StaffSurname, StaffEmail, StaffPassword, DateJoined);

            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void StaffEmailMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();

            //string variable to store any error messsage
            String Error = "";

            //create some test data to pass the method
            string StaffEmail = "";

            //invoke method
            Error = aStaff.Valid(StaffFirstname, StaffSurname, StaffEmail, StaffPassword, DateJoined);

            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void StaffEmailMin()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();

            //string variable to store any error messsage
            String Error = "";

            //create some test data to pass the method
            string StaffEmail = "A";

            //invoke method
            Error = aStaff.Valid(StaffFirstname, StaffSurname, StaffEmail, StaffPassword, DateJoined);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void StaffEmailMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();

            //string variable to store any error messsage
            String Error = "";

            //create some test data to pass the method
            string StaffEmail = "Af";

            //invoke method
            Error = aStaff.Valid(StaffFirstname, StaffSurname, StaffEmail, StaffPassword, DateJoined);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void StaffEmailMid()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();

            //string variable to store any error messsage
            String Error = "";

            //create some test data to pass the method
            string StaffEmail = "";
            StaffEmail = StaffEmail.PadRight(25, 'a');

            //invoke method
            Error = aStaff.Valid(StaffFirstname, StaffSurname, StaffEmail, StaffPassword, DateJoined);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void StaffEmailMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();

            //string variable to store any error messsage
            String Error = "";

            //create some test data to pass the method
            string StaffEmail = "";
            StaffEmail = StaffEmail.PadRight(49, 'a');

            //invoke method
            Error = aStaff.Valid(StaffFirstname, StaffSurname, StaffEmail, StaffPassword, DateJoined);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void StaffEmailMax()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();

            //string variable to store any error messsage
            String Error = "";

            //create some test data to pass the method
            string StaffEmail = "";
            StaffEmail = StaffEmail.PadRight(50, 'a');

            //invoke method
            Error = aStaff.Valid(StaffFirstname, StaffSurname, StaffEmail, StaffPassword, DateJoined);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void StaffEmailMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();

            //string variable to store any error messsage
            String Error = "";

            //create some test data to pass the method
            string StaffEmail = "";
            StaffEmail = StaffEmail.PadRight(51, 'a');

            //invoke method
            Error = aStaff.Valid(StaffFirstname, StaffSurname, StaffEmail, StaffPassword, DateJoined);

            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void StaffEmailExtremeMax()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();

            //string variable to store any error messsage
            String Error = "";

            //create some test data to pass the method
            string StaffEmail = "";
            StaffEmail = StaffEmail.PadRight(300, 'a');
            //invoke method
            Error = aStaff.Valid(StaffFirstname, StaffSurname, StaffEmail, StaffPassword, DateJoined);

            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void StaffPasswordMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();

            //string variable to store any error messsage
            String Error = "";

            //create some test data to pass the method
            string StaffPassword = "";

            //invoke method
            Error = aStaff.Valid(StaffFirstname, StaffSurname, StaffEmail, StaffPassword, DateJoined);

            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void StaffPasswordMin()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();

            //string variable to store any error messsage
            String Error = "";

            //create some test data to pass the method
            string StaffPassword = "A";

            //invoke method
            Error = aStaff.Valid(StaffFirstname, StaffSurname, StaffEmail, StaffPassword, DateJoined);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void StaffPasswordMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();

            //string variable to store any error messsage
            String Error = "";

            //create some test data to pass the method
            string StaffPassword = "Af";

            //invoke method
            Error = aStaff.Valid(StaffFirstname, StaffSurname, StaffEmail, StaffPassword, DateJoined);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void StaffPasswordMid()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();

            //string variable to store any error messsage
            String Error = "";

            //create some test data to pass the method
            string StaffPassword = "";
            StaffPassword = StaffPassword.PadRight(8, 'a');

            //invoke method
            Error = aStaff.Valid(StaffFirstname, StaffSurname, StaffEmail, StaffPassword, DateJoined);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void StaffPasswordMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();

            //string variable to store any error messsage
            String Error = "";

            //create some test data to pass the method
            string StaffPassword = "";
            StaffPassword = StaffPassword.PadRight(15, 'a');

            //invoke method
            Error = aStaff.Valid(StaffFirstname, StaffSurname, StaffEmail, StaffPassword, DateJoined);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void StaffPasswordMax()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();

            //string variable to store any error messsage
            String Error = "";

            //create some test data to pass the method
            string StaffPassword = "AfnanKhalid12345";

            //invoke method
            Error = aStaff.Valid(StaffFirstname, StaffSurname, StaffEmail, StaffPassword, DateJoined);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void StaffPasswordMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();

            //string variable to store any error messsage
            String Error = "";

            //create some test data to pass the method
            string StaffPassword = "";
            StaffPassword = StaffPassword.PadRight(17, 'a');

            //invoke method
            Error = aStaff.Valid(StaffFirstname, StaffSurname, StaffEmail, StaffPassword, DateJoined);

            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void StaffPasswordExtremeMax()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();

            //string variable to store any error messsage
            String Error = "";

            //create some test data to pass the method
            string StaffPassword = "";
            StaffPassword = StaffPassword.PadRight(100, 'a');
            //invoke method
            Error = aStaff.Valid(StaffFirstname, StaffSurname, StaffEmail, StaffPassword, DateJoined);

            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void DateJoinedExtremeMin()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();

            //string variable to store any error messsage
            String Error = "";

            //create a variable to store the test date data
            DateTime TestDate;

            //set date to today
            TestDate = DateTime.Now.Date;

            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(-100);

            //convert the date variable to a string variable
            string DateJoined = TestDate.ToString();

            //invoke method
            Error = aStaff.Valid(StaffFirstname, StaffSurname, StaffEmail, StaffPassword, DateJoined);

            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void DateJoinedMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();

            //string variable to store any error messsage
            String Error = "";

            //create a variable to store the test date data
            DateTime TestDate;

            //set date to today
            TestDate = DateTime.Now.Date;

            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddDays(-1);

            //convert the date variable to a string variable
            string DateJoined = TestDate.ToString();

            //invoke method
            Error = aStaff.Valid(StaffFirstname, StaffSurname, StaffEmail, StaffPassword, DateJoined);

            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void DateJoinedMin()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();

            //string variable to store any error messsage
            String Error = "";

            //create a variable to store the test date data
            DateTime TestDate;

            //set date to today
            TestDate = DateTime.Now.Date;

            //convert the date variable to a string variable
            string DateJoined = TestDate.ToString();

            //invoke method
            Error = aStaff.Valid(StaffFirstname, StaffSurname, StaffEmail, StaffPassword, DateJoined);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void DateJoinedMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();

            //string variable to store any error messsage
            String Error = "";

            //create a variable to store the test date data
            DateTime TestDate;

            //set date to today
            TestDate = DateTime.Now.Date;

            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddDays(1);

            //convert the date variable to a string variable
            string DateJoined = TestDate.ToString();

            //invoke method
            Error = aStaff.Valid(StaffFirstname, StaffSurname, StaffEmail, StaffPassword, DateJoined);

            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void DateJoinedExtremeMax()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();

            //string variable to store any error messsage
            String Error = "";

            //create a variable to store the test date data
            DateTime TestDate;

            //set date to today
            TestDate = DateTime.Now.Date;

            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(100);

            //convert the date variable to a string variable
            string DateJoined = TestDate.ToString();

            //invoke method
            Error = aStaff.Valid(StaffFirstname, StaffSurname, StaffEmail, StaffPassword, DateJoined);

            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void DateJoinedInvalidData()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();

            //string variable to store any error messsage
            String Error = "";

            //convert the date variable to a string variable
            string DateJoined = "This is not a Date!";

            //invoke method
            Error = aStaff.Valid(StaffFirstname, StaffSurname, StaffEmail, StaffPassword, DateJoined);

            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }
    }
}
