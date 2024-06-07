using ClassLibrary;
using System;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{

    //variable to store the primary key value of the record to be deleted
    Int32 Product_Id;

    protected void Page_Load(object sender, EventArgs e)
    {
      

        {
            //get the number of the Stock to be deleted from the session object
            Product_Id = Convert.ToInt32(Session["Product_Id"]);
        }
    }

    protected void btnYes_Click(object sender, EventArgs e)

    {
        //create a new instance of stock list collection class
        ClsStockCollection  StockList = new ClsStockCollection();
        //find the record to delete
        StockList.ThisStock.Find(Product_Id);
        //delete the record
        StockList.Delete();
        //redirect back to the main page
        Response.Redirect("StockList.aspx");
    }


    protected void btnNo_Click(object sender, EventArgs e)
    {
        //redirect back to the main page
        Response.Redirect("StockList.aspx");
    }
}