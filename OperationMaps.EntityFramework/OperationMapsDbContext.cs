using Microsoft.EntityFrameworkCore;
using OperationMaps.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperationMaps.EntityFramework
{
    public class OperationMapsDbContext : DbContext
    {
        public OperationMapsDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Form4Item> Form4Items { get; set; }
        public DbSet<Capacitor> Capacitors { get; set; }
    }
}
