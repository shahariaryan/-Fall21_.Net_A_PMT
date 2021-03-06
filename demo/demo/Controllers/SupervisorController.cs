using BEL;
using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ApiApp.Controllers
{
    public class SupervisorController : ApiController
    {
        [Route("api/Project/Create")]
        [HttpPost]
        public void Add(ProjectModel n)
        {
            
            ProjectService.Add(n);
        }



        [Route("api/Project/All")]
        [HttpGet]
        public List<ProjectModel> GetAll()
        {
            return ProjectService.GetAll();
        }


        [Route("api/Project/GetById/{id}")]
        [HttpGet]
        public ProjectModel GetById(int id)
        {
            return ProjectService.GetById(id);
        }

        [Route("api/Project/{status}")]
        [HttpGet]
        public List<ProjectModel> GetByStatus(string status)
        {
            return ProjectService.GetByStatus(status);
        }

        [Route("api/Project/StateProgress/{pId}")]
        [HttpPost]
        public void StateProgress(int pId)
        {
            ProjectService.StateProgress(pId);
        }


        [Route("api/Project/StateCompleted/{pId}")]
        [HttpPost]
        public void StateCompleted(int pId)
        {
            ProjectService.StateCompleted(pId);
        }

        [Route("api/Project/Enroll/Confirm/{eId}")]
        [HttpPost]
        public void Confirm(int eId)
        {
            EnrollmentService.Confirm(eId);
        }


        [Route("api/Project/Enroll/Decline/{eId}")]
        [HttpPost]
        public void Decline(int eId)
        {
            EnrollmentService.Decline(eId);
        }


    }
}