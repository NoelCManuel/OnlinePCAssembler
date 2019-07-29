using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OnlinePCAssembler.Models;
using System.Data.SqlClient;

namespace OnlinePCAssembler.Controllers
{
    public class HomeController : Controller
    {
        SqlConnection con = new SqlConnection();
        SqlCommand com = new SqlCommand();
        SqlDataReader dr;
        [HttpGet]
        public ActionResult Homepage()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
        public ActionResult Verify(Account acc)
        {
            connectionSting();
            con.Open();
            com.Connection = con;
            com.CommandText = "select * from login where username='" + acc.username + "','" + acc.password + "'";
            dr = com.ExecuteReader();
            if (dr.Read())
            {

            }
            else
            {

            }
            con.Close();
            return View();
        }
        void connectionSting()
        {
            con.ConnectionString = "server=localhost;user id=root;database=testdb;allowuservariables=True";
        }
        public ActionResult About()
        {
            return View();
        }
        public ActionResult Contact()
        {
            return View();
        }
    }
}