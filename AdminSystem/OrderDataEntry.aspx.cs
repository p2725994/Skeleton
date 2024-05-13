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
        AnOrder.OrderTotal = Convert.ToDecimal(txtOrderTotal.Text);
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

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the order class
        clsOrder AnOrder = new clsOrder();
        //create a variable to store the result of the find operation
        Int32 OrderId;
        //create a variable to store the result of the find operation
        Boolean Found = false;
        //get the primary key entered by the user
        OrderId = Convert.ToInt32(txtOrderId.Text);
        //find the record
        Found = AnOrder.Find(OrderId);
        //if found
        if (Found == true)
        {
            //display the values of the properties in the forn
            txtOrderTotal.Text = AnOrder.OrderTotal.ToString();
            txtDatePlaced.Text = AnOrder.DatePlaced.ToString();
            chkPurchased.Checked = AnOrder.Purchased;
            txtDeliveryAddress.Text = AnOrder.DeliveryAddress;
            txtNoOfItems.Text = AnOrder.NoOfItems.ToString();
            chkIsGift.Checked = AnOrder.IsGift;

        }
    }
}