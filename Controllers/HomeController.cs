using MyProjectWebApp.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyProjectWebApp.Repo;

namespace MyProjectWebApp.Controllers
{
    public class HomeController : Controller
    {
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
                SalesPersonList=appSP
            };
            return View(emp);
        }
    }
}