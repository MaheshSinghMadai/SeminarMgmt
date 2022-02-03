using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SeminarMgmt.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeminarMgmt.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
          
        }
      
        public DbSet<Seminar> Seminars { get; set; }

        public DbSet<Attendee> Attendees { get; set; }

        public DbSet<Organizer> Organizers { get; set; }

    }
}
