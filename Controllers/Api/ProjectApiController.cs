using MyProjectWebApp.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MyProjectWebApp.Controllers.Api
{
    public class ProjectApiController : ApiController
    {
        [HttpGet]
        [Route("ProjectApi/GetProjectList")]
        public IHttpActionResult Project()
        {
            Common objRepo = new Common();
            var p = objRepo.GetProjectsList();
            return Ok(p);
        }
        [HttpGet]
        [Route("ProjectApi/GetList")]
        public IHttpActionResult manageSearch(string Proj_Type, string Prac_Type, string Cust_Name)
        {
            ProjectSaveData objRepo = new ProjectSaveData();
            var p = objRepo.Search(Proj_Type, Prac_Type, Cust_Name);
            return Ok(p);
        }
    }
}
