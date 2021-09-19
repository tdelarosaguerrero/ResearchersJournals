using ResearchersJournals.Web.Entities;
using ResearchersJournals.Web.Models.DocumentModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ResearchersJournals.Web.Infrastructure.Repositories.DocumentRepository
{
    public interface IDocumentsRepository
    {
        /// <summary>
        /// Save Documents in db 
        /// </summary>
        /// <param name="document"></param>
        public void SaveDocument(JournalDocument document);
        /// <summary>
        /// documents of the authenticated researcher and of the users that I am subscribed to
        /// </summary>
        /// <param name="researcherId"></param>
        /// <returns></returns>
        public IEnumerable<ResearchersDocumentsDTO> GetResearchersDocuments(int researcherId);
        /// <summary>
        /// Get document by id
        /// </summary>
        /// <param name="documentId"></param>
        /// <returns></returns>
        public JournalDocument GetDocument(int documentId);
    }
}
