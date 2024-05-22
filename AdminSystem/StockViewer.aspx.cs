using System;
using ClassLibrary;
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
        clsStocks AStock = new clsStocks();

        //get the data from the session object
        AStock = (clsStocks)Session["AStock"];

        //display the product Id
        Response.Write(AStock.Product_Id + "\n\n");

        //display the staff Firstname
        Response.Write(AStock.Product_Price + "\n\n");

        //display the staff Surname
        Response.Write(AStock.Product_Description + "\n\n");

        //display the staff Email
        Response.Write(AStock.Product_Expiry + "\n\n");

        //display the staff Password
        Response.Write(AStock.Product_Quantity + "\n\n");

        //display the staff Date Joined
        Response.Write(AStock.Product_Name + "\n\n");

        //display the staff's shift
        Response.Write(AStock.Available + "\n\n");

    }
}
