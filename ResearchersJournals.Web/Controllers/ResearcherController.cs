using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;
using Microsoft.Extensions.Logging;
using ResearchersJournals.Web.Infrastructure.Repositories.ResearcherRepository.Researchers;
using ResearchersJournals.Web.Models.ResearcherModels;

namespace ResearchersJournals.Web.Controllers
{
    [Authorize]
    public class ResearcherController : BaseController
    {
        private IResearcherRepository researcherRepository { get; set; }
        private readonly ILogger<ResearcherController> _logger;
        public ResearcherController(IResearcherRepository _researcherRepository, ILogger<ResearcherController> logger)
        {
            this.researcherRepository = _researcherRepository;
            _logger = logger;
        }
        public IActionResult Researchers()
        {
            var data = researcherRepository.GetResearchers(this.CurrentResearcher.Id);
            return View(data);
        }
        [HttpPost]
        public IActionResult Subscribe(SubscribeViewModel model)
        {
            var data = researcherRepository.GetResearcher(model.ResearcherId);
            data.IsSubscribe = !model.Subscribe;
            researcherRepository.SubscribeToResearcher(CurrentResearcher.Id, model.ResearcherId, model.Subscribe);
            return PartialView("_ResearcherRow", data);


        }
    }
}
