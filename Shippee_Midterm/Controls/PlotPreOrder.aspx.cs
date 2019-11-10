using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class PlotPreOrder : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        txtcurrDate.Text = DateTime.Now.ToString("MM-dd-yyy");


        if (Session["LoggedIn"] != null && Session["LoggedIn"].ToString() == "TRUE")
        {
            //keep them where they are
        }

        else
        {
            Response.Redirect("~Controls/Default.aspx");
        }
    }

}