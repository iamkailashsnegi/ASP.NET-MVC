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
        [Route("Home/ProjectAddKailash")]
        public IHttpActionResult AddProject(ProjectController pm)
        {
            return Ok();
        }

        [HttpGet]
        [Route("Home/GetProjectStatusKailash")]
        public IHttpActionResult ProjectStatusList(int parentId)
        {
            Common objRepo = new Common();
            var appProjStatus = objRepo.GetProjectStatus(parentId);

            return Ok(appProjStatus);
        }

        [HttpGet]
        [Route("Home/GetProjectCatagoryKailash")]
        public IHttpActionResult ProjectCatList(int parentId)
        {
            Common objRepo = new Common();
            var appProjType = objRepo.GetProjectCat(parentId);

            return Ok(appProjType);
        }

        [HttpGet]
        [Route("Home/GetTimeSheetKailash")]
        public IHttpActionResult TimeSheetTypeList(int parentId)
        {
            Common objRepo = new Common();
            var appTimeSheet = objRepo.GetTimesheet(parentId);

            return Ok(appTimeSheet);
        }

        [HttpGet]
        [Route("Home/GetCIGKailash")]
        public IHttpActionResult CIGList(int parentId)
        {
            Common objRepo = new Common();
            var appCIG = objRepo.GetCIGroup(parentId);

            return Ok(appCIG);
        }

        [HttpGet]
        [Route("Home/GetPracTypeKailash")]
        public IHttpActionResult PracTypeList(int parentId)
        {
            Common objRepo = new Common();
            var appPracType = objRepo.GetPracType(parentId);

            return Ok(appPracType);
        }

        [HttpGet]
        [Route("Home/GetProjectTypeKailash")]
        public IHttpActionResult ProjectTypeList(int parentId)
        {
            Common objRepo = new Common();
            var appProjType = objRepo.GetProjectType(parentId);

            return Ok(appProjType);
        }

        [HttpGet]
        [Route("Home/GetRecruiterKailash")]
        public IHttpActionResult RecruiterList()
        {
            Common objRepo = new Common();
            var appRec = objRepo.GetRecruiter();

            return Ok(appRec);
        }

        [HttpGet]
        [Route("Home/GetLocationKailash")]
        public IHttpActionResult LocationGroupList()
        {
            Common objRepo = new Common();
            var appLocation = objRepo.GetLocation();

            return Ok(appLocation);
        }
        [HttpGet]
        [Route("Home/GetSubDomainKailash")]
        public IHttpActionResult SubDomainList()
        {
            Common objRepo = new Common();
            var appSubDomain = objRepo.GetSubDomain();

            return Ok(appSubDomain);
        }
        [HttpGet]
        [Route("Home/GetTSRKailash")]
        public IHttpActionResult TSRList()
        {
            Common objRepo = new Common();
            var appTSR = objRepo.GetTimeSheetRep();

            return Ok(appTSR);
        }
        [HttpGet]
        [Route("Home/GetSalesPersonKailash")]
        public IHttpActionResult SalesPersonList()
        {
            Common objRepo = new Common();
            var appSalesPerson = objRepo.GetSalesPerson();

            return Ok(appSalesPerson);
        }
        [HttpGet]
        [Route("Home/GetPayRollKailash")]
        public IHttpActionResult PayRollStateList()
        {
            Common objRepo = new Common();
            var appPayRoll = objRepo.GetPayRoll();

            return Ok(appPayRoll);
        }
    }
}
