using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practice.Models
{
    public class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            EmployeeDBContext context = app.ApplicationServices
                .CreateScope().ServiceProvider.GetRequiredService<EmployeeDBContext>();

            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }

            if (!context.Employees.Any())
            {
                context.Employees.AddRange(

                     new Employee
                     {
                         Name = "Pain",
                         Ages = 20,
                         Number = 2345798,
                         Mails = "Pain@gmail.com",
                         ImgUrl = "https://upload.wikimedia.org/wikipedia/vi/1/13/Pain_Yahiko.jpg"

                     },
                            new Employee
                            {
                                Name = "Conan",
                                Ages = 19,
                                Number = 12345,
                                Mails = "Conan@gmail.com",
                                ImgUrl = "https://upload.wikimedia.org/wikipedia/vi/1/13/Pain_Yahiko.jpg"

                            },
                            new Employee
                            {
                                Name = "Pain",
                                Ages = 20,
                                Number = 2345798,
                                Mails = "Pain@gmail.com",
                                ImgUrl = "https://upload.wikimedia.org/wikipedia/vi/1/13/Pain_Yahiko.jpg"

                            },
                            new Employee
                            {
                                Name = "Conan",
                                Ages = 19,
                                Number = 12345,
                                Mails = "Conan@gmail.com",
                                ImgUrl = "https://upload.wikimedia.org/wikipedia/vi/1/13/Pain_Yahiko.jpg"

                            },
                            new Employee
                            {
                                Name = "Pain",
                                Ages = 20,
                                Number = 2345798,
                                Mails = "Pain@gmail.com",
                                ImgUrl = "https://upload.wikimedia.org/wikipedia/vi/1/13/Pain_Yahiko.jpg"

                            },
                            new Employee
                            {
                                Name = "Conan",
                                Ages = 19,
                                Number = 12345,
                                Mails = "Conan@gmail.com",
                                ImgUrl = "https://upload.wikimedia.org/wikipedia/vi/1/13/Pain_Yahiko.jpg"

                            }
                );
                context.SaveChanges();
            }
        }
    }
}
