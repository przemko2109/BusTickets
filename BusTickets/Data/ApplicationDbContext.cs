using BusTickets.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusTickets.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Age> ages { get; set; }
        public DbSet<City> cities { get; set; }
        public DbSet<Day> days { get; set; }
        public DbSet<Map> map { get; set; }
        public DbSet<Schedule> schedule { get; set; }
        public DbSet<Ticket> tickets { get; set; }
    }
}
