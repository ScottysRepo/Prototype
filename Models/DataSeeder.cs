using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace CodingClub.Models
{
    public class DataSeeder
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using(var context = new CodingClubContext(serviceProvider.GetRequiredService<DbContextOptions<CodingClubContext>>()))
            {

                // CLIENTS
                if (context.Clients.Any())
                {
                    //leave, there is already data in the database
                    return; 
                }

                var clients = new List<Client>
                {
                    new Client { FirstName="Jimmie", LastName="Ramos", CompanyName="ACME", Email="jramos@acme.com", Phone="555-555-5555" },
                    new Client { FirstName="Kristy", LastName="Miles", CompanyName="World Wide Industries", Email="kmiles@wwi.com", Phone="555-555-5555" },
                    new Client { FirstName="Shelley", LastName="Walker", CompanyName="Big Money Inc", Email="swalker@bigmoneyinc.com", Phone="555-555-5555" },
                     new Client { FirstName="Joe", LastName="Smith", CompanyName="JS", Email="js@gmail.com", Phone="555-555-5555" },
                    new Client { FirstName="John", LastName="Doe", CompanyName="Another Fake Company", Email="fake@fakenews.com", Phone="555-555-5555" }                };
                context.AddRange(clients);
                context.SaveChanges();


                // CLIENTS
                if (context.Members.Any())
                {
                    //leave, there is already data in the database
                    return; 
                }

                var members = new List<Member>
                {
                    new Member { FirstName="Joe", LastName="Doe", Major="CIS", Email="jdoeo@buffs.wtamu.edu", Phone="420-666-6969" },
                   }
                };

                context.AddRange(members);
                context.SaveChanges();

                // PROJECTS
                if (context.Projects.Any())
                {
                    //leave, there is already data in the database
                    return; 
                }

  
                //quickly grab the recent records added to the DB to get the IDs
               
                      

            }
        }
    }
}