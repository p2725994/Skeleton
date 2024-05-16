using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing5
{
    [TestClass]
    public class tstOrder
    {
        //============= GOOD TEST DATA =====================

        //create some test data to pass the method
        string DatePlaced = DateTime.Now.ToShortDateString();
        string DeliveryAddress = "123 test street, B12 3NG";
        string OrderTotal = "19.99";

        //============= ORDER OBJECT TESTING ===============

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
            decimal TestData = 31.99m;
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

        //=============== FIND METHOD TESTING ==============
        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create a Boolean variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 OrderId = 6;
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
            Int32 OrderId = 6;
            //invoke the method
            Found = AnOrder.Find(OrderId);
            //check the order id
            if (AnOrder.OrderId != 6)
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
            Int32 OrderId = 6;
            //invoke the method
            Found = AnOrder.Find(OrderId);
            //check the order id
            if (AnOrder.OrderTotal != 39.95m)
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
            Int32 OrderId = 6;
            //invoke the method
            Found = AnOrder.Find(OrderId);
            //check the order id
            if (AnOrder.DatePlaced != Convert.ToDateTime("29/04/2024"))
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
            Int32 OrderId = 6;
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
            Int32 OrderId = 6;
            //invoke the method
            Found = AnOrder.Find(OrderId);
            //check the order id
            if (AnOrder.DeliveryAddress != "42 Old Lane, N51 6LN")
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
            Int32 OrderId = 6;
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
            Int32 OrderId = 6;
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

        //============== VALIDATION TESTING =====================

        [TestMethod]
        public void ValidMethodOK()
        {
            //create an insatnce of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            string Error = "";
            //invoke the method
            Error = AnOrder.Valid(DatePlaced, DeliveryAddress, OrderTotal);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        //============= DELIVERY ADDRESS VALIDATION TESTING ===============

        [TestMethod]
        public void DeliveryAddressMinLessOne()
        {
            //create an insatnce of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string DeliveryAddress = ""; //this should trigger an error
            //invoke the method
            Error = AnOrder.Valid(DatePlaced, DeliveryAddress, OrderTotal);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DeliveryAddressMin()
        {
            //create an insatnce of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string DeliveryAddress = "a"; //this should be ok
            //invoke the method
            Error = AnOrder.Valid(DatePlaced, DeliveryAddress, OrderTotal);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DeliveryAddressMinPlusOne()
        {
            //create an insatnce of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string DeliveryAddress = "aa"; //this should be ok
            //invoke the method
            Error = AnOrder.Valid(DatePlaced, DeliveryAddress, OrderTotal);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DeliveryAddressMaxLessOne()
        {
            //create an insatnce of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string DeliveryAddress = "";
            DeliveryAddress = DeliveryAddress.PadRight(49, 'a'); //this should be ok
            //invoke the method
            Error = AnOrder.Valid(DatePlaced, DeliveryAddress, OrderTotal);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DeliveryAddressMax()
        {
            //create an insatnce of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string DeliveryAddress = "";
            DeliveryAddress = DeliveryAddress.PadRight(50, 'a'); //this should be ok
            //invoke the method
            Error = AnOrder.Valid(DatePlaced, DeliveryAddress, OrderTotal);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DeliveryAddressMaxPlusOne()
        {
            //create an insatnce of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string DeliveryAddress = "";
            DeliveryAddress = DeliveryAddress.PadRight(51, 'a'); //this should trigger an error
            //invoke the method
            Error = AnOrder.Valid(DatePlaced, DeliveryAddress, OrderTotal);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DeliveryAddressMid()
        {
            //create an insatnce of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string DeliveryAddress = "";
            DeliveryAddress = DeliveryAddress.PadRight(25, 'a'); //this should be ok
            //invoke the method
            Error = AnOrder.Valid(DatePlaced, DeliveryAddress, OrderTotal);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DeliveryAddressExtremeMax()
        {
            //create an insatnce of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string DeliveryAddress = "";
            DeliveryAddress = DeliveryAddress.PadRight(500, 'a'); //this should trigger an error
            //invoke the method
            Error = AnOrder.Valid(DatePlaced, DeliveryAddress, OrderTotal);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        //================== DATE PLACED VALIDATION TESTING ==============

        [TestMethod]
        public void DatePlacedExtremeMin()
        {
            //create an insatnce of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            string Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to today's date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is -100 years
            TestDate = TestDate.AddYears(-100);
            //convert the date variable to a string variable
            string DatePlaced = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(DatePlaced, DeliveryAddress, OrderTotal);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DatePlacedMinLessOne()
        {
            //create an insatnce of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            string Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to today's date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is -1 day
            TestDate = TestDate.AddDays(-1);
            //convert the date variable to a string variable
            string DatePlaced = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(DatePlaced, DeliveryAddress, OrderTotal);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DatePlacedMin()
        {
            //create an insatnce of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            string Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to today's date
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable
            string DatePlaced = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(DatePlaced, DeliveryAddress, OrderTotal);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DatePlacedMinPlusOne()
        {
            //create an insatnce of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            string Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to today's date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is -1 day
            TestDate = TestDate.AddDays(1);
            //convert the date variable to a string variable
            string DatePlaced = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(DatePlaced, DeliveryAddress, OrderTotal);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DatePlacedExtremeMax()
        {
            //create an insatnce of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            string Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to today's date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is -1 day
            TestDate = TestDate.AddYears(100);
            //convert the date variable to a string variable
            string DatePlaced = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(DatePlaced, DeliveryAddress, OrderTotal);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DatePlacedInvalidData()
        {
            //create an insatnce of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            string Error = "";
            //set the DatePlaced variable to a non date value
            string DatePlaced = "this is not a date!";
            //invoke the method
            Error = AnOrder.Valid(DatePlaced, DeliveryAddress, OrderTotal);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        //================== ORDER TOTAL VALIDATION ===============

        [TestMethod]
        public void OrderTotalExtremeMin()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to srote any error message
            string Error = "";
            //create some test data to pass the method
            string OrderTotal = "-9999999.99";
            //invoke the method
            Error = AnOrder.Valid(DatePlaced, DeliveryAddress, OrderTotal);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderTotalMinLessOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to srote any error message
            string Error = "";
            //create some test data to pass the method
            string OrderTotal = "-0.01";
            //invoke the method
            Error = AnOrder.Valid(DatePlaced, DeliveryAddress, OrderTotal);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderTotalMin() 
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to srote any error message
            string Error = "";
            //create some test data to pass the method
            string OrderTotal = "0.00";
            //invoke the method
            Error = AnOrder.Valid(DatePlaced, DeliveryAddress, OrderTotal);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderTotalMinPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to srote any error message
            string Error = "";
            //create some test data to pass the method
            string OrderTotal = "0.01";
            //invoke the method
            Error = AnOrder.Valid(DatePlaced, DeliveryAddress, OrderTotal);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderTotalMaxLessOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to srote any error message
            string Error = "";
            //create some test data to pass the method
            string OrderTotal = "9999999.98";
            //invoke the method
            Error = AnOrder.Valid(DatePlaced, DeliveryAddress, OrderTotal);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderTotalMax()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to srote any error message
            string Error = "";
            //create some test data to pass the method
            string OrderTotal = "9999999.99";
            //invoke the method
            Error = AnOrder.Valid(DatePlaced, DeliveryAddress, OrderTotal);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderTotalMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to srote any error message
            string Error = "";
            //create some test data to pass the method
            string OrderTotal = "10000000.00";
            //invoke the method
            Error = AnOrder.Valid(DatePlaced, DeliveryAddress, OrderTotal);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderTotalMid()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to srote any error message
            string Error = "";
            //create some test data to pass the method
            string OrderTotal = "4999999.995";
            //invoke the method
            Error = AnOrder.Valid(DatePlaced, DeliveryAddress, OrderTotal);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderTotalExtremeMax()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to srote any error message
            string Error = "";
            //create some test data to pass the method
            string OrderTotal = "99999999.99";
            //invoke the method
            Error = AnOrder.Valid(DatePlaced, DeliveryAddress, OrderTotal);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderTotalInvalidData()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to srote any error message
            string Error = "";
            //create some test data to pass the method
            string OrderTotal = "this is not a decimal!";
            //invoke the method
            Error = AnOrder.Valid(DatePlaced, DeliveryAddress, OrderTotal);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
    }
}
