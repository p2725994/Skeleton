using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class StockLogin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //if this  is the first time the page is displayed
        if (!IsPostBack == false)
        {
            //update the list box
            DisplayStocks();
        }
        //create an instance of the stock user class
        clsStockUser AnUser = new clsStockUser();
        //get data from the session object
        AnUser = (clsStockUser)Session["AnUser"];
        //display the user name
        Response.Write("logged in as;"+ AnUser.UserName);
        
    }

    private void DisplayStocks()
    {
        throw new NotImplementedException();
    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        //create an instance of the stock user class
        clsStockUser AnUser = new clsStockUser();

        //create the variable to store the UserName and Password
        string UserName = txtUserName.Text;
        string Password = txtPassword.Text;

        //create a Boolean variable to store the results of the find user operation
        Boolean Found = false;

        //get the UserName entered by the user
        UserName = Convert.ToString(txtUserName.Text);

        //get the Password entered by the user
        Password = Convert.ToString(txtPassword.Text);

        //find the record
        Found = AnUser.FindUser(UserName, Password);
        //Add a session to capture the user name
        Session["AnUser"] = AnUser;

        //if Username/Password is empty
        if (txtUserName.Text == "")
        {
            //record the error
            lblError.Text = "Enter a UserName";
        }
        else if (txtPassword.Text == "")
        {
            //record the error
            lblError.Text = "Enter a Password";
        }
        //if found
        else if (Found == true)
        {
            //redirect to the List page
            Response.Redirect("StockList.aspx");
        }
        else if (Found == false)
        {
            //record the error
            lblError.Text = "Login details are incorrect. Please try again! ";
        }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        //redirect to the main menu
        Response.Redirect("TeamMainMenu.aspx");
    }
}