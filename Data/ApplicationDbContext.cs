using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using GroupProject.Models;

namespace GroupProject.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }
        public DbSet<GroupProject.Models.Booking> Booking { get; set; }
        public DbSet<GroupProject.Models.Customer> Customer { get; set; }
        public DbSet<GroupProject.Models.Room> Room { get; set; }
    }
}
