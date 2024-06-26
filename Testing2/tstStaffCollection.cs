﻿using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing2
{
    [TestClass]
    public class tstStaffCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class
            clsStaffCollection AllStaff = new clsStaffCollection();
            //check that an instance is created 
            Assert.IsNotNull(AllStaff);
        }

        [TestMethod]
        public void StaffListOK()
        {
            //create an instance of the class
            clsStaffCollection AllStaff = new clsStaffCollection();

            //create some test data to assign property 
            //in this case the data needs to a list of objects
            List<clsStaff> TestList = new List<clsStaff>();

            //Add an Item to the list 
            //create the item of the data
            clsStaff TestItem = new clsStaff();

            //set its property
            TestItem.StaffNo = 12;
            TestItem.StaffFirstname = "Afnan";
            TestItem.StaffSurname = "Khalid";
            TestItem.StaffEmail = "Afnankhalid@gmail.com";
            TestItem.StaffPassword = "Afnan123";
            TestItem.DateJoined = DateTime.Now;
            TestItem.IsOnShift = true;

            //add the item to the test list
            TestList.Add(TestItem);

            //assign the data to the test list
            AllStaff.StaffList = TestList;

            //test to see that the two values are the same
            Assert.AreEqual(AllStaff.StaffList, TestList);
        }

        [TestMethod]
        public void ThisStaffPropertyOK()
        {
            //create an instance of the class
            clsStaffCollection AllStaff = new clsStaffCollection();

            //Add an Item to the list 
            //create the item of the data
            clsStaff TestItem = new clsStaff();

            //set its property
            TestItem.StaffNo = 12;
            TestItem.StaffFirstname = "Afnan";
            TestItem.StaffSurname = "Khalid";
            TestItem.StaffEmail = "Afnankhalid@gmail.com";
            TestItem.StaffPassword = "Afnan123";
            TestItem.DateJoined = DateTime.Now;
            TestItem.IsOnShift = true;

            //assign the data to the test list
            AllStaff.ThisStaff = TestItem;

            //test to see that the two values are the same
            Assert.AreEqual(AllStaff.ThisStaff, TestItem);
        }

        [TestMethod]
        public void ListandCountOK()
        {
            //create an instance of the class
            clsStaffCollection AllStaff = new clsStaffCollection();

            //create some test data to assign property 
            //in this case the data needs to a list of objects
            List<clsStaff> TestList = new List<clsStaff>();

            //Add an Item to the list 
            //create the item of the data
            clsStaff TestItem = new clsStaff();

            //set its property
            TestItem.StaffNo = 12;
            TestItem.StaffFirstname = "Afnan";
            TestItem.StaffSurname = "Khalid";
            TestItem.StaffEmail = "Afnankhalid@gmail.com";
            TestItem.StaffPassword = "Afnan123";
            TestItem.DateJoined = DateTime.Now;
            TestItem.IsOnShift = true;

            //add the item to the test list
            TestList.Add(TestItem);

            //assign the data to the test list
            AllStaff.StaffList = TestList;

            //test to see that the two values are the same
            Assert.AreEqual(AllStaff.Count, TestList.Count);

        }

        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class
            clsStaffCollection AllStaff = new clsStaffCollection();

            //create the item of the data
            clsStaff TestItem = new clsStaff();

            //variable to store primary key
            Int32 PrimaryKey = 0;

            //set its property
            TestItem.StaffNo = 12;
            TestItem.StaffFirstname = "Afnan";
            TestItem.StaffSurname = "Khalid";
            TestItem.StaffEmail = "Afnankhalid@gmail.com";
            TestItem.StaffPassword = "Afnan123";
            TestItem.DateJoined = DateTime.Now;
            TestItem.IsOnShift = true;

            //set ThisStaf to test data
            AllStaff.ThisStaff = TestItem;

            //Add the record
            PrimaryKey = AllStaff.Add();

            //add the item to the test list
            TestItem.StaffNo = PrimaryKey;

            //find record
            AllStaff.ThisStaff.Find(PrimaryKey);

            //test to see that the two values are the same
            Assert.AreEqual(AllStaff.ThisStaff, TestItem);

        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class
            clsStaffCollection AllStaff = new clsStaffCollection();

            //create the item of the data
            clsStaff TestItem = new clsStaff();

            //variable to store primary key
            Int32 PrimaryKey = 0;

            //set its property
            TestItem.StaffNo = 8;
            TestItem.StaffFirstname = "Afnan";
            TestItem.StaffSurname = "Khalid";
            TestItem.StaffEmail = "Afnankhalid@gmail.com";
            TestItem.StaffPassword = "Afnan123";
            TestItem.DateJoined = DateTime.Now;
            TestItem.IsOnShift = true;

            //set ThisStaff to test data
            AllStaff.ThisStaff = TestItem;

            //Add the record
            PrimaryKey = AllStaff.Add();

            //add the item to the test list
            TestItem.StaffNo = PrimaryKey;

            //modify the test record;
            TestItem.StaffFirstname = "Adam";
            TestItem.StaffSurname = "lol";
            TestItem.StaffEmail = "Alol@gmail.com";
            TestItem.StaffPassword = "Force123";
            TestItem.DateJoined = DateTime.Now;
            TestItem.IsOnShift = false;

            //set the record based on the new test data
            AllStaff.ThisStaff = TestItem;

            //update the record
            AllStaff.Update();

            //find record
            AllStaff.ThisStaff.Find(PrimaryKey);

            //test to see that the two values are the same
            Assert.AreEqual(AllStaff.ThisStaff, TestItem);

        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class
            clsStaffCollection AllStaff = new clsStaffCollection();

            //create the item of the data
            clsStaff TestItem = new clsStaff();

            //variable to store primary key
            Int32 PrimaryKey = 0;

            //set its property
            TestItem.StaffNo = 12;
            TestItem.StaffFirstname = "Afnan";
            TestItem.StaffSurname = "Khalid";
            TestItem.StaffEmail = "Afnankhalid@gmail.com";
            TestItem.StaffPassword = "Afnan123";
            TestItem.DateJoined = DateTime.Now;
            TestItem.IsOnShift = true;

            //set ThisStaf to test data
            AllStaff.ThisStaff = TestItem;

            //Add the record
            PrimaryKey = AllStaff.Add();

            //add the item to the test list
            TestItem.StaffNo = PrimaryKey;

            //find record
            AllStaff.ThisStaff.Find(PrimaryKey);

            //delete the record
            AllStaff.Delete();

            //now find the record
            Boolean Found = AllStaff.ThisStaff.Find(PrimaryKey);

            //test to see that the two values are the same
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void ReportByEmailMethodOK()
        {
            //create an instance of the unfiltered class
            clsStaffCollection AllStaff = new clsStaffCollection();

            //create an instance of the filtered class
            clsStaffCollection FilteredStaff = new clsStaffCollection();

            //apply a blank string(should return all records);
            FilteredStaff.ReportByEmail("");

            //test to see that the two values are the same
            Assert.AreEqual(AllStaff.Count, FilteredStaff.Count);
        }

        [TestMethod]
        public void ReportByEmailNoneFound()
        {
            //create an instance of the filtered class
            clsStaffCollection FilteredStaff = new clsStaffCollection();

            //apply an email that doesnt exist;
            FilteredStaff.ReportByEmail("xxxxxxxxxxxx@xxxxxxx.xxx");

            //test to see that the two values are the same
            Assert.AreEqual(0, FilteredStaff.Count);
        }

        [TestMethod]
        public void ReportByEmailTestDataFound()
        {
            //create an instance of the filtered class
            clsStaffCollection FilteredStaff = new clsStaffCollection();

            //variable to store the outcome
            Boolean OK = true;

            //apply an email that doesnt exist;
            FilteredStaff.ReportByEmail("asda123@gmail.com");

            //check that the correct number of records are found
            if (FilteredStaff.Count == 2)
            {
                //check to see that the first record is 10
                if (FilteredStaff.StaffList[0].StaffNo != 50) 
                { 
                    OK = false;
                }
                //check to see that the first record is 11
                if (FilteredStaff.StaffList[1].StaffNo != 51)
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
