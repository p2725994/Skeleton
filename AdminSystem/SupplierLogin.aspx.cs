using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class SupplierLogin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnLoginin_Click(object sender, EventArgs e)
    {
        //redirect to the data entry page 
        Response.Redirect("SupplierDataEntry.aspx");

    }

}