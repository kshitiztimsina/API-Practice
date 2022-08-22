﻿using APIProject.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace APIProject.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }
        public DbSet<Book> books { get; set; }
    }
}
