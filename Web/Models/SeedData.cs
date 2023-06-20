using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Web.Data;
using System;
using System.Linq;

namespace Web.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new WebContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<WebContext>>()))
        {
            // Look for any Games.
            if (context.Game.Any())
            {
                return;   // DB has been seeded
            }
            context.Game.AddRange(
                new Game
                {
                    Title = "Mario Kart",
                    ReleaseDate = DateTime.Parse("1989-2-12"),
                    Developer = "Nintendo",
                    Price = 7.99M
                },
                new Game
                {
                    Title = "Grand Theft Auto V",
                    ReleaseDate = DateTime.Parse("2012-3-13"),
                    Developer = "Rockstar",
                    Price = 28.99M
                },
                new Game
                {
                    Title = "Need For Speed Underground",
                    ReleaseDate = DateTime.Parse("2003-2-23"),
                    Developer = "EA",
                    Price = 9.99M
                },
                new Game
                {
                    Title = "Need For Speed Underground 2",
                    ReleaseDate = DateTime.Parse("2004-4-15"),
                    Developer = "EA",
                    Price = 23.99M
                }
            );
            context.SaveChanges();
        }
    }
}
