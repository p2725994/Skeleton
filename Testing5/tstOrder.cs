using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing5
{
    [TestClass]
    public class tstOrder
    {
        [TestMethod]
        public void InstaneOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //test to see that it exists
            Assert.IsNotNull(AnOrder);
        }

        [TestMethod]
        public void OrderIdPropertyOK()
        {
            //create an instance of the calss we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            int TestData = 1;
            //assign the data to the property
            AnOrder.OrderId = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.OrderId, TestData);
        }

            [TestMethod]
        public void OrderTotalPropertyOK()
        {
            //create an instance of the calss we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            int TestData = 32;
            //assign the data to the property
            AnOrder.OrderTotal = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.OrderTotal, TestData);
        }

        [TestMethod]
        public void DatePlacedPropertyOK()
        {
            //create an instance of the calss we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AnOrder.DatePlaced = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.DatePlaced, TestData);
        }

        [TestMethod]
        public void PurchasedPropertyOK()
        {
            //create an instance of the calss we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            AnOrder.Purchased = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.Purchased, TestData);
        }

        [TestMethod]
        public void DeliveryAddressPropertyOK()
        {
            //create an instance of the calss we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            String TestData = "123 test street, B12 3FG";
            //assign the data to the property
            AnOrder.DeliveryAddress = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.DeliveryAddress, TestData);
        }

        [TestMethod]
        public void NoOfItemsPropertyOK()
        {
            //create an instance of the calss we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            int TestData = 5;
            //assign the data to the property
            AnOrder.NoOfItems = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.NoOfItems, TestData);
        }

        [TestMethod]
        public void IsGiftPropertyOK()
        {
            //create an instance of the calss we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            AnOrder.IsGift = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.IsGift, TestData);
        }
    }
}
