using Microsoft.EntityFrameworkCore;
using ResearchersJournals.Web.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ResearchersJournals.Infrastructure.Web.Data
{
    public class ResearchersDbContext : DbContext
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="options"></param>
        public ResearchersDbContext(DbContextOptions<ResearchersDbContext> options)
            : base(options)
        { }
        #region  Entities Definitions
        /// <summary>
        /// this table will be used to store investigators
        /// </summary>
        public DbSet<Researcher> Researchers { get; set; }
        /// <summary>
        /// this table is used for uploaded documents
        /// </summary>
        public DbSet<JournalDocument> JournalDocuments { get; set; }
        /// <summary>
        /// This table is used to indicate to researchers that a researcher is subscribed
        /// </summary>
        public DbSet<ResearcherSubscription> ResearcherSubscriptions { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source = Researchers.db");
            base.OnConfiguring(optionsBuilder);
        }
        #endregion

    }
}
