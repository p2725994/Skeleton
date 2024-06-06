using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    Int32 SupplierId;
    protected void Page_Load(object sender, EventArgs e)
    {
        SupplierId = Convert.ToInt32(Session["SupplierId"]);

    }

    protected void btnyes_Click(object sender, EventArgs e)
    {
        //create a mew instance of supplier collection class
        clsSupplierCollection SupplierDataEntry = new clsSupplierCollection();
        //find the record
        SupplierDataEntry.ThisSupplier.Find(SupplierId);
        //delete the record
        SupplierDataEntry.Delete();
        //redirect back to the main page
        Response.Redirect("SupplierList.aspx");


    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        Response.Redirect("SupplierList.aspx");
    }
}