﻿// <auto-generated />
using System;
using App.Infrastructures.Db.SqlServer.Ef.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace App.Infrastructures.Db.SqlServer.Ef.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230506114615_init")]
    partial class init
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("App.Domain.Core.Entities.Bid", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<int>("ExpertId")
                        .HasColumnType("int");

                    b.Property<int>("ExpertSuggestedPrice")
                        .HasColumnType("int");

                    b.Property<string>("ExpertSuggestionComment")
                        .IsRequired()
                        .HasMaxLength(2000)
                        .HasColumnType("nvarchar(2000)");

                    b.Property<DateTime?>("LastModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<int?>("LastModifiedBy")
                        .HasColumnType("int");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<int>("StatusId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ExpertId");

                    b.HasIndex("OrderId");

                    b.HasIndex("StatusId");

                    b.ToTable("Bids");
                });

            modelBuilder.Entity("App.Domain.Core.Entities.BidStatus", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int?>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.HasKey("Id");

                    b.ToTable("BidStatuses");
                });

            modelBuilder.Entity("App.Domain.Core.Entities.City", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int?>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DeletedBy")
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("LastModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<int?>("LastModifiedBy")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.HasKey("Id");

                    b.ToTable("Cities");
                });

            modelBuilder.Entity("App.Domain.Core.Entities.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("BackupMobileNumber")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.Property<DateTime?>("Birthdate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("CityId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DeletedBy")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<int?>("GenderId")
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("LastModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<int?>("LastModifiedBy")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("MobileNumber")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.Property<int?>("ScoreAvg")
                        .HasColumnType("int");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("App.Domain.Core.Entities.CustomerAddress", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CityId")
                        .HasColumnType("int");

                    b.Property<string>("CityRegionTitle")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DeletedBy")
                        .HasColumnType("int");

                    b.Property<string>("FullAddress")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<bool>("IsMainAddress")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("LastModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<int?>("LastModifiedBy")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.HasIndex("CustomerId");

                    b.ToTable("CustomerAddresses");
                });

            modelBuilder.Entity("App.Domain.Core.Entities.Expert", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("BackupMobileNumber")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.Property<DateTime?>("Birthdate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("CityId")
                        .HasColumnType("int");

                    b.Property<string>("CompanyName")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DeletedBy")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<int?>("GenderId")
                        .HasColumnType("int");

                    b.Property<string>("HomeAddress")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("LastModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<int?>("LastModifiedBy")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("MobileNumber")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.Property<int?>("ScoreAvg")
                        .HasColumnType("int");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.ToTable("Experts");
                });

            modelBuilder.Entity("App.Domain.Core.Entities.ExpertService", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int?>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DeletedBy")
                        .HasColumnType("int");

                    b.Property<int>("ExpertId")
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("LastModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<int?>("LastModifiedBy")
                        .HasColumnType("int");

                    b.Property<int>("ServiceId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ExpertId");

                    b.HasIndex("ServiceId");

                    b.ToTable("ExpertServices");
                });

            modelBuilder.Entity("App.Domain.Core.Entities.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("AcceptedExpertId")
                        .HasColumnType("int");

                    b.Property<DateTime>("AvailabilityFrom")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("AvailabilityTo")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<int>("CustomerAddressId")
                        .HasColumnType("int");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ExpertFinishedWorkAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ExpertStartedWorkAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("LastModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<int?>("LastModifiedBy")
                        .HasColumnType("int");

                    b.Property<int?>("ScoreByAcceptedExpertId")
                        .HasColumnType("int");

                    b.Property<int?>("ScoreByCustomerId")
                        .HasColumnType("int");

                    b.Property<int>("ServiceCategoryId")
                        .HasColumnType("int");

                    b.Property<int>("StatusId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.HasIndex("StatusId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("App.Domain.Core.Entities.OrderService", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DeletedBy")
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<int>("ServiceId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.HasIndex("ServiceId");

                    b.ToTable("OrderServices");
                });

            modelBuilder.Entity("App.Domain.Core.Entities.OrderStatus", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int?>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.HasKey("Id");

                    b.ToTable("OrderStatues");
                });

            modelBuilder.Entity("App.Domain.Core.Entities.Service", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("BasePrice")
                        .HasColumnType("int");

                    b.Property<int?>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DeletedBy")
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Services");
                });

            modelBuilder.Entity("App.Domain.Core.Entities.ServiceCategory", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int?>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<int?>("ParentId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.HasKey("Id");

                    b.ToTable("ServiceCategories");
                });

            modelBuilder.Entity("App.Domain.Core.Entities.Bid", b =>
                {
                    b.HasOne("App.Domain.Core.Entities.Expert", "Expert")
                        .WithMany("Bids")
                        .HasForeignKey("ExpertId")
                        .IsRequired()
                        .HasConstraintName("FK_Bids_Experts");

                    b.HasOne("App.Domain.Core.Entities.Order", "Order")
                        .WithMany("Bids")
                        .HasForeignKey("OrderId")
                        .IsRequired()
                        .HasConstraintName("FK_Bids_Orders");

                    b.HasOne("App.Domain.Core.Entities.BidStatus", "Status")
                        .WithMany("Bids")
                        .HasForeignKey("StatusId")
                        .IsRequired()
                        .HasConstraintName("FK_Bids_BidStatuses");

                    b.Navigation("Expert");

                    b.Navigation("Order");

                    b.Navigation("Status");
                });

            modelBuilder.Entity("App.Domain.Core.Entities.CustomerAddress", b =>
                {
                    b.HasOne("App.Domain.Core.Entities.City", "City")
                        .WithMany("CustomerAddresses")
                        .HasForeignKey("CityId")
                        .IsRequired()
                        .HasConstraintName("FK_CustomerAddresses_Cities");

                    b.HasOne("App.Domain.Core.Entities.Customer", "Customer")
                        .WithMany("CustomerAddresses")
                        .HasForeignKey("CustomerId")
                        .IsRequired()
                        .HasConstraintName("FK_CustomerAddresses_Customers");

                    b.Navigation("City");

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("App.Domain.Core.Entities.Expert", b =>
                {
                    b.HasOne("App.Domain.Core.Entities.City", "City")
                        .WithMany("Experts")
                        .HasForeignKey("CityId")
                        .HasConstraintName("FK_Experts_Cities");

                    b.Navigation("City");
                });

            modelBuilder.Entity("App.Domain.Core.Entities.ExpertService", b =>
                {
                    b.HasOne("App.Domain.Core.Entities.Expert", "Expert")
                        .WithMany("ExpertServices")
                        .HasForeignKey("ExpertId")
                        .IsRequired()
                        .HasConstraintName("FK_ExpertServices_Experts");

                    b.HasOne("App.Domain.Core.Entities.Service", "Service")
                        .WithMany("ExpertServices")
                        .HasForeignKey("ServiceId")
                        .IsRequired()
                        .HasConstraintName("FK_ExpertServices_Services");

                    b.Navigation("Expert");

                    b.Navigation("Service");
                });

            modelBuilder.Entity("App.Domain.Core.Entities.Order", b =>
                {
                    b.HasOne("App.Domain.Core.Entities.Customer", "Customer")
                        .WithMany("Orders")
                        .HasForeignKey("CustomerId")
                        .IsRequired()
                        .HasConstraintName("FK_Orders_Customers");

                    b.HasOne("App.Domain.Core.Entities.OrderStatus", "Status")
                        .WithMany("Orders")
                        .HasForeignKey("StatusId")
                        .IsRequired()
                        .HasConstraintName("FK_Orders_OrderStatues");

                    b.Navigation("Customer");

                    b.Navigation("Status");
                });

            modelBuilder.Entity("App.Domain.Core.Entities.OrderService", b =>
                {
                    b.HasOne("App.Domain.Core.Entities.Order", "Order")
                        .WithMany("OrderServices")
                        .HasForeignKey("OrderId")
                        .IsRequired()
                        .HasConstraintName("FK_OrderServices_Orders");

                    b.HasOne("App.Domain.Core.Entities.Service", "Service")
                        .WithMany("OrderServices")
                        .HasForeignKey("ServiceId")
                        .IsRequired()
                        .HasConstraintName("FK_OrderServices_Services");

                    b.Navigation("Order");

                    b.Navigation("Service");
                });

            modelBuilder.Entity("App.Domain.Core.Entities.Service", b =>
                {
                    b.HasOne("App.Domain.Core.Entities.ServiceCategory", "Parent")
                        .WithMany("Services")
                        .HasForeignKey("CategoryId")
                        .HasConstraintName("FK_Services_ServiceCategories");

                    b.Navigation("Parent");
                });

            modelBuilder.Entity("App.Domain.Core.Entities.BidStatus", b =>
                {
                    b.Navigation("Bids");
                });

            modelBuilder.Entity("App.Domain.Core.Entities.City", b =>
                {
                    b.Navigation("CustomerAddresses");

                    b.Navigation("Experts");
                });

            modelBuilder.Entity("App.Domain.Core.Entities.Customer", b =>
                {
                    b.Navigation("CustomerAddresses");

                    b.Navigation("Orders");
                });

            modelBuilder.Entity("App.Domain.Core.Entities.Expert", b =>
                {
                    b.Navigation("Bids");

                    b.Navigation("ExpertServices");
                });

            modelBuilder.Entity("App.Domain.Core.Entities.Order", b =>
                {
                    b.Navigation("Bids");

                    b.Navigation("OrderServices");
                });

            modelBuilder.Entity("App.Domain.Core.Entities.OrderStatus", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("App.Domain.Core.Entities.Service", b =>
                {
                    b.Navigation("ExpertServices");

                    b.Navigation("OrderServices");
                });

            modelBuilder.Entity("App.Domain.Core.Entities.ServiceCategory", b =>
                {
                    b.Navigation("Services");
                });
#pragma warning restore 612, 618
        }
    }
}
