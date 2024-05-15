using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create a new instance of clsCustomer
        clsCustomer ACustomer = new clsCustomer();
        //get data from session object
        ACustomer = (clsCustomer)Session["ACustomer"];
        //display the firstname for this entry
        Response.Write(ACustomer.CustomerFirstname);        
        //display last name for this entry
        Response.Write(ACustomer.CustomerLastname);
        //display birthdate for this entry
        Response.Write(ACustomer.CustomerBirthdate);
        //display Phone for this entry
        Response.Write(ACustomer.CustomerPhone);
        //display email for this entry
        Response.Write(ACustomer.CustomerEmail);



    }
}