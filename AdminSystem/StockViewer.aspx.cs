using ClassLibrary;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create a new instance of clsStock
        clsStocks astock = new clsStocks();
        //get the data from the session object
        astock = (clsStocks)Session["astock"];
        //display the house number for this entry
        Response.Write(astock.Product_Name);


    }
}