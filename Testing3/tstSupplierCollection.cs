using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Security.Policy;

namespace Testing3
{
    [TestClass]
    public class tstSuplierCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class
            clsSupplierCollection AllSupplier = new clsSupplierCollection();
            //check that an instance is created 
            Assert.IsNotNull(AllSupplier);
        }

        [TestMethod]
        public void SupplierListOK()
        {
            //create an instance of the class
            clsSupplierCollection AllSupplier = new clsSupplierCollection();

            //create some test data to assign property 
            //in this case the data needs to a list of objects
            List<clsSupplier> TestList = new List<clsSupplier>();

            //Add an Item to the list 
            //create the item of the data
            clsSupplier TestItem = new clsSupplier();

            //set its property
            TestItem.SupplierId = 1;
            TestItem.SupplierName = "RedBull";
            TestItem.SupplierEmail = "RedBull@gmail.com";
            TestItem.SupplierAddress = "123 456";
            TestItem.SupplierProducts = "RedBull Energy";
            TestItem.SupplierDeliveryDate = DateTime.Now;
            TestItem.SupplierFromUk = true;

            TestList.Add(TestItem);
            //assign the data to property
            AllSupplier.SupplierList = TestList;
            Assert.AreEqual(AllSupplier.SupplierList, TestList);
        }

        [TestMethod]
        public void ThisSupplierPropertyOK()
        {
            //create an instance of the class
            clsSupplierCollection AllSupplier = new clsSupplierCollection();

            //Add an Item to the list 
            //create the item of the data
            clsSupplier TestItem = new clsSupplier();

            //set its property
            TestItem.SupplierId = 1;
            TestItem.SupplierName = "RedBull";
            TestItem.SupplierEmail = "RedBull@gmail.com";
            TestItem.SupplierAddress = "123 456";
            TestItem.SupplierProducts = "RedBull Energy";
            TestItem.SupplierDeliveryDate = DateTime.Now;
            TestItem.SupplierFromUk = true;


            //assign the data to the test list
            AllSupplier.ThisSupplier = TestItem;

            //test to see that the two values are the same
            Assert.AreEqual(AllSupplier.ThisSupplier, TestItem);
        }


        [TestMethod]
            public void ListAndCountOK()
            {
                //create an instance of the class we want to create
                clsSupplierCollection AllSupplier = new clsSupplierCollection();
                //create some test data to assign to the property
                //in this case the data needs to be a list of objects
                List<clsSupplier> TestList = new List<clsSupplier>();
                //Add an Item of test data
                // create an item of test data
                clsSupplier TestItem = new clsSupplier();
                //set its properties
                TestItem.SupplierId = 1;
                TestItem.SupplierName = "RedBull";
                TestItem.SupplierEmail = "RedBull@gmail.com";
                TestItem.SupplierProducts = "RedBull Energy";
                TestItem.SupplierAddress = "123 345";
                TestItem.SupplierDeliveryDate = DateTime.Now;
                TestItem.SupplierFromUk = true;
                //add the item to test list
                TestList.Add(TestItem);
                //assign theb data to the property
                AllSupplier.SupplierList = TestList;
                //test to see that the two values are the same
                Assert.AreEqual(AllSupplier.SupplierList, TestList);
            }

     
        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create 
            clsSupplierCollection AllSupplier = new clsSupplierCollection();
            //create the item of test data
            clsSupplier TestItem = new clsSupplier();
            Int32 PrimaryKey = 0;
            TestItem.SupplierId = 1;
            TestItem.SupplierName = "RedBull";
            TestItem.SupplierEmail = "RedBull@gmail.com";
            TestItem.SupplierAddress = "123 456";
            TestItem.SupplierProducts = "RedBull Energy";
            TestItem.SupplierDeliveryDate = DateTime.Now;
            TestItem.SupplierFromUk = true;

            AllSupplier.ThisSupplier = TestItem;
            //add the record
            PrimaryKey = AllSupplier.Add();
            //Set the primary key of the test data 

            TestItem.SupplierId = PrimaryKey;

            AllSupplier.ThisSupplier.Find(PrimaryKey);
            Assert.AreEqual(AllSupplier.ThisSupplier, TestItem);

        }
        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class we want to create 
            clsSupplierCollection AllSupplier = new clsSupplierCollection();
            //create the item of test data
            clsSupplier TestItem = new clsSupplier();
            Int32 PrimaryKey = 0;
            TestItem.SupplierId = 1;
            TestItem.SupplierName = "RedBull";
            TestItem.SupplierEmail = "RedBull@gmail.com";
            TestItem.SupplierAddress = "123 456";
            TestItem.SupplierProducts = "RedBull Energy";
            TestItem.SupplierDeliveryDate = DateTime.Now;
            TestItem.SupplierFromUk = true;

            AllSupplier.ThisSupplier = TestItem;
            //add the record
            PrimaryKey = AllSupplier.Add();
            //Set the primary key of the test data 

            TestItem.SupplierId = PrimaryKey;
            //modufy the test record 
            TestItem.SupplierName = "Another Name";
            TestItem.SupplierEmail = "Another Email";
            TestItem.SupplierAddress = "123 ABC";
            TestItem.SupplierProducts = "SupplierProducts";
            TestItem.SupplierDeliveryDate = DateTime.Now;
            TestItem.SupplierFromUk = false;
            //set the record based on the new test data 
            AllSupplier.ThisSupplier = TestItem;
            //update the  record 
            AllSupplier.Update();
            //find the record
            AllSupplier.ThisSupplier.Find(PrimaryKey);
            Assert.AreEqual(AllSupplier.ThisSupplier, TestItem);

        }
        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create 
            clsSupplierCollection AllSupplier = new clsSupplierCollection();
            //create the item of test data
            clsSupplier TestItem = new clsSupplier();
            Int32 PrimaryKey = 0;
            TestItem.SupplierId = 1;
            TestItem.SupplierName = "RedBull";
            TestItem.SupplierEmail = "RedBull@gmail.com";
            TestItem.SupplierAddress = "123 456";
            TestItem.SupplierProducts = "RedBull Energy";
            TestItem.SupplierDeliveryDate = DateTime.Now;
            TestItem.SupplierFromUk = true;

            AllSupplier.ThisSupplier = TestItem;
            //add the record
            PrimaryKey = AllSupplier.Add();
            //Set the primary key of the test data 
            AllSupplier.ThisSupplier.Find(PrimaryKey);
            AllSupplier.Delete();
            Boolean Found = AllSupplier.ThisSupplier.Find(PrimaryKey);
            Assert.IsFalse(Found);



        }

        [TestMethod]
        public void ReportBySupplierAddressMethodOK()
        {
            clsSupplierCollection AllSupplier = new clsSupplierCollection();
            clsSupplierCollection FilteredSupplier = new clsSupplierCollection();
            FilteredSupplier.ReportBySupplierAddress("");
            //test to see that the 2 vlaues are the saeme 
            Assert.AreEqual(AllSupplier.Count, FilteredSupplier.Count);


        }
        [TestMethod]
        public void ReportBySupplierAddressNoneFoundOK()
        {
            clsSupplierCollection FilteredSupplier = new clsSupplierCollection();
            ;
            FilteredSupplier.ReportBySupplierAddress("XXX XXX");
            //test to see that the 2 vlaues are the saeme 
            Assert.AreEqual(0, FilteredSupplier.Count);

        }


        [TestMethod]
        public void ReportBySupplierMethodTestDataFound()
        {
            //create an instance of the filtered class
            clsSupplierCollection FilteredSupplier = new clsSupplierCollection();


            //variable to store the outcome
            Boolean OK = true;

            //apply an email that doesnt exist;
            FilteredSupplier.ReportBySupplierAddress("123 457");

            //check that the correct number of records are found
            if (FilteredSupplier.Count == 2)
            {
                //check to see that the first record is 10
                if (FilteredSupplier.SupplierList[0].SupplierId != 5)
                {
                    OK = false;
                }
                //check to see that the first record is 11
                if (FilteredSupplier.SupplierList[1].SupplierId != 6)
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






        
   


