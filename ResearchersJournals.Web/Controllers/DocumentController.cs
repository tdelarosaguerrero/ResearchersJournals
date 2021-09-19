using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ResearchersJournals.Web.Infrastructure.Repositories.DocumentRepository;
using ResearchersJournals.Web.Models.DocumentModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ResearchersJournals.Web.Controllers
{
    [Authorize]
    public class DocumentController : BaseController
    {
        private IDocumentsRepository documentsRepository { get; set; }
        private readonly ILogger<ResearcherController> _logger;
        public DocumentController(IDocumentsRepository _documentsRepository, ILogger<ResearcherController> logger)
        {
            this.documentsRepository = _documentsRepository;
            _logger = logger;
        }
        public IActionResult JournalsDocuments()
        {
            var documentsList = documentsRepository.GetResearchersDocuments(CurrentResearcher.Id);
            return View(documentsList);
        }
        public IActionResult UploadDocument()
        {
            return View();
        }
        [HttpPost]
        public IActionResult UploadDocument(DocumentViewModel model)
        {
            byte[] document = null;
            if (model.FormFile == null || model.FormFile.Length == 0)
            {
                ModelState.AddModelError("file", "please select a file");
                return View();
            }

            using (var ms = new MemoryStream())
            {
                model.FormFile.CopyTo(ms);
                document = ms.ToArray();
            }
            if (document != null)
            {
                documentsRepository.SaveDocument(new Entities.JournalDocument
                {
                    CreatedDate = DateTime.Now,
                    FileContent = document,
                    Name = model.FormFile.FileName,
                    ResearcherId = CurrentResearcher.Id
                });
            }
            return RedirectToAction("JournalsDocuments");
        }
        [HttpGet]
        public IActionResult GetDocument(int documentId)
        {
            try
            {
                var document = documentsRepository.GetDocument(documentId);
                string base64Document = Convert.ToBase64String(document.FileContent, 0, document.FileContent.Length);
                return PartialView("_DocumentViewer", base64Document);
            }
            catch (Exception ex)
            {
                return Json(new { Success = false, Message = ex.Message });
            }


        }
        [HttpGet]
        public IActionResult DownloadDocument(int documentId)
        {
            try
            {
                var document = documentsRepository.GetDocument(documentId);
                string base64Document = Convert.ToBase64String(document.FileContent, 0, document.FileContent.Length);
                string fileName = document.Name;
                if (!fileName.Contains(".pdf"))
                {
                    fileName = string.Format("{0}.{1}", fileName, "PDF");
                }
                return File(document.FileContent, " application/pdf", fileName);
            }
            catch (Exception ex)
            {
                return Json(new { Success = false, Message = ex.Message });
            }
        }
    }
}
