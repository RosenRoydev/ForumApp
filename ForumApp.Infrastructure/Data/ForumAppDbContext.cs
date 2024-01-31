using ForumApp.Infrastructure.Data.Configuration;
using ForumApp.Infrastructure.Data.Models;
using ForumApp.Infrastructure.Migrations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumApp.Infrastructure.Data
{
    /// <summary>
    /// Dates for creating and modifying of Database
    /// </summary>
    public class ForumAppDbContext :DbContext
    {
        public ForumAppDbContext(DbContextOptions<ForumAppDbContext> options)
            : base(options) 
        { 


        }
        public DbSet<Post> Posts { get; set; }

        protected override void  OnModelCreating (ModelBuilder modelBuilder)
        {
          
            base.OnModelCreating (modelBuilder);

            modelBuilder.ApplyConfiguration(new PostConfiguration());
        }
        
    }
}
