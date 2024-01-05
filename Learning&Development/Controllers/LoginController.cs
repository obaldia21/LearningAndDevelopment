using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


// Using models

using Learning_Development.Models;
using System.Data.SqlClient;
using System.Data;

namespace Learning_Development.Controllers
{
    public class LoginController : Controller
    {

        //Conenction to the database

        static string connectionString = "Data Source=YY299852;Initial Catalog=LeaningAndDevelopment;User ID=sa;Password=Josueda2; Connection Timeout=200; pooling=true;Max Pool Size=32767";


        // GET: Login
        public ActionResult Login()
        {
            return View();
        }

        public ActionResult newLogin()
        {
            return View();
        }


        public ActionResult Logout() 
        { 
            return View();
        }


        [HttpPost]

        public ActionResult Login(Administrator admin)
        {
            
           
            return View();
        }




    }
}