﻿using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1_List : System.Web.UI.Page
{
    //variable to store the primary key with page level scope
    Int32 OrderId;

    protected void Page_Load(object sender, EventArgs e)
    {
        //if this is the first time the page is displayed
        if (IsPostBack == false)
        {
            //update the list box
            DisplayOrders();
            /**
            //create an instance of the Order collection
            clsOrderCollection Orders = new clsOrderCollection();
            //set the data source to the list of orders in the collection
            lstOrderList.DataSource = Orders.OrderList;
            //set the name of the primary key
            lstOrderList.DataValueField = "OrderId";
            //set the data field to display
            lstOrderList.DataTextField = "DeliveryAddress";
            //bind the data to the list
            lstOrderList.DataBind();
            **/
        }

        //create a new instance of clsOrderUser
        clsOrderUser AnUser = new clsOrderUser();
        //get data from the session object
        AnUser = (clsOrderUser)Session["AnUser"];
        //display the user name
        Response.Write("Logged in as: " + AnUser.UserName);
    }

    void DisplayOrders()
    {
        //create an instance of the Order collection
        clsOrderCollection Orders = new clsOrderCollection();
        //set the data source to the list of orders in the collection
        lstOrderList.DataSource = Orders.OrderList;
        //set the name of the primary key
        lstOrderList.DataValueField = "OrderId";
        //set the data field to display
        lstOrderList.DataTextField = "DeliveryAddress";
        //bind the data to the list
        lstOrderList.DataBind();
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        //store -1 into the session objet to indicate this is a new record
        Session["OrderId"] = -1;
        //redirect to the data entry page
        Response.Redirect("OrderDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //variable to store the primary key value of the record to be edited
        Int32 OrderId;
        //if a record has been selected from the list
        if (lstOrderList.SelectedIndex != -1)
        {
            //get the primary key of the record to edit
            OrderId = Convert.ToInt32(lstOrderList.SelectedValue);
            //store the data in the session object
            Session["OrderId"] = OrderId;
            //redirect to the edit page
            Response.Redirect("OrderDataEntry.aspx");
        }
        else        //if no record has been selected
        {
            lblError.Text = "Please select a record from the list to edit";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //variable to store the primary key value of the record to be deleted
        Int32 OrderId;
        //if a record has been selected from the list
        if (lstOrderList.SelectedIndex != -1)
        {
            //get the primary key value of the record delete
            OrderId = Convert.ToInt32(lstOrderList.SelectedValue);
            //store the data in the session object
            Session["OrderId"] = OrderId;
            //redirect to the delete page
            Response.Redirect("OrderConfirmDelete.aspx");
        }
        else //if no record has been selected
        {
            //display an error message
            lblError.Text = "Please select a record from the list to delete";
        }
    }

    protected void btnApplyFilter_Click(object sender, EventArgs e)
    {
        //create an instance of the order object
        clsOrderCollection AnOrder = new clsOrderCollection();
        //retrieve the value of the delivery address from the presentation layer
        AnOrder.ReportByDeliveryAddress(txtFilter.Text);
        //set the data source to the list of orders in the collection
        lstOrderList.DataSource = AnOrder.OrderList;
        //set the name of the primary key
        lstOrderList.DataValueField = "OrderId";
        //set the name of the field to display
        lstOrderList.DataTextField = "DeliveryAddress";
        //bind the data to the list
        lstOrderList.DataBind();
    }

    protected void btnClearFilter_Click(object sender, EventArgs e)
    {
        //create an instance of the order object
        clsOrderCollection AnOrder = new clsOrderCollection();
        //set an empty string
        AnOrder.ReportByDeliveryAddress("");
        //clear any existin filter to tidy up the interface
        txtFilter.Text = "";
        //set the data source to the list of orders in the collection
        lstOrderList.DataSource = AnOrder.OrderList;
        //set the name of the primary key
        lstOrderList.DataValueField = "OrderId";
        //set the name of the field to display
        lstOrderList.DataTextField = "DeliveryAddress";
        //bind the data to the list
        lstOrderList.DataBind();
    }

    protected void btnMainMenu_Click(object sender, EventArgs e)
    {
        //redirect to the main menu
        Response.Redirect("TeamMainMenu.aspx");
    }
}