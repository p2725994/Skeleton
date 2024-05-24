using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace Testing4
{
    [TestClass]
    public class tstStock
    {
        //good test data
        //create some test data to pass method
        string Product_Name = "Rockstar";
        string Product_Description = "An energizing kick of caffeine";
        string Product_Quantity = "25";
        string Product_Price = "2.99";
        string Product_Expiry = DateTime.Now.ToShortDateString();

        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsStocks aStock = new clsStocks();

            //test to see that it exists.
            Assert.IsNotNull(aStock);
        }

        [TestMethod]
        public void Product_ExpiryPropertOK()
        {
            //crete an instance of the class we want to create
            clsStocks aStock = new clsStocks();
            //create some test data to assign the property
            DateTime TestData = DateTime.Now.Date;
            //set the Birthdate property with the test data
            aStock.Product_Expiry = TestData;
            //verify that the birthdate porperty was set correctly
            Assert.AreEqual(aStock.Product_Expiry, TestData);
        }


        [TestMethod]
        public void Product_DescriptionPropertyOK()
        {
            //create an instance of the class we want to create
            clsStocks aStock = new clsStocks();
            //create some test data to assign to the property
            String TestData = "cherryflavour";
            //assign the data to the property
            aStock.Product_Description = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(aStock.Product_Description, TestData);
        }


        [TestMethod]
        public void Product_NamePropertyOK()
        {
            //create an instance of the class we want to create
            clsStocks aStock = new clsStocks();
            //create some test data to assign to the property
            String TestData = "R+asap";
            //assign the data to the property
            aStock.Product_Name = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(aStock.Product_Name, TestData);
        }


        [TestMethod]
        public void Product_QuantityPropertyOK()
        {
            //create an instance of the class we want to create
            clsStocks aStock = new clsStocks();
            //create some test data to assign to the property
            Int32 TestData = 25;
            //assign the data to the property
            aStock.Product_Quantity = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(aStock.Product_Quantity, TestData);
        }

        [TestMethod]
        public void Product_PricePropertyOK()
        {
            //create an instance of the class we want to create

            clsStocks aStock = new clsStocks();
            //create some test data to assign to the property
            Double TestData = 2;
            //assign the data to the property
            aStock.Product_Price = (float)TestData;
            //test to see that the two values are the same
            Assert.AreEqual(aStock.Product_Price, TestData);
        }

        [TestMethod]
        public void Product_IdPropertyOK()
        {
            //create an instance of the class we want to create
            clsStocks aStock = new clsStocks();
            //create some test data to assign to the property
            int TestData = 1;
            //assign the data to the property
            aStock.Product_Id = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(aStock.Product_Id, TestData);
        }

        [TestMethod]
        public void AvailablePropertyOK()
        {
            //create an instance of the class we want to create
            clsStocks aStock = new clsStocks();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            aStock.Available = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(aStock.Available, TestData);
        }

        /******************FIND METHOD TEST******************/

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsStocks aStock = new clsStocks();
            //create a Boolean variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 Product_Id = 2;
            //invoke the method
            Found = aStock.Find(Product_Id);
            //test to see that the two values are the same
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestProductIdFound()
        {
            //create an instance of the class we want to create
            clsStocks aStock = new clsStocks();

            //create a Boolean variable to store the result of the search
            Boolean Found = false;

            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;

            //create some test data to use with the method
            Int32 Product_Id = 2;

            //invoke the method
            Found = aStock.Find(Product_Id);

            //check the StaffNo
            if (aStock.Product_Id != 2)
            {
                OK = false;
            }

            //test to see that the two values are the same
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestProductNameFound()
        {
            //create an instance of the class we want to create
            clsStocks aStock = new clsStocks();

            //create a Boolean variable to store the result of the search
            Boolean Found = false;

            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;

            //create some test data to use with the method
            Int32 Product_Id = 2;

            //invoke the method
            Found = aStock.Find(Product_Id);

            //check the StaffNo
            if (aStock.Product_Name != "R+asap cherryrry")
            {
                OK = false;
            }

            //test to see that the two values are the same
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestProductDescriptionFound()
        {
            //create an instance of the class we want to create
            clsStocks aStock = new clsStocks();

            //create a Boolean variable to store the result of the search
            Boolean Found = false;

            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;

            //create some test data to use with the method
            Int32 Product_Id = 2;

            //invoke the method
            Found = aStock.Find(Product_Id);

            //check the StaffNo
            if (aStock.Product_Description != " cherry flavour")
            {
                OK = false;
            }

            //test to see that the two values are the same
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestProductQuantityFound()
        {
            //create an instance of the class we want to create
            clsStocks aStock = new clsStocks();

            //create a Boolean variable to store the result of the search
            Boolean Found = false;

            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;

            //create some test data to use with the method
            Int32 Product_Id = 2;

            //invoke the method
            Found = aStock.Find(Product_Id);

            //check the StaffNo
            if (aStock.Product_Quantity != 399)
            {
                OK = false;
            }

            //test to see that the two values are the same
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestProductPriceFound()
        {
            //create an instance of the class we want to create
            clsStocks aStock = new clsStocks();

            //create a Boolean variable to store the result of the search
            Boolean Found = false;

            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;

            //create some test data to use with the method
            Int32 Product_Id = 2;

            //invoke the method
            Found = aStock.Find(Product_Id);

            //check the StaffNo
            if (aStock.Product_Price != 2)
            {
                OK = false;
            }

            //test to see that the two values are the same
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestProductExpiryFound()
        {
            //create an instance of the class we want to create
            clsStocks aStock = new clsStocks();

            //create a Boolean variable to store the result of the search
            Boolean Found = false;

            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;

            //create some test data to use with the method
            Int32 Product_Id = 2;

            //invoke the method
            Found = aStock.Find(Product_Id);

            //check the StaffNo
            if (aStock.Product_Expiry != Convert.ToDateTime("01/12/2026"))
            {
                OK = false;
            }

            //test to see that the two values are the same
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestAvailableFound()
        {
            //create an instance of the class we want to create
            clsStocks aStock = new clsStocks();

            //create a Boolean variable to store the result of the search
            Boolean Found = false;

            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;

            //create some test data to use with the method
            Int32 Product_Id = 2;

            //invoke the method
            Found = aStock.Find(Product_Id);

            //check the StaffNo
            if (aStock.Available != true)
            {
                OK = false;
            }

            //test to see that the two values are the same
            Assert.IsTrue(OK);
        }
        //valid method
        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsStocks aStock = new clsStocks();
            //string variable to store any error message
            string Error = "";
            //invoke method
            Error = aStock.Valid(Product_Description, Product_Name, Product_Expiry, Product_Quantity, Product_Price);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

            //product name
        }

        [TestMethod]
        public void Product_NameMinLessOne()
        {
            //create an instance of the class we want to create
            clsStocks aStock = new clsStocks();
            //string c=variable to store any error message
            string Error = "";
            //create some test data to pass to themethod
            string Product_Name = ""; //this should trigger an error

            Error = aStock.Valid(Product_Description, Product_Name, Product_Expiry, Product_Quantity, Product_Price);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void Product_NameNoMin()
        {
            //create an instance of the class we want to create
            clsStocks aStock = new clsStocks();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Product_Name = "aaaa"; //this should be ok
                                          //invoke the method
            Error = aStock.Valid(Product_Description, Product_Name, Product_Expiry, Product_Quantity, Product_Price);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void Product_NameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStocks aStock = new clsStocks();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Product_Name = "aaaa"; //this should be ok
                                          //invoke the method
            Error = aStock.Valid(Product_Description, Product_Name, Product_Expiry, Product_Quantity, Product_Price);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void Product_NameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStocks aStock = new clsStocks();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Product_Name = "aaaa"; //this should be ok
                                          //invoke the method
            Error = aStock.Valid(Product_Description, Product_Name, Product_Expiry, Product_Quantity, Product_Price);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void Product_NameMax()
        {
            //create an instance of the class we want to create
            clsStocks aStock = new clsStocks();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Product_Name = "aaaa"; //this should be ok
                                          //invoke the method
            Error = aStock.Valid(Product_Description, Product_Name, Product_Expiry, Product_Quantity, Product_Price);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Product_NameNoMid()
        {
            //create an instance of the class we want to create
            clsStocks aStock = new clsStocks();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Product_Name = "aaaa"; //this should be ok
                                          //invoke the method
            Error = aStock.Valid(Product_Description, Product_Name, Product_Expiry, Product_Quantity, Product_Price);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void Product_NameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStocks aStock = new clsStocks();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method

            string Product_Name = "";//this should  fail
            Product_Name = Product_Name.PadRight(31, 'a');

            //invoke the method
            Error = aStock.Valid(Product_Description, Product_Name, Product_Expiry, Product_Quantity, Product_Price);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void Product_NameExtremeMax()
        {
            //create an instance of the class we want to create
            clsStocks aStock = new clsStocks();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Product_Name = "";
            Product_Name = Product_Name.PadRight(200, 'a');//this should fail
            Error = aStock.Valid(Product_Description, Product_Name, Product_Expiry, Product_Quantity, Product_Price);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        // product description
        [TestMethod]
        public void Product_DescriptionMinLessOne()
        {
            //create an instance of the class we want to create
            clsStocks aStock = new clsStocks();
            //string c=variable to store any error message
            string Error = "";
            //create some test data to pass to themethod
            string Product_Description = ""; //this should trigger an error

            Error = aStock.Valid(Product_Description, Product_Name, Product_Expiry, Product_Quantity, Product_Price);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void Product_DescriptionMin()
        {
            //create an instance of the class we want to create
            clsStocks aStock = new clsStocks();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Product_Description = ""; //this should be ok
            Product_Description = Product_Description.PadRight(50, 'a');

            //invoke the method
            Error = aStock.Valid(Product_Description, Product_Name, Product_Expiry, Product_Quantity, Product_Price);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void Product_DescriptionMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStocks aStock = new clsStocks();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Product_Description = "aaaa"; //this should be ok
                                                 //invoke the method
            Error = aStock.Valid(Product_Description, Product_Name, Product_Expiry, Product_Quantity, Product_Price);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void Product_DescriptionMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStocks aStock = new clsStocks();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Product_Description = "aaaa"; //this should be ok
                                                 //invoke the method
            Error = aStock.Valid(Product_Description, Product_Name, Product_Expiry, Product_Quantity, Product_Price);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void Product_DescriptionMax()
        {
            //create an instance of the class we want to create
            clsStocks aStock = new clsStocks();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Product_Description = "aaaa"; //this should be ok
                                                 //invoke the method
            Error = aStock.Valid(Product_Description, Product_Name, Product_Expiry, Product_Quantity, Product_Price);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Product_DescriptionNoMid()
        {
            //create an instance of the class we want to create
            clsStocks aStock = new clsStocks();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Product_Description = "aaaa"; //this should be ok
                                                 //invoke the method
            Error = aStock.Valid(Product_Description, Product_Name, Product_Expiry, Product_Quantity, Product_Price);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void Product_DescriptionMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStocks aStock = new clsStocks();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Product_Description = "aaaa"; //this should  fail
                                                 //invoke the method
            Error = aStock.Valid(Product_Description, Product_Name, Product_Expiry, Product_Quantity, Product_Price);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void Product_DescriptionExtremeMax()
        {
            //create an instance of the class we want to create
            clsStocks aStock = new clsStocks();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Product_Description = "";
            Product_Description = Product_Description.PadRight(500, 'a');//this should fail
            Error = aStock.Valid(Product_Description, Product_Name, Product_Expiry, Product_Quantity, Product_Price);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        //  product expiry//
        public void Product_ExpiryExtreemMin()
        {
            //create an instance of the class we want to create
            clsStocks aStock = new clsStocks();
            // string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(-100);
            //convert the date varible to string variable
            String DateAdded = TestDate.ToString();
            //invoke the method
            Error = aStock.Valid(Product_Description, Product_Name, Product_Expiry, Product_Quantity, Product_Price);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void Product_ExpiryExtremeMin()
        {
            //create an instance of the class we want to create
            clsStocks aStock = new clsStocks();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(-100);
            //convert the date variable to a string variable
            string Product_Expiry = TestDate.ToString();
            //invoke the method
            Error = aStock.Valid(Product_Description, Product_Name, Product_Expiry, Product_Quantity, Product_Price);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void Product_ExpiryMinLessOne()
        {
            //create an instance of the class we want to create
            clsStocks aStock = new clsStocks();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(-1);
            //convert the date variable to a string variable
            string Product_Expiry = TestDate.ToString();
            //invoke the method
            Error = aStock.Valid(Product_Description, Product_Name, Product_Expiry, Product_Quantity, Product_Price);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void Product_ExpiryMin()
        {
            //create an instance of the class we want to create
            clsStocks aStock = new clsStocks();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;

            //convert the date variable to a string variable
            string Product_Expiry = TestDate.ToString();
            //invoke the method
            Error = aStock.Valid(Product_Description, Product_Name, Product_Expiry, Product_Quantity, Product_Price);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void Product_ExpiryMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStocks aStock = new clsStocks();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(1);
            //convert the date variable to a string variable
            string Product_Expiry = TestDate.ToString();
            //invoke the method
            Error = aStock.Valid(Product_Description, Product_Name, Product_Expiry, Product_Quantity, Product_Price);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void Product_ExpiryExtremeMax()
        {
            //create an instance of the class we want to create
            clsStocks aStock = new clsStocks();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(100);
            //convert the date variable to a string variable
            string Product_Expiry = TestDate.ToString();
            //invoke the method
            Error = aStock.Valid(Product_Description, Product_Name, Product_Expiry, Product_Quantity, Product_Price);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        //TESTING INVALID DATA//
        [TestMethod]
        public void Product_ExpiryInvalidData()
        {
            //create an instance of the class we want to create
            clsStocks aStock = new clsStocks();
            //string variable to store any error message
            String Error = "";
            //set the Product_expiry to a non date value
            String Product_Expiry = "this is not a date";
            //invoke the method
            Error = aStock.Valid(Product_Description, Product_Name, Product_Expiry, Product_Quantity, Product_Price);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");


            //TESTING PRODUCT QUANTITY
        }
        [TestMethod]
        public void Product_QuantityMinLessOne()
        {
            //create an instance of the class we want to create
            clsStocks aStock = new clsStocks();
            //string c=variable to store any error message
            string Error = "";
            //create some test data to pass to themethod
            string Product_Quantity = ""; //this should trigger an error
            //invoke the method
            Error = aStock.Valid(Product_Description, Product_Name, Product_Expiry, Product_Quantity, Product_Price);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void Product_QuantityMin()
        {
            //create an instance of the class we want to create
            clsStocks aStock = new clsStocks();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Product_Quantity = "1"; //this should be ok
            //invoke the method
            Error = aStock.Valid(Product_Description, Product_Name, Product_Expiry, Product_Quantity, Product_Price);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void Product_QuantityMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStocks aStock = new clsStocks();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Product_Quantity = "11"; //this should be ok
            //invoke the method
            Error = aStock.Valid(Product_Description, Product_Name, Product_Expiry, Product_Quantity, Product_Price);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void Product_QuantityMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStocks aStock = new clsStocks();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Product_Quantity = "11"; //this should be ok
            Product_Quantity = Product_Quantity.PadRight(50, 'a');
            //invoke the method
            Error = aStock.Valid(Product_Description, Product_Name, Product_Expiry, Product_Quantity, Product_Price);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        private void padRight(int v1, char v2)
        {
            throw new NotImplementedException();
        }

        [TestMethod]
        public void Product_QuantityMax()
        {
            //create an instance of the class we want to create
            clsStocks aStock = new clsStocks();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Product_Quantity = "11"; //this should be ok
            Product_Quantity = Product_Quantity.PadRight(50, 'a');
            //invoke the method
            Error = aStock.Valid(Product_Description, Product_Name, Product_Expiry, Product_Quantity, Product_Price);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        // test product price
        [TestMethod]
        public void Product_PriceMinLessOne()
        {
            //create an instance of the class we want to test
            clsStocks aStock = new clsStocks();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string Product_Price = "-0.01"; //this should trigger an error for being less than the minimum
                                            //invoke the method
            Error = aStock.Valid(Product_Description, Product_Name, Product_Expiry, Product_Quantity, Product_Price);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void Product_PriceMin()
        {
            //create an instance of the class we want to test
            clsStocks aStock = new clsStocks();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string Product_Price = "0.00"; //this should be ok
                                           //invoke the method
            Error = aStock.Valid(Product_Description, Product_Name, Product_Expiry, Product_Quantity, Product_Price);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Product_PriceMinPlusOne()
        {
            //create an instance of the class we want to test
            clsStocks aStock = new clsStocks();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string Product_Price = "0.01"; //this should be ok
            //invoke the method
            Error = aStock.Valid(Product_Description, Product_Name, Product_Expiry, Product_Quantity, Product_Price);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Product_PriceMaxLessOne()
        {
            //create an instance of the class we want to test
            clsStocks aStock = new clsStocks();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string Product_Price = "99999.99"; //this should be ok
             //invoke the method
            Error = aStock.Valid(Product_Description, Product_Name, Product_Expiry, Product_Quantity, Product_Price);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Product_PriceMax()
        {
            //create an instance of the class we want to test
            clsStocks aStock = new clsStocks();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string Product_Price = "100000.00"; //this should trigger an error
            //invoke the method
            Error = aStock.Valid(Product_Description, Product_Name, Product_Expiry, Product_Quantity, Product_Price);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }      

    }
}