using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    //variable to store the PK value of the record to be deleted
    Int32 StaffNo;

    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the staff to be deleted from the session object
        StaffNo = Convert.ToInt32(Session["StaffNo"]);
    }
    protected void btnNo_Click(object sender, EventArgs e)
    {
        //redirect back to the main page
        Response.Redirect("StaffList.aspx");
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        //create a new instance of the staff book collection class
        clsStaffCollection StaffBook = new clsStaffCollection();

        StaffBook.ThisStaff.Find(StaffNo);

        //find the record to delete
        StaffBook.Delete();

        //redirect back to the main page
        Response.Redirect("StaffList.aspx");
    }
}