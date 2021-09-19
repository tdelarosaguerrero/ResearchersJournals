using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ResearchersJournals.Web.Models.Security
{
    public class ResearcherUser
    {
    

        public ResearcherUser() : this(0, string.Empty, string.Empty) { }

        public ResearcherUser(int id, string name, string email)
        {
            this.Id = id;
            this.Name = name;
            this.Email = email;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
    }
}
