using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer
{
    public class AddressDbContext: DbContext
    {
        public DbSet<LongCode> LongCodes { get; set; }
        public DbSet<ShortCode> ShortCodes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.; Database=AddressDB; Trusted_Connection=true;");
        }
    }
}
