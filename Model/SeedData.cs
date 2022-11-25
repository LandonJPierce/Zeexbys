using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace Zeexbys.Model;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using var context = new FoodContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<FoodContext>>());

        // Look for any movies.
        if (context.Menus.Any())
        {
            return;   // DB has been seeded
        }
        context.Menus.AddRange(
            new Menu
            {
                Name = "Flaming Chow",
                Description = "Piping hot burger with all the trimmings, served open face, cooked with red-hot flares",
                Calories = "899",
                Price = 11
            },
            new Menu
            {
                Name = "Double-Smokey",
                Description = "Double meat and burnt to the crisp, an acquired taste. Cooked with our best burners.",
                Calories = "1400",
                Price = 14
            },
            new Menu
            {
                Name = "Hot dog",
                Description = "It's a hot dog, that's it...",
                Calories = "bro it's literally a hot dog",
                Price = 50
            },
            new Menu
            {
                Name = "BBQ Platter",
                Description = "A bunch of exotic meats cooked with exotic vapors, exotic meats include: Aligator, Zebra, Iguana.",
                Calories = "1600",
                Price = 18
            }
        );
        context.SaveChanges();
    }
}