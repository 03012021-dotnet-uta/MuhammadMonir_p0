﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PizzaBox.DAL;

namespace PizzaBox.DAL.Migrations
{
    [DbContext(typeof(MyContext))]
    partial class MyContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.4")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PizzaBox.Domain.Models.Crust", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<float>("BasePrice")
                        .HasColumnType("real");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Crusts");
                });

            modelBuilder.Entity("PizzaBox.Domain.Models.Customer", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("PizzaBox.Domain.Models.CustomizedPizza", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CrustID")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ToppingID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("CrustID");

                    b.HasIndex("ToppingID");

                    b.ToTable("CustomizedPizzas");
                });

            modelBuilder.Entity("PizzaBox.Domain.Models.CustomizedPizzaTopping", b =>
                {
                    b.Property<int>("CustomizedPizzaID")
                        .HasColumnType("int");

                    b.Property<int>("ToppingID")
                        .HasColumnType("int");

                    b.HasKey("CustomizedPizzaID", "ToppingID");

                    b.HasIndex("ToppingID");

                    b.ToTable("CustomizedPizzaTopping");
                });

            modelBuilder.Entity("PizzaBox.Domain.Models.Order", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CustomerID")
                        .HasColumnType("int");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<float>("StoreAmount")
                        .HasColumnType("real");

                    b.Property<int>("StoreID")
                        .HasColumnType("int");

                    b.Property<float>("TaxAmount")
                        .HasColumnType("real");

                    b.HasKey("ID");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("PizzaBox.Domain.Models.OrderDetail", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("OrderID")
                        .HasColumnType("int");

                    b.Property<float>("Price")
                        .HasColumnType("real");

                    b.Property<int>("ProductID")
                        .HasColumnType("int");

                    b.Property<string>("ProductName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("OrderID");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("PizzaBox.Domain.Models.PremadePizza", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CrustID")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ToppingID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("CrustID");

                    b.HasIndex("ToppingID");

                    b.ToTable("PremadePizzas");
                });

            modelBuilder.Entity("PizzaBox.Domain.Models.PremadePizzaTopping", b =>
                {
                    b.Property<int>("PremadePizzaID")
                        .HasColumnType("int");

                    b.Property<int>("ToppingID")
                        .HasColumnType("int");

                    b.HasKey("PremadePizzaID", "ToppingID");

                    b.HasIndex("ToppingID");

                    b.ToTable("PremadePizzaTopping");
                });

            modelBuilder.Entity("PizzaBox.Domain.Models.Size", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("PriceMultiplicationFactor")
                        .HasColumnType("real");

                    b.HasKey("ID");

                    b.ToTable("Sizes");
                });

            modelBuilder.Entity("PizzaBox.Domain.Models.Topping", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<float>("BasePrice")
                        .HasColumnType("real");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Toppings");
                });

            modelBuilder.Entity("PizzaBox.Domain.Models.CustomizedPizza", b =>
                {
                    b.HasOne("PizzaBox.Domain.Models.Crust", "Crust")
                        .WithMany()
                        .HasForeignKey("CrustID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PizzaBox.Domain.Models.Topping", null)
                        .WithMany("CustomizedPizzas")
                        .HasForeignKey("ToppingID");

                    b.Navigation("Crust");
                });

            modelBuilder.Entity("PizzaBox.Domain.Models.CustomizedPizzaTopping", b =>
                {
                    b.HasOne("PizzaBox.Domain.Models.CustomizedPizza", "PremadePizza")
                        .WithMany("CustomizedPizzaToppings")
                        .HasForeignKey("CustomizedPizzaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PizzaBox.Domain.Models.Topping", "Topping")
                        .WithMany()
                        .HasForeignKey("ToppingID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PremadePizza");

                    b.Navigation("Topping");
                });

            modelBuilder.Entity("PizzaBox.Domain.Models.OrderDetail", b =>
                {
                    b.HasOne("PizzaBox.Domain.Models.Order", "Order")
                        .WithMany("OrderDetails")
                        .HasForeignKey("OrderID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");
                });

            modelBuilder.Entity("PizzaBox.Domain.Models.PremadePizza", b =>
                {
                    b.HasOne("PizzaBox.Domain.Models.Crust", "Crust")
                        .WithMany()
                        .HasForeignKey("CrustID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PizzaBox.Domain.Models.Topping", null)
                        .WithMany("PremadePizzaToppings")
                        .HasForeignKey("ToppingID");

                    b.Navigation("Crust");
                });

            modelBuilder.Entity("PizzaBox.Domain.Models.PremadePizzaTopping", b =>
                {
                    b.HasOne("PizzaBox.Domain.Models.PremadePizza", "PremadePizza")
                        .WithMany("PremadePizzaToppings")
                        .HasForeignKey("PremadePizzaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PizzaBox.Domain.Models.Topping", "Topping")
                        .WithMany()
                        .HasForeignKey("ToppingID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PremadePizza");

                    b.Navigation("Topping");
                });

            modelBuilder.Entity("PizzaBox.Domain.Models.CustomizedPizza", b =>
                {
                    b.Navigation("CustomizedPizzaToppings");
                });

            modelBuilder.Entity("PizzaBox.Domain.Models.Order", b =>
                {
                    b.Navigation("OrderDetails");
                });

            modelBuilder.Entity("PizzaBox.Domain.Models.PremadePizza", b =>
                {
                    b.Navigation("PremadePizzaToppings");
                });

            modelBuilder.Entity("PizzaBox.Domain.Models.Topping", b =>
                {
                    b.Navigation("CustomizedPizzas");

                    b.Navigation("PremadePizzaToppings");
                });
#pragma warning restore 612, 618
        }
    }
}
