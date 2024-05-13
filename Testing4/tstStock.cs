using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing4
{
    [TestClass]
    public class tstStock
    {
        //good test data
        //create some test data to pass method
        string Product_Name = "Rockstar";
        string Product_Description = "An energizing kick of caffeine";
        string Product_Quantity = "25";
        string Product_Price = "2.99";
        string Product_Expiry = DateTime.Now.ToShortDateString();

        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsStocks aStock = new clsStocks();

            //test to see that it exists.
            Assert.IsNotNull(aStock);
        }

        [TestMethod]
        public void Product_ExpiryPropertOK()
        {
            //crete an instance of the class we want to create
            clsStocks aStock = new clsStocks();
            //create some test data to assign the property
            DateTime TestData = DateTime.Now.Date;
            //set the Birthdate property with the test data
            aStock.Product_Expiry = TestData;
            //verify that the birthdate porperty was set correctly
            Assert.AreEqual(aStock.Product_Expiry, TestData);
        }


        [TestMethod]
        public void Product_DescriptionPropertyOK()
        {
            //create an instance of the class we want to create
            clsStocks aStock = new clsStocks();
            //create some test data to assign to the property
            String TestData = "cherryflavour";
            //assign the data to the property
            aStock.Product_Description = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(aStock.Product_Description, TestData);
        }


        [TestMethod]
        public void Product_NamePropertyOK()
        {
            //create an instance of the class we want to create
            clsStocks aStock = new clsStocks();
            //create some test data to assign to the property
            String TestData = "R+asap";
            //assign the data to the property
            aStock.Product_Name = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(aStock.Product_Name, TestData);
        }


        [TestMethod]
        public void Product_QuantityPropertyOK()
        {
            //create an instance of the class we want to create
            clsStocks aStock = new clsStocks();
            //create some test data to assign to the property
            Int32 TestData = 25;
            //assign the data to the property
            aStock.Product_Quantity = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(aStock.Product_Quantity, TestData);
        }

        [TestMethod]
        public void Product_PricePropertyOK()
        {
            //create an instance of the class we want to create

            clsStocks aStock = new clsStocks();
            //create some test data to assign to the property
            Double TestData = 2;
            //assign the data to the property
            aStock.Product_Price = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(aStock.Product_Price, TestData);
        }

        [TestMethod]
        public void Product_IdPropertyOK()
        {
            //create an instance of the class we want to create
            clsStocks aStock = new clsStocks();
            //create some test data to assign to the property
            int TestData = 1;
            //assign the data to the property
            aStock.Product_Id = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(aStock.Product_Id, TestData);
        }

        [TestMethod]
        public void AvailablePropertyOK()
        {
            //create an instance of the class we want to create
            clsStocks aStock = new clsStocks();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            aStock.Available = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(aStock.Available, TestData);
        }

        /******************FIND METHOD TEST******************/

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsStocks aStock = new clsStocks();
            //create a Boolean variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 Product_Id = 1;
            //invoke the method
            Found = aStock.Find(Product_Id);
            //test to see that the two values are the same
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestProductIdFound()
        {
            //create an instance of the class we want to create
            clsStocks aStock = new clsStocks();

            //create a Boolean variable to store the result of the search
            Boolean Found = false;

            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;

            //create some test data to use with the method
            Int32 Product_Id = 1;

            //invoke the method
            Found = aStock.Find(Product_Id);

            //check the StaffNo
            if (aStock.Product_Id != 1)
            {
                OK = false;
            }

            //test to see that the two values are the same
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestProductNameFound()
        {
            //create an instance of the class we want to create
            clsStocks aStock = new clsStocks();

            //create a Boolean variable to store the result of the search
            Boolean Found = false;

            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;

            //create some test data to use with the method
            Int32 Product_Id = 1;

            //invoke the method
            Found = aStock.Find(Product_Id);

            //check the StaffNo
            if (aStock.Product_Name != "R+sap strawberry")
            {
                OK = false;
            }

            //test to see that the two values are the same
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestProductDescriptionFound()
        {
            //create an instance of the class we want to create
            clsStocks aStock = new clsStocks();

            //create a Boolean variable to store the result of the search
            Boolean Found = false;

            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;

            //create some test data to use with the method
            Int32 Product_Id = 1;

            //invoke the method
            Found = aStock.Find(Product_Id);

            //check the StaffNo
            if (aStock.Product_Description != "strawberry flavour")
            {
                OK = false;
            }

            //test to see that the two values are the same
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestProductQuantityFound()
        {
            //create an instance of the class we want to create
            clsStocks aStock = new clsStocks();

            //create a Boolean variable to store the result of the search
            Boolean Found = false;

            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;

            //create some test data to use with the method
            Int32 Product_Id = 1;

            //invoke the method
            Found = aStock.Find(Product_Id);

            //check the StaffNo
            if (aStock.Product_Quantity != 2345)
            {
                OK = false;
            }

            //test to see that the two values are the same
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestProductPriceFound()
        {
            //create an instance of the class we want to create
            clsStocks aStock = new clsStocks();

            //create a Boolean variable to store the result of the search
            Boolean Found = false;

            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;

            //create some test data to use with the method
            Int32 Product_Id = 1;

            //invoke the method
            Found = aStock.Find(Product_Id);

            //check the StaffNo
            if (aStock.Product_Price != 2)
            {
                OK = false;
            }

            //test to see that the two values are the same
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestProductExpiryFound()
        {
            //create an instance of the class we want to create
            clsStocks aStock = new clsStocks();

            //create a Boolean variable to store the result of the search
            Boolean Found = false;

            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;

            //create some test data to use with the method
            Int32 Product_Id = 1;

            //invoke the method
            Found = aStock.Find(Product_Id);

            //check the StaffNo
            if (aStock.Product_Expiry != Convert.ToDateTime("01/12/2026"))
            {
                OK = false;
            }

            //test to see that the two values are the same
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestAvailableFound()
        {
            //create an instance of the class we want to create
            clsStocks aStock = new clsStocks();

            //create a Boolean variable to store the result of the search
            Boolean Found = false;

            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;

            //create some test data to use with the method
            Int32 Product_Id = 1;

            //invoke the method
            Found = aStock.Find(Product_Id);

            //check the StaffNo
            if (aStock.Available != true)
            {
                OK = false;
            }

            //test to see that the two values are the same
            Assert.IsTrue(OK);
        }
    }
}
