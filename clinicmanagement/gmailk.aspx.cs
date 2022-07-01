using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.Net.Mail;
using System.Data.SqlClient;

namespace clinicmanagement
{
    public partial class gmailk : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                string username = "";
                string password = "";
                SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-M007G7LD\JAGASQL;Initial Catalog=master;User ID=sa;Password=jaga1234");
                SqlCommand cmd = new SqlCommand("select name, id from new where pass=@email", con);
                cmd.Parameters.AddWithValue("@email", TextBox1.Text);
                con.Open();
                using (SqlDataReader sdr = cmd.ExecuteReader())
                {

                    if (sdr.Read())
                    {
                        username = sdr["name"].ToString();
                        password = sdr["id"].ToString();

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
                    mns.Body = ("Your Username is:" + username + "\n" + "Your Password is:" + password);
                    client.Send(mns);
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "popup", "alert('sended');", true);



                    //MailMessage msg = new MailMessage();
                    //msg.From = new MailAddress("a1jagas96@gmail.com");
                    //msg.To.Add(TextBox1.Text);
                    //msg.Subject = " Recover your Password";
                    //msg.Body = ("Your Username is:" + username + "<br/><br/>" + "Your Password is:" + password);
                    //msg.IsBodyHtml = true;

                    //SmtpClient smt = new SmtpClient();
                    //smt.Host = "smtp.gmail.com";
                    //System.Net.NetworkCredential ntwd = new NetworkCredential();
                    //ntwd.UserName = "@gmail.com"; //Your Email ID  
                    //ntwd.Password = ""; // Your Password  
                    //smt.UseDefaultCredentials = true;
                    //smt.Credentials = ntwd;
                    //smt.Port = 587;
                    //smt.EnableSsl = true;
                    //smt.Send(msg);
                    //Label1.Text = "Username and Password Sent Successfully";
                    //Label1.ForeColor = System.Drawing.Color.ForestGreen;


                    //SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                    //client.EnableSsl = true;
                    //client.DeliveryMethod = SmtpDeliveryMethod.Network;
                    //client.UseDefaultCredentials = false;
                    //client.Credentials = new NetworkCredential("a1jagas96@gmail.com", "07311996");
                    //MailMessage mns = new MailMessage();
                    //mns.To.Add(TextBox1.Text);
                    //mns.From = new MailAddress("a1dilli96@gmail.com");
                    //mns.Subject = TextBox2.Text;
                    //mns.Body = TextBox3.Text;
                    //client.Send(mns);
                    //ScriptManager.RegisterStartupScript(this, this.GetType(), "popup", "alert('sended');", true);
                }
            }
            catch(Exception ex)
            {
                Response.Write("could not send" + ex.Message);
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string username = "";
            string password = "";
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-M007G7LD\JAGASQL;Initial Catalog=master;User ID=sa;Password=jaga1234");
            SqlCommand cmd = new SqlCommand("select name, id from new where pass=@email", con);
            cmd.Parameters.AddWithValue("@email", TextBox1.Text);
            con.Open();
            using (SqlDataReader sdr = cmd.ExecuteReader())
            {

                if (sdr.Read())
                {
                    username = sdr["name"].ToString();
                    password = sdr["id"].ToString();

                }

            }
            con.Close();

            if (!string.IsNullOrEmpty(password))
            {
                MailMessage msg = new MailMessage();
                msg.From = new MailAddress("a1jagas96@gmail.com");
                msg.To.Add(TextBox1.Text);
                msg.Subject = " Recover your Password";
                msg.Body = ("Your Username is:" + username + "<br/><br/>" + "Your Password is:" + password);
                msg.IsBodyHtml = true;

                SmtpClient smt = new SmtpClient();
                smt.Host = "smtp.gmail.com";
                System.Net.NetworkCredential ntwd = new NetworkCredential();
                ntwd.UserName = "@gmail.com"; //Your Email ID  
                ntwd.Password = ""; // Your Password  
                smt.UseDefaultCredentials = true;
                smt.Credentials = ntwd;
                smt.Port = 587;
                smt.EnableSsl = true;
                smt.Send(msg);
               Label1.Text = "Username and Password Sent Successfully";
              Label1.ForeColor = System.Drawing.Color.ForestGreen;
            }
        }
    }
}