using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing1
{
    [TestClass]
    public class tstCustomerCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            Assert.IsNotNull(AllCustomers);
        }



        [TestMethod]
        public void CustomerListOK() 
        {
            //create an instance of class
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create some test to assign to property
            //in this case the data needs to be a list of objects
            List<clsCustomer> TestList = new List<clsCustomer>();
            //add am item to the list
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //set its properties
            TestItem.Verified = true;
            TestItem.CustomerID = 1;
            TestItem.CustomerFirstname = "Afnan";
            TestItem.CustomerLastname = "Khalid";
            TestItem.CustomerEmail = "afnan@yahoo.com";
            TestItem.CustomerPhone = 771234567;
            TestItem.CustomerBirthdate = DateTime.Now.AddYears(-50);
            //add item to test list
            TestList.Add(TestItem);
            //assign the data to property
            AllCustomers.CustomerList = TestList;
            Assert.AreEqual(AllCustomers.CustomerList, TestList);
        }

        [TestMethod]
        public void ThisCustomerPropertyOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            clsCustomer TestCustomer = new clsCustomer();   
            TestCustomer.Verified = true;
            TestCustomer.CustomerFirstname = "Afnan";
            TestCustomer.CustomerLastname = "Khalid";
            TestCustomer.CustomerEmail = "afnan@yahoo.com";
            TestCustomer.CustomerPhone = 771234567;
            TestCustomer.CustomerBirthdate= DateTime.Now.AddYears(-50);
            AllCustomers.ThisCustomer = TestCustomer;
            Assert.AreEqual(AllCustomers.ThisCustomer, TestCustomer);
        }



        [TestMethod]
        public void ListAndCountOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            List<clsCustomer> TestList = new List<clsCustomer>();
            clsCustomer TestItem = new clsCustomer();
            TestItem.Verified = true;
            TestItem.CustomerID = 1;
            TestItem.CustomerFirstname = "Afnan";
            TestItem.CustomerLastname = "Khalid";
            TestItem.CustomerEmail = "afnan@yahoo.com";
            TestItem.CustomerPhone = 771234567;
            TestItem.CustomerBirthdate = DateTime.Now.AddYears(-50);
            TestList.Add(TestItem);
            AllCustomers.CustomerList = TestList;
            Assert.AreEqual(AllCustomers.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of class
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //variable to store primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.Verified= true;
            TestItem.CustomerID = 1;
            TestItem.CustomerFirstname = "Michael";
            TestItem.CustomerLastname = "JAckson";
            TestItem.CustomerEmail = "michael@gmail.com";
            TestItem.CustomerPhone = 771231231;
            TestItem.CustomerBirthdate = DateTime.Now.AddYears(-49);
            //set thiscustomer to the test data
            AllCustomers.ThisCustomer = TestItem;
            //add the record
            PrimaryKey = AllCustomers.Add();
            //set the primary key of test data
            TestItem.CustomerID = PrimaryKey;
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);
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
        public void UpdateMethodOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            clsCustomer TestItem = new clsCustomer();
            Int32 PrimaryKey = 0;
            TestItem.Verified = true;
            TestItem.CustomerFirstname = "Michael";
            TestItem.CustomerLastname = "Jackson";
            TestItem.CustomerEmail = "michael.J@gmail.com";
            TestItem.CustomerPhone = 778908909;
            TestItem.CustomerBirthdate = DateTime.Now.AddYears(-61);
            AllCustomers.ThisCustomer = TestItem;
            PrimaryKey = AllCustomers.Add();
            TestItem.CustomerID = PrimaryKey;
            TestItem.Verified = false;
            TestItem.CustomerFirstname = "Bob";
            TestItem.CustomerLastname = "Ross";
            TestItem.CustomerEmail = "bob@gmail.com";
            TestItem.CustomerPhone = 776546543;
            TestItem.CustomerBirthdate = DateTime.Now.AddYears(-74).AddDays(-72);
            AllCustomers.ThisCustomer = TestItem;
            AllCustomers.Update();
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);
        }

    }
}
