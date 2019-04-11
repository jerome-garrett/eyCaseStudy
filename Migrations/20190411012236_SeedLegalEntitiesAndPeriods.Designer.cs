﻿// <auto-generated />
using System;
using EYCaseStudy.API.Persistance;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EYCaseStudy.API.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20190411012236_SeedLegalEntitiesAndPeriods")]
    partial class SeedLegalEntitiesAndPeriods
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.2-servicing-10034")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EYCaseStudy.API.Models.LegalEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.Property<string>("Region");

                    b.HasKey("Id");

                    b.ToTable("LegalEntities");
                });

            modelBuilder.Entity("EYCaseStudy.API.Models.Period", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("StartDate");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.ToTable("Periods");
                });

            modelBuilder.Entity("EYCaseStudy.API.Models.Sale", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BusinessUnit");

                    b.Property<int>("LegalEntityId");

                    b.Property<int>("PeriodId");

                    b.Property<string>("Product");

                    b.Property<string>("ProductLine");

                    b.Property<int>("QuantitySold");

                    b.Property<decimal>("TotalPrice")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasComputedColumnSql("QuantitySold * UnitPrice");

                    b.Property<decimal>("UnitPrice");

                    b.HasKey("Id");

                    b.HasIndex("LegalEntityId");

                    b.HasIndex("PeriodId");

                    b.ToTable("Sales");
                });

            modelBuilder.Entity("EYCaseStudy.API.Models.Sale", b =>
                {
                    b.HasOne("EYCaseStudy.API.Models.LegalEntity", "LegalEntity")
                        .WithMany()
                        .HasForeignKey("LegalEntityId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("EYCaseStudy.API.Models.Period", "Period")
                        .WithMany()
                        .HasForeignKey("PeriodId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
