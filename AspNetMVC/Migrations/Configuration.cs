namespace AspNetMVC.Migrations
{
    using AspNetMVC.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<AspNetMVC.Models.MovieDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(AspNetMVC.Models.MovieDBContext context)
        {
            context.Movies.AddOrUpdate(i => i.Title,
        new Movie
        {
            Title = "When Harry Met Sally",
            RealeaseDate = DateTime.Parse("1989-1-11"),
            Genre = "Romantic Comedy",
            Price = 7.99M
        },

         new Movie
         {
             Title = "Ghostbusters ",
             RealeaseDate = DateTime.Parse("1984-3-13"),
             Genre = "Comedy",
             Price = 8.99M
         },

         new Movie
         {
             Title = "Ghostbusters 2",
             RealeaseDate = DateTime.Parse("1986-2-23"),
             Genre = "Comedy",
             Price = 9.99M
         },

       new Movie
       {
           Title = "Rio Bravo",
           RealeaseDate = DateTime.Parse("1959-4-15"),
           Genre = "Western",
           Price = 3.99M
       }
   );

        }
    }
}
