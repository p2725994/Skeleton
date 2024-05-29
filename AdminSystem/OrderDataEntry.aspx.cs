using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    //variable to store the primary key eith page level scope
    Int32 OrderId;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the order to be processed
        OrderId = Convert.ToInt32(Session["OrderId"]);
        if (IsPostBack == false)
        {
            //if this is not a new record
            if (OrderId != -1)
            {
                //diplay the current data for the record
                DisplayOrder();
            }
        }
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new insatance of clsOrder
        clsOrder AnOrder = new clsOrder();
        //capture the Order Total
        string OrderTotal = txtOrderTotal.Text;
        //capture the Date Placed
        string DatePlaced = txtDatePlaced.Text;
        //capture the Purchased check box
        string Purchased = chkPurchased.Text;
        //capture the Delivery Address
        string DeliveryAddress = txtDeliveryAddress.Text;
        //capture the No of Items
        string NoOfItems = txtNoOfItems.Text;
        //capture the Is Gift check box
        string IsGift = chkIsGift.Text;
        //variable to store any error messages
        string Error = "";
        //validate the data
        Error = AnOrder.Valid(DatePlaced, DeliveryAddress, OrderTotal, NoOfItems);
        if (Error == "")
        {
            //capture the order id
            AnOrder.OrderId = OrderId;
            //capture the Order Total
            AnOrder.OrderTotal = Convert.ToDecimal(OrderTotal);
            //capture the Date Placed
            AnOrder.DatePlaced = Convert.ToDateTime(DatePlaced);
            //capture the delivery address
            AnOrder.DeliveryAddress = DeliveryAddress;
            //capture the No of Items
            AnOrder.NoOfItems = Convert.ToInt32(NoOfItems);
            //capture the Purchased status
            AnOrder.Purchased = chkPurchased.Checked;
            //capture the IsGift status
            AnOrder.IsGift = chkIsGift.Checked;
            //create a new instance of the order collction
            clsOrderCollection OrderList = new clsOrderCollection();

            //if this is a new reord ci.e OrderId = -1 then add the data
            if (OrderId == -1)
            {
                //set the ThisOrder property
                OrderList.ThisOrder = AnOrder;
                //add the new record
                OrderList.Add();
            }
            //otherwise it must be an update
            else
            {
                //find the record to update
                OrderList.ThisOrder.Find(OrderId);
                //set the ThisOrder property
                OrderList.ThisOrder = AnOrder;
                //update the record
                OrderList.Update();
            }
            //navigate to the list page
            Response.Redirect("OrderList.aspx");
        }
        else
        {
            //display the error message
            lblError.Text = Error;
        }
        
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
            //display the values of the properties in the form
            txtOrderTotal.Text = AnOrder.OrderTotal.ToString();
            txtDatePlaced.Text = AnOrder.DatePlaced.ToString();
            chkPurchased.Checked = AnOrder.Purchased;
            txtDeliveryAddress.Text = AnOrder.DeliveryAddress;
            txtNoOfItems.Text = AnOrder.NoOfItems.ToString();
            chkIsGift.Checked = AnOrder.IsGift;

        }
    }

    void DisplayOrder()
    {
        //create an instance od the order book
        clsOrderCollection OrderBook = new clsOrderCollection();
        //find the record to update
        OrderBook.ThisOrder.Find(OrderId);
        //display the data for the record
        txtOrderId.Text = OrderBook.ThisOrder.OrderId.ToString();
        txtOrderTotal.Text = OrderBook.ThisOrder.OrderTotal.ToString();
        txtDatePlaced.Text = OrderBook.ThisOrder.DatePlaced.ToString();
        chkPurchased.Checked = OrderBook.ThisOrder.Purchased;
        txtDeliveryAddress.Text = OrderBook.ThisOrder.DeliveryAddress.ToString();
        txtNoOfItems.Text = OrderBook.ThisOrder.NoOfItems.ToString();
        chkIsGift.Checked = OrderBook.ThisOrder.IsGift;
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        //redirect to the list page
        Response.Redirect("OrderList.aspx");
    }
}