using APIProject.Data.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace APIProject.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();
                if (!context.books.Any())
                {
                    context.books.AddRange(new Book()
                    {
                        title = "1ST Book Title",
                        description = "Description",
                        author = "Kshitiz Timsina",
                        date_added = DateTime.Now.AddDays(-10),
                        rate = 4,
                        genre = "Biography",
                        cover_url = "https..",
                        date_read = DateTime.Now,
                        is_read = true
                    }, new Book()
                    {
                        title = "2nd Book Title",
                        description = "2nd Description",
                        author = "Kshitiz Timsina",
                        date_added = DateTime.Now.AddDays(-10),
                        rate = 4,
                        genre = "Biography",
                        cover_url = "https..",
                        date_read = DateTime.Now,
                        is_read = true
                    });

                    context.SaveChanges();
                }
            }
        }
    }
}
