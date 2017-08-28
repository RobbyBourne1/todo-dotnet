using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using todoDotnet.Models;

namespace todoDotnet.DataContext
{
    public partial class todoListContext : DbContext
    {
        public DbSet<TodoModel> Todos { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseNpgsql(@"Host=localhost;Database=todoList;Username=dev;Password=dev");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {}
    }
}
