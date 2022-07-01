using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace clinicmanagement
{
    public partial class Homepage : System.Web.UI.Page
    {
        //Request
        string n = "";
        BAL b = new BAL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                
                DataTable s = b.specialist();
                DropDownList4.DataSource = s;
                DropDownList4.DataTextField = "Specialist";
                DropDownList4.DataBind();
                DropDownList4.Items.Insert(0, new ListItem("-- Select Specialist --", "Select"));
            }
           
        }
        protected void DropDownList4_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable n = b.state(DropDownList4.Text);
            DropDownList5.DataSource = n;
            DropDownList5.DataTextField = "Country";
            DropDownList5.DataBind();
            DropDownList5.Items.Insert(0, new ListItem("-- Select Country --", "Select"));
        }
        protected void DropDownList5_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable m =b.city(DropDownList5.Text);
            DropDownList3.DataSource = m;
            DropDownList3.DataTextField = "City";
            DropDownList3.DataBind();
            DropDownList3.Items.Insert(0, new ListItem("-- Select City --", "Select"));
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            Label5.Visible = true;
            DropDownList6.Visible = true;
            Button2.Visible = true;
            DataTable a = b.doctorlist(DropDownList4.Text, DropDownList5.Text, DropDownList3.Text);
            GridView1.DataSource = a;
            GridView1.DataBind();
            DataTable f = b.doctorid(DropDownList4.Text, DropDownList5.Text, DropDownList3.Text);
            DropDownList6.DataSource = f;
            DropDownList6.DataTextField = "DoctorID";
            DropDownList6.DataBind();
        }

        protected void DropDownList3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

      

        protected void GridView1_SelectedIndexChanged1(object sender, EventArgs e)
        {
           
        }

        protected void DropDownList6_SelectedIndexChanged(object sender, EventArgs e)
        {
          
              
          
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if(b.appont(Request.Cookies["username"].Value,DropDownList6.Text,"Pending", n))
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Appointment Requested Successfully')", true);
                
            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Invalid Credentials')", true);
              
            }
        }
    }
}