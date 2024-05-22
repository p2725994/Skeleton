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

    }
}
