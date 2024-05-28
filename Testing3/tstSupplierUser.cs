using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing3
{
    [TestClass]
    public class tstSupplierUser
    {
        [TestMethod]
        public void IntanceOK()
        {
            //create an instance of the class we want to create
            ClsStockUser AnUser = new ClsStockUser();
            //test to see that it exists
            Assert.IsNotNull(AnUser);
        }
    }
}
