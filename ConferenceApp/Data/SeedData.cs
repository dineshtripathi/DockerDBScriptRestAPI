using System;
using System.Linq;
using ConferenceApp.Models;
using Microsoft.Extensions.DependencyInjection;

namespace ConferenceApp.Data
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            try
            {
                var context = serviceProvider.GetService<ConferenceContext>();
              //  context.Database.EnsureCreated();
              //  if (!context.Speakers.Any())
                {
                    context.Speakers.Add(new Speaker
                    {
                        Id = 1,
                        First = "Jim",
                        Last = "Beam",
                        EmailAddress = "jim.beam@bourbon.com"
                    });
                    context.Speakers.Add(new Speaker
                    {
                        Id = 2,
                        First = "Jack",
                        Last = "Daniels",
                        EmailAddress = "jack.daniels@whisky.com"
                    });
                    context.Sponsors.Add(new Sponsor
                    {
                        Id = 1,
                        CompanyName = "Bad Mutha Distillery",
                        Level = "Keg",
                        Description = "A really cool distillery.",
                        Url = "https://this.doesnot.exist/"
                    });
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
              //  Console.WriteLine(e);
                throw;
            }
          
        }
    }
}