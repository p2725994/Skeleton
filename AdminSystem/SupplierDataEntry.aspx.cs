﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }





    protected void btnOK_Click1(object sender, EventArgs e)
    {
        //navigate to the view page
        Response.Redirect("SupplierViewer.aspx");
    }

   
}