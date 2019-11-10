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
            Response.Redirect("~Controls/Default.aspx");
        }
    }

    protected void btnSearch_Click(object sender, EventArgs e)
    {
        Plot temp = new Plot();

        DataSet ds = temp.SearchAPlot(srcFName.Text, srcLName.Text);

        gvPerson.DataSource = ds;
        gvPerson.DataMember = ds.Tables[0].TableName;
        gvPerson.DataBind();

    }
}