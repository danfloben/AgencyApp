﻿using AgencyApp.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace AgencyApp.Data.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Agency> Agencies { get; set; }
        public DbSet<Currency> Currencies { get; set; }

    }
}
