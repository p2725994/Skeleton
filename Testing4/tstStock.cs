using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing4
{
    [TestClass]
    public class tstStock
    {
        public bool True { get; private set; }

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
            clsStocks.Product_Expiry = TestData;
            //verify that the birthdate porperty was set correctly
            Assert.AreEqual(clsStocks.Product_Expiry, TestData);
        }


        [TestMethod]
        public void Product_DescriptionPropertyOK()
        {
            //create an instance of the class we want to create
            clsStocks aStock = new clsStocks();
            //create some test data to assign to the property
            String TestData = "cherryflavour";
            //assign the data to the property
            clsStocks.Product_Description = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(clsStocks.Product_Description, TestData);
        }


        [TestMethod]
        public void Product_NamePropertyOK()
        {
            //create an instance of the class we want to create
            clsStocks aStock = new clsStocks();
            //create some test data to assign to the property
            String TestData = "R+asap";
            //assign the data to the property
            clsStocks.Product_Name = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(clsStocks.Product_Name, TestData);
        }


        [TestMethod]
        public void Product_QuantityPropertyOK()
        {
            //create an instance of the class we want to create
            clsStocks aStock = new clsStocks();
            //create some test data to assign to the property
            String TestData = "350ml";
            //assign the data to the property
            clsStocks.Product_Quantity = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(clsStocks.Product_Quantity, TestData);
        }

        [TestMethod]
        public void Product_PricePropertyOK()
        {
            //create an instance of the class we want to create

            clsStocks aStock = new clsStocks();
            //create some test data to assign to the property
            Double TestData = 2;
            //assign the data to the property
            clsStocks.Product_Price =TestData;
            //test to see that the two values are the same
            Assert.AreEqual(clsStocks.Product_Price, TestData);
        }

        [TestMethod]
        public void Product_IdPropertyOK()
        {
            //create an instance of the class we want to create
            clsStocks aStock = new clsStocks();
            //create some test data to assign to the property
            int TestData = 1;
            //assign the data to the property
            clsStocks.Product_Id = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(clsStocks.Product_Id, TestData);
        }
        [TestMethod]
        public void AvailablePropertyOK()
        {
            //create an instance of the class we want to create
            clsStocks aStock = new clsStocks();
            //create some test data to assign to the property
            Boolean TestData = True;
            //assign the data to the property
            clsStocks.Available = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(clsStocks.Available, TestData);
        }
    }
}

