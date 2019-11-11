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
        txtcurrDate.Text = DateTime.Now.ToShortDateString();

        if (Session["LoggedIn"] != null && Session["LoggedIn"].ToString() == "TRUE")
        {
            //keep them where they are
        }

        else
        {
            Response.Redirect("Default.aspx");
        }

        if ((!IsPostBack) && Request.QueryString["Plot_ID"] != null)
        {

            strPlot_ID = Request.QueryString["Plot_ID"].ToString();
            lblPlot_ID.Text = strPlot_ID;

            intPlot_ID = Convert.ToInt32(strPlot_ID);

            Plot temp = new Plot();

            SqlDataReader dr = temp.FindAPlot(intPlot_ID);

            while (dr.Read())
            {
                txtcurrDate.Text = dr["currDate"].ToString();
                ddcemetary.SelectedValue = dr["cemetary"].ToString();
                txtfirstName.Text = dr["firstName"].ToString();
                txtmiddleName.Text = dr["middleName"].ToString();
                txtlastName.Text = dr["lastName"].ToString();
                ddtitle.SelectedValue = dr["title"].ToString();
                txtCalDOB.Text = dr["DOB"].ToString();
                txtCalDOD.Text = dr["DOD"].ToString();

                if (Convert.ToBoolean(dr["vet"]))
                {
                    checkVet.Checked = true;
                }
                
                ddbranch.SelectedValue = dr["branch"].ToString();
                ddstone.SelectedValue = dr["stone"].ToString();
                txtnote.Text = dr["note"].ToString();
            }

        }

        else
        {
            //Nothing
        }


        
    }


    protected void calDOB_SelectionChanged(object sender, EventArgs e)
    {
        txtCalDOB.Text = calDOB.SelectedDate.ToShortDateString();
    }

    protected void calDOD_SelectionChanged(object sender, EventArgs e)
    {
        txtCalDOD.Text = calDOD.SelectedDate.ToShortDateString();
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


        if (Validator.gotBadWords(ddcemetary.SelectedValue) == false
            && Validator.IsitFilledin(ddcemetary.SelectedValue) == true)

        {


            input.Cemetary = ddcemetary.SelectedValue;



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

        if (Validator.gotBadWords(ddtitle.SelectedValue) == false && Validator.IsitFilledin(ddtitle.SelectedValue) == true)

        {


            input.Title = ddtitle.SelectedValue;



        }

        else
        {
            lblFeedback.Text = "Validation Failed Try again.";
            return;

        }

        
        if (Validator.gotBadWords(txtCalDOB.Text) == false && Validator.IsitFilledin(txtCalDOB.Text) == true)

        {


            input.DateOB = txtCalDOB.Text;



        }

        else
        {
            lblFeedback.Text = "Validation Failed Try again.";
            return;
        }

        if (Validator.gotBadWords(txtCalDOD.Text) == false && Validator.IsitFilledin(txtCalDOD.Text) == true)

        {


            input.DateOD = txtCalDOD.Text;



        }

        else
        {
            lblFeedback.Text = "Validation Failed Try again.";
            return;
        }

        //not sure how to run check boxes
        if (checkVet.Checked)

        {

            input.Vet = checkVet.Checked;

        }

        else
        {
            input.Vet = false;
        }

        if (Validator.gotBadWords(ddbranch.SelectedValue) == false)

        {


            input.Branch = ddbranch.SelectedValue;



        }

        else
        {
            lblFeedback.Text = "Validation Failed Try again.";
            return;
        }

        if (Validator.gotBadWords(ddstone.SelectedValue) == false && Validator.IsitFilledin(ddstone.SelectedValue) == true)

        {


            input.Stone = ddstone.SelectedValue;



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
         Plot input = new Plot();
        input.Plot_ID = Convert.ToInt32(lblPlot_ID.Text);

         if (Validator.gotBadWords(txtcurrDate.Text) == false && Validator.IsitFilledin(txtcurrDate.Text) == true)

         {
             input.CurrDate = txtcurrDate.Text;

         }

         else
         {
             lblFeedback.Text = "Update Failed Try again.";


         }


         if (Validator.gotBadWords(ddcemetary.SelectedValue) == false
             && Validator.IsitFilledin(ddcemetary.SelectedValue) == true)

         {


             input.Cemetary = ddcemetary.SelectedValue;



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

         if (Validator.gotBadWords(ddtitle.SelectedValue) == false && Validator.IsitFilledin(ddtitle.SelectedValue) == true)

         {


             input.Title = ddtitle.SelectedValue;



         }

         else
         {
             lblFeedback.Text = "Update Failed Try again.";


         }

         
         if (Validator.gotBadWords(txtCalDOB.Text) == false && Validator.IsitFilledin(txtCalDOB.Text) == true)

         {


             input.DateOB = txtCalDOB.Text;



         }

         else
         {
             lblFeedback.Text = "Update Failed Try again.";

         }

         if (Validator.gotBadWords(txtCalDOD.Text) == false && Validator.IsitFilledin(txtCalDOD.Text) == true)

         {


             input.DateOD = txtCalDOD.Text;



         }

         else
         {
             lblFeedback.Text = "Update Failed Try again.";

         }

         
         if (checkVet.Checked)

         {


             input.Vet = checkVet.Checked;


         }

         else
         {
            input.Vet = false;

         }

         if (Validator.gotBadWords(ddbranch.SelectedValue) == false)

         {


             input.Branch = ddbranch.SelectedValue;



         }

         else
         {
             lblFeedback.Text = "Update Failed Try again.";

         }

         if (Validator.gotBadWords(ddstone.SelectedValue) == false && Validator.IsitFilledin(ddstone.SelectedValue) == true)

         {


             input.Stone = ddstone.SelectedValue;



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

         lblFeedback.Text = input.UpdateAPlot(input.Plot_ID).ToString() + " Plot Updated!";
    }



    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Plot input = new Plot();
        input.Plot_ID = Convert.ToInt32(lblPlot_ID.Text);

        lblFeedback.Text = input.DeleteAPlot(input.Plot_ID).ToString() + " Person Deleted";

        ClearAll();
    }



    public void ClearAll()
    {
        txtcurrDate.Text = string.Empty;
        ddcemetary.SelectedValue = "0";
        txtfirstName.Text = string.Empty;
        txtmiddleName.Text = string.Empty;
        txtlastName.Text = string.Empty;
        ddtitle.SelectedValue = "0";
        txtCalDOB.Text = string.Empty;
        txtCalDOD.Text = string.Empty;
        checkVet.Text = string.Empty;
        ddbranch.SelectedValue = "0";
        ddstone.SelectedValue = "0";
        txtnote.Text = string.Empty;

    }



    protected void ddbranch_SelectedIndexChanged(object sender, EventArgs e)
    {
        if(ddbranch.SelectedValue != "0")
        {

            if (!checkVet.Checked)
            {
                lblFeedback.Text = "Must check Vet if you select a branch";
                
            }

        }
    }
}