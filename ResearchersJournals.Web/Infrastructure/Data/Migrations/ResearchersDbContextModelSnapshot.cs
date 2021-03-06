// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ResearchersJournals.Infrastructure.Web.Data;

namespace ResearchersJournals.Web.Infrastructure.Data.Migrations
{
    [DbContext(typeof(ResearchersDbContext))]
    partial class ResearchersDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.10");

            modelBuilder.Entity("ResearchersJournals.Web.Entities.JournalDocument", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("TEXT");

                    b.Property<byte[]>("FileContent")
                        .HasColumnType("BLOB");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<int>("ResearcherId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("ResearcherId");

                    b.ToTable("JournalDocuments");
                });

            modelBuilder.Entity("ResearchersJournals.Web.Entities.Researcher", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserName")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Researchers");
                });

            modelBuilder.Entity("ResearchersJournals.Web.Entities.ResearcherSubscription", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("TEXT");

                    b.Property<int>("ResearcherId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SubscribedResearcherId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("ResearcherId");

                    b.HasIndex("SubscribedResearcherId");

                    b.ToTable("ResearcherSubscriptions");
                });

            modelBuilder.Entity("ResearchersJournals.Web.Entities.JournalDocument", b =>
                {
                    b.HasOne("ResearchersJournals.Web.Entities.Researcher", "Researcher")
                        .WithMany()
                        .HasForeignKey("ResearcherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Researcher");
                });

            modelBuilder.Entity("ResearchersJournals.Web.Entities.ResearcherSubscription", b =>
                {
                    b.HasOne("ResearchersJournals.Web.Entities.Researcher", "Researcher")
                        .WithMany()
                        .HasForeignKey("ResearcherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ResearchersJournals.Web.Entities.Researcher", "SubscribedResearcher")
                        .WithMany()
                        .HasForeignKey("SubscribedResearcherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Researcher");

                    b.Navigation("SubscribedResearcher");
                });
#pragma warning restore 612, 618
        }
    }
}
