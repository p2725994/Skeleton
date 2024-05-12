using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //Create a new instance of clsAddress
        clsSupplier ASupplier = new clsSupplier();

        //get the data  from the session objecy 
        ASupplier = (clsSupplier)Session["ASupplier"];
        //display the product of of the entry
        Response.Write(ASupplier.SupplierProducts);

    }
}