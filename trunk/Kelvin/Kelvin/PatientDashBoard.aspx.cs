﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Kelvin
{
    public partial class PatientDashBoard : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["UserId"] == null)
                {
                    Response.Redirect("Login.aspx");
                }
            }
        }

        protected void lbtnDiagonistic_Click(object sender, System.EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }
        protected void ibtnDiagonistic_Click(object sender, System.EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }


    }
}
