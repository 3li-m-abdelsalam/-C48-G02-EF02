using Microsoft.EntityFrameworkCore;

namespace Assm_2_EF
{
    public static class Program
    {
        static void Main(string[] args)
        {
            {
                var options = new DbContextOptionsBuilder<EventHubDbContext>()
                    .UseSqlServer(
                        "Server=.;Database=EventHubDB;Trusted_Connection=True;TrustServerCertificate=True;")
                    .Options;

                using (var context = new EventHubDbContext(options))
                {
                    context.Database.EnsureCreated();
                }

                Console.WriteLine("EventHub Database Created Successfully!");
            }
        }
    }
}
