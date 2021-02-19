using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Models;

namespace WebApp.Data
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {

        }

        public DbSet<Expense> Expenses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Expense>().HasData(new List<Expense>() {
            new Expense(){Id=1, Type="Hotel",Amount=10,Comment="hotel"},
            new Expense(){Id=2,Type="Misc",Amount=10,Comment="misc"},
            new Expense(){Id=3,Type="Resto",Amount=15,Comment="resto"},
            new Expense(){Id=4,Type="Resto",Amount=10,Comment="resto"},
            });

            base.OnModelCreating(modelBuilder);
        }

    }
}
