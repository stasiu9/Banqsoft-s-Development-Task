﻿// <auto-generated />
using System;
using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LoanAPI.Migrations
{
    [DbContext(typeof(RepositoryContext))]
    partial class RepositoryContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Entities.Models.Loan", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("LoandId");

                    b.Property<double>("InterestRate")
                        .HasColumnType("float");

                    b.Property<string>("LoanType")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.HasKey("Id");

                    b.ToTable("Loans");

                    b.HasData(
                        new
                        {
                            Id = new Guid("96a7ebc6-65b2-4c7a-96bc-4daac6a5b237"),
                            InterestRate = 3.5,
                            LoanType = "Housing loan"
                        },
                        new
                        {
                            Id = new Guid("b6014483-03ac-4829-8b0b-ad2627542df4"),
                            InterestRate = 5.2999999999999998,
                            LoanType = "Car loan"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
