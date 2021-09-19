using ResearchersJournals.Web.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ResearchersJournals.Web.Infrastructure.Repositories.AccountRepository.Account
{
    public interface IAccountRepository
    {
        public Researcher AuthenticateResearcher(string userName, string password);
        public void RegisterResearcher(Researcher researcher);
    }
}
