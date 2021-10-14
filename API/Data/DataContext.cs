using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
            
        }
    
        //takes type of class we want to create database set for (AppUser). Table is then cal Users
        public DbSet<AppUser> Users { get; set; }
    }
}