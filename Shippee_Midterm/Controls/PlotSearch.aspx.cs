using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class Controls_PlotSearch : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["LoggedIn"] != null && Session["LoggedIn"].ToString() == "TRUE")
        {
            //keep them where they are
        }

        else
        {
            Response.Redirect("Default.aspx");
        }
    }

    protected void btnSearch_Click(object sender, EventArgs e)
    {
        //determine if text boxes are populated, if not, don't need to go on!
        if(srcCemetary.Text.Trim().Length < 1 && srcLName.Text.Trim().Length < 1)
        {
            throw new Exception("Must enter a VALUE!");
            return;
        }



        Plot temp = new Plot();

        DataSet ds = temp.SearchAPlot(srcCemetary.Text, srcLName.Text);

        gvPerson.DataSource = ds;
        gvPerson.DataMember = ds.Tables[0].TableName;
        gvPerson.DataBind();

    }
}