using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;
public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)

    {
        //if this is the first time the page is displayed
        if (!IsPostBack)
        {
            //update the list box
            DisplayStocks();
        }
    }

    private void DisplayStocks()
  
        {
            //create an instance of the address collection
            ClsStockCollection Stock = new ClsStockCollection();
            //set the data source to list of stick in the collection
            lstStockList.DataSource = Stock.StockList;
            //set the name of the primay key
            lstStockList.DataValueField = "Product_Id";
            //set the data field to display
            lstStockList.DataTextField = "Product_Name";
            //bind the data to the list
            lstStockList.DataBind();
        }
    
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is a new record
        Session["Product_Id"] = -1;
        //redirect to the data entry page
        Response.Redirect("StockDataEntry.aspx");

    }
    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //variable to store the primary key value of the record to be edited
        Int32 Product_Id;
        //if a record has been selected from the list
        if (lstStockList.SelectedIndex != -1)
        {
            //get the primary key value of the record to edit
            Product_Id = Convert.ToInt32(lstStockList.SelectedValue);
            //store the data in the session object
            Session["Product_Id"] = Product_Id;
            //redict to edit page
            Response.Redirect("StockDataEntry.aspx");
        }
        else
        {
            lblError.Text = "Please select a record from the list to edit";
        }


        }

    }
        


        
