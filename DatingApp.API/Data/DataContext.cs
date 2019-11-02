using System;
using System.Data;
using Microsoft.EntityFrameworkCore;
using DatingApp.API.Models;

namespace DatingApp.API.Data
{
    public class DataContext :DbContext
    {

        public DataContext(DbContextOptions<DataContext> options) :base(options)
        {
            
        }
        public DbSet<Employee> Employees { get; set; }
    }
}