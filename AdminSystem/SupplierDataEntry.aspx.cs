using System;
using ClassLibrary;
using System.Activities.Expressions;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class _1_DataEntry : System.Web.UI.Page
{
    public int SupplierId { get; private set; }

    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of supplier to be processed
        SupplierId = Convert.ToInt32(Session["SupplierId"]);
        if (IsPostBack == false)
        {
            //if this is not a new record
            if (SupplierId != -1)
            {
                DisplaySupplier();
            }
        }

    }

    protected void btnOK_Click1(object sender, EventArgs e)
    {
        //create a new instance of clsSupplier
        clsSupplier ASupplier = new clsSupplier();


        string SupplierName = txtSupplierName.Text;
        string SupplierEmail = txtSupplierEmail.Text;
        string SupplierAddress = txtSupplierAddress.Text;
        string SupplierProduct = txtSupplierProduct.Text;
        string SupplierDeliveryDate = txtSupplierDeliveryDate.Text;
        string SupplierFromUk = chkSupplierFromUk.Text;

        string Error = "";
        Error = ASupplier.Valid(SupplierName, SupplierEmail, SupplierProduct, SupplierAddress, SupplierDeliveryDate);
        if (Error == "")
        {
            //capture the data 
            ASupplier.SupplierId = SupplierId;
            ASupplier.SupplierName = SupplierName;
            ASupplier.SupplierEmail = SupplierEmail;
            ASupplier.SupplierProducts = SupplierProduct;
            ASupplier.SupplierAddress = SupplierAddress;
            ASupplier.SupplierDeliveryDate = Convert.ToDateTime(SupplierDeliveryDate);
            ASupplier.SupplierFromUk = chkSupplierFromUk.Checked;
            clsSupplierCollection SupplierList = new clsSupplierCollection();
            //set the ThisSupplier Property

            if (SupplierId == -1)
            {
                SupplierList.ThisSupplier = ASupplier;
                //add the new record
                SupplierList.Add();

            }
            else//find the record to update
            {
                SupplierList.ThisSupplier.Find(SupplierId);
                SupplierList.ThisSupplier = ASupplier;
                SupplierList.Update();

            }


          
            Response.Redirect("SupplierList.aspx");

        }
        else
        {
            lblError.Text = Error;  

        }
    }


        protected void btnCancel_Click(object sender, EventArgs e)
        {

        }

        protected void btnFind_Click(object sender, EventArgs e)
        {
            //create an instance of the supplier class
            clsSupplier ASupplier = new clsSupplier();
            // create a varibale to store the primary key
            Int32 SupplierId;
            //create a vairable to store the result of the find operation
            Boolean Found = false;

            SupplierId = Convert.ToInt32(txtSupplierId.Text);
            //find the record
            Found = ASupplier.Find(SupplierId);
            //if found
            if (Found == true)
            {
                txtSupplierName.Text = ASupplier.SupplierName;
                txtSupplierEmail.Text = ASupplier.SupplierEmail;
                txtSupplierProduct.Text = ASupplier.SupplierProducts;
                txtSupplierAddress.Text = ASupplier.SupplierAddress;
                txtSupplierDeliveryDate.Text = ASupplier.SupplierDeliveryDate.ToString();
                chkSupplierFromUk.Checked = ASupplier.SupplierFromUk;


            }



        }
    protected void DisplaySupplier()
    { //create an instance of the address book 
        clsSupplierCollection Supplier =new clsSupplierCollection();
        //find the record to update 
        Supplier.ThisSupplier.Find(SupplierId);
        txtSupplierId.Text =Supplier.ThisSupplier.SupplierId.ToString();
        txtSupplierName.Text = Supplier.ThisSupplier.SupplierName.ToString();
        txtSupplierEmail.Text = Supplier.ThisSupplier.SupplierEmail.ToString();
        txtSupplierProduct.Text = Supplier.ThisSupplier.SupplierProducts.ToString();
        txtSupplierAddress.Text = Supplier.ThisSupplier.SupplierAddress.ToString();
        chkSupplierFromUk.Checked = Supplier.ThisSupplier.SupplierFromUk;
        txtSupplierDeliveryDate.Text = Supplier.ThisSupplier.SupplierDeliveryDate.ToString();

        //display the data fot the record
    }

    }
