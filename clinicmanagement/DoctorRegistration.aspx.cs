using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace clinicmanagement
{
    public partial class DoctorRegistration : System.Web.UI.Page
    {
      
        BAL b = new BAL();
        string gender = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            ValidationSettings.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            if(TextBox3.Text.Trim() !="" &&  TextBox4.Text.Trim() != ""  && TextBox6.Text.Trim() != "" && TextBox8.Text.Trim() != "" && TextBox9.Text.Trim() != "" && TextBox10.Text.Trim() != "" && RadioButton1.Checked!=true||RadioButton2.Checked!=true && DropDownList1.SelectedValue !="" && DropDownList2.SelectedValue !="" && DropDownList3.SelectedValue !="" && TextBox11.Text.Trim() !="")
            {
                if(RadioButton1.Checked==true)
                    {
                        gender = "male";
                    }
                else
                    {
                        gender = "Female";
                    }
                if(b.doctorregister(TextBox3.Text,TextBox4.Text,gender,Convert.ToInt32(TextBox6.Text),DropDownList1.SelectedValue,Convert.ToInt32(TextBox8.Text),Convert.ToInt64(TextBox9.Text),TextBox10.Text, DropDownList2.SelectedValue, DropDownList3.SelectedValue,TextBox11.Text))
                {
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Record Inserted Successfully')", true);
                   
                }
                else
                {
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('UserName Aldready Exist')", true);
                   
                }
            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Please Fill above Fields')", true);
                
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("index.aspx");
        }
    }
}