﻿using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //if its the first time the page is displayed
        if (IsPostBack ==  false)
        {
            DisplayCustomers();
        }

        clsCustomerUser AnUser = new clsCustomerUser();
        AnUser = (clsCustomerUser)Session["AnUser"];
        Response.Write("Logged in as: " + AnUser.UserName);
    }
    void DisplayCustomers()
    {
        clsCustomerCollection Customers = new clsCustomerCollection();
        lstCustomerList.DataSource = Customers.CustomerList;
        lstCustomerList.DataValueField = "CustomerID";
        lstCustomerList.DataTextField = "CustomerFirstname";
        lstCustomerList.DataBind();
    }

    protected void lstCustomerList_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session obj to indicate this is a new record
        Session["CustomerID"] = -1;
        Response.Redirect("CustomerDataEntry.aspx");
    }


    protected void btnEdit_Click1(object sender, EventArgs e)
    {
        Int32 CustomerID;
        if (lstCustomerList.SelectedIndex != -1)
        {
            CustomerID = Convert.ToInt32(lstCustomerList.SelectedValue);
            Session["CustomerID"] = CustomerID;
            Response.Redirect("CustomerDataEntry.aspx");
        }
        else
        {
            lblError.Text = "Please select a record from the list to edit";
      
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //var to store the primary key
        Int32 CustomerID;
        if (lstCustomerList.SelectedIndex != -1)
        {
            CustomerID = Convert.ToInt32(lstCustomerList.SelectedValue);
            Session["CustomerID"] = CustomerID;
            Response.Redirect("CustomerConfirmDelete.aspx");
        }
        else
        {
            lblError.Text = "Please select a record from the list to delte";
        }
    }

    protected void btnApplyFilter_Click(object sender, EventArgs e)
    {
        clsCustomerCollection ACustomer = new clsCustomerCollection();  
        ACustomer.ReportByCustomerFirstname(txtFirstname.Text);
        lstCustomerList.DataSource = ACustomer.CustomerList;
        lstCustomerList.DataValueField = "CustomerID";
        lstCustomerList.DataTextField = "CustomerFirstname";
        lstCustomerList.DataBind();
    }

    protected void btnClearFilter_Click(object sender, EventArgs e)
    {
        clsCustomerCollection ACustomer = new clsCustomerCollection();
        ACustomer.ReportByCustomerFirstname("");
        txtFirstname.Text = "";
        lstCustomerList.DataSource = ACustomer.CustomerList;
        lstCustomerList.DataValueField = "CustomerID";
        lstCustomerList.DataTextField = "CustomerFirstname";
        lstCustomerList.DataBind();
    }

    protected void btnReturnMainMenu_Click(object sender, EventArgs e)
    {
        Response.Redirect("TeamMainMenu.aspx");
    }
}