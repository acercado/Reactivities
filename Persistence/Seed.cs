using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;

namespace Persistence
{
    public class Seed
    {
        public static async Task SeedData(DataContext context)
        {
            if (context.Activities.Any()) return;
            
            var activities = new List<Activity>
            {
                new Activity
                {
                    Title = "Bulacan Rescue March 2020",
                    Date = DateTime.Now.AddMonths(-2),
                    Description = "Flooding evac",
                    Category = "evac",
                    City = "Bulacan",
                    Venue = "Cityhall",
                },
                new Activity
                {
                    Title = "Mt. Maculot SAR",
                    Date = DateTime.Now.AddMonths(-1),
                    Description = "3 missing mountaineers",
                    Category = "sar",
                    City = "Batangas",
                    Venue = "Cuenca",
                },
                new Activity
                {
                    Title = "VA: Ortigas Avenue",
                    Date = DateTime.Now.AddMonths(1),
                    Description = "Vehicular accident, 2 sedan and 1 van",
                    Category = "va",
                    City = "Ortigas",
                    Venue = "Ortigas Avenue",
                },
                new Activity
                {
                    Title = "Future Activity 2",
                    Date = DateTime.Now.AddMonths(2),
                    Description = "Activity 2 months in future",
                    Category = "sar",
                    City = "Manila",
                    Venue = "Tondo",
                },
                new Activity
                {
                    Title = "Future Activity 3",
                    Date = DateTime.Now.AddMonths(3),
                    Description = "Activity 3 months in future",
                    Category = "ret",
                    City = "Manila",
                    Venue = "Tondo",
                },
                new Activity
                {
                    Title = "Future Activity 4",
                    Date = DateTime.Now.AddMonths(4),
                    Description = "Activity 4 months in future",
                    Category = "va",
                    City = "Manila",
                    Venue = "Tondo",
                },
                new Activity
                {
                    Title = "Future Activity 5",
                    Date = DateTime.Now.AddMonths(5),
                    Description = "Activity 5 months in future",
                    Category = "va",
                    City = "Manila",
                    Venue = "Tondo",
                },
                new Activity
                {
                    Title = "Future Activity 6",
                    Date = DateTime.Now.AddMonths(6),
                    Description = "Activity 6 months in future",
                    Category = "va",
                    City = "Manila",
                    Venue = "Tondo",
                },
                new Activity
                {
                    Title = "Future Activity 7",
                    Date = DateTime.Now.AddMonths(7),
                    Description = "Activity 2 months ago",
                    Category = "va",
                    City = "Manila",
                    Venue = "Tondo",
                },
                new Activity
                {
                    Title = "Future Activity 8",
                    Date = DateTime.Now.AddMonths(8),
                    Description = "Activity 8 months in future",
                    Category = "va",
                    City = "Manila",
                    Venue = "Tondo",
                }
            };

            await context.Activities.AddRangeAsync(activities);
            await context.SaveChangesAsync();
        }
    }
}