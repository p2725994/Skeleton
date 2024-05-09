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
        AStaff.StaffNo = Convert.ToInt32(txtStaffNo.Text);

        //capture staff firstname
        AStaff.StaffFirstname = txtStaffFirstname.Text;

        //capture staff surname
        AStaff.StaffSurname = txtStaffSurname.Text;

        //capture staff email
        AStaff.StaffEmail = txtStaffEmail.Text;

        //capture staff password
        AStaff.StaffPassword = txtStaffPassword.Text;

        //capture date joined
        AStaff.DateJoined = Convert.ToDateTime(DateTime.Now);
        
        //capture Is On Shift check box
        AStaff.IsOnShift = chkIsOnShift.Checked;

        //Store the Staff in the session object
        Session["AStaff"] = AStaff;

        //navigate to the view page
        Response.Redirect("StaffViewer.aspx");
    }
}