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

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //variable to store the PK value of the record to be edited
        Int32 StaffNo;

        //if a record has been selected from the list
        if (lstStaffList.SelectedIndex != -1) 
        {
            //get the PK value of the record to edit
            StaffNo = Convert.ToInt32(lstStaffList.SelectedValue);

            //store the data in te sesision object
            Session["StaffNo"] = StaffNo;

            //redirect to the edit page
            Response.Redirect("StaffDataEntry.aspx");
        }
        else //if no record has been recorded 
        {
            lblError.Text = "Please select a record from the list to edit.";
        }

        /*
         *  1.	First check to see if the list has been selected. 
            2.	If it has, pick up the primary key value via the SelectedValue property of the list box.
            3.	Assuming it has we then place the primary key value into the session object.
            4.	Then we redirect to the page AnAddress.aspx.
            5.	The error label will display a message to the user if a list item hasn’t been selected.
         */
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //variable to store the PK value of the record to be edited
        Int32 StaffNo;

        //if a record has been selected from the list
        if (lstStaffList.SelectedIndex != -1)
        {
            //get the PK value of the record to edit
            StaffNo = Convert.ToInt32(lstStaffList.SelectedValue);

            //store the data in te sesision object
            Session["StaffNo"] = StaffNo;

            //redirect to the edit page
            Response.Redirect("StaffConfirmDelete.aspx");
        }
        else //if no record has been recorded 
        {
            lblError.Text = "Please select a record from the list to delete.";
        }

    }

    protected void btnApplyFilter_Click(object sender, EventArgs e)
    {
        //create an instance of Staff Collection
        clsStaffCollection AStaff = new clsStaffCollection();

        //retrieve the value of email in the presentation layer
        AStaff.ReportByEmail(txtFilter.Text);

        //set the data source to the list of emails in the collection
        lstStaffList.DataSource = AStaff.StaffList;

        //set the name of the PK
        lstStaffList.DataValueField = "StaffNo";

        //set the name of the field
        lstStaffList.DataTextField = "StaffEmail";

        //bind the data to the list
        lstStaffList.DataBind();
    }


    protected void btnClearFilter_Click(object sender, EventArgs e)
    {
        //create an instance of Staff Collection
        clsStaffCollection AStaff = new clsStaffCollection();

        //set an empty string
        AStaff.ReportByEmail("");

        //clear any existing filter to tidy up the interface
        txtFilter.Text = "";

        //set the data source to the list of emails in the collection
        lstStaffList.DataSource = AStaff.StaffList;

        //set the name of the PK
        lstStaffList.DataValueField = "StaffNo";

        //set the name of the field
        lstStaffList.DataTextField = "StaffEmail";

        //bind the data to the list
        lstStaffList.DataBind();
    }
}