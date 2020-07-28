using DonutWorldAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DonutWorldAPI.Data
{
    public class DonutWorldContext : DbContext
    {
        public DonutWorldContext(DbContextOptions<DonutWorldContext> opt) : base(opt)
        {
                
        }

        public DbSet<Donut> Donuts { get; set; }
    }
}
