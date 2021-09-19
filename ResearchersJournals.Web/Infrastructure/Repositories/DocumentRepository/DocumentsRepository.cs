using Microsoft.EntityFrameworkCore;
using ResearchersJournals.Infrastructure.Web.Data;
using ResearchersJournals.Web.Entities;
using ResearchersJournals.Web.Models.DocumentModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ResearchersJournals.Web.Infrastructure.Repositories.DocumentRepository
{
    public class DocumentsRepository : IDocumentsRepository
    {
        private readonly ResearchersDbContext _db;

        public DocumentsRepository(ResearchersDbContext researchersDbContext)
        {
            _db = researchersDbContext;
        }

        public void SaveDocument(JournalDocument document)
        {
            _db.JournalDocuments.Add(document);
            _db.SaveChanges();
        }

        public IEnumerable<ResearchersDocumentsDTO> GetResearchersDocuments(int researcherId)
        {
            List<ResearchersDocumentsDTO> researchersDocuments = new List<ResearchersDocumentsDTO>();
            /// We look for the documents of the researchers that the logged-in researcher is subscribed to. 
            var querySubscribedDocuments = from doc in _db.JournalDocuments.Include(e => e.Researcher)
                                           join subscribedR in _db.ResearcherSubscriptions.Where(e => e.ResearcherId == researcherId)
                                           on doc.ResearcherId equals subscribedR.SubscribedResearcherId
                                           select new ResearchersDocumentsDTO
                                           {
                                               IsOwner = false,
                                               CreatedDate = doc.CreatedDate,
                                               DocumentId = doc.Id,
                                               FileName = doc.Name,
                                               ResearcherName = doc.Researcher.Name
                                           };

            researchersDocuments.AddRange(querySubscribedDocuments.ToList());
            // My Journal Documents
            var myDocuments = _db.JournalDocuments.Include(e => e.Researcher).Where(e => e.ResearcherId == researcherId).Select(doc => new ResearchersDocumentsDTO
            {
                IsOwner = true,
                CreatedDate = doc.CreatedDate,
                DocumentId = doc.Id,
                FileName = doc.Name,
                ResearcherName = doc.Researcher.Name

            });
            researchersDocuments.AddRange(myDocuments.ToList());
            return researchersDocuments;
        }
        public JournalDocument GetDocument(int documentId)
        {
            var document = _db.JournalDocuments.FirstOrDefault(e => e.Id == documentId);
            return document;
           
        }
    }
}
