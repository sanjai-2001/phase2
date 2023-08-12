﻿// <auto-generated />
using System;
using EFCF.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EFCF.Migrations
{
    [DbContext(typeof(EmployeeDataBase))]
    [Migration("20230810073706_createDB1")]
    partial class createDB1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EFCF.Model.Dept", b =>
                {
                    b.Property<int>("DeptNo")
                        .HasColumnType("int");

                    b.Property<string>("DeptName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DeptNo");

                    b.ToTable("Depts");
                });

            modelBuilder.Entity("EFCF.Model.Emp", b =>
                {
                    b.Property<int>("EmpNo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EmpNo"));

                    b.Property<int?>("DeptNavDeptNo")
                        .HasColumnType("int");

                    b.Property<string>("EmpName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Empadd")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EmpNo");

                    b.HasIndex("DeptNavDeptNo");

                    b.ToTable("Emps");
                });

            modelBuilder.Entity("EFCF.Model.Emp", b =>
                {
                    b.HasOne("EFCF.Model.Dept", "DeptNav")
                        .WithMany("Employees")
                        .HasForeignKey("DeptNavDeptNo");

                    b.Navigation("DeptNav");
                });

            modelBuilder.Entity("EFCF.Model.Dept", b =>
                {
                    b.Navigation("Employees");
                });
#pragma warning restore 612, 618
        }
    }
}
