using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class PlotPreOrder : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        lblPlot_ID.Visible = false;
        string strPlot_ID = "";
        int intPlot_ID = 0;
        txtcurrDate.Text = DateTime.Now.ToString("MM-dd-yyy");

        if ((!IsPostBack) && Request.QueryString["Plot_ID"] != null)
        {

            strPlot_ID = Request.QueryString["Per_ID"].ToString();
            lblPlot_ID.Text = strPlot_ID;

            intPlot_ID = Convert.ToInt32(strPlot_ID);

            Plot temp = new Plot();

            SqlDataReader dr = temp.FindAPlot(intPlot_ID);

            while (dr.Read())
            {
                txtcurrDate.Text = dr["currDate"].ToString();
                //are dropdowns done this way?
                ddcemetary.Text = dr["cemetary"].ToString();
                txtfirstName.Text = dr["firstNamee"].ToString();
                txtmiddleName.Text = dr["middleName"].ToString();
                txtlastName.Text = dr["lastName"].ToString();
                ddtitle.Text = dr["title"].ToString();
                //How do I do Calendar dates here?
                calDOB.SelectedDate = dr["DOB"].ToDateString();
                calDOD.SelectedDate = dr["DOD"].ToDateString();
                checkVet.Text = dr["vet"].ToString();
                ddbranch.Text = dr["branch"].ToString();
                ddstone.Text = dr["stone"].ToString();
                txtnote.Text = dr["note"].ToString();
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
            Response.Redirect("~Controls/Default.aspx");
        }
    }



    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Plot input = new Plot();

        if (Validator.gotBadWords(txtcurrDate.Text) == false && Validator.IsitFilledin(txtcurrDate.Text) == true)

        {
            input.CurrDate = txtcurrDate.Text;

        }

        else
        {
            lblFeedback.Text = "Validation Failed Try again.";
            return;

        }


        if (Validator.gotBadWords(ddcemetary.Text) == false
            && Validator.IsitFilledin(txtcurrDate.Text) == true)

        {


            input.Cemetary = ddcemetary.Text;



        }

        else
        {
            lblFeedback.Text = "Validation Failed Try again.";
            return;
        }

        if (Validator.gotBadWords(txtfirstName.Text) == false && Validator.IsitFilledin(txtfirstName.Text) == true)

        {


            input.FirstName = txtfirstName.Text;



        }

        else
        {
            lblFeedback.Text = "Validation Failed Try again.";
            return;
        }

        if (Validator.gotBadWords(txtmiddleName.Text) == false)

        {


            input.MiddleName = txtmiddleName.Text;



        }

        else
        {
            lblFeedback.Text = "Validation Failed Try again.";
            return;
        }

        if (Validator.gotBadWords(txtlastName.Text) == false && Validator.IsitFilledin(txtlastName.Text) == true)

        {


            input.LastName = txtlastName.Text;



        }

        else
        {
            lblFeedback.Text = "Validation Failed Try again.";
            return;
        }

        if (Validator.gotBadWords(ddtitle.Text) == false && Validator.IsitFilledin(ddtitle.Text) == true)

        {


            input.Title = ddtitle.Text;



        }

        else
        {
            lblFeedback.Text = "Validation Failed Try again.";
            return;

        }

        //Not sure how to Validate with CalDOB.SelectedDate, See line 41
        if (Validator.gotBadWords(calDOB.SelectedDate) == false && Validator.IsitFilledin(calDOB.SelectedDate) == true)

        {


            input.DateOB = calDOB.SelectedDate;



        }

        else
        {
            lblFeedback.Text = "Validation Failed Try again.";
            return;
        }

        if (Validator.gotBadWords(calDOD.SelectedDate) == false && Validator.IsitFilledin(calDOD.SelectedDate) == true)

        {


            input.DateOD = calDOD.SelectedDate;



        }

        else
        {
            lblFeedback.Text = "Validation Failed Try again.";
            return;
        }

        //not sure how to run check boxes
        if (Validator.gotBadWords(checkVet.Text) == false && Validator.IsitFilledin(checkVet.Text) == true)

        {


            input.Vet = checkVet.Text;



        }

        else
        {
            lblFeedback.Text = "Validation Failed Try again.";
            return;
        }

        if (Validator.gotBadWords(ddbranch.Text) == false)

        {


            input.Branch = ddbranch.Text;



        }

        else
        {
            lblFeedback.Text = "Validation Failed Try again.";
            return;
        }

        if (Validator.gotBadWords(ddstone.Text) == false && Validator.IsitFilledin(ddstone.Text) == true)

        {


            input.Stone = ddstone.Text;



        }

        else
        {
            lblFeedback.Text = "Validation Failed Try again.";
            return;
        }

        if (Validator.gotBadWords(txtnote.Text) == false)

        {


            input.Note = txtnote.Text;



        }

        else
        {
            lblFeedback.Text = "Validation Failed Try again.";
            return;
        }



        lblFeedback.Text = input.AddAPlot();
    }

    protected void btnUpdate_Click(object sender, EventArgs e)
    {
       /* Plot input = new Plot();
        input.Plot_ID = Convert.ToInt32(lblPlot_ID.Text)

        if (Validator.gotBadWords(txtcurrDate.Text) == false && Validator.IsitFilledin(txtcurrDate.Text) == true)

        {
            input.CurrDate = txtcurrDate.Text;

        }

        else
        {
            lblFeedback.Text = "Update Failed Try again.";
            

        }


        if (Validator.gotBadWords(ddcemetary.Text) == false
            && Validator.IsitFilledin(txtcurrDate.Text) == true)

        {


            input.Cemetary = ddcemetary.Text;



        }

        else
        {
            lblFeedback.Text = "Update Failed Try again.";
            
        }

        if (Validator.gotBadWords(txtfirstName.Text) == false && Validator.IsitFilledin(txtfirstName.Text) == true)

        {


            input.FirstName = txtfirstName.Text;



        }

        else
        {
            lblFeedback.Text = "Update Failed Try again.";
            
        }

        if (Validator.gotBadWords(txtmiddleName.Text) == false)

        {


            input.MiddleName = txtmiddleName.Text;



        }

        else
        {
            lblFeedback.Text = "Update Failed Try again.";
            
        }

        if (Validator.gotBadWords(txtlastName.Text) == false && Validator.IsitFilledin(txtlastName.Text) == true)

        {


            input.LastName = txtlastName.Text;



        }

        else
        {
            lblFeedback.Text = "Update Failed Try again.";
            
        }

        if (Validator.gotBadWords(ddtitle.Text) == false && Validator.IsitFilledin(ddtitle.Text) == true)

        {


            input.Title = ddtitle.Text;



        }

        else
        {
            lblFeedback.Text = "Update Failed Try again.";
            

        }

        //Not sure how to Validate with CalDOB.SelectedDate, See line 41
        if (Validator.gotBadWords(calDOB.SelectedDate) == false && Validator.IsitFilledin(calDOB.SelectedDate) == true)

        {


            input.DateOB = calDOB.SelectedDate;



        }

        else
        {
            lblFeedback.Text = "Update Failed Try again.";
            
        }

        if (Validator.gotBadWords(calDOD.SelectedDate) == false && Validator.IsitFilledin(calDOD.SelectedDate) == true)

        {


            input.DateOD = calDOD.SelectedDate;



        }

        else
        {
            lblFeedback.Text = "Update Failed Try again.";
            
        }

        //not sure how to run check boxes
        if (Validator.gotBadWords(checkVet.Text) == false && Validator.IsitFilledin(checkVet.Text) == true)

        {


            input.Vet = checkVet.Text;



        }

        else
        {
            lblFeedback.Text = "Update Failed Try again.";
            
        }

        if (Validator.gotBadWords(ddbranch.Text) == false)

        {


            input.Branch = ddbranch.Text;



        }

        else
        {
            lblFeedback.Text = "Update Failed Try again.";
            
        }

        if (Validator.gotBadWords(ddstone.Text) == false && Validator.IsitFilledin(ddstone.Text) == true)

        {


            input.Stone = ddstone.Text;



        }

        else
        {
            lblFeedback.Text = "Update Failed Try again.";
            
        }

        if (Validator.gotBadWords(txtnote.Text) == false)

        {


            input.Note = txtnote.Text;



        }

        else
        {
            lblFeedback.Text = "Update Failed Try again.";
            
        }

        lblFeedback.Text = input.UpdateAPlot(1).ToString() + " Plot Updated!";*/
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Plot input = new Plot();
        input.Plot_ID = Convert.ToInt32(lblPlot_ID.Text);

        lblFeedback.Text = input.DeleteAPlot(1).ToString() + " Person Deleted";
    }

    
}