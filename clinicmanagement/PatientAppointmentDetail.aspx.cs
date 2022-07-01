using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace clinicmanagement
{
    public partial class PatientAppointmentDetail : System.Web.UI.Page
    {
        BAL b = new BAL();
       
        SqlConnection con;
        DataSet ds = new DataSet();
        SqlCommand cmd = new SqlCommand();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DataTable s = b.patientlist(Request.Cookies["username"].Value);
                GridView1.DataSource = s;
                GridView1.DataBind();
            }
        }

        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                Label lbl_Status = e.Row.Cells[5].FindControl("lbl_Status") as Label;
                if (lbl_Status.Text == "Pending")
                {
                    e.Row.Cells[4].ForeColor = System.Drawing.Color.Red;
                    //
                    //Change the back color.
                    e.Row.Cells[4].BackColor = Color.Yellow;
                }

                else
                {
                    e.Row.Cells[4].ForeColor = System.Drawing.Color.White;
                    //
                    //Change the back color.
                    e.Row.Cells[4].BackColor = Color.Green;
                }
            }


            //if (e.Row.RowType == DataControlRowType.DataRow)
            //{
            //    if (e.Row.Cells[4].Text == "Pending") //Here is the condition!
            //    {
            //        //   
            //        //Change the cell color.
            //        e.Row.Cells[4].ForeColor = System.Drawing.Color.Red;
            //        //
            //        //Change the back color.
            //        e.Row.Cells[4].BackColor = Color.Yellow;

            //    }
            //    else
            //    {
            //        e.Row.Cells[4].ForeColor = System.Drawing.Color.White;
            //        //
            //        //Change the back color.
            //        e.Row.Cells[4].BackColor = Color.Green;
            //    }
            //}

          
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            con = new SqlConnection(@"Data Source=LAPTOP-M007G7LD\JAGASQL;Initial Catalog=master;User ID=sa;Password=jaga1234");
            cmd.Connection = con;
            Label lbl_AppointmentID = (Label)GridView1.Rows[e.RowIndex].FindControl("lbl_AppointmentID");
            cmd.CommandText = "Delete from appointment where AppointmentID='" + lbl_AppointmentID.Text + "'";
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            DataTable s = b.patientlist(Request.Cookies["username"].Value);
            GridView1.DataSource = s;
            GridView1.DataBind();



            //int index = Convert.ToInt32(e.RowIndex);
            //DataTable dt = b.patientlist(Request.Cookies["username"].Value);
            //dt.Rows[index].Delete();
          
            //GridView1.DataSource = dt;
            //GridView1.DataBind();



            //int index = Convert.ToInt32(e.RowIndex);
            //DataTable dt = b.patientlist(Request.Cookies["username"].Value;
            //dt.Rows[index].Delete();

            //GridView1.DataSource = dt;
            //GridView1.DataBind();

        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}