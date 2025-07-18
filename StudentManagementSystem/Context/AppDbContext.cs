﻿using Microsoft.EntityFrameworkCore;
using StudentManagementSystem.Models;
using System;


namespace StudentManagementSystem.Context
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) 
            : base(options)
        {

        }


        public DbSet<Student> Students { get; set; }
    }
}
