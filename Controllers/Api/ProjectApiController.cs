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
        [Route("ProjectApi/Edit")]
        public IHttpActionResult Edit(int Id)
        {
            ProjectSaveData objRepo = new ProjectSaveData();
            var editData = objRepo.Edit(Id);
            return Ok(editData);
        }

    }
}
