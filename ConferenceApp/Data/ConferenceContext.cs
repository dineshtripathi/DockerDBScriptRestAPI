using System.Collections.Generic;
using ConferenceApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;
namespace ConferenceApp.Data
{
    public class ConferenceContext : DbContext
    {
        public ConferenceContext(DbContextOptions<ConferenceContext> options)
            : base(options)
        {}

        public DbSet<Speaker> Speakers { get; set; }

        public DbSet<Sponsor> Sponsors { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
          //  modelBuilder.Seed();
            //modelBuilder.Entity<Speaker>().HasData(new List<Speaker>
            //{
            //    new Speaker
            //    {
            //        Id = 1,
            //        First = "Jim",
            //        Last = "Beam",
            //        EmailAddress = "jim.beam@bourbon.com"
            //    },
            //    new Speaker
            //    {
            //        Id=2,
            //        First = "Jack",
            //        Last = "Daniels",
            //        EmailAddress = "jack.daniels@whisky.com"
            //    }
            //});

            //modelBuilder.Entity<Sponsor>().HasData(new List<Sponsor>
            //{
            //    new Sponsor
            //    {
            //        Id=1,
            //        CompanyName = "Bad Mutha Distillery",
            //        Level = "Keg",
            //        Description = "A really cool distillery.",
            //        Url = "https://this.doesnot.exist/"
            //    }
            //});
            //foreach (var entity in modelBuilder.Model.GetEntityTypes())
            //{
            //    modelBuilder.Entity(entity.Name).ToTable(entity.ClrType.Name + "s");
            //}
        }
    }
}
