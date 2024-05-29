using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    Int32 CustomerID;
    protected void Page_Load(object sender, EventArgs e)
    {
        CustomerID = Convert.ToInt32(Session["CustomerID"]);
        if (IsPostBack == false)
        {
            if (CustomerID != -1)
            {
                DisplayCustomer();
            }
        }
    }

    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }

    protected void TextBox1_TextChanged1(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        clsCustomer ACustomer = new clsCustomer();
        string CustomerFirstname = txtCustomerFirstname.Text;
        string CustomerLastname = txtCustomerLastname.Text;
        string CustomerEmail = txtCustomerEmail.Text;
        string CustomerPhone = txtCustomerPhone.Text;
        string CustomerBirthdate = txtCustomerBirthdate.Text;
        string Verified = chkVerified.Text;
        string Error = "";
        Error = ACustomer.Valid(CustomerFirstname, CustomerLastname, CustomerEmail, CustomerBirthdate, CustomerPhone);

        if (Error == "")
        { 
            ACustomer.CustomerID = CustomerID;
            //capture the Firstname
            ACustomer.CustomerFirstname = CustomerFirstname;
            //capture the Lastname
            ACustomer.CustomerLastname = CustomerLastname;
            //capture the Email
            ACustomer.CustomerEmail = CustomerEmail;
            //capture the Birthdate
            ACustomer.CustomerBirthdate = Convert.ToDateTime(CustomerBirthdate);
            //capture the Phone number
            ACustomer.CustomerPhone = Convert.ToInt32(CustomerPhone);
            //capture verification
            ACustomer.Verified = chkVerified.Checked;
            clsCustomerCollection CustomerList = new clsCustomerCollection();

            if (CustomerID == -1)
                {
                CustomerList.ThisCustomer = ACustomer;
                CustomerList.Add();
            }

            else
            {
                CustomerList.ThisCustomer.Find(CustomerID);
                CustomerList.ThisCustomer = ACustomer;
                CustomerList.Update();
            }
            Response.Redirect("CustomerList.aspx");
        }
        else
        {
            //display error mesg
            lblError.Text = Error;
        }
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

        void DisplayCustomer()
        {
            clsCustomerCollection Customer = new clsCustomerCollection();
            Customer.ThisCustomer.Find(CustomerID); 
            txtCustomerID.Text = Customer.ThisCustomer.CustomerID.ToString();
            txtCustomerFirstname.Text = Customer.ThisCustomer.CustomerFirstname.ToString();
            txtCustomerLastname.Text = Customer.ThisCustomer.CustomerLastname.ToString();
            txtCustomerEmail.Text = Customer.ThisCustomer.CustomerEmail.ToString();
            txtCustomerPhone.Text = Customer.ThisCustomer.CustomerPhone.ToString();
            txtCustomerBirthdate.Text = Customer.ThisCustomer.CustomerBirthdate.ToString();
            chkVerified.Checked = Customer.ThisCustomer.Verified;
        }

    }