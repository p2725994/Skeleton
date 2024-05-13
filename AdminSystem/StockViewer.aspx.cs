using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        clsStocks aStock = new clsStocks();


        aStock = (clsStocks)Session["AStock"];


        Response.Write(aStock.Product_Id + "\n\n");


        Response.Write(aStock.Product_Name + "\n\n");


        Response.Write(aStock.Product_Description + "\n\n");


        Response.Write(aStock.Product_Quantity + "\n\n");


        Response.Write(aStock.Product_Price + "\n\n");


        Response.Write(aStock.Product_Expiry + "\n\n");


        Response.Write(aStock.Available + "\n\n");
    }
}
