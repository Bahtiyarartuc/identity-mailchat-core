﻿using IdentityChatEmailNight.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace IdentityChatEmailNight.Context
{
    public class EmailContext : IdentityDbContext<AppUser>

    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-2VT4JLT;initial Catalog=EmailChatNightDb;integrated security=true;trust server certificate=true");
        }

        public DbSet<Message> Messages { get; set; }
    }
}
