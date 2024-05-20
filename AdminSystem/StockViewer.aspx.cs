using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;
using System.Collections;

public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // if this is the first code the page is displayed
        if (!IsPostBack == false)
        {
            //update the list box
            DisplayStock();
        }
    }
    void DisplayStock()
    {
        //create an instance of the stock collection
        ClsStockCollection astock = new ClsStockCollection();
        //set the data source to list stock in the collection
       lstStockList.DataSource = astock.StockList;
        //set the name of the primary key
        lstStockList.DataValueField = "Product_No";
        //set the data field to display      

        lstStockList.DataTextField = "Product_Name";
        // bind the data to the list
        lstStockList.DataBind();

    }
}

