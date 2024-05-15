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

    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }

    protected void TextBox1_TextChanged1(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsCustomer
        clsCustomer ACustomer = new clsCustomer();
        //capture the Firstname
        ACustomer.CustomerFirstname = txtCustomerFirstname.Text;
        //capture the Lastname
        ACustomer.CustomerLastname = txtCustomerLastname.Text;
        //capture the Email
        ACustomer.CustomerEmail = txtCustomerEmail.Text;
        //capture the Birthdate
        ACustomer.CustomerBirthdate = Convert.ToDateTime(DateTime.Now);
        //capture the Phone number
        ACustomer.CustomerPhone = Convert.ToInt32(txtCustomerPhone.Text);
        //capture the verified check box
        ACustomer.Verified = chkVerified.Checked;
        //store the firstname in the session object
        Session["ACustomer"] = ACustomer;
        //navigate to the view page
        Response.Redirect("CustomerViewer.aspx");
    }

    protected void txtCustomerID_TextChanged(object sender, EventArgs e)
    {

    }

    protected void txtCustomerLastname_TextChanged(object sender, EventArgs e)
    {

    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of classa
        clsCustomer ACustomer = new clsCustomer();
        //create a variable to stoe the primary key
        Int32 CustomerID;
        //create a variable to store the result of the find option
        Boolean Found = false;
        //get the primary key entered by user
        CustomerID = Convert.ToInt32(txtCustomerID.Text);
        //find the record
        Found = ACustomer.Find(CustomerID);
        //if found
        if (Found == true) 
        {
            //display the values of the properties in the form
            txtCustomerFirstname.Text = ACustomer.CustomerFirstname;
            txtCustomerLastname.Text = ACustomer.CustomerLastname;
            txtCustomerEmail.Text = ACustomer.CustomerEmail;
            txtCustomerPhone.Text = ACustomer.CustomerPhone.ToString();
            txtCustomerBirthdate.Text = ACustomer.CustomerBirthdate.ToString();
            chkVerified.Checked = ACustomer.Verified;
        }

    }
}