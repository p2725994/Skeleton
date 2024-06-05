using ASP;
using ClassLibrary;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1_DataEntry : System.Web.UI.Page
{
    Int32 Product_Id;
    private int product_Id;

    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of stock to be processed
        Product_Id = Convert.ToInt32(Session["Product_Id"]);
        if (IsPostBack == false)
        {
            //if this is not a new record
            if (Product_Id != -1)
            {
                //display the current data for the record
                DisplayStock();

            }
        }
    }

    private void DisplayStock()
    {
        //create an instance of the address collection
        ClsStockCollection StockList = new ClsStockCollection();
        //find the record to update
        StockList.ThisStock.Find(Product_Id);
        //display the data for the record
        txtProduct_Id.Text = StockList.ThisStock.Product_Id.ToString();
        txtProduct_Name.Text = StockList.ThisStock.Product_Name.ToString();
        txtProduct_Description.Text = StockList.ThisStock.Product_Description.ToString();
        txtProduct_Quantity.Text = StockList.ThisStock.Product_Quantity.ToString();
        txtProduct_Price.Text = StockList.ThisStock.Product_Price.ToString();
        txtProduct_Expiry.Text = StockList.ThisStock.Product_Expiry.ToString();
        chkAvailable.Checked = StockList.ThisStock.Available;
    }



    protected void btnOK_Click(object sender, EventArgs e)
    {
        // create a new instance of clsStock
        clsStocks aStock = new clsStocks();

        // capture the product Id
        //string Product_Id = txtProduct_Id.Text;

        // capture the product name
        string Product_Name = txtProduct_Name.Text;

        // capture product description
        string Product_Description = txtProduct_Description.Text;

        // capture product quantity
        string Product_Quantity = txtProduct_Quantity.Text;

        // capture product price
        string Product_Price = txtProduct_Price.Text;

        // capture product expiry
        string Product_Expiry = txtProduct_Expiry.Text;

        // capture available check box
        string Available = chkAvailable.Text;

        //variable to store error message
        string Error = "";
        Error = aStock.Valid(Product_Description, Product_Name, Product_Expiry, Product_Quantity, Product_Price);
        if (Error == "")
        {
            //capture the Product_Id
            aStock.Product_Id = Product_Id;


            // capture the product name
            aStock.Product_Name = Product_Name;

            // capture product description
            aStock.Product_Description = Product_Description;

            // capture product quantity
            aStock.Product_Quantity = Convert.ToInt32(Product_Quantity);

            // capture product price
            aStock.Product_Price = (float)Convert.ToDecimal(Product_Price);

            // capture product expiry
            aStock.Product_Expiry = Convert.ToDateTime(Product_Expiry);
            //capture active
            aStock.Available = chkAvailable.Checked;
            //create a new instance of stock collection
            ClsStockCollection StockList = new ClsStockCollection();
            // if this is a new record i.e Product_Id = -1 then add the data

            if (Product_Id == -1)
            {
                //set the ThisStock property
                StockList.ThisStock = aStock;
                // add the new record
                StockList.Add();


            }

            //otherwise it must be update
            else
            {
                //find the record to update
                StockList.ThisStock.Find(Product_Id);
                // Set the ThisStock property
                StockList.ThisStock = aStock;
                //update the record
                StockList.Update();

            }
            //redirect back to the list page
            Response.Redirect("StockDataEntry.aspx");
        }
        else
        {
            //display the error message#
            lblError.Text = Error;
        }
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the stock class
        clsStocks aStock = new clsStocks();
        //create variable to store primary key
        Int32 Product_Id;
        //create a Boolean variable to store the results of the find operation
        Boolean Found = false;
        //get the primary key entered by the user
        Product_Id = Convert.ToInt32(txtProduct_Id.Text);
        //find the record
        Found = aStock.Find(Product_Id);
        //if found
        if (Found == true)

          
        {
            //display the values of the properties in the form
            txtProduct_Name.Text = aStock.Product_Name;
            txtProduct_Description.Text = aStock.Product_Description;
            txtProduct_Quantity.Text = aStock.Product_Quantity.ToString();
            txtProduct_Price.Text = aStock.Product_Price.ToString();
            txtProduct_Expiry.Text = aStock.Product_Expiry.ToString();
            chkAvailable.Checked = aStock.Available;


        }
    }

    protected void btnMainMenu_Click(object sender, EventArgs e)
    {
        //redirect the user to the stock login page
        Response.Redirect("TeamMainMenu.aspx");
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        //redirect to the main menu page
        Response.Redirect("StockList.aspx");
    }
}

      

       
       
    

