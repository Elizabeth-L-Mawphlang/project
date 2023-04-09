using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Personal.Models;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.IO;

namespace Personal.Controllers
{
    public class NewReg : Controller
    {
        // GET: NewReg
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(userclass uc,HttpPostedFileBase file)
        {
            string mainconn = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(mainconn);
            string sqlquery = "insert into tblRegistration (Img,rname,lname,email,gender,address,city,state,rcode,phone) values (@Img,@rname,@lname,@email,@gender,@address,@city,@state,@rcode,@phone)";
            SqlCommand sqlcomm = new SqlCommand(sqlquery, sqlconn);
            sqlconn.Open();
            if (file != null && file.ContentLength > 0)
            {
                string filename = Path.GetFileName(file.FileName);
                string imgpath = Path.Combine(Server.MapPath("~/Images/"),filename);
                file.SaveAs(imgpath);
            }
            sqlcomm.Parameters.AddWithValue("@Img", "~/Images/"+file.FileName);
            sqlcomm.Parameters.AddWithValue("@rname", uc.rname);
            sqlcomm.Parameters.AddWithValue("@lname", uc.lname);
            sqlcomm.Parameters.AddWithValue("@email", uc.email);
            sqlcomm.Parameters.AddWithValue("@gender", uc.gender);
            sqlcomm.Parameters.AddWithValue("@address", uc.address);
            sqlcomm.Parameters.AddWithValue("@city", uc.city);
            sqlcomm.Parameters.AddWithValue("@state", uc.state);
            sqlcomm.Parameters.AddWithValue("@rcode", uc.rcode);
            sqlcomm.Parameters.AddWithValue("@phone", uc.phone);
            sqlcomm.ExecuteNonQuery();
            sqlconn.Close();
            ViewData["Message" ]= "User Record" + uc.rname + "Is Saved Successfully!";
            return View();
        }
    }
}