using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Channels;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    Int32 SupplierId;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the supplier to be processed
        SupplierId = Convert.ToInt32(Session["SupplierId"]);
        if (IsPostBack == false)
        {
            //if this is the not a new record
            if (SupplierId != -1)

            { DisplaySupplier(); }
        }


    }
    private void DisplaySupplier()
    {
        //create an instance of supplier Collection
        clsSupplierCollection Supplier = new clsSupplierCollection();

        //set the data source to list of Staff in collection
        lstSupplierList.DataSource = Supplier.SupplierList;

        //set the name of primary key
        lstSupplierList.DataValueField = "SupplierId";

        //set the data field to display
        lstSupplierList.DataTextField = "SupplierName";

        //bind the data to the list
        lstSupplierList.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["SupplierId"] = -1;
        //redirect to the data entry page 
        Response.Redirect("SupplierEntry.aspx");

    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //variable to store the primary key value of the record to be edited 
        Int32 SupplierId;
        if (lstSupplierList.SelectedIndex != -1)
        {
            //get the primary key value of the record to edit 
            SupplierId = Convert.ToInt32(lstSupplierList.SelectedValue);
            //store the data in the session object 
            Session["SupplierId"] = SupplierId;
            Response.Redirect("SupplierDataEntry.aspx");

        }
        else
        {
            lblError.Text = "Please select a record from the list to edit";
        }


    }


    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Int32 SupplierId;
        //if a record has been slected from the list
        if (lstSupplierList.SelectedIndex != -1)
        {
            //get the promary key value of the record delete
            SupplierId = Convert.ToInt32(lstSupplierList.SelectedValue);
            //store the data in the session object 
            Session["SupplierId"] = SupplierId;
            Response.Redirect("SupplierConfirmDelete.aspx");
        }
        else
        {
            lblError.Text = "Please select a record from the list to delete";
        }


    }
}