using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperationMaps.EntityFramework
{
    public class OperationMapsDbContextFactory : IDesignTimeDbContextFactory<OperationMapsDbContext>
    {
        public OperationMapsDbContext CreateDbContext(string[] args = null)
        {
            var options = new DbContextOptionsBuilder<OperationMapsDbContext>();
            options.UseSqlite(@"Data Source=C:\Ilya\Cometa\OperationMaps\DB\OperationMaps.db");

            return new OperationMapsDbContext(options.Options);
        }
    }
}
