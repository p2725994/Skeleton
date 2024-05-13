using ClassLibrary;
using System;
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

    protected void btnOK_Click(object sender, EventArgs e)
    {
        // create a new instance of clsStock
        clsStocks aStock = new clsStocks();


        aStock.Product_Id = Convert.ToInt32(txtProduct_Id.Text);


        aStock.Product_Name = txtProduct_Name.Text;


        aStock.Product_Description = txtProduct_Description.Text;


        aStock.Product_Quantity = Convert.ToInt32(txtProduct_Quantity.Text);


        aStock.Product_Price = Convert.ToDouble(txtProduct_Price.Text);


        aStock.Product_Expiry = Convert.ToDateTime(DateTime.Now);


        aStock.Available = chkAvailable.Checked;


        Session["AStock"] = aStock;

        //navigate to the view page
        Response.Redirect("StockViewer.aspx");
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {

        clsStocks aStock = new clsStocks();

        Int32 Product_Id;

        Boolean Found = false;

        Product_Id = Convert.ToInt32(txtProduct_Id.Text);
        //find the record
        Found = aStock.Find(Product_Id);
        //if found
        if (Found == true)
        {
            //display the values of the properties in the form
            txtProduct_Name.Text = aStock.Product_Name;
            txtProduct_Description.Text = aStock.Product_Description;
            txtProduct_Quantity.Text = aStock.Product_Quantity.ToString();
            txtProduct_Price.Text = aStock.Product_Price.ToString();
            txtProduct_Expiry.Text = aStock.Product_Expiry.ToString();
            chkAvailable.Checked = aStock.Available;

        }
    }
}
