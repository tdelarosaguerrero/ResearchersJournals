using Microsoft.AspNetCore.Mvc;
using ResearchersJournals.Web.Models.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace ResearchersJournals.Web.Controllers
{
    public class BaseController : Controller
    {
        public virtual ResearcherUser CurrentResearcher
        {
            get
            {
                var identity = (ClaimsIdentity)User.Identity;
                int researcherId = Convert.ToInt32(identity.Claims.Where(c => c.Type == "ResearcherId")
                              .Select(c => c.Value).SingleOrDefault());
                string email =  identity.Claims.Where(c => c.Type == ClaimTypes.Email)
                              .Select(c => c.Value).SingleOrDefault();

                string name = identity.Claims.Where(c => c.Type == ClaimTypes.Name)
                             .Select(c => c.Value).SingleOrDefault();
                ResearcherUser researcherUser = new ResearcherUser(researcherId, name, email);
                return researcherUser;
            }
        }
    }
}
