using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class Controls_PersonSearch : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["LoggedIn"] != null && Session["LoggedIn"].ToString() == "TRUE")
        {
            //keep them where they are
        }

        else
        {
            Response.Redirect("default.aspx");
        }
    }

    protected void btnSearch_Click(object sender, EventArgs e)
    {
        PersonV2 temp = new PersonV2();

        DataSet ds = temp.SearchAPerson(srcFName.Text, srcLName.Text);

        gvPerson.DataSource = ds;
        gvPerson.DataMember = ds.Tables[0].TableName;
        gvPerson.DataBind();

    }
}