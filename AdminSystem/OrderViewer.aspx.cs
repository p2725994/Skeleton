using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create a new instance of clsOrder
        clsOrder AnOrder = new clsOrder();
        //get the data from the session object
        AnOrder = (clsOrder)Session["AnOrder"];
        //display the Order Id for this entry
        Response.Write(AnOrder.OrderId);
        //display the Order Total for this entry
        Response.Write(AnOrder.OrderTotal);
        //display the Date Placed for this entry
        Response.Write(AnOrder.DatePlaced);
        //display the Purchased status for this entry
        Response.Write(AnOrder.Purchased);
        //display the Delivery Address for this entry
        Response.Write(AnOrder.DeliveryAddress);
        //display the No of Items for this entry
        Response.Write(AnOrder.NoOfItems); 
        //display the Is Gift status for this entry
        Response.Write(AnOrder.IsGift);
    }
}