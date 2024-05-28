using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing4
{
    [TestClass]
    public class tstStockUsers
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
