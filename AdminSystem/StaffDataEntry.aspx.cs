using System;
using ClassLibrary;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class _1_DataEntry : System.Web.UI.Page
{
    //variable to store PK with page level scope
    Int32 StaffNo;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the staff to be processed
        StaffNo = Convert.ToInt32(Session["StaffNo"]);
        if (IsPostBack == false)
        {
            //if this is not a new record
            if (StaffNo != -1)
            {
                //display the current data for the record
                DisplayStaff();
            }
        }
    }

    void DisplayStaff()
    {
        //create an instance of Staff Book
        clsStaffCollection StaffBook = new clsStaffCollection();

        //find the record to update
        StaffBook.ThisStaff.Find(StaffNo);

        //display the data for the record
        txtStaffNo.Text =        StaffBook.ThisStaff.StaffNo.ToString();
        txtStaffFirstname.Text = StaffBook.ThisStaff.StaffFirstname.ToString();
        txtStaffSurname.Text =   StaffBook.ThisStaff.StaffSurname.ToString();
        txtStaffEmail.Text =     StaffBook.ThisStaff.StaffEmail.ToString();
        txtStaffPassword.Text =  StaffBook.ThisStaff.StaffPassword.ToString();
        txtDateJoined.Text =     StaffBook.ThisStaff.DateJoined.ToString();
        chkIsOnShift.Checked =   StaffBook.ThisStaff.IsOnShift;
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsStaff
        clsStaff AStaff = new clsStaff();

        //capture staff firstname
        string StaffFirstname = txtStaffFirstname.Text;

        //capture staff surname
        string StaffSurname = txtStaffSurname.Text;

        //capture staff email
        string StaffEmail = txtStaffEmail.Text;

        //capture staff password
        string StaffPassword = txtStaffPassword.Text;

        //capture date joined
        string DateJoined =txtDateJoined.Text;

        //capture Is On Shift check box
        string IsOnShift = chkIsOnShift.Text;

        //variable to store any error messages
        string Error = "";

        //validate data
        Error = AStaff.Valid(StaffFirstname, StaffSurname, StaffEmail, StaffPassword, DateJoined);
        if (Error == "")
        {
            //capturethe StaffNo
            AStaff.StaffNo = StaffNo;

            //capture staff name
            AStaff.StaffFirstname = StaffFirstname;

            //capture staff surname
            AStaff.StaffSurname = StaffSurname;

            //capture staff email
            AStaff.StaffEmail = StaffEmail;

            //capture staff password
            AStaff.StaffPassword = StaffPassword;

            //capture date joined
            AStaff.DateJoined = Convert.ToDateTime(DateJoined);

            //capture is on shift
            AStaff.IsOnShift =chkIsOnShift.Checked;

            //create a new instance of the staff collection
            clsStaffCollection StaffList = new clsStaffCollection();

            //if this is a new record
            if (StaffNo == -1)
            {
                //set the ThisStaff property
                StaffList.ThisStaff = AStaff;

                //add the new record
                StaffList.Add();
            }
            //otherwise it must be an update
            else
            {
                //find the record to update
                StaffList.ThisStaff.Find(StaffNo);

                //set the ThisStaff property
                StaffList.ThisStaff = AStaff;

                //add the new record
                StaffList.Update();
            }
            //redirect back to the list page
            Response.Redirect("StaffList.aspx");
        }
        else
        {
            //display the error message
            lblError.Text = Error;
        }

    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the staff class
        clsStaff aStaff = new clsStaff();
        //create variable to store primary key
        Int32 StaffNo;
        //create a Boolean variable to store the results of the find operation
        Boolean Found = false;
        //get the primary key entered by the user
        StaffNo = Convert.ToInt32(txtStaffNo.Text);
        //find the record
        Found = aStaff.Find(StaffNo);
        //if found
        if (Found == true)
        {
            //display the values of the properties in the form
            txtStaffFirstname.Text = aStaff.StaffFirstname;
            txtStaffSurname.Text = aStaff.StaffSurname;
            txtStaffEmail.Text = aStaff.StaffEmail;
            txtStaffPassword.Text = aStaff.StaffPassword;
            txtDateJoined.Text = aStaff.DateJoined.ToString();
            chkIsOnShift.Checked = aStaff.IsOnShift;

        }

    }

    protected void btnMenu_Click(object sender, EventArgs e)
    {
        //redirect to the main menu page
        Response.Redirect("TeamMainMenu.aspx");
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        //redirect to the main menu page
        Response.Redirect("StaffList.aspx");
    }
}