﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace DataAccess.Concrete.EntityFramework.Contexts
{
    public class BasarsoftDbContext : DbContext, IBasarsoftDbContext
    {
        protected readonly IConfiguration Configuration;

        public BasarsoftDbContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public BasarsoftDbContext()
        {
            
        }


        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // connect to postgres with connection string from app settings
            options.UseNpgsql(Configuration.GetConnectionString("WebApiDatabase"));
        }

        public DbSet<Door> Doors { get; set; }
        
    }
}
