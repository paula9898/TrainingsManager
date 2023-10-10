using Microsoft.EntityFrameworkCore;
using TrainingsManager.Backend.Model;
using TrainingsManager.Backend.Model.Activities;

namespace TrainingsManager.Backend.EntityFramework.Data
{
    public class TrainingsManagerDbContext : DbContext
    {
        public TrainingsManagerDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Activity> Activities { get; set; }///zeby entity framework wiedzial jakie tabele mam i recordy
        public DbSet<Cycling> Cyclings { get; set; }
        public DbSet<Running> Runnings { get; set; }
        public DbSet<Squatting> Squattings { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Activity>()
                .HasOne(x => x.User)
                .WithMany(x => x.Activities);


            modelBuilder.Entity<Activity>()
               .HasOne(x => x.Running)
               .WithOne(x => x.Activity)
               .HasForeignKey<Running>(x => x.Id);

            modelBuilder.Entity<Activity>()
             .HasOne(x => x.Cycling)
             .WithOne(x => x.Activity)
             .HasForeignKey<Cycling>(x => x.Id);

            modelBuilder.Entity<Activity>()
             .HasOne(x => x.Squatting)
             .WithOne(x => x.Activity)
             .HasForeignKey<Squatting>(x => x.Id);

            modelBuilder.Entity<Cycling>()
                .ToTable("Cyclings");
            modelBuilder.Entity<Running>()
               .ToTable("Runnings");
            modelBuilder.Entity<Squatting>()
               .ToTable("Squattings");
        }
    }
}