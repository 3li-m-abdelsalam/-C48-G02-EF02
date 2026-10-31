using Assm_2_EF.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assm_2_EF
{
    public class EventHubDbContext : DbContext
    {
        public EventHubDbContext(DbContextOptions<EventHubDbContext> options)
            : base(options)
        {
        }

        public DbSet<Organizer> Organizers { get; set; }

        public DbSet<OrganizerProfile> OrganizerProfiles { get; set; }

        public DbSet<Event> Events { get; set; }

        public DbSet<Attendee> Attendees { get; set; }

        public DbSet<Badge> Badges { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(
                new OrganizerProfileConfiguration());
    
            modelBuilder.ApplyConfiguration(
                new BadgeConfiguration());
           
            modelBuilder.Entity<Event>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.HasOne(e => e.Organizer)
                      .WithMany(o => o.Events)
                      .HasForeignKey(e => e.OrganizerId)
                      .IsRequired();
            });
        }
    }
}
