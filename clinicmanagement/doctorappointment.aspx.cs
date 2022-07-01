using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace clinicmanagement
{
    public partial class doctorappointment : System.Web.UI.Page
    {
        BAL b = new BAL();
        protected void Page_Load(object sender, EventArgs e)
        {
            DataTable s = b.doctorappoint(Request.Cookies["user"].Value);
            GridView1.DataSource = s;
            GridView1.DataBind();
        }
    }
}