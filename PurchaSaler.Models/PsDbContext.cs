using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace PurchaSaler.Models
{
    public class PsDbContext:DbContext
    {
        public PsDbContext(DbContextOptions<PsDbContext> options)
            :base(options)
        {

        }

        public DbSet<Users> Users { get; set; }
    }
}
