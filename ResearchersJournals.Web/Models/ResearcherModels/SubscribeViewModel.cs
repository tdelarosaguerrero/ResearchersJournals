using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ResearchersJournals.Web.Models.ResearcherModels
{
    public class SubscribeViewModel
    {
        public int ResearcherId { get; set; }
        public bool Subscribe { get; set; }
    }
}
