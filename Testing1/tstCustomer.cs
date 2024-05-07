using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing1
{
    [TestClass]
    public class tstCustomer
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance
            clsCustomer ACustomer = new clsCustomer();
            //test to see if it exists
            Assert.IsNotNull(ACustomer);
        }
    }
}
