using ResearchersJournals.Web.Models.ResearcherModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ResearchersJournals.Web.Infrastructure.Repositories.ResearcherRepository.Researchers
{
    public interface IResearcherRepository
    {
        public IEnumerable<ResearcherDTO> GetResearchers(int id);
        public void SubscribeToResearcher(int researcherId, int subscribedResearcherId, bool isSubscribe);
        public ResearcherDTO GetResearcher (int id);
    }
}
