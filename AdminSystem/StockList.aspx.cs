﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;
public partial class _1_List : System.Web.UI.Page
{
    Int32 Product_Id;
    protected void Page_Load(object sender, EventArgs e)
    {
      
                //if this  is the first time the page is displayed
                if (IsPostBack == false)
                {
                    //update the list box
                    DisplayStocks();
                }
                //create an instance of the stock user class
                clsStockUser AnUser = new clsStockUser();
                //get data from the session object
                AnUser = (clsStockUser)Session["AnUser"];
                //display the user name
                Response.Write("logged in as;" + AnUser.UserName);

            
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

    protected void btnAdd_Click1(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is a new record
        Session["Product_Id"] = -1;
        //redirect to the data entry page
        Response.Redirect("StockDataEntry.aspx");
    }

    protected void BtnEdit_Click(object sender, EventArgs e)
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


    protected void btnDelete_Click(object sender, EventArgs e)
    {

        //variable to store the primary key value the record to be deleted
        Int32 Product_Id;
        //if a record has been selected from the list
        if(lstStockList.SelectedIndex != -1)

        {
            //get the primary key value of the record delete
            Product_Id = Convert.ToInt32(lstStockList.SelectedValue);
            //store the data in the session object
            Session["Product_Id"] = Product_Id;
            //redirrect to delete page
            Response.Redirect("StockConfirmDelete.aspx");

        }
        else // if no record has been selected
        {
            //display an error message
            lblError.Text = "Please select a record from the list to delete";

        }

    }

    protected void BtnClearFilter_Click(object sender, EventArgs e)
    {
            //create an instance of Staff Collection
            ClsStockCollection AStock = new ClsStockCollection();

           //set an empty string
            AStock.ReportByProduct_Name("");

            //clear any existing filter to tidy up the interface
            txtFilter.Text = "";

            //set the data source to the list of names in the collection
            lstStockList.DataSource = AStock.StockList;

            //set the name of the PK
            lstStockList.DataValueField = "Product_Id";

             //set the name of the field
            lstStockList.DataTextField = "Product_Name";

            //bind the data to the list
            lstStockList.DataBind();
        

    }
   

    protected void BtnApplyFilter_Click(object sender, EventArgs e)
    {

        //create an instance of Staff Collection
        ClsStockCollection AStock = new ClsStockCollection();

            //retrieve the value of product name in the presentation layer
            AStock.ReportByProduct_Name(txtFilter.Text);

            //set the data source to the list of Names in the collection
            lstStockList.DataSource = AStock.StockList;

            //set the name of the Primary key
            lstStockList.DataValueField = "Product_Id";

            //set the name of the field to display
            lstStockList.DataTextField = "Product_Name";

            //bind the data to the list
            lstStockList.DataBind();

        
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

    protected void btnMainMenu_Click(object sender, EventArgs e)
    {
        //redirect the user to the stock login page
        Response.Redirect("TeamMainMenu.aspx");
    }
}
        


        
