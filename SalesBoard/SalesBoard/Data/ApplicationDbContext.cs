using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SalesBoard.Models;

namespace SalesBoard.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<SalesBoard.Models.Items> Items { get; set; }
        public DbSet<SalesBoard.Models.Sales> Sales { get; set; }
        public DbSet<SalesBoard.Models.Carts> Carts { get; set; }
    }
}
