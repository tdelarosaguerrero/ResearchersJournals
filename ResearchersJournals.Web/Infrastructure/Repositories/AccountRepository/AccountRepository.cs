using ResearchersJournals.Infrastructure.Web.Data;
using ResearchersJournals.Web.Entities;
 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ResearchersJournals.Web.Infrastructure.Repositories.AccountRepository.Account
{
    public class AccountRepository : IAccountRepository
    {
        private readonly ResearchersDbContext _db;
    
        public AccountRepository(ResearchersDbContext researchersDbContext)
        {
            _db = researchersDbContext;
        }
        public Researcher AuthenticateResearcher(string userName, string password)
        {
            string passwordHash = Utils.Utils.GenerarHashSHA256(password);
            if (!_db.Researchers.Any(e => e.UserName == userName && e.Password == Utils.Utils.GenerarHashSHA256(password)))
            {
                throw new Exception("Invalid user name or password");
            }
            var data = _db.Researchers.FirstOrDefault(e => e.UserName == userName && e.Password == passwordHash);
            return data;
        }

        public void RegisterResearcher(Researcher researcher)
        {
            string passwordHash = Utils.Utils.GenerarHashSHA256(researcher.Password);
            if (_db.Researchers.Any(e => e.UserName == researcher.UserName))
            {
                throw new Exception("Username not available");
            }
            researcher.Password = passwordHash;
            researcher.CreatedDate = DateTime.Now;
            _db.Researchers.Add(researcher);
            _db.SaveChanges();
        }
    }
}
