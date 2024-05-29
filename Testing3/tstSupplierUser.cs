using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing3
{
    [TestClass]
    public class tstSupplierUser
    {
        [TestMethod]
        public void IntanceOK()
        {
            //create an instance of the class we want to create
            clsSupplierUser AnUser = new clsSupplierUser();
            //test to see that it exists
            Assert.IsNotNull(AnUser);
        }



        [TestMethod]
        public void UserIDPropertyOK()
        {
            //create an instance of the class we want to create
            clsSupplierUser AnUser = new clsSupplierUser();

            //create some test data to assign to the property
            Int32 TestData = 5;

            //assing the data to the property
            AnUser.UserID = TestData;

            //test to see that it exists
            Assert.AreEqual(AnUser.UserID, TestData);
        }

        [TestMethod]
        public void UserNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsSupplierUser AnUser = new clsSupplierUser();

            //create some test data to assign to the property
            string TestData = "Pranavh";

            //assing the data to the property
            AnUser.UserName = TestData;

            //test to see that it exists
            Assert.AreEqual(AnUser.UserName, TestData);
        }

        [TestMethod]
        public void PasswordPropertyOK()
        {
            //create an instance of the class we want to create
            clsSupplierUser AnUser = new clsSupplierUser();

            //create some test data to assign to the property
            string TestData = "Pranavh123";

            //assing the data to the property
            AnUser.Password = TestData;

            //test to see that it exists
            Assert.AreEqual(AnUser.Password, TestData);
        }

        [TestMethod]
        public void DepartmentPropertyOK()
        {
            //create an instance of the class we want to create
            clsSupplierUser AnUser = new clsSupplierUser();

            //create some test data to assign to the property
            string TestData = "Supplier";

            //assing the data to the property
            AnUser.Department = TestData;

            //test to see that it exists
            Assert.AreEqual(AnUser.Department, TestData);


        }
        [TestMethod]
        public void FindUserMethodOK()
        {
            //create an instance of the class we want to create 
            clsSupplierUser AnUser = new clsSupplierUser();
            //create a Boolean variable to store the results of the validation 
            Boolean Found = false;
            //create some test data to use with the method 
            string UserName = "Pranavh";
            string Password = "Pranavh123";
            //invoke the method 
            Found = AnUser.FindUser(UserName, Password);
            //test to see if the results is true
            Assert.IsTrue(Found);  


        }
        [TestMethod]
        public void TestUserNamePWFound()
        {

            //create an instance of the class we want to create 
            clsSupplierUser AnUser = new clsSupplierUser();
            Boolean Found = false;
            Boolean OK = true;

            string UserName = "Pranavh";
            string Password = "Pranavh123";

            //invoke the method 
            Found = AnUser.FindUser(UserName, Password);
            if (AnUser.UserName != UserName && AnUser.Password != Password)
            { OK = false; }
            Assert.IsTrue(OK);
        
        }
    }
}
