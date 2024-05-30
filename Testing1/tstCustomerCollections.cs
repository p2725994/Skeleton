using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing1
{
    [TestClass]
    public class tstCustomerCollections
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
            TestCustomer.CustomerBirthdate = DateTime.Now.AddYears(-50);
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
            TestItem.Verified = true;
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


        [TestMethod]
        public void DeleteMethodOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create item of test data
            clsCustomer TestItem = new clsCustomer();
            //variable to store primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.Verified = true;
            TestItem.CustomerFirstname = "Michael";
            TestItem.CustomerLastname = "Jackson";
            TestItem.CustomerEmail = "michael.J@gmail.com";
            TestItem.CustomerPhone = 778908909;
            TestItem.CustomerBirthdate = DateTime.Now.AddYears(-61);
            //set thiscustomer data to the test data
            AllCustomers.ThisCustomer = TestItem;
            //add the record
            PrimaryKey = AllCustomers.Add();
            //set the primary key of the test data
            TestItem.CustomerID = PrimaryKey;
            //find the record
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            AllCustomers.Delete();
            //now fiond the record
            Boolean Found = AllCustomers.ThisCustomer.Find(PrimaryKey);
            Assert.IsFalse(Found);

        }

        [TestMethod]
        public void ResportByCustomerFirstnameOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            clsCustomerCollection FilterCustomers = new clsCustomerCollection();
            FilterCustomers.ReportByCustomerFirstname("");
            Assert.AreEqual(AllCustomers.Count, FilterCustomers.Count);

        }

        [TestMethod]
        public void ReportBCustomerFirstnameNoneFound()
        {
            clsCustomerCollection FilterCustomers = new clsCustomerCollection();
            FilterCustomers.ReportByCustomerFirstname("xxxxx");
            Assert.AreEqual(0, FilterCustomers.Count);
        }

        [TestMethod]
        public void ReprtByCustomerFirstnameTestDataFound()
        {
            clsCustomerCollection FilterCustomers = new clsCustomerCollection();
            Boolean OK = true;
            FilterCustomers.ReportByCustomerFirstname("ccccc");
            if (FilterCustomers.Count == 2)
            {
                if (FilterCustomers.CustomerList[0].CustomerID != 1058)
                {
                    OK = false;
                }
                if (FilterCustomers.CustomerList[0].CustomerID != 1060)
                {
                    OK = false; 
                }
            }
            else 
            {
                OK = false; 
            }
            Assert.IsTrue(OK);  
        }

    }
}
