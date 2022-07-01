using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace clinicmanagement
{
    public partial class patientforgotpassword : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text.Trim() != "")
            {
                try
                {
                    string username = "";
                    string password = "";
                    SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-M007G7LD\JAGASQL;Initial Catalog=master;User ID=sa;Password=jaga1234");
                    SqlCommand cmd = new SqlCommand("select PatientName,PPassword from preg where Gmail=@email", con);
                    cmd.Parameters.AddWithValue("@email", TextBox1.Text);
                    con.Open();
                    using (SqlDataReader sdr = cmd.ExecuteReader())
                    {

                        if (sdr.Read())
                        {
                            username = sdr["PatientName"].ToString();
                            password = sdr["PPassword"].ToString();

                        }

                    }
                    con.Close();


                    if (!string.IsNullOrEmpty(password))
                    {

                        SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                        client.EnableSsl = true;
                        client.DeliveryMethod = SmtpDeliveryMethod.Network;
                        client.UseDefaultCredentials = false;
                        client.Credentials = new NetworkCredential("a1jagas96@gmail.com", "07311996");
                        MailMessage mns = new MailMessage();
                        mns.To.Add(TextBox1.Text);
                        mns.From = new MailAddress("a1dilli96@gmail.com");
                        mns.Subject = " Recover your Password";
                        mns.Body = ("Your UserName is:" + username + "\n" + "Your Password is:" + password);
                        client.Send(mns);
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "popup", "alert('UserName and Password Sended Succesfully');", true);




                    }
                }
                catch (Exception ex)
                {
                    Response.Write("could not send" + ex.Message);
                }
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "popup", "alert('Please Fill All The Fields');", true);
            }
        }
    }
    }
