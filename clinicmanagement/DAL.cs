
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace clinicmanagement
{
    public class DAL
    {
        
        
        SqlConnection con;
        SqlCommand cmd;
        public SqlConnection connector()
        {
            con = new SqlConnection(@"Data Source=LAPTOP-M007G7LD\JAGASQL;Initial Catalog=master;User ID=sa;Password=jaga1234");
            return con;
        }
        public bool Doctorlogin(string Doctorname, string password)
        {
            connector();
            string sql = "select count(*) from dreg where DoctorName='" + Doctorname + "' and DPassword='" + password + "'";
            cmd = new SqlCommand(sql, con);
            con.Open();
            int val = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();

            if (val == 0)
            {
                return false;
            }
            else
            {
                return true;
            }


        }
        public bool patientlogin(string Patientname, string password)
        {
            connector();
            string sql = "select count(*) from preg where PatientName='" + Patientname + "' and PPassword='" + password + "'";
            cmd = new SqlCommand(sql, con);
            con.Open();
            int val = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();

            if (val == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public bool doctorregister(string doctorname, string password, string gender, int age, string specialist, int fees, long mobnumber, string address, string city, string country,string gmail)
        {
            con = connector();
            string sql = "select count(*) from dreg where DoctorName='" + doctorname + "'";
            cmd = new SqlCommand(sql, con);
            con.Open();
            int count = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();
            if (count == 0)
            {
                try
                {
                    string sql1 = "insert into dreg(DoctorName,DPassword,Gender,Age,Specialist,Fees,MobileNumber,ClinicAddress,City,Country,Gmail) values('" + doctorname + "','" + password + "','" + gender + "','" + age + "','" + specialist + "','" + fees + "','" + mobnumber + "','" + address + "','" + city + "','" + country + "','"+gmail+"')";
                    cmd = new SqlCommand(sql1, con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    return true;
                }
                catch
                {


                    return false;
                }

            }
            else
            {
                return false;
            }
        }
        public bool patientregister(string patientname, string password,  string gender, int age, long phonenumber, string fathername, long mobnumber, string address,string gmail)
        {
            con = connector();
            string sql = "select count(*) from preg where  PatientName='" + patientname + "'";
            cmd = new SqlCommand(sql, con);
            con.Open();
            int count = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();
            if (count == 0)
            {
                try
                {
                    string sql1 = "insert into preg(PatientName,PPassword,Gender,Age,PhoneNumber,FatherName,MobileNumber,PAddress,Gmail) values( '" + patientname + "','" + password + "','" + gender + "','" + age + "','" + phonenumber + "','" + fathername + "','" + mobnumber + "','" + address + "','"+gmail+"')";
                    cmd = new SqlCommand(sql1, con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    return true;
                }
                catch
                {
                    return false;
                }

            }
            else
            {
                return false;
            }
        }
        public DataTable doctorlist(string specialist, string state, string city)
        {
            connector();
            string s = "select DoctorID,DoctorName,Specialist,Fees,MobileNumber,ClinicAddress from dreg where Specialist='" + specialist + "' and Country='" + state + "' and City='" + city + "'";
            cmd = new SqlCommand(s, con);
            con.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Close();
            da.Dispose();
            return dt;
        }
        public DataTable specialist()
        {
            connector();
            string s = "select distinct Specialist from dreg";
            cmd = new SqlCommand(s, con);
            con.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Close();
            da.Dispose();
            return dt;
        }
        public DataTable state(string specialist)
        {
            connector();
            string s = "select distinct Country from dreg where Specialist ='"+specialist+"'";
            cmd = new SqlCommand(s, con);
            con.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Close();
            da.Dispose();
            return dt;
        }
        public DataTable city(string country)
        {
            connector();
            string s = "select distinct City from dreg where Country ='" + country + "'";
            cmd = new SqlCommand(s, con);
            con.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Close();
            da.Dispose();
            return dt;
        }
        public DataTable doctorid(string specialist, string state, string city)
        {
            connector();
            string s = "select DoctorID from dreg  where Specialist='" + specialist + "' and Country='" + state + "' and City='" + city + "'";
            cmd = new SqlCommand(s, con);
            con.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Close();
            da.Dispose();
            return dt;
        }

        public bool appointment(String patientid,string doctorid, string Status,string Allotted)
        {

            connector();


            string s = "select PatientID from preg where PatientName ='"+patientid+"'";
            cmd = new SqlCommand(s, con);
            con.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Close();
            da.Dispose();

            DataRow row=dt.Rows[0];


            int IDpatient = Convert.ToInt32(row["PatientID"]);


            //string s1 = "select DoctorID from dregister where DoctorName ='" + username + "'";
            //cmd = new SqlCommand(s, con);
            //con.Open();
            //DataTable dt1 = new DataTable();
            //SqlDataAdapter da1 = new SqlDataAdapter(cmd);
            //da.Fill(dt);
            //con.Close();
            //da.Dispose();

            //DataRow row1 = dt.Rows[0];


            //int IDpatient1 = Convert.ToInt32(row["DoctorID"]);





            string s2 = "insert into appointment(PatientID,DoctorID,Status,AllotedTime)values('"+IDpatient+"','"+doctorid+"','"+Status+"','"+Allotted+"')";
            cmd = new SqlCommand(s2, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            return true;
        }
        public DataTable patientlist(string patientid)
        {
            connector();


            string s = "select PatientID from preg where PatientName ='" + patientid + "'";
            cmd = new SqlCommand(s, con);
            con.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Close();
            da.Dispose();

            DataRow row = dt.Rows[0];
            int IDpatient = Convert.ToInt32(row["PatientID"]);
            string s2 = "select AppointmentID,PatientID,DoctorID,Status,AllotedTime from appointment where PatientID='" + IDpatient + "'";
            cmd = new SqlCommand(s2, con);
            con.Open();
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter(cmd);
            da1.Fill(dt1);
            con.Close();
            da1.Dispose();
            return dt1;

        }

        public DataTable dpatientlist(string doctorid)
        {
            connector();
             string s = "select DoctorID from dreg where DoctorName ='" + doctorid + "'";
            cmd = new SqlCommand(s, con);
            con.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Close();
            da.Dispose();

            DataRow row = dt.Rows[0];


            int IDpatient1 = Convert.ToInt32(row["DoctorID"]);
            string s2 = "select * from appointment where DoctorID='" + IDpatient1 + "'";
            cmd = new SqlCommand(s2, con);
            con.Open();
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter(cmd);
            da1.Fill(dt1);
            con.Close();
            da1.Dispose();
            return dt1;

        }
        public DataTable updateappoint(string appontmentid, string status, string allotetime)
        {
            connector();
            string s = "update appointment set Status='"+status+"',AllotedTime='"+allotetime+"' where AppointmentID='"+appontmentid+"'";
            cmd = new SqlCommand(s, con);
            con.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Close();
            da.Dispose();
            return dt;
        }
        public bool pchangepass(string username,string pass1,string pass)
        {
            connector();
            string sql1 = "update preg set PPassword='" + pass+ "' where PatientName='" + username + "' and PPassword='"+pass1+"'";
            cmd = new SqlCommand(sql1, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            return true;
        }

        public bool dchangepass(string username, string pass1, string pass)
        {
            connector();
            string sql1 = "update dreg set DPassword='" + pass + "' where DoctorName='" + username + "' and DPassword='" + pass1 + "'";
            cmd = new SqlCommand(sql1, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            return true;
        }
        public DataTable cancelappoint(int appintmentid)
        {
            connector();
            string s = "delete  from appointment where AppointmentID='"+appintmentid+"'";
            cmd = new SqlCommand(s, con);
            con.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Close();
            da.Dispose();
            return dt;
        }

        public DataTable doctorappoint(string doctorid)
        {
            connector();
            string s = "select DoctorID from dreg where DoctorName ='" + doctorid + "'";
            cmd = new SqlCommand(s, con);
            con.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Close();
            da.Dispose();

            DataRow row = dt.Rows[0];


            int IDpatient1 = Convert.ToInt32(row["DoctorID"]);
            connector();
            string s1 = "select *  from appointment where Status !='Pending'";
            cmd = new SqlCommand(s1, con);
            con.Open();
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter(cmd);
            da1.Fill(dt1);
            con.Close();
            da1.Dispose();
            return dt1;
        }

    }

}


