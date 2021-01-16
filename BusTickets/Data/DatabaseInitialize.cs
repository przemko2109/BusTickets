using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusTickets.Data
{
    public static class DatabaseInitialize
    {
        public static void Initialize(ApplicationDbContext context)
        {
            context.Database.EnsureCreated();

            if(context.schedule.Any())
            {
                return;
            }

            if (context.tickets.Any())
            {
                return;
            }

            if (context.map.Any())
            {
                return;
            }
            
            if (context.days.Any())
            {
                return;
            }
            
            if (context.cities.Any())
            {
                return;
            }
            
            if (context.ages.Any())
            {
                return;
            }
            
            context.SaveChanges();
        }
    }
}
