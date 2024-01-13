using Azure;
using CarRental.DataBase.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using static System.Net.Mime.MediaTypeNames;
using CarRental.DTO;
using System.Reflection.Emit;
using System.ComponentModel;
using System.Xml;
using Microsoft.Build.Execution;

namespace CarRental.DataBase
{
    public class Context : IdentityDbContext<Client>
    {
        
       
           public DbSet<Car> Cars { get; set; }
           public DbSet<Client> Clients { get; set; }
           public DbSet<Rental> Rentals { get; set; }
           public DbSet<Review> Reviews { get; set; }



            public Context(DbContextOptions<Context> options) : base(options)
            {


            }


            protected override void OnModelCreating(ModelBuilder builder)
            {
                base.OnModelCreating(builder);




            builder.Entity<Rental>()
                .HasKey(r => r.Id);

            builder.Entity<Rental>()
                .HasOne<Car>(r => r.Car)
                .WithMany(c => c.Rentals)
                .HasForeignKey(r => r.CarId);

            builder.Entity<Rental>()
                .HasOne<Client>(r => r.Client)
                .WithMany(c => c.Rentals)
                .HasForeignKey(r => r.ClientId);




            builder.Entity<Review>()
                .HasKey(r => r.Id);

            builder.Entity<Review>()
                .HasOne<Car>(r => r.Car)
                .WithMany(c => c.Reviews)
                .HasForeignKey(r => r.CarId);

            builder.Entity<Review>()
                .HasOne<Client>(r => r.Client)
                .WithMany(c => c.Reviews)
                .HasForeignKey(r => r.ClientId);


            // Cascade deleting
            builder.Entity<Car>()
                .HasMany(c => c.Rentals)
                 .WithOne(r => r.Car)
                 .OnDelete(DeleteBehavior.Cascade);

           builder.Entity<Car>()
                .HasMany(c => c.Reviews)
                .WithOne(r => r.Car)
                .OnDelete(DeleteBehavior.Cascade);





            //builder.Entity<Application>()
            //    .HasKey(ap => new { ap.JobId, ap.UserId });


            //builder.Entity<Application>()
            //    .HasOne<Job>(ap => ap.Job)
            //    .WithMany(j => j.Applications)
            //    .HasForeignKey(ap => ap.JobId)
            //    .OnDelete(DeleteBehavior.NoAction);

            //builder.Entity<Application>()
            //    .HasOne<User>(ap => ap.User)
            //    .WithMany(u => u.Applications)
            //    .HasForeignKey(ap => ap.UserId)
            //    .OnDelete(DeleteBehavior.NoAction);





        }


            public DbSet<CarRental.DTO.AvailableCarViewModel> AvailableCarViewModel { get; set; } = default!;

    }

    }

