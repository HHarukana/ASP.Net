﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Controls_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        if(txtUser.Text == "Scott" && txtPass.Text == "NEIT")
        {
            Session["LoggedIn"] = "TRUE";

            Response.Redirect("ControlPanel.aspx");

        }

        else
        {
            lblIssue.Text = "Login Attemp Failed";
            Session.Abandon();
        }

    }
}