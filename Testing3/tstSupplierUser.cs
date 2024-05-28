using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing3
{
    [TestClass]

    public class tstSupplierUser
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create 
            clsSupplierUser AnUser = new clsSupplierUser();
            //test to see that it exists
            Assert.IsNotNull(AnUser);
        
        }

    }

}
    
