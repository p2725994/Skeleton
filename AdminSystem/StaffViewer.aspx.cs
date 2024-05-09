using System;
using ClassLibrary;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create a new instance of clsStaff
        clsStaff AStaff = new clsStaff();

        //get the data from the session object
        AStaff = (clsStaff)Session["AStaff"];

        //display the staff Number
        Response.Write(AStaff.StaffNo + "\n\n");

        //display the staff Firstname
        Response.Write(AStaff.StaffFirstname + "\n\n");

        //display the staff Surname
        Response.Write(AStaff.StaffSurname + "\n\n");

        //display the staff Email
        Response.Write(AStaff.StaffEmail + "\n\n");

        //display the staff Password
        Response.Write(AStaff.StaffPassword + "\n\n");

        //display the staff Date Joined
        Response.Write(AStaff.DateJoined + "\n\n");

        //display the staff's shift
        Response.Write(AStaff.IsOnShift + "\n\n");

    }
}