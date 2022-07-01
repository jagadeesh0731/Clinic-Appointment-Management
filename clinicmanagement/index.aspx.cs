using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace clinicmanagement
{
    public partial class index : System.Web.UI.Page
    {
        BAL b = new BAL();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void logbtn_ServerClick(object sender, EventArgs e)
        {
            if (username.Value.Trim() != "" && password.Value.Trim() != "")
            {
                if (b.doctorlogin(username.Value, password.Value))
                {
                    Response.Cookies["user"].Value = username.Value;
                    Response.Redirect("DoctorHomePage.aspx");
                }
                else
                {
                    Label1.Text = "Please Register";
                }
            }
            else
            {
                Label1.Text = "Please Fill Above Fields";
            }
        }
    }
}