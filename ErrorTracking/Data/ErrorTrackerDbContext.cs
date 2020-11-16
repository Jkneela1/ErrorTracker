using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ErrorTracking.Models;


namespace ErrorTracking.Data
{
    public class ErrorTrackerDbContext: DbContext
    {
        public ErrorTrackerDbContext(DbContextOptions<ErrorTrackerDbContext> options)
            : base(options) 
        { }

        public DbSet<Post> Posts { get; set; }
    }
}
