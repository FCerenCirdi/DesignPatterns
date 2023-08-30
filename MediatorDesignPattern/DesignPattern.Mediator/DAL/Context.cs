﻿using Microsoft.EntityFrameworkCore;

namespace DesignPattern.Mediator.DAL
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-8G1SNAU\\SQLEXPRESS;initial catalog=DesignPattern8;integrated security=true;");
        }
        public DbSet<Product> Products { get; set; }
    }
}
