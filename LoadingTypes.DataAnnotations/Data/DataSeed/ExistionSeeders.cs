using LoadingTypes.DataAnnotations.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoadingTypes.DataAnnotations.Data.DataSeed
{
    public static class ExistionSeeders
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categories>().HasData(new[]
            {
                new Categories() {Id = 1, Name = "Produce" },
                new Categories() {Id = 2, Name = "Drinks" },
                new Categories() {Id = 3, Name = "Dairy" },
                new Categories() {Id = 4, Name = "Meat" },
                new Categories() {Id = 5, Name = "Frozen" },
                new Categories() {Id = 6, Name = "Cleaning" },
                new Categories() {Id = 7, Name = "Baking"},
            });
            modelBuilder.Entity<Countries>().HasData(new[]
            {
                new Countries() {Id = 1,Name = "Ukraine"},
                new Countries() {Id = 2,Name = "Poland"},
                new Countries() {Id = 3,Name = "United States of America"},
                new Countries() {Id = 4,Name = "Japan"},
                new Countries() {Id = 5,Name = "Kambojo"},
                new Countries() {Id = 6,Name = "Netherland"},
                new Countries() {Id = 7,Name = "Greece"},
            });
            modelBuilder.Entity<Cities>().HasData(new[]
            {
                new Cities() {Id = 1, Name = "Rivne", CountryId = 1},
                new Cities() {Id = 2, Name = "Lutsk", CountryId = 2},
                new Cities() {Id = 3, Name = "Lviv", CountryId = 3},
                new Cities() {Id = 4, Name = "Kiev", CountryId = 4},
                new Cities() {Id = 5, Name = "Odessa", CountryId = 5},
                new Cities() {Id = 6, Name = "Lublin", CountryId = 6},
                new Cities() {Id = 7, Name = "Miami", CountryId = 7},
            });
            modelBuilder.Entity<Positions>().HasData(new[]
            {
                new Positions() {Id = 1, Name = "Chill"},
                new Positions() {Id = 2, Name = "Fast"},
                new Positions() {Id = 3, Name = "Boring"},
                new Positions() {Id = 4, Name = "Amazing"},
            });
            modelBuilder.Entity<Products>().HasData(new[]
            {
                new Products() {Id = 1, CategoryId = 1, Name = "Bottle of Water", Discount = 47, Price = 430, IsInStock = true, Quantity = 4},
                new Products() {Id = 2, CategoryId = 2, Name = "Glasses", Discount = 12, Price = 630, IsInStock = false, Quantity = 0},
                new Products() {Id = 3, CategoryId = 3, Name = "Weight", Discount = 134, Price = 122, IsInStock = true, Quantity = 93},
                new Products() {Id = 4, CategoryId = 4, Name = "VGA Monitor", Discount = 2, Price = 1120, IsInStock = true, Quantity = 12},
                new Products() {Id = 5, CategoryId = 5, Name = "Keyboard", Discount = 0f, Price = 3224, IsInStock = true, Quantity = 3},
                new Products() {Id = 6, CategoryId = 6, Name = "Steam Deck", Discount = 45, Price = 7400, IsInStock = true, Quantity = 1120},
                new Products() {Id = 7, CategoryId = 7, Name = "Morshinska", Discount = 0, Price = 17, IsInStock = true, Quantity = 1},
            });
            modelBuilder.Entity<Shops>().HasData(new[]
            {
                new Shops() {Id = 1, CityId = 1, Name = "Zlata Plaza", Adress = "near shag", ParkingArea = 1},
                new Shops() {Id = 2, CityId = 2,Name = "Vandal", Adress = "bariga house", ParkingArea = 0},
                new Shops() {Id = 3, CityId = 3,Name = "Ekvator", Adress = "Asgard", ParkingArea = 70},
                new Shops() {Id = 4, CityId = 4,Name = "23Sim", Adress = "Stepana Bandery", ParkingArea = 2},
                new Shops() {Id = 5, CityId = 5,Name = "ABC", Adress = "Kolodenka", ParkingArea = 5},
                new Shops() {Id = 6, CityId = 6,Name = "Penny", Adress = "Near Kolodenka", ParkingArea = 6},
                new Shops() {Id = 7, CityId = 7,Name = "Defense of the Ancients", Adress = "Steam Platform", ParkingArea = 346},
            });
            modelBuilder.Entity<Workers>().HasData(new[]
            {
                new Workers() {Id = 1, PositionId = 1, ShopId = 1, Name = "Ivan" , Surname = "Kuban", Email = "Word@gmail.com", PhoneNumber = "+3806543905", Salary = 0},
                new Workers() {Id = 2, PositionId = 2, ShopId = 2, Name = "Luda", Surname = "OneTapMaster", Email = "SuperPro@gmail.com", PhoneNumber = "+12543623", Salary = 1234},
                new Workers() {Id = 3, PositionId = 3, ShopId = 3, Name = "Yarik", Surname = "TwoTapsMaster", Email = "LargeShake@gmail.com", PhoneNumber = "+20983452345", Salary = 76455656},
                new Workers() {Id = 4, PositionId = 4, ShopId = 4, Name = "Dasha", Surname = "ProMaster69", Email = "ThorProMaster69@gmail.com", PhoneNumber = "+01230941025", Salary = 3423},
                new Workers() {Id = 5, PositionId = 1, ShopId = 5, Name = "Petro", Surname = "Biba", Email = "PetroBiba@ukr.ua", PhoneNumber = "+3806834563", Salary = 99999},
                new Workers() {Id = 6, PositionId = 2, ShopId = 6, Name = "Pudge", Surname = "Hook", Email = "idonthameanemail@gmail.com", PhoneNumber = "+99999999", Salary = 1215624618},
                new Workers() {Id = 7, PositionId = 3, ShopId = 7, Name = "Mc Soloway", Surname = "PussyLake", Email = "ihaveanemail@gmail.com", PhoneNumber = "+1235537345", Salary = 12},
            });
        }
    }
}
