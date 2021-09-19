using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ResearchersJournals.Web.Entities;
namespace ResearchersJournals.Web.Models.ResearcherModels
{
    public class ResearcherDTO :  Researcher
    {
        
        public bool IsSubscribe { get; set; }
    }
}
