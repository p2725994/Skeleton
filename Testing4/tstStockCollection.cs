﻿using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing4
{
    [TestClass]
    public class tstStockCollection
    {
        private int PrimaryKey;
        private int primarykey;
        private int primaryKey;

        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            ClsStockCollection Allstocks = new ClsStockCollection();
            //test to see that it exists
            Assert.IsNotNull(Allstocks);
        }

        [TestMethod]
        public void StockListOK()
        {
            //create an instance of the class we want to create
            ClsStockCollection Allstocks = new ClsStockCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsStocks> TestList = new List<clsStocks>();
            //Add an Item of test data
            // create an item of test data
            clsStocks TestItem = new clsStocks();
            //set its properties
            TestItem.Product_Id = 1;
            TestItem.Product_Name = "Rockstar";
            TestItem.Product_Description = "An energizing kick of caffeine";
            TestItem.Product_Quantity = 25;
            TestItem.Product_Price = 2.99F;
            TestItem.Product_Expiry = DateTime.Now;
            TestItem.Available = true;
            //add the item to test list
            TestList.Add(TestItem);
            //assign theb data to the property
            Allstocks.StockList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(Allstocks.StockList, TestList);
        }
    

        [TestMethod]
        public void ThisStockPropertyOK()
        {
            //create an instance of the class we want to create
            ClsStockCollection Allstocks = new ClsStockCollection();
            //create some test data to assign to the property
            clsStocks Teststock = new clsStocks();
            //set its properties
            Teststock.Product_Id = 1;
            Teststock.Product_Name = "Rockstar";
            Teststock.Product_Description = "An energizing kick of caffeine";
            Teststock.Product_Quantity = 25;
            Teststock.Product_Price = 2.99F;
            Teststock.Product_Expiry = DateTime.Now;
            Teststock.Available = true;

            //assign the dat to the property
            Allstocks.ThisStock = Teststock;
            //test  to see that two vcalues are the same
            Assert.AreEqual(Allstocks.ThisStock, Teststock);
        }

        [TestMethod]
        public void ListAndCount()
        {
            //create an instance of the class we want to create
            ClsStockCollection Allstocks = new ClsStockCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsStocks> TestList = new List<clsStocks>();
            //Add an Item of test data
            // create an item of test data
            clsStocks TestItem = new clsStocks();
            //set its properties
            TestItem.Product_Id = 1;
            TestItem.Product_Name = "Rockstar";
            TestItem.Product_Description = "An energizing kick of caffeine";
            TestItem.Product_Quantity = 25;
            TestItem.Product_Price = 2.99F;
            TestItem.Product_Expiry = DateTime.Now;
            TestItem.Available = true;
            //add the item to test list
            TestList.Add(TestItem);
            //assign theb data to the property
            Allstocks.StockList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(Allstocks.StockList, TestList);
        }

        [TestMethod]
        public void AddMethodOK() {
            //create an instance of the class we want to create
            ClsStockCollection Allstocks = new ClsStockCollection();
            // create an item of test data
            clsStocks TestItem = new clsStocks();
            //set its properties
            TestItem.Product_Id = 1;
            TestItem.Product_Name = "Rockstar";
            TestItem.Product_Description = "An energizing kick of caffeine";
            TestItem.Product_Quantity = 25;
            TestItem.Product_Price = 2.99F;
            TestItem.Product_Expiry = DateTime.Now;
            TestItem.Available = true;
            //set ThisStock to the test data
            Allstocks.ThisStock = TestItem;
            //add the record
            primaryKey = Allstocks.Add();
            //set the primary key of the test data
            TestItem.Product_Id = PrimaryKey;
            //find this method
            Allstocks.ThisStock.Find(primarykey);
          //test to see that the two values are the same
            Assert.AreEqual(Allstocks.ThisStock, TestItem);

        }
        public void UpdateMethodOK()
        {

       
     
            //create an instance of the class we want to create
            ClsStockCollection Allstocks = new ClsStockCollection();
            // create an item of test data
            clsStocks TestItem = new clsStocks();
            Int32 Primarykey = 0;
            //set its properties
            TestItem.Product_Id = 1;
            TestItem.Product_Name = "Rockstar";
            TestItem.Product_Description = "An energizing kick of caffeine";
            TestItem.Product_Quantity = 25;
            TestItem.Product_Price = 2.99F;
            TestItem.Product_Expiry = DateTime.Now;
            TestItem.Available = true;
            //set ThisStock to the test data
            Allstocks.ThisStock = TestItem;
            //add the record
            primaryKey = Allstocks.Add();
            //set the primary key of the test data
            TestItem.Product_Id = PrimaryKey;
            //modify the test record
            TestItem.Product_Id = 1;
            TestItem.Product_Name = "Rockstar";
            TestItem.Product_Description = "An energizing kick of caffeine";
            TestItem.Product_Quantity = 25;
            TestItem.Product_Price = 2.99F;
            TestItem.Product_Expiry = DateTime.Now;
            TestItem.Available = true;
            //set the record based on the new test data
            Allstocks.ThisStock = TestItem;
            // update the record
            Allstocks.Update();
            //find the record
            Allstocks.ThisStock.Find(Primarykey);
            //test to see if Thisaddress matches the test data
            Assert.AreEqual(Allstocks.ThisStock, TestItem);
        }

       
    }
}
