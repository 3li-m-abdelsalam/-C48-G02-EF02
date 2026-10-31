using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assm_2_EF.NewFolder
{
    public class EventHubDbContextFactory
         : IDesignTimeDbContextFactory<EventHubDbContext>
    {
        public EventHubDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder =
                new DbContextOptionsBuilder<EventHubDbContext>();

            optionsBuilder.UseSqlServer(
                "Server=.;Database=EventHubDB;Trusted_Connection=True;TrustServerCertificate=True;");

            return new EventHubDbContext(optionsBuilder.Options);
        }
    }
}
