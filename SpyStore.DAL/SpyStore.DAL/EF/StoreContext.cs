using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using SpyStore.Models;
using SpyStore.Models.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpyStore.DAL.EF
{
    public class StoreContext : DbContext
    {
        private static DbContextOptions options;

        public StoreContext()

        {
        }
        public StoreContext(DbContextOptions options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Server=(lovaldb)\mssqllocaldb;Database=SpyStore;Trusted_Connection=True;MultipleActiveResultSets=true;");
            }
        }

        public DbSet<Category> Categories { get; set; }

        
    }
}
