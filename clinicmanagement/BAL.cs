using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace clinicmanagement
{

    public class BAL
    {
        DAL a = new DAL();
        public bool doctorlogin(string Doctorname, string password)
        {
            if (a.Doctorlogin(Doctorname, password))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool patientlogin(string patientname, string password)
        {
            if (a.patientlogin(patientname, password))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool doctorregister(string doctorname, string password,  string gender, int age, string specialist, int fees, long mobnumber, string address, string city, string country,string gmail)
        {
            if (a.doctorregister(doctorname, password, gender, age, specialist, fees, mobnumber, address, city, country,gmail))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool patientregister(string patientname, string password, string gender, int age,long phonenumber, string fathername, long mobnumber, string address,string gmail)
        {
            if (a.patientregister(patientname, password,gender, age, phonenumber, fathername, mobnumber, address,gmail))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public DataTable doctorlist(string specialist, string state, string city)
        {
            return a.doctorlist(specialist, state, city);

        }
        public DataTable specialist()
        {
            return a.specialist();
        }
        public DataTable state(string specialist)
        {
            return a.state(specialist);
        }
        public DataTable city(string country)
        {
            return a.city(country);
        }
        public bool appont(string patientid, string doctorid, string Status, string Allotted)
        {
            return a.appointment(patientid, doctorid, Status, Allotted);
        }
        public DataTable patientlist(string patientid)
        {
            return a.patientlist(patientid);

        }
        public DataTable doctorid(string specialist, string state, string city)
        {
            return a.doctorid(specialist, state, city);
        }






        public DataTable dpatientlist(string doctorid)
        {
            return a.dpatientlist(doctorid);
        }

        public DataTable updateappointment(string appontmentid1, string status1, string allotetime1)
        {
            return a.updateappoint(appontmentid1, status1, allotetime1);
        }


        public bool pchangepass(string username, string pass1, string pass)
        {
           
            return a.pchangepass(username,pass1,pass);
        }

        public bool dchangepass(string username, string pass1, string pass)
        {

            return a.dchangepass(username, pass1, pass);
        }

        public DataTable cancelappoint(int appointmentid)
        {
            return a.cancelappoint(appointmentid);
        }

        public DataTable doctorappoint(string doctorid)
        {
            return a.doctorappoint(doctorid);
        }

    }
}