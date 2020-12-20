﻿using Allup.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Allup.DAL
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options){}
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Laptop", Image = "category-1.jpg", IsMain = true, HasDeleted = false },
                new Category { Id = 2, Name = "Computer", Image = "category-2.jpg", IsMain = true, HasDeleted = false },
                new Category { Id = 3, Name = "Smartphone", Image = "category-3.jpg", IsMain = true, HasDeleted = false },
                new Category { Id = 4, Name = "Game Console", Image = "category-4.jpg", IsMain = true, HasDeleted = false },
                new Category { Id = 5, Name = "Bottoms", Image = "category-5.jpg", IsMain = true, HasDeleted = false },
                new Category { Id = 6, Name = "Tops&Sets", Image = "category-6.jpg", IsMain = true, HasDeleted = false },
                new Category { Id = 7, Name = "Audio&Video", Image = "category-7.jpg", IsMain = true, HasDeleted = false },
                new Category { Id = 8, Name = "Accessories", Image = "category-8.jpg", IsMain = true, HasDeleted = false },
                new Category { Id = 9, Name = "Camera", Image = "category-9.jpg", IsMain = true, HasDeleted = false },
                new Category { Id = 10, Name = "Video Games", Image = "category-10.jpg", IsMain = true, HasDeleted = false },
                new Category { Id = 11, Name = "Printer", Image = "category-11.jpg", IsMain = true, HasDeleted = false },
                new Category { Id = 12, Name = "Headphones", Image = "category-12.jpg", IsMain = true, HasDeleted = false }
                );
        }

    }
}
