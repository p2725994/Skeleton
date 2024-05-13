using System;

using System.Collections.Generic;

using System.Linq;

using System.Web;

using System.Web.UI;

using System.Web.UI.WebControls;

using ClassLibrary;



public partial class _1_DataEntry : System.Web.UI.Page

{

    private object aStock;



    protected void Page_Load(object sender, EventArgs e)

    {



    }



    protected void txtProduct_Name_TextChanged(object sender, EventArgs e)

    {



    }



    protected void txtProduct_Expiry_TextChanged(object sender, EventArgs e)

    {



    }



    protected void btnOK_Click(object sender, EventArgs e)

    {

        //create a new instance of ClsStocks

        clsStocks aStock = new clsStocks();

        //Capture the Product name
        aStock .Product_Name = txtProduct_Name.Text;
        //store the stock in the session object

        Session["astock"] = aStock ;

        //navigate to view page

        Response.Redirect("StockViewer.aspx");



    }

}
