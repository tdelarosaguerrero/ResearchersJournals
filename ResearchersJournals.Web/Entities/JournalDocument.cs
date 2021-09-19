using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ResearchersJournals.Web.Entities
{
    public class JournalDocument
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public byte[] FileContent { get; set; }
        public DateTime CreatedDate { get; set; }
        [ForeignKey("Researcher")]
        public int ResearcherId { get; set; }
        public Researcher Researcher { get; set; }
    }
}
