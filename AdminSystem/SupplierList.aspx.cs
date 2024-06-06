using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.ServiceModel.Channels;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the supplier to be processed
        if (IsPostBack == false)
        {
            DisplaySuppliers();

        }
        clsSupplierUser AnUser = new clsSupplierUser();
        //get data from the session object 
        AnUser = (clsSupplierUser)Session["AnUser"];
        Response.Write("Logged in as" + AnUser.UserName);


    }
    private void DisplaySuppliers()
    {
        //create an instance of supplier Collection
        clsSupplierCollection Suppliers = new clsSupplierCollection();

        //set the data source to list of Staff in collection
        lstSupplierList.DataSource = Suppliers.SupplierList;

        //set the name of primary key
        lstSupplierList.DataValueField = "SupplierId";

        //set the data field to display
        lstSupplierList.DataTextField = "SupplierAddress";

        //bind the data to the list
        lstSupplierList.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["SupplierId"] = -1;
        //redirect to the data entry page 
        Response.Redirect("SupplierDataEntry.aspx");

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




    protected void btnApplyFilter_Click(object sender, EventArgs e)
    {
        //create an instance of the address object
        clsSupplierCollection ASupplier = new clsSupplierCollection();
        //retrieve the value of post from the presentaion layer
        ASupplier.ReportBySupplierAddress(txtFilter.Text);
        lstSupplierList.DataSource = ASupplier.SupplierList;
        //set the name of the primary key
        lstSupplierList.DataValueField = "SupplierId";
        //set the name of the field to display
        lstSupplierList.DataTextField = "SupplierAddress";
        //bind the data to the list 
        lstSupplierList.DataBind();


    }

    protected void btnClearFilter_Click(object sender, EventArgs e)
    {
        //create an instance of the supplier object 
        clsSupplierCollection ASupplier = new clsSupplierCollection();
        //set an empty string 
        ASupplier.ReportBySupplierAddress("");
        txtFilter.Text = "";
        lstSupplierList.DataSource = ASupplier.SupplierList;
        lstSupplierList.DataValueField = "SupplierId";
        //set the name of the field to display
        lstSupplierList.DataTextField = "SupplierAddess";
        //bind the data to the list 
        lstSupplierList.DataBind();


    }

    protected void lstSupplierList_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}