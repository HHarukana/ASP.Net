using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class Controls_ContactManager : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        lblPerson_ID.Visible = false;

        string strPer_ID = "";
        int intPer_ID = 0;

        if ((!IsPostBack) && Request.QueryString["Per_ID"] != null)
        {

            strPer_ID = Request.QueryString["Per_ID"].ToString();
            lblPerson_ID.Text = strPer_ID;

            intPer_ID = Convert.ToInt32(strPer_ID);

            PersonV2 temp = new PersonV2();

            SqlDataReader dr = temp.FindAPerson(intPer_ID);

            while (dr.Read())
            {
                txtFName.Text = dr["FirstName"].ToString();
                txtMName.Text = dr["MiddleName"].ToString();
                txtLName.Text = dr["LastName"].ToString();
                txtStreet.Text = dr["Street"].ToString();
                txtCity.Text = dr["City"].ToString();
                txtState.Text = dr["State"].ToString();
                txtZip.Text = dr["Zip"].ToString();
                txtNum.Text = dr["Number"].ToString();
                txtMail.Text = dr["EMail"].ToString();
            }

        }

        else
        {
            //Nothing
        }



        if (Session["LoggedIn"] != null && Session["LoggedIn"].ToString() == "TRUE")
        {
            //keep them where they are
        }

        else
        {
            Response.Redirect("default.aspx");
        }


    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        PersonV2 input = new PersonV2();

        if (Validator.gotBadWords(txtFName.Text) == false && Validator.IsitFilledin(txtFName.Text) == true)

        {
            input.PersonFirst = txtFName.Text;
            
        }

        else
        {
            lblFeedback.Text = "Validation Failed Try again.";
            return;

        }


        if (Validator.gotBadWords(txtMName.Text) == false)

        {


            input.PersonMiddle = txtMName.Text;
            


        }

        else
        {
            lblFeedback.Text = "Validation Failed Try again.";
            return;
        }

        if (Validator.gotBadWords(txtLName.Text) == false && Validator.IsitFilledin(txtLName.Text) == true)

        {


            input.PersonLast = txtLName.Text;
            


        }

        else
        {
            lblFeedback.Text = "Validation Failed Try again.";
            return;
        }

        if (Validator.gotBadWords(txtStreet.Text) == false && Validator.IsitFilledin(txtStreet.Text) == true)

        {


            input.PersonStreet = txtStreet.Text;
            


        }

        else
        {
            lblFeedback.Text = "Validation Failed Try again.";
            return;
        }

        if (Validator.gotBadWords(txtCity.Text) == false && Validator.IsitFilledin(txtCity.Text) == true)

        {


            input.PersonCity = txtCity.Text;
            


        }

        else
        {
            lblFeedback.Text = "Validation Failed Try again.";
            return;
        }

        if (Validator.gotBadWords(txtState.Text) == false && Validator.IsitFilledin(txtState.Text) == true)

        {


            input.PersonState = txtState.Text;
            


        }

        else
        {
            lblFeedback.Text = "Validation Failed Try again.";
            return;

        }

        if (Validator.gotBadWords(txtZip.Text) == false && Validator.IsitFilledin(txtZip.Text) == true)

        {


            input.PersonZip = txtZip.Text;
            


        }

        else
        {
            lblFeedback.Text = "Validation Failed Try again.";
            return;
        }

        if (Validator.gotBadWords(txtNum.Text) == false && Validator.IsitFilledin(txtNum.Text) == true)

        {


            input.PersonNum = txtNum.Text;
            


        }

        else
        {
            lblFeedback.Text = "Validation Failed Try again.";
            return;
        }

        if (Validator.gotBadWords(txtMail.Text) == false && Validator.IsitFilledin(txtMail.Text) == true)

        {


            input.PersonMail = txtMail.Text;
            


        }

        else
        {
            lblFeedback.Text = "Validation Failed Try again.";
            return;
        }

        lblFeedback.Text = input.AddARecord();
    }

    protected void btnUpdate_Click(object sender, EventArgs e)
    {

        PersonV2 input = new PersonV2();
        input.Person_ID = Convert.ToInt32(lblPerson_ID.Text);

        if (Validator.gotBadWords(txtFName.Text) == false)

        {
            
            input.PersonFirst = txtFName.Text;
            
        }

        else
        {
            lblFeedback.Text = "Update Failed Try again.";
            
        }

        if (Validator.gotBadWords(txtMName.Text) == false)

        {

            
            input.PersonMiddle = txtMName.Text;

            
        }

        else
        {
            lblFeedback.Text = "Update Failed Try again.";

        }

        if (Validator.gotBadWords(txtLName.Text) == false)

        {


            input.PersonLast = txtLName.Text;
   
            
        }

        else
        {
            lblFeedback.Text = "Update Failed Try again.";

        }

        if (Validator.gotBadWords(txtStreet.Text) == false)

        {

            input.PersonStreet = txtStreet.Text;

            
        }

        else
        {
            lblFeedback.Text = "Update Failed Try again.";

        }

        if (Validator.gotBadWords(txtCity.Text) == false)

        {

            input.PersonCity = txtCity.Text;

        }

        else
        {
            lblFeedback.Text = "Update Failed Try again.";

        }

        if (Validator.gotBadWords(txtState.Text) == false)

        {

            input.PersonState = txtState.Text;

            
        }

        else
        {
            lblFeedback.Text = "Update Failed Try again.";

        }

        if (Validator.gotBadWords(txtZip.Text) == false)

        {

            input.PersonZip = txtZip.Text;

            
        }

        else
        {
            lblFeedback.Text = "Update Failed Try again.";

        }

        if (Validator.gotBadWords(txtNum.Text) == false)

        {

            input.PersonNum = txtNum.Text;

            
        }

        else
        {
            lblFeedback.Text = "Update Failed Try again.";

        }

        if (Validator.gotBadWords(txtMail.Text) == false)

        {

            input.PersonMail = txtMail.Text;
            
        }

        else
        {
            lblFeedback.Text = "Update Failed Try again.";

        }

        lblFeedback.Text = input.UpdateAPerson(1).ToString() + " Records Updated!";

    }


    protected void btnDelete_Click(object sender, EventArgs e)
    {

        PersonV2 input = new PersonV2();
        input.Person_ID = Convert.ToInt32(lblPerson_ID.Text);

        lblFeedback.Text = input.DeleteAPerson(1).ToString() + " Person Deleted";

    }
}

   