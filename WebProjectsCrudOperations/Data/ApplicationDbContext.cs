﻿using Microsoft.EntityFrameworkCore;
using WebProjectsCrudOperations.Models.Entities;

namespace WebProjectsCrudOperations.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
    }
}
