﻿// <auto-generated />
using System;
using LoadingTypes.DataAnnotations.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LoadingTypes.DataAnnotations.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20230822110821_Filling")]
    partial class Filling
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.21")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("LoadingTypes.DataAnnotations.Entities.Categories", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)")
                        .HasColumnName("Category");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Produce"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Drinks"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Dairy"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Meat"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Frozen"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Cleaning"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Baking"
                        });
                });

            modelBuilder.Entity("LoadingTypes.DataAnnotations.Entities.Cities", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("CountryId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("City");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.ToTable("Cities");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CountryId = 1,
                            Name = "Rivne"
                        },
                        new
                        {
                            Id = 2,
                            CountryId = 2,
                            Name = "Lutsk"
                        },
                        new
                        {
                            Id = 3,
                            CountryId = 3,
                            Name = "Lviv"
                        },
                        new
                        {
                            Id = 4,
                            CountryId = 4,
                            Name = "Kiev"
                        },
                        new
                        {
                            Id = 5,
                            CountryId = 5,
                            Name = "Odessa"
                        },
                        new
                        {
                            Id = 6,
                            CountryId = 6,
                            Name = "Lublin"
                        },
                        new
                        {
                            Id = 7,
                            CountryId = 7,
                            Name = "Miami"
                        });
                });

            modelBuilder.Entity("LoadingTypes.DataAnnotations.Entities.Countries", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Country");

                    b.HasKey("Id");

                    b.ToTable("Countries");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Ukraine"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Poland"
                        },
                        new
                        {
                            Id = 3,
                            Name = "United States of America"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Japan"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Kambojo"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Netherland"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Greece"
                        });
                });

            modelBuilder.Entity("LoadingTypes.DataAnnotations.Entities.Positions", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Position");

                    b.HasKey("Id");

                    b.ToTable("Positions");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Chill"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Fast"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Boring"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Amazing"
                        });
                });

            modelBuilder.Entity("LoadingTypes.DataAnnotations.Entities.Products", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("CategoryId")
                        .HasColumnType("int");

                    b.Property<float>("Discount")
                        .HasColumnType("real");

                    b.Property<bool>("IsInStock")
                        .HasColumnType("bit")
                        .HasColumnName("Avaible");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Discount = 47f,
                            IsInStock = true,
                            Name = "Bottle of Water",
                            Price = 430m,
                            Quantity = 4
                        },
                        new
                        {
                            Id = 2,
                            Discount = 12f,
                            IsInStock = false,
                            Name = "Glasses",
                            Price = 630m,
                            Quantity = 0
                        },
                        new
                        {
                            Id = 3,
                            Discount = 134f,
                            IsInStock = true,
                            Name = "Weight",
                            Price = 122m,
                            Quantity = 93
                        },
                        new
                        {
                            Id = 4,
                            Discount = 2f,
                            IsInStock = true,
                            Name = "VGA Monitor",
                            Price = 1120m,
                            Quantity = 12
                        },
                        new
                        {
                            Id = 5,
                            Discount = 0f,
                            IsInStock = true,
                            Name = "Keyboard",
                            Price = 3224m,
                            Quantity = 3
                        },
                        new
                        {
                            Id = 6,
                            Discount = 45f,
                            IsInStock = true,
                            Name = "Steam Deck",
                            Price = 7400m,
                            Quantity = 1120
                        },
                        new
                        {
                            Id = 7,
                            Discount = 0f,
                            IsInStock = true,
                            Name = "Morshinska",
                            Price = 17m,
                            Quantity = 1
                        });
                });

            modelBuilder.Entity("LoadingTypes.DataAnnotations.Entities.Shops", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Adress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CityId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ParkingArea")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.ToTable("Shops");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Adress = "near shag",
                            CityId = 1,
                            Name = "Zlata Plaza",
                            ParkingArea = 1
                        },
                        new
                        {
                            Id = 2,
                            Adress = "bariga house",
                            CityId = 2,
                            Name = "Vandal",
                            ParkingArea = 0
                        },
                        new
                        {
                            Id = 3,
                            Adress = "Asgard",
                            CityId = 3,
                            Name = "Ekvator",
                            ParkingArea = 70
                        },
                        new
                        {
                            Id = 4,
                            Adress = "Stepana Bandery",
                            CityId = 4,
                            Name = "23Sim",
                            ParkingArea = 2
                        },
                        new
                        {
                            Id = 5,
                            Adress = "Kolodenka",
                            CityId = 5,
                            Name = "ABC",
                            ParkingArea = 5
                        },
                        new
                        {
                            Id = 6,
                            Adress = "Near Kolodenka",
                            CityId = 6,
                            Name = "Penny",
                            ParkingArea = 6
                        },
                        new
                        {
                            Id = 7,
                            Adress = "Steam Platform",
                            CityId = 7,
                            Name = "Defense of the Ancients",
                            ParkingArea = 346
                        });
                });

            modelBuilder.Entity("LoadingTypes.DataAnnotations.Entities.Workers", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Phone");

                    b.Property<int>("PositionId")
                        .HasColumnType("int");

                    b.Property<decimal>("Salary")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("ShopId")
                        .HasColumnType("int");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("PositionId");

                    b.HasIndex("ShopId");

                    b.ToTable("Workers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "Word@gmail.com",
                            Name = "Ivan",
                            PhoneNumber = "+3806543905",
                            PositionId = 1,
                            Salary = 0m,
                            ShopId = 1,
                            Surname = "Kuban"
                        },
                        new
                        {
                            Id = 2,
                            Email = "SuperPro@gmail.com",
                            Name = "Luda",
                            PhoneNumber = "+12543623",
                            PositionId = 2,
                            Salary = 1234m,
                            ShopId = 2,
                            Surname = "OneTapMaster"
                        },
                        new
                        {
                            Id = 3,
                            Email = "LargeShake@gmail.com",
                            Name = "Yarik",
                            PhoneNumber = "+20983452345",
                            PositionId = 3,
                            Salary = 76455656m,
                            ShopId = 3,
                            Surname = "TwoTapsMaster"
                        },
                        new
                        {
                            Id = 4,
                            Email = "ThorProMaster69@gmail.com",
                            Name = "Dasha",
                            PhoneNumber = "+01230941025",
                            PositionId = 4,
                            Salary = 3423m,
                            ShopId = 4,
                            Surname = "ProMaster69"
                        },
                        new
                        {
                            Id = 5,
                            Email = "PetroBiba@ukr.ua",
                            Name = "Petro",
                            PhoneNumber = "+3806834563",
                            PositionId = 1,
                            Salary = 99999m,
                            ShopId = 5,
                            Surname = "Biba"
                        },
                        new
                        {
                            Id = 6,
                            Email = "idonthameanemail@gmail.com",
                            Name = "Pudge",
                            PhoneNumber = "+99999999",
                            PositionId = 2,
                            Salary = 1215624618m,
                            ShopId = 6,
                            Surname = "Hook"
                        },
                        new
                        {
                            Id = 7,
                            Email = "ihaveanemail@gmail.com",
                            Name = "Mc Soloway",
                            PhoneNumber = "+1235537345",
                            PositionId = 3,
                            Salary = 12m,
                            ShopId = 7,
                            Surname = "PussyLake"
                        });
                });

            modelBuilder.Entity("LoadingTypes.DataAnnotations.Entities.Cities", b =>
                {
                    b.HasOne("LoadingTypes.DataAnnotations.Entities.Countries", "Countries")
                        .WithMany("Cities")
                        .HasForeignKey("CountryId");

                    b.Navigation("Countries");
                });

            modelBuilder.Entity("LoadingTypes.DataAnnotations.Entities.Products", b =>
                {
                    b.HasOne("LoadingTypes.DataAnnotations.Entities.Categories", "Categories")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId");

                    b.Navigation("Categories");
                });

            modelBuilder.Entity("LoadingTypes.DataAnnotations.Entities.Shops", b =>
                {
                    b.HasOne("LoadingTypes.DataAnnotations.Entities.Cities", "Cities")
                        .WithMany("Shops")
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cities");
                });

            modelBuilder.Entity("LoadingTypes.DataAnnotations.Entities.Workers", b =>
                {
                    b.HasOne("LoadingTypes.DataAnnotations.Entities.Positions", "Positions")
                        .WithMany("Workers")
                        .HasForeignKey("PositionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LoadingTypes.DataAnnotations.Entities.Shops", "Shops")
                        .WithMany("Workers")
                        .HasForeignKey("ShopId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Positions");

                    b.Navigation("Shops");
                });

            modelBuilder.Entity("LoadingTypes.DataAnnotations.Entities.Categories", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("LoadingTypes.DataAnnotations.Entities.Cities", b =>
                {
                    b.Navigation("Shops");
                });

            modelBuilder.Entity("LoadingTypes.DataAnnotations.Entities.Countries", b =>
                {
                    b.Navigation("Cities");
                });

            modelBuilder.Entity("LoadingTypes.DataAnnotations.Entities.Positions", b =>
                {
                    b.Navigation("Workers");
                });

            modelBuilder.Entity("LoadingTypes.DataAnnotations.Entities.Shops", b =>
                {
                    b.Navigation("Workers");
                });
#pragma warning restore 612, 618
        }
    }
}
