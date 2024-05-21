﻿using ASP;
using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1_DataEntry : System.Web.UI.Page
{
    Int32 Product_Id;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of stock to be processed
        Product_Id = Convert.ToInt32(Session["Product_Id"]);
        if (IsPostBack == false)
        {
            //if this is not a new record
            if(Product_Id != -1)
            {
                //display the current data for the record
                DisplayStock();

            }
        }
    }

    private void DisplayStock()
    {
        throw new NotImplementedException();
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        // create a new instance of clsStock
        clsStocks aStock = new clsStocks();

        // capture the product Id
        string Product_Id = txtProduct_Id.Text;

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

            //set the ThisStock property
            StockList.ThisStock = aStock;
            // add the new record
            StockList.Add();

            //redirect back to the list page
            Response.Redirect("StockList.aspx");
        }
        else
        {
            //display the error message#
            lblError.Text = Error;
        }
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {

        clsStocks aStock = new clsStocks();

        Int32 Product_Id;

        Boolean Found = false;

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
}
