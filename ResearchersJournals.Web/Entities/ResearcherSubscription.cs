using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ResearchersJournals.Web.Entities
{
    public class ResearcherSubscription
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [ForeignKey("Researcher")]
        public int ResearcherId { get; set; }
        [ForeignKey("SubscribedResearcher")]
        public int SubscribedResearcherId { get; set; }
        public Researcher Researcher { get; set; }
        public Researcher SubscribedResearcher { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
