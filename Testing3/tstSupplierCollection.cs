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
        { clsSupplierCollection AllSupplier = new clsSupplierCollection();
            Int32 SomeCount = 2;
            AllSupplier.Count = SomeCount;
            Assert.AreEqual(AllSupplier.Count, SomeCount);

        }
        [TestMethod]
        public void ThisSupplierPropertyOK() {
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

            AllSupplier.ThisSupplier =TestItem;
            //add the record
            PrimaryKey = AllSupplier.Add();
            //Set the primary key of the test data 

            TestItem.SupplierId =PrimaryKey;

            AllSupplier.ThisSupplier.Find(PrimaryKey);
            Assert.AreEqual(AllSupplier.ThisSupplier, TestItem);

        }
     

    }
}


