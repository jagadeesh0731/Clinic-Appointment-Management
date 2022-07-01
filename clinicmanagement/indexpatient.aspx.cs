using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace clinicmanagement
{
    public partial class indexpatient : System.Web.UI.Page
    {
        BAL b = new BAL();
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void logbtn_ServerClick(object sender, EventArgs e)
        {
            if (username.Value.Trim() != "" && password.Value.Trim() != "")
            {
                if (b.patientlogin(username.Value, password.Value))
                {
                    Response.Cookies["username"].Value = username.Value;
                    Response.Redirect("HomePage.aspx");
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