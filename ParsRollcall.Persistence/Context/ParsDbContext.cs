using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ParsRollcall.Domain.Entities.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParsRollcall.Persistence.Context
{
    public class ParsDbContext:IdentityDbContext<User>
    {
        public ParsDbContext(DbContextOptions options):base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<RollCall>().Property(c => c.Ip).HasMaxLength(15);
        }
        public DbSet<RollCall> RollCalls { get; set; }
    }
}
