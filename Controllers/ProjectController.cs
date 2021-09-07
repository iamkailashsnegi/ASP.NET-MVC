using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyProjectWebApp.Controllers
{
    public class ProjectController : Controller
    {
        private SqlConnection con;

        private void Connection()
        {
            string _conString = ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString;
            con = new SqlConnection(_conString);

        }
        // GET: Project
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Edit(int Id)
        {
            return View();
        }
       
    }
}