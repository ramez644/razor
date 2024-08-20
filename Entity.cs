
using Microsoft.EntityFrameworkCore.SqlServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlTypes;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Data.Entity.SqlServer;

using Microsoft.Identity;
using Microsoft.EntityFrameworkCore.Design;
using testquery2fri;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;


namespace testquery2fri
{
    internal class Entity : DbContext
    {
        public Entity() : base()
        {



        }
        public Entity(DbContextOptions options) : base(options)
        {

        }

        //public Entity(DbContextOptions<Entity> options) : base(options) { }

        public  DbSet <Department> Departments { get; set; }

        public DbSet<Doctor> Doctors { get; set; }

        public DbSet<Patient> Patients { get; set; }

        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<DoctorPatient> DoctorPatients { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer(@"Data Source=MVC\SQLEXPRESS;Initial Catalog=test;Integrated Security=True;TrustServerCertificate=True");

            base.OnConfiguring(optionsBuilder);

         
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Patient>().Property(p => p.Name).IsRequired().HasMaxLength(100);
            modelBuilder.Entity<Patient>().Property(p=>p.PhoneNumber).IsRequired().HasMaxLength(15);

            modelBuilder.Entity<Doctor>().Property(p=>p.Name).IsRequired().HasMaxLength(100);
            modelBuilder.Entity<Doctor>().Property(p=>p.Email).IsRequired().HasMaxLength(200);
            modelBuilder.Entity<Doctor>().Property(p => p.YoxEeperience).IsRequired();



        }






    }
}
