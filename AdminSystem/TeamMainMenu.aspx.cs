﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class TeamMainMenu : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }


    protected void btnStaff_Click(object sender, EventArgs e)
    {
        //redirect to the login page
        Response.Redirect("StaffLogin.aspx");
    }

    protected void btnCustomer_Click(object sender, EventArgs e)
    {
        //redirect to the login page
        Response.Redirect("CustomerLogin.aspx");
    }

    protected void btnOrder_Click(object sender, EventArgs e)
    {
        //redirect to the login page
        Response.Redirect("OrderLogin.aspx");
    }

    protected void btnStock_Click(object sender, EventArgs e)
    {
        //redirect to the login page
        Response.Redirect("StockLogin.aspx");
    }

    protected void btnSupplier_Click(object sender, EventArgs e)
    {
        //redirect to the login page
        Response.Redirect("SupplierLogin.aspx");
    }
}