﻿// <auto-generated />
using System;
using IKEA.DAL.Persistant.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace IKEA.DAL.Persistant.Data.Migration
{
   
    partial class DepartmentModule
    {
        /// <inheritdoc />
        protected override void DepartmentModule(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("IKEA.DAL.Models.Departments.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 10L, 10);

                    b.Property<DateOnly>("CreationDate")
                        .HasColumnType("date");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int>("LastModifiedBy")
                        .HasColumnType("int");

                    b.Property<int>("LastModifiedOn")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("int")
                        .HasComputedColumnSql("GetDate()");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("code")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<int>("createdby")
                        .HasColumnType("int");

                    b.Property<DateTime>("createdon")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GetDate()");

                    b.HasKey("Id");

                    b.ToTable("departments");
                });
#pragma warning restore 612, 618
        }
    }
}
