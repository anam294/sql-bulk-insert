using System;
using Microsoft.EntityFrameworkCore;
using SqlBulkInsertTool.Entities;

namespace SqlBulkInsertTool.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base (options)
        {
        }
            
        public DbSet<Employee> Employees { get; set; }
    }
}

