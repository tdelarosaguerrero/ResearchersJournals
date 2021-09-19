using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ResearchersJournals.Web.Models.DocumentModels
{
    public class ResearchersDocumentsDTO
    {
        public string ResearcherName { get; set; }
        public string FileName { get; set; }
       
        public bool IsOwner { get; set; }
        public int DocumentId { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
