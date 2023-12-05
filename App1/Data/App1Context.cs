using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using App1.Data;

namespace App1.Data
{
    public class App1Context : DbContext
    {
        public App1Context (DbContextOptions<App1Context> options)
            : base(options)
        {
        }

        public DbSet<Person> Person { get; set; } = default!;
        public DbSet<App1.Data.Income> Income { get; set; } = default!;
        public DbSet<App1.Data.Expense> Expense { get; set; } = default!;
        public DbSet<App1.Data.Budget> Budget { get; set; } = default!;
        public DbSet<App1.Data.Savings> Savings { get; set; } = default!;
        public object Persons { get; internal set; }
    }
}
