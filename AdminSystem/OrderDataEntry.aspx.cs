using System;
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

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new insatance of clsOrder
        clsOrder AnOrder = new clsOrder();
        //capture the Order Id
        AnOrder.OrderId = Convert.ToInt32(txtOrderId.Text);
        //capture the Order Total
        AnOrder.OrderTotal = Convert.ToInt32(txtOrderTotal.Text);
        //capture the Date Placed
        AnOrder.DatePlaced = Convert.ToDateTime(txtDatePlaced.Text);
        //capture the Purchased check box
        AnOrder.Purchased = chkPurchased.Checked;
        //capture the Delivery Address
        AnOrder.DeliveryAddress = txtDeliveryAddress.Text;
        //capture the No of Items
        AnOrder.NoOfItems = Convert.ToInt32(txtNoOfItems.Text);
        //capture the Is Gift check box
        AnOrder.IsGift = chkIsGift.Checked;
        //store the order in the session object
        Session["AnOrder"] = AnOrder;
        //navigate to the view page
        Response.Redirect("OrderViewer.aspx");
    }
}