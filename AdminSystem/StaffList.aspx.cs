using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //if this is the first time the pafe is displaying
        if (IsPostBack == false) 
        {
            //update the list box
            DisplayStaffs();
        }

    }

    private void DisplayStaffs()
    {
        //create an instance of Staff Collection
        clsStaffCollection Staffs = new clsStaffCollection();

        //set the data source to list of Staff in collection
        lstStaffList.DataSource = Staffs.StaffList;

        //set the name of primary key
        lstStaffList.DataValueField = "StaffNo";

        //set the data field to display
        lstStaffList.DataTextField = "StaffEmail";

        //bind the data to the list
        lstStaffList.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 in the session object to indicate is a new session
        Session["StaffNo"] = -1;

        //redirect to the data entry page
        Response.Redirect("StaffDataEntry.aspx");

    }
}