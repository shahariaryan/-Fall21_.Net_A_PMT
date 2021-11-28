using BEL;
using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Security;

namespace ApiApp.Controllers
{
    public class LoginController : ApiController
    {

        [Route("api/Login/UserLogin")]
        [HttpPost]
        public void GetLogin(string username, string password)
        {

            var supervisor = SupervisorService.GetLogin(username, password);

            var member = MemberService.GetLogin(username, password);


            if (supervisor != null)
            {
                FormsAuthentication.SetAuthCookie(Convert.ToString(supervisor.Id), true);
                
            }

            else if (member != null)
            {
                FormsAuthentication.SetAuthCookie(member.Username, true);
                
            }
           
        }
    }
}