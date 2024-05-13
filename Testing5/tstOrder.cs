using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing5
{
    [TestClass]
    public class tstOrder
    {
        [TestMethod]
        public void InstanceOK()
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
            float TestData = 31.99f;
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

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create a Boolean variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 OrderId = 21;
            //invoke the method
            Found = AnOrder.Find(OrderId);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestOrderIdFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create a Boolean variable to store the results of the validation
            Boolean Found = false;
            //create a boolean variable to record if the data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderId = 21;
            //invoke the method
            Found = AnOrder.Find(OrderId);
            //check the order id
            if (AnOrder.OrderId != 21)
            {
                OK = false;
            }
            //test to see if the result is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestOrderTotalFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create a Boolean variable to store the results of the validation
            Boolean Found = false;
            //create a boolean variable to record if the data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderId = 21;
            //invoke the method
            Found = AnOrder.Find(OrderId);
            //check the order id
            if (AnOrder.OrderTotal != 34.99f)
            {
                OK = false;
            }
            //test to see if the result is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDatePlacedFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create a Boolean variable to store the results of the validation
            Boolean Found = false;
            //create a boolean variable to record if the data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderId = 21;
            //invoke the method
            Found = AnOrder.Find(OrderId);
            //check the order id
            if (AnOrder.DatePlaced != Convert.ToDateTime("01/01/2024"))
            {
                OK = false;
            }
            //test to see if the result is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPurchasedFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create a Boolean variable to store the results of the validation
            Boolean Found = false;
            //create a boolean variable to record if the data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderId = 21;
            //invoke the method
            Found = AnOrder.Find(OrderId);
            //check the order id
            if (AnOrder.Purchased != true)
            {
                OK = false;
            }
            //test to see if the result is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDeliveryAddressFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create a Boolean variable to store the results of the validation
            Boolean Found = false;
            //create a boolean variable to record if the data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderId = 21;
            //invoke the method
            Found = AnOrder.Find(OrderId);
            //check the order id
            if (AnOrder.DeliveryAddress != "Test Address")
            {
                OK = false;
            }
            //test to see if the result is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestNoOfItemsFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create a Boolean variable to store the results of the validation
            Boolean Found = false;
            //create a boolean variable to record if the data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderId = 21;
            //invoke the method
            Found = AnOrder.Find(OrderId);
            //check the order id
            if (AnOrder.NoOfItems != 5)
            {
                OK = false;
            }
            //test to see if the result is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestIsGiftFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create a Boolean variable to store the results of the validation
            Boolean Found = false;
            //create a boolean variable to record if the data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderId = 21;
            //invoke the method
            Found = AnOrder.Find(OrderId);
            //check the order id
            if (AnOrder.IsGift != true)
            {
                OK = false;
            }
            //test to see if the result is true
            Assert.IsTrue(OK);
        }
    }
}
