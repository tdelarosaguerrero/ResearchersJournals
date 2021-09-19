using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ResearchersJournals.Web.Models.DocumentModels
{
    public class DocumentViewModel
    {
        [Display(Name = "File Name")]
        public string FileName { get; set; }
        [Display(Name = "Upload File")]
        public IFormFile FormFile { get; set; }
    }
}
