using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing3
{
    [TestClass]
    public class tstSupplier
    {
        [TestMethod]
        public void InstanceOK()
        { 

        clsAddress AnAddress = new clsAddress();

        Assert.IsNotNull(AnAddress);
        
        }
    }
}
