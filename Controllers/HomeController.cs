using MyProjectWebApp.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyProjectWebApp.Repo;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace MyProjectWebApp.Controllers
{
    public class HomeController : Controller
    {
        private SqlConnection con;

        private void Connection()
        {
            string _conString = ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString;
            con = new SqlConnection(_conString);

        }
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        
        public ActionResult Project()
        {
            Common objRepo = new Common();
            var appProjSatus = objRepo.GetProjectStatus(1800);
            var appProjType = objRepo.GetProjectType(4650);
            var appProjCat = objRepo.GetProjectCat(19491);
            var appTime = objRepo.GetTimesheet(13120);
            var appCIG = objRepo.GetCIGroup(10300);
            var appPT = objRepo.GetPracType(15760);
            var appRec = objRepo.GetRecruiter();
            var appLoc = objRepo.GetLocation();
            var appSubDomain = objRepo.GetSubDomain();
            var appTSR = objRepo.GetTimeSheetRep();
            var appSP = objRepo.GetSalesPerson();
            var appPRS = objRepo.GetPayRoll();
            var emp = new ProjectAddEditViewModel
            {
                ProjectStatusList = appProjSatus,
                ProjectCatList= appProjCat,
                ProjectTypeList=appProjType,
                TimeSheetTypeList=appTime,
                CIGList=appCIG,
                PracTypeList= appPT,
                RecruiterList= appRec,
                LocationGroupList=appLoc,
                SubDomainList=appSubDomain,
                TSRList=appTSR,
                SalesPersonList=appSP,
                PayRollStateList=appPRS
            };
            return View(emp);
        }
     
        public ActionResult Save(ProjectAddEditViewModel model)
        {
            Connection();
            con.Open();
            SqlCommand cmd = new SqlCommand("Project_Kailash_Training", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Cust_Name", model.Project.Cust_Name);
            cmd.Parameters.AddWithValue("@Proj_Name", model.Project.Project_Name);
            cmd.Parameters.AddWithValue("@Proj_Id", model.Project.Id);
            cmd.Parameters.AddWithValue("@Start_Date", model.Project.SD);
            cmd.Parameters.AddWithValue("@End_Date", model.Project.ED);
            cmd.Parameters.AddWithValue("@Proj_Status", model.Project.Project_Status);
            cmd.Parameters.AddWithValue("@Loc_Group", model.Project.Location_Group);
            cmd.Parameters.AddWithValue("@PayRoll", model.Project.PayRoll_State);
            cmd.Parameters.AddWithValue("@SalesPerson", model.Project.Sales_Person);
            cmd.Parameters.AddWithValue("@Proj_Cat", model.Project.Proj_Cat);
            cmd.Parameters.AddWithValue("@Proj_Type", model.Project.Proj_Type);
            cmd.Parameters.AddWithValue("@Sub_Domain", model.Project.Sub_Dom);
            cmd.Parameters.AddWithValue("@TimeSheetRep", model.Project.TSP);
            cmd.Parameters.AddWithValue("@ClientInvoice", model.Project.CIG);
            cmd.Parameters.AddWithValue("@TimeSheetType", model.Project.TimesheetType);
            cmd.Parameters.AddWithValue("@IsVMS", model.Project.IVT);
            cmd.Parameters.AddWithValue("@Prac_Type", model.Project.Prac_Type);
            cmd.Parameters.AddWithValue("@Recruiter", model.Project.Recruiter);
            cmd.ExecuteNonQuery();
            con.Close();
            return View(model);
        }
    }
}