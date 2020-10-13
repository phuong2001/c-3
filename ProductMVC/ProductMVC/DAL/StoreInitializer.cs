using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using ProductMVC.Models;

namespace ProductMVC.DAL
{
    public class StoreInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<StoreContext>
    {
        protected override void Seed(StoreContext context)
        {
            var products = new List<Product>
            {
                new Product{name="áo xịn",img="123",EnrollmentDate=DateTime.Parse("2020-01-01")},
                new Product{name="quân đùi",img="123",EnrollmentDate=DateTime.Parse("2020-02-01")},
                new Product{name="váy đểu",img="123",EnrollmentDate=DateTime.Parse("2020-03-01")},
                new Product{name="áo rách",img="123",EnrollmentDate=DateTime.Parse("2020-04-01")},
                new Product{name="quân thủngr đít",img="123",EnrollmentDate=DateTime.Parse("2020-05-01")},
                new Product{name="váy vá",img="123",EnrollmentDate=DateTime.Parse("2020-06-01")}
            };
            products.ForEach(s => context.Products.Add(s));
            context.SaveChanges();

            var categorys = new List<Category>
            {
                new Category{CategoryID=1000,Title="áo",},
                new Category{CategoryID=1111,Title="quần",},
                new Category{CategoryID=1110,Title="váy",}
            };
            categorys.ForEach(s => context.Categorys.Add(s));
            context.SaveChanges();

            var enrollments = new List<Enrollment>
            {
                new Enrollment{ProductID=1,CategoryID=1000,},
                new Enrollment{ProductID=1,CategoryID=1111,},
                new Enrollment{ProductID=1,CategoryID=1110,},
                new Enrollment{ProductID=2,CategoryID=1000,},
                new Enrollment{ProductID=2,CategoryID=1111,},
                new Enrollment{ProductID=3,CategoryID=1110,},
                new Enrollment{ProductID=4,CategoryID=1000,},
                new Enrollment{ProductID=4,CategoryID=1111,},
                new Enrollment{ProductID=5,CategoryID=1110,},
                new Enrollment{ProductID=5,CategoryID=1000,},
                new Enrollment{ProductID=6,CategoryID=1111,},
                new Enrollment{ProductID=6,CategoryID=1110,},
            };
            enrollments.ForEach(s => context.Enrollments.Add(s));
            context.SaveChanges();
        }
    }
}