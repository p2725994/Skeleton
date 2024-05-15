using System;
using ClassLibrary;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }


    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsStaff
        clsStaff AStaff = new clsStaff();

        //capture Staff Number
        string StaffNo = txtStaffNo.Text;

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

            //Store the Staff in the session object
            Session["AStaff"] = AStaff;

            //navigate to the view page
            Response.Redirect("StaffViewer.aspx");
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
}