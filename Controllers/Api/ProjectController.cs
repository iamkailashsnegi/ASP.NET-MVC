using MyProjectWebApp.Models;
using MyProjectWebApp.Repo;
using MyProjectWebApp.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MyProjectWebApp.Controllers.Api
{
    public class ProjectController : ApiController
    {
        //POST Api/commands
        [HttpPost]
        [Route("ProjectApi/Add")]
        public IHttpActionResult AddProject(Project pm)
        {
            ProjectSaveData objRepo = new ProjectSaveData();
            var saveData = objRepo.AddProject(pm);
            return Ok(saveData);
        }

        [HttpGet]
        public string Edit(int id)
        {
            return "value";
        }

        [HttpGet]
        [Route("ProjectApi/GetProjectStatus")]
        public IHttpActionResult ProjectStatusList(int parentId)
        {
            Common objRepo = new Common();
            var appProjStatus = objRepo.GetProjectStatus(parentId);

            return Ok(appProjStatus);
        }

        [HttpGet]
        [Route("ProjectApi/GetProjectCatagory")]
        public IHttpActionResult ProjectCatList(int parentId)
        {
            Common objRepo = new Common();
            var appProjType = objRepo.GetProjectCat(parentId);

            return Ok(appProjType);
        }

        [HttpGet]
        [Route("ProjectApi/GetTimeSheet")]
        public IHttpActionResult TimeSheetTypeList(int parentId)
        {
            Common objRepo = new Common();
            var appTimeSheet = objRepo.GetTimesheet(parentId);

            return Ok(appTimeSheet);
        }

        [HttpGet]
        [Route("ProjectApi/GetCIG")]
        public IHttpActionResult CIGList(int parentId)
        {
            Common objRepo = new Common();
            var appCIG = objRepo.GetCIGroup(parentId);

            return Ok(appCIG);
        }

        [HttpGet]
        [Route("ProjectApi/GetPracType")]
        public IHttpActionResult PracTypeList(int parentId)
        {
            Common objRepo = new Common();
            var appPracType = objRepo.GetPracType(parentId);

            return Ok(appPracType);
        }

        [HttpGet]
        [Route("ProjectApi/GetProjectType")]
        public IHttpActionResult ProjectTypeList(int parentId)
        {
            Common objRepo = new Common();
            var appProjType = objRepo.GetProjectType(parentId);

            return Ok(appProjType);
        }

        [HttpGet]
        [Route("ProjectApi/GetRecruiter")]
        public IHttpActionResult RecruiterList()
        {
            Common objRepo = new Common();
            var appRec = objRepo.GetRecruiter();

            return Ok(appRec);
        }

        [HttpGet]
        [Route("ProjectApi/GetLocation")]
        public IHttpActionResult LocationGroupList()
        {
            Common objRepo = new Common();
            var appLocation = objRepo.GetLocation();

            return Ok(appLocation);
        }
        [HttpGet]
        [Route("ProjectApi/GetSubDomain")]
        public IHttpActionResult SubDomainList()
        {
            Common objRepo = new Common();
            var appSubDomain = objRepo.GetSubDomain();

            return Ok(appSubDomain);
        }
        [HttpGet]
        [Route("ProjectApi/GetTSR")]
        public IHttpActionResult TSRList()
        {
            Common objRepo = new Common();
            var appTSR = objRepo.GetTimeSheetRep();

            return Ok(appTSR);
        }
        [HttpGet]
        [Route("ProjectApi/GetSalesPerson")]
        public IHttpActionResult SalesPersonList()
        {
            Common objRepo = new Common();
            var appSalesPerson = objRepo.GetSalesPerson();

            return Ok(appSalesPerson);
        }
        [HttpGet]
        [Route("ProjectApi/GetPayRoll")]
        public IHttpActionResult PayRollStateList()
        {
            Common objRepo = new Common();
            var appPayRoll = objRepo.GetPayRoll();

            return Ok(appPayRoll);
        }
    }
}
