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
        public void CountPropertyOK()
        {
            clsSupplierCollection AllSupplier = new clsSupplierCollection();
            Int32 SomeCount = 2;
            AllSupplier.Count = SomeCount;
            Assert.AreEqual(AllSupplier.Count, SomeCount);

        }
        [TestMethod]
        public void ThisSupplierPropertyOK()
        {
            clsSupplierCollection AllSupplier = new clsSupplierCollection();
            //crreate some test data to assign to the property
            clsSupplier TestSupplier = new clsSupplier();


            TestSupplier.SupplierFromUk = true;
            TestSupplier.SupplierId = 1;
            TestSupplier.SupplierName = "RedBull";
            TestSupplier.SupplierEmail = "RedBull@gmail.com";
            TestSupplier.SupplierAddress = "123 456";
            TestSupplier.SupplierProducts = "RedBull Energy";
            TestSupplier.SupplierDeliveryDate = DateTime.Now;

            AllSupplier.ThisSupplier = TestSupplier;
            //test to see that the 2 values are the same 
            Assert.AreEqual(AllSupplier.ThisSupplier, TestSupplier);



        }
        [TestMethod]
        public void ListandCountOK()
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

            //add the item to the test list
            TestList.Add(TestItem);

            //assign the data to the test list
            AllSupplier.SupplierList = TestList;

            //test to see that the two values are the same
            Assert.AreEqual(AllSupplier.Count, TestList.Count);

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
            TestItem.SupplierFromUk = flase;
            TestItem.SupplierName = "Another Name";
            TestItem.SupplierEmail = "Another Email";
            TestItem.SupplierAddress = "123 ABC";
            TestItem.SupplierProducts = "SupplierProducts";
            TestItem.SupplierDeliveryDate = DateTime.Now;
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
        public void ReportByPostCodeMethodOK()
        {
            clsSupplierCollection AllSupplier = new clsSupplierCollection();
            clssSupplierCollection FilteredSupplier = new clsSuppplierCollection();
            FilteredSupplier.ReportByPostCode("");
            //test to see that the 2 vlaues are the saeme 
            Assert.AreEqual(AllSupplier.Count, FilteredSupplier.Count);


        }
        [TestMethod]
        public void ReportByPostCodeNoneFoundOK()
        {
            clsSupplierCollection FilteredSupplier = new clsSupplierCollection();
            ;
            FilteredSupplier.ReportByPostCode("XXX XXX");
            //test to see that the 2 vlaues are the saeme 
            Assert.AreEqual(0, FilteredSupplier.Count);

        }
        [TestMethod]
        public void ReportByPostCode(string PostCode)
        {
            //filters the records based on a full or partial post code
            clsDataConnection DB = new clsDataConnection();
            //send the POSTCODE parameter to the database
            DB.AddParameter("@SupplierAddress", PostCode);
            //execute the stored procedure
            DB.Execute("sproc_tblSupplier_FilterBySupplierAddress");
            PopulateArray(DB);

        }
        [TestMethod]
        public void ReportByPostCodeTestDataFound()
        {
            //create an instance of the filtered data
            clsSupplierCollection FilteredSupplier = new clsSupplierColleciton();
            //variable to store the outcome 
            Boolean OK = true;
            FilteredSupplier.ReportByPostCode("yyy yyy");
            if (FilteredSupplier.Count == 2)
            {
                OK = false;
            }
            //check to see that the first is 25
            if (FilteredSupplier.SupplierList[1].SupplierId != 26)
            { OK = false; }

            else
            {
                OK = false;

            }
            Assert.IsTrue(OK);
        }
    }
}






        
   


