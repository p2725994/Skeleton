using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        { DisplaySupplier(); }


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
        lstSupplierList.DataTextField = "SuppliuerName";

        //bind the data to the list
        lstSupplierList.DataBind();
    }
}