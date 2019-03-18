using System;
using System.Collections.Generic;
using System.Text;
using AspNetCore.Entity.Core;
using Microsoft.EntityFrameworkCore;

namespace AspNetCore.Entity.Context
{
    public class MsContext: DbContext
    {
        public MsContext(DbContextOptions<MsContext> options):base(options)
        {

        }
        public DbSet<Villager> Villagers { get; set; }
        private static  readonly string connString = "Host=localhost;Port=5432;Database=mstb;Username=postgres;Password=aohui123";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(connString);
        }
    }
}
