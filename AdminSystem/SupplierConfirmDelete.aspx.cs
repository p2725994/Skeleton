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
        clsSupplierCollection SupplierDataEntry = new clsSupplierCollection();
        SupplierDataEntry.ThisSupplier.Find(SupplierId);
        SupplierDataEntry.Delete();
        Response.Redirect("SupplierBookList.aspx");


    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        Response.Redirect("SupplierBookList.aspx");
    }
}