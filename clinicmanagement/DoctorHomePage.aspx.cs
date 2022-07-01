using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace clinicmanagement
{
    public partial class DoctorHomePage : System.Web.UI.Page
    {
        BAL b = new BAL();
       protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                DataTable c = b.dpatientlist(Request.Cookies["user"].Value);
                GridView1.DataSource = c;
                GridView1.DataBind();
                //ShowData();
            }

           
        }


        protected void GridView1_RowEditing(object sender, System.Web.UI.WebControls.GridViewEditEventArgs e)
        {
            //NewEditIndex property used to determine the index of the row being edited.  
            GridView1.EditIndex = e.NewEditIndex;
            DataTable c = b.dpatientlist(Request.Cookies["user"].Value);
            GridView1.DataSource = c;
            GridView1.DataBind();

        }
        protected void GridView1_RowUpdating(object sender, System.Web.UI.WebControls.GridViewUpdateEventArgs e)
        {
            //Finding the controls from Gridview for the row which is going to update  
            Label AppointmentID = GridView1.Rows[e.RowIndex].FindControl("lbl_AppointmentID") as Label;
            Label PatientID = GridView1.Rows[e.RowIndex].FindControl("lbl_PatientID") as Label;
            Label DoctorID = GridView1.Rows[e.RowIndex].FindControl("lbl_DoctorID") as Label;
            TextBox Status = GridView1.Rows[e.RowIndex].FindControl("txt_Status") as TextBox;
            TextBox AllotedTime = GridView1.Rows[e.RowIndex].FindControl("txt_AllotedTime") as TextBox;
        DataTable    v = b.updateappointment(AppointmentID.Text, Status.Text, AllotedTime.Text);
            GridView1.DataSource = v;
            GridView1.DataBind();

            //Setting the EditIndex property to -1 to cancel the Edit mode in Gridview  
            GridView1.EditIndex = -1;
            //Call ShowData method for displaying updated data 
            DataTable c = b.dpatientlist(Request.Cookies["user"].Value);
            GridView1.DataSource = c;
            GridView1.DataBind();

        }
        protected void GridView1_RowCancelingEdit(object sender, System.Web.UI.WebControls.GridViewCancelEditEventArgs e)
        {
            //Setting the EditIndex property to -1 to cancel the Edit mode in Gridview  
            GridView1.EditIndex = -1;
            DataTable c = b.dpatientlist(Request.Cookies["user"].Value);
            GridView1.DataSource = c;
            GridView1.DataBind();

        }
    }
}