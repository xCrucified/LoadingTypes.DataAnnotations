﻿using LoadingTypes.DataAnnotations.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace LoadingTypes.DataAnnotations.Data
{
    public class DataContext : DbContext
    {
        public DataContext() : base()
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            string conn = "Data Source=(localdb)\\ProjectModels;Initial Catalog=ShopDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            optionsBuilder.UseSqlServer(conn);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Categories>().HasData(new[]
            {
                new Categories() { Id = 1, Name = "Produce" },
                new Categories() { Id = 2, Name = "Drinks" },
                new Categories() { Id = 3, Name = "Dairy" },
                new Categories() { Id = 4, Name = "Meat" },
                new Categories() { Id = 5, Name = "Frozen" },
                new Categories() { Id = 6, Name = "Cleaning" },
                new Categories() { Id = 7, Name = "Baking"},
            });
            modelBuilder.Entity<Cities>().HasData(new[]
            {
                new Categories() { Id = 1, Name = "Rivne"},
                new Categories() { Id = 2, Name = "Lutsk"},
                new Categories() { Id = 3, Name = "Lviv"},
                new Categories() { Id = 4, Name = "Kiev"},
                new Categories() { Id = 5, Name = "Odessa"},
                new Categories() { Id = 6, Name = "Lublin"},
                new Categories() { Id = 7, Name = "Miami"},
            });
            modelBuilder.Entity<Countries>().HasData(new[]
            {
                new Countries() { Id = 1, Name = "Ukraine"},
                new Countries() { Id = 2, Name = "Poland"},
                new Countries() { Id = 3, Name = "United States of America"},
                new Countries() { Id = 4, Name = "Japan"},
                new Countries() { Id = 5, Name = "Kambojo"},
                new Countries() { Id = 6, Name = "Netherland"},
                new Countries() { Id = 7, Name = "Greece"},
            });
            modelBuilder.Entity<Positions>().HasData(new[]
            {
                new Positions() { Id = 1, Name = "Chill"},
                new Positions() { Id = 2, Name = "Fast"},
                new Positions() { Id = 3, Name = "Boring"},
                new Positions() { Id = 4, Name = "Amazing"},
            });
            modelBuilder.Entity<Products>().HasData(new[]
            {
                new Products() { Id = 1, Name = "Bottle of Water", Discount = 47, Price = 430, IsInStock = true, Quantity = 4, CategoryId = 1},
                new Products() { Id = 2, Name = "Glasses", Discount = 12, Price = 630, IsInStock = false, Quantity = 0, CategoryId = 2},
                new Products() { Id = 3, Name = "Weight", Discount = 134, Price = 122, IsInStock = true, Quantity = 93, CategoryId = 3},
                new Products() { Id = 4, Name = "VGA Monitor", Discount = 2, Price = 1120, IsInStock = true, Quantity = 12, CategoryId = 4},
                new Products() { Id = 5, Name = "Keyboard", Discount = 0f, Price = 3224, IsInStock = true, Quantity = 3, CategoryId = 5},
                new Products() { Id = 6, Name = "Steam Deck", Discount = 45, Price = 7400, IsInStock = true, Quantity = 1120, CategoryId = 6},
                new Products() { Id = 7, Name = "Morshinska", Discount = 0, Price = 17, IsInStock = true, Quantity = 1, CategoryId = 7},
            });
            modelBuilder.Entity<Shops>().HasData(new[]
            {
                new Shops() { Name = "Zlata Plaza", Adress = "near shag", ParkingArea = 1, CityId = 1 },
                new Shops() { Name = "Vandal", Adress = "bariga house", ParkingArea = 0 , CityId = 2 },
                new Shops() { Name = "Ekvator", Adress = "Asgard", ParkingArea = 70  , CityId = 3},
                new Shops() { Name = "23Sim", Adress = "Stepana Bandery", ParkingArea = 2, CityId = 4},
                new Shops() { Name = "ABC", Adress = "Kolodenka", ParkingArea = 5   , CityId = 5},
                new Shops() { Name = "Penny", Adress = "Near Kolodenka", ParkingArea = 6   , CityId = 6},
                new Shops() { Name = "Defense of the Ancients", Adress = "Steam Platform", ParkingArea = 346, CityId = 7},
            });
            modelBuilder.Entity<Workers>().HasData(new[]
            {
                new Workers() { Name = "Ivan" , Surname = "Kuban", Email = "Word@gmail.com", PhoneNumber = "+3806543905", Salary = 0,PositionId = 3, ShopId = 1 },
                new Workers() { Name = "Luda" , Surname = "OneTapMaster", Email = "SuperPro@gmail.com", PhoneNumber = "+12543623", Salary = 1234, ShopId = 2, PositionId = 2},
                new Workers() { Name = "Yarik" , Surname = "TwoTapsMaster", Email = "LargeShake@gmail.com", PhoneNumber = "+20983452345", Salary = 76455656, ShopId = 3, PositionId = 1},
                new Workers() { Name = "Dasha" , Surname = "ProMaster69", Email = "ThorProMaster69@gmail.com", PhoneNumber ="+01230941025", Salary = 3423, PositionId = 4, ShopId = 4},
                new Workers() { Name = "Petro" , Surname = "Biba", Email = "PetroBiba@ukr.ua", PhoneNumber = "+3806834563", Salary = 99999, PositionId = 3, ShopId = 5},
                new Workers() { Name = "Pudge" , Surname = "Hook", Email = "idonthameanemail@gmail.com", PhoneNumber = "+99999999", Salary = 1215624618, PositionId = 2, ShopId = 6},
                new Workers() { Name = "Mc Soloway" , Surname = "PussyLake", Email = "ihaveanemail@gmail.com", PhoneNumber = "+1235537345", Salary = 12, PositionId = 1, ShopId =7},
            });
        }


        public DbSet<Categories> Categories { get; set; }
        public DbSet<Cities> Cities { get; set; }
        public DbSet<Countries> Countries { get; set; }
        public DbSet<Positions> Positions { get; set; }
        public DbSet<Products> Products { get; set; }
        public DbSet<Shops> Shops { get; set; }
        public DbSet<Workers> Workers { get; set; }
    }
}
