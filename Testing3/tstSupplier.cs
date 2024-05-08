using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

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
        public void ActivePropertyOK()
        {
            clsSupplier ASupplier = new clsSupplier();

            Boolean TestData = true;

            ASupplier.Active = TestData;

            Assert.AreEqual(ASupplier.Active, TestData);


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
        public void DeliverydatePropertyOK()
        {
            //create an instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();

            //create test data to assign to the property
            DateTime TestData = DateTime.Now.Date;

            //assign the data to the property
            ASupplier.Deliverydate = TestData;

            //test to see that the 2 values are the same
            Assert.AreEqual(ASupplier.Deliverydate, TestData);
        }

        [TestMethod]
        public void SupplierIdPropertyOK()
        {
            //create an instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            ASupplier.SupplierID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ASupplier.SupplierID, TestData);
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




    }

}



