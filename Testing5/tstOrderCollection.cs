using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Runtime.Remoting.Messaging;

namespace Testing5
{
    [TestClass]
    public class tstOrderCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //test to see that it exists
            Assert.IsNotNull(AllOrders);
        }

        [TestMethod]
        public void OrderListOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsOrder> TestList = new List<clsOrder>();
            //add an Item to the list
            //create the item of test data
            clsOrder TestItem = new clsOrder();
            //set its properties
            TestItem.OrderTotal = 12.99m;
            TestItem.Purchased = true;
            TestItem.DatePlaced = DateTime.Now;
            TestItem.DeliveryAddress = "123 Test Street, B12 3GT";
            TestItem.NoOfItems = 3;
            TestItem.IsGift = false;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllOrders.OrderList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllOrders.OrderList, TestList);
        }

        /**
        [TestMethod]
        public void CountProprtyOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create some test data to assign to the property
            Int32 SomeCount = 2;
            //assign the data to the proprety
            AllOrders.Count = SomeCount;
            //test to see that the two values are the same
            Assert.AreEqual(AllOrders.Count, SomeCount);
        }
        **/

        [TestMethod]
        public void ThisOrderPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create the item of test data
            clsOrder TestItem = new clsOrder();
            //set its properties
            TestItem.OrderTotal = 12.99m;
            TestItem.Purchased = true;
            TestItem.DatePlaced = DateTime.Now;
            TestItem.DeliveryAddress = "123 Test Street, B12 3GT";
            TestItem.NoOfItems = 3;
            TestItem.IsGift = false;
            //assign the data to the property
            AllOrders.ThisOrder = TestItem;
            //test to see that the two values are the same
            Assert.AreEqual(AllOrders.ThisOrder, TestItem);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create the list of test data
            List<clsOrder> TestList = new List<clsOrder>();
            //create the item of test data
            clsOrder TestItem = new clsOrder();
            //set its properties
            TestItem.OrderTotal = 12.99m;
            TestItem.Purchased = true;
            TestItem.DatePlaced = DateTime.Now;
            TestItem.DeliveryAddress = "123 Test Street, B12 3GT";
            TestItem.NoOfItems = 3;
            TestItem.IsGift = false;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllOrders.OrderList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllOrders.Count, TestList.Count);
        }

        /**
        [TestMethod]
        public void TwoRecordsPresent()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //test to see that the two values are the same
            Assert.AreEqual(AllOrders.Count, 2);
        }
        **/

        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create 
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create the item of test data
            clsOrder TestItem = new clsOrder();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.OrderTotal = 12.99m;
            TestItem.Purchased = true;
            TestItem.DatePlaced = DateTime.Now;
            TestItem.DeliveryAddress = "123 Test Street, B12 3GT";
            TestItem.NoOfItems = 3;
            TestItem.IsGift = false;
            //set ThisOrder to the test data
            AllOrders.ThisOrder = TestItem;
            //add the record
            PrimaryKey = AllOrders.Add();
            //set the primary key to the test data
            TestItem.OrderId = PrimaryKey;
            //find the record
            AllOrders.ThisOrder.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllOrders.ThisOrder, TestItem);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class we want to create 
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create the item of test data
            clsOrder TestItem = new clsOrder();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.OrderTotal = 12.99m;
            TestItem.Purchased = true;
            TestItem.DatePlaced = DateTime.Now;
            TestItem.DeliveryAddress = "123 Test Street, B12 3GT";
            TestItem.NoOfItems = 3;
            TestItem.IsGift = false;
            //set ThisOrder to the test data
            AllOrders.ThisOrder = TestItem;
            //add the record
            PrimaryKey = AllOrders.Add();
            //set the primary key to the test data
            TestItem.OrderId = PrimaryKey;
            //modify the test record
            TestItem.OrderTotal = 15.49m;
            TestItem.Purchased = false;
            TestItem.DatePlaced = DateTime.Now;
            TestItem.DeliveryAddress = "321 Test Lane, B21 3TG";
            TestItem.NoOfItems = 4;
            TestItem.IsGift = true;
            //set the record based on the new test data
            AllOrders.ThisOrder = TestItem;
            //update the record
            AllOrders.Update();
            //find the record
            AllOrders.ThisOrder.Find(PrimaryKey);
            //test to see if ThisOrder matches the test data
            Assert.AreEqual(AllOrders.ThisOrder, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create 
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create the item of test data
            clsOrder TestItem = new clsOrder();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.OrderTotal = 12.99m;
            TestItem.Purchased = true;
            TestItem.DatePlaced = DateTime.Now;
            TestItem.DeliveryAddress = "123 Test Street, B12 3GT";
            TestItem.NoOfItems = 3;
            TestItem.IsGift = false;
            //set ThisOrder to the test data
            AllOrders.ThisOrder = TestItem;
            //add the record
            PrimaryKey = AllOrders.Add();
            //set the primary key to the test data
            TestItem.OrderId = PrimaryKey;
            //find the record
            AllOrders.ThisOrder.Find(PrimaryKey);
            //delete the record
            AllOrders.Delete();
            //now find the record
            Boolean Found = AllOrders.ThisOrder.Find(PrimaryKey);
            //test to see that the record was not found
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void ReportbyDeliveryAddressMethodOK()
        {
            //create an instance of the class containing unfiltered results
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create an instance of the filtered data
            clsOrderCollection FilteredOrders = new clsOrderCollection();
            //apply a blank string (should return all records)
            FilteredOrders.ReportByDeliveryAddress("");
            //test to see that the two values are the same
            Assert.AreEqual(AllOrders.Count, FilteredOrders.Count);
        }

        [TestMethod]
        public void ReportByDeliveryAddressNonFound()
        {
            //create an instance of the class we want to create
            clsOrderCollection FilteredOrders = new clsOrderCollection();
            //apply a delivery address that doesnt exist
            FilteredOrders.ReportByDeliveryAddress("987 Fake Street, xxx xxx");
            //test to see that there are no records
            Assert.AreEqual(0, FilteredOrders.Count);
        }

        [TestMethod]
        public void ReportByDeliveryAddressFound()
        {
            //create an instance of the filtered data
            clsOrderCollection FilteredOrders = new clsOrderCollection();
            //variable to store the outcome
            Boolean OK = true;
            //apply a delivery address that doesnt exist
            FilteredOrders.ReportByDeliveryAddress("999 Odd street, xxx xxx");
            //check that the correct number of records are found
            if (FilteredOrders.Count == 2)
            {
                //check to see that the first record is 1037
                if (FilteredOrders.OrderList[0].OrderId != 1037)
                {
                    OK = false;
                }
                //check to see that the second record is 1038
                if (FilteredOrders.OrderList[1].OrderId != 1038)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            //test to see that there are no records
            Assert.IsTrue(OK);
        }

    }
}
