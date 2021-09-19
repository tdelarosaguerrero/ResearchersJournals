using ResearchersJournals.Infrastructure.Web.Data;
using ResearchersJournals.Web.Models.ResearcherModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ResearchersJournals.Web.Infrastructure.Repositories.ResearcherRepository.Researchers
{
    public class ResearcherRepository : IResearcherRepository
    {
        private readonly ResearchersDbContext _db;
        public ResearcherRepository(ResearchersDbContext researchersDbContext)
        {
            _db = researchersDbContext;
        }

        public ResearcherDTO GetResearcher(int id)
        {
            ResearcherDTO researcherDTO = new ResearcherDTO();
            var data = _db.Researchers.FirstOrDefault(e => e.Id == id);
            researcherDTO.CreatedDate = data.CreatedDate;
            researcherDTO.Email = data.Email;
            researcherDTO.Id = data.Id;
            researcherDTO.Name = data.Name;
            researcherDTO.UserName = data.UserName;

            return researcherDTO;
        }

        public IEnumerable<ResearcherDTO> GetResearchers(int id)
        {
            var query = from researcher in _db.Researchers.Where(e => e.Id != id)
                        join researcherSub in _db.ResearcherSubscriptions.Where(e => e.ResearcherId == id) on
                        researcher.Id equals researcherSub.SubscribedResearcherId into researcherSubscriptions
                        from researcherSubscription in researcherSubscriptions.DefaultIfEmpty()
                        select new ResearcherDTO
                        {
                            CreatedDate = researcher.CreatedDate,
                            Email = researcher.Email,
                            Id = researcher.Id,
                            IsSubscribe = researcherSubscription != null ? true : false,
                            Name = researcher.Name,
                            UserName = researcher.UserName
                        };
            return query;
        }

        public void SubscribeToResearcher(int researcherId, int subscribedResearcherId, bool isSubscribe)
        {
            if (isSubscribe)
            {
                var itemToDelete = _db.ResearcherSubscriptions.FirstOrDefault(e => e.ResearcherId == researcherId && e.SubscribedResearcherId == subscribedResearcherId);
                _db.Remove(itemToDelete);
                _db.SaveChanges();
            }
            else {
                _db.ResearcherSubscriptions.Add(new Entities.ResearcherSubscription
                {
                    ResearcherId = researcherId,
                    SubscribedResearcherId = subscribedResearcherId
                });
                _db.SaveChanges();
            }
        }
    }
}
