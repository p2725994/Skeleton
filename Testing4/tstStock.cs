﻿using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing4
{
    [TestClass]
    public class tstStock
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsStocks aStock = new clsStocks();

            //test to see that it exists
            Assert.IsNotNull(aStock);
        }
    }
}
