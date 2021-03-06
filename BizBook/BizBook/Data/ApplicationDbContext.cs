﻿using System;
using System.Collections.Generic;
using System.Text;
using BizBook.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BizBook.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<ApplicationUser> ApplicationUsers { get; set; }

        public DbSet<BizBook.Models.BusinessProfile> BusinessProfile { get; set; }

        public DbSet<BizBook.Models.Consumer> Consumer { get; set; }
        public DbSet<BlogPost> BlogPost { get; set; }
        public DbSet<BizBook.Models.Ad> Ad { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Message> Message { get; set; }
        public DbSet<UserGroup> UserGroup { get; set; }
        public DbSet<BizBook.Models.SavedBusiness> SavedBusiness { get; set; }

    }
}
