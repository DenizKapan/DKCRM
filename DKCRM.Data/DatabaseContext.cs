using DKCRM.Core.Entities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;



namespace DKCRM.Data
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Address> Addresses { get; set; } // veritabanı tablolarımızı temsil eden dbset ler
        public DbSet<Category> Categories { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Defination> Definations { get; set; }
        public DbSet<District> Districts { get; set; }
        public DbSet<Request> Requests { get; set; }        
        public DbSet<SolutionGroup> SolutionGroups { get; set; }
        public DbSet<Statu> Status { get; set; }
        public DbSet<Telephone> Telephones { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Ticket_ATT> Ticket_ATTs { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<ErrorLog> ErrorLogs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"server=.; database=DKCRM; trusted_connection=true; TrustServerCertificate=True;");
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    ID = 1,
                    Email = "admin@kapan.com",
                    Name = "Deniz",
                    SurName = "Kapan",
                    Password = "010203",
                    IsAdmin = true
                },
                new User
                {
                    ID = 2,
                    Email = "bo@kapan.com",
                    Name = "Deniz",
                    SurName = "Kapan",
                    Password = "010203",
                    IsBO = true
                },
                new User
                {
                    ID = 3,
                    Email = "agent@kapan.com",
                    Name = "Deniz",
                    SurName = "Kapan",
                    Password = "010203",
                    IsAgent = true
                });

            modelBuilder.Entity<City>().HasData(
                new City
                {
                    ID = 1,
                    Description = "Adana"
                });
            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    ID = 1,
                    CategoryName = "Şikayet"                    
                });
            modelBuilder.Entity<Request>().HasData(
                new Request
                {
                    ID = 1,
                    RequestName = "Geç Teslim"
                });
            modelBuilder.Entity<SolutionGroup>().HasData(
                new SolutionGroup
                {
                    ID = 1,
                    SolutionName = "BackOffice",
                    DisplayFlag = true
                });

            base.OnModelCreating(modelBuilder);
        }
    }
}
