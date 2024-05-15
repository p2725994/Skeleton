using ClassLibrary;
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

    }
}
