using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing2
{
    [TestClass]
    public class tstStaffUser
    {
        [TestMethod]
        public void TestMethod1()
        {
            //create an instance of the class we want to create
            clsStaffuser AnUser = new clsStaffuser();

            //test to see that it exists
            Assert.IsNotNull(AnUser);
        }

        [TestMethod]
        public void UserIDPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaffuser AnUser = new clsStaffuser();

            //create some test data to assign to the property
            Int32 TestData = 1;

            //assing the data to the property
            AnUser.UserID = TestData;

            //test to see that it exists
            Assert.IsNotNull(AnUser);
        }

        [TestMethod]
        public void UserNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsStaffuser AnUser = new clsStaffuser();

            //create some test data to assign to the property
            string TestData = "Afnan";

            //assing the data to the property
            AnUser.UserName = TestData;

            //test to see that it exists
            Assert.AreEqual(AnUser.UserName, TestData);
        }

        [TestMethod]
        public void PasswordPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaffuser AnUser = new clsStaffuser();

            //create some test data to assign to the property
            string TestData = "Afnan123";

            //assing the data to the property
            AnUser.Password = TestData;

            //test to see that it exists
            Assert.AreEqual(AnUser.Password, TestData);
        }

        [TestMethod]
        public void DepartmentPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaffuser AnUser = new clsStaffuser();

            //create some test data to assign to the property
            string TestData = "Staff";

            //assing the data to the property
            AnUser.Department = TestData;

            //test to see that it exists
            Assert.AreEqual(AnUser.Department, TestData);
        }

        [TestMethod]
        public void FindUserMethodOK()
        {
            //create an instance of the class we want to create
            clsStaffuser AnUser = new clsStaffuser();

            //create a Boolean variable to store the results of the validation
            Boolean Found = false;

            //create some test data to use with the method
            string UserName = "Afnan";
            string Password = "Afnan123";

            //invoke the method
            Found = AnUser.FindUser(UserName, Password);

            //test to see that the result is true
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestUserNamePWFound()
        {
            //create an instance of the class we want to create
            clsStaffuser AnUser = new clsStaffuser();

            //create a Boolean variable to store the results of the search
            Boolean Found = false;

            //create a Boolean variable to record the data is ok (assume it is)
            Boolean OK = true;

            //create some test data to use with the method
            string UserName = "Afnan";
            string Password = "Afnan123";

            //invoke the method
            Found = AnUser.FindUser(UserName, Password);

            //check the user id property
            if (AnUser.UserName != UserName && AnUser.Password != Password)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
    }
}
