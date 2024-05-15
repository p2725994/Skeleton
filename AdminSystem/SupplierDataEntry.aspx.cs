using System;
using System.Activities.Expressions;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click1(object sender, EventArgs e)
    {
        clsSupplier ASupplier = new clsSupplier();

        ASupplier.SupplierProducts = txtSupplierProduct.Text;
        Session["ASupplier"] = ASupplier;
        
        Response.Redirect("SupplierViewer.aspx");

    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {

    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the supplier class
        clsSupplier ASupplier = new clsSupplier();
        // create a varibale to store the primary key
        Int32 SupplierId;
        //create a vairable to store the result of the find operation
        Boolean Found = false;

        SupplierId = Convert.ToInt32(txtSupplierId.Text);
        //find the record
        Found = ASupplier.Find(SupplierId);
        //if found
        if (Found == true)
        {
            txtSupplierName.Text = ASupplier.SupplierName;
            txtSupplierEmail.Text = ASupplier.SupplierEmail;
            txtSupplierProduct.Text = ASupplier.SupplierProducts;
            txtSupplierAddress.Text = ASupplier.SupplierAddress;
            txtSupplierDeliveryDate.Text =ASupplier.SupplierDeliveryDate.ToString();
            chkSupplierFromUk.Checked = ASupplier.SupplierFromUk;


        }


    }

}