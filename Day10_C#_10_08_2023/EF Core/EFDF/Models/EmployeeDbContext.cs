using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace EFDF.Models;

public partial class EmployeeDbContext : DbContext
{
    public EmployeeDbContext()
    {
    }

    public EmployeeDbContext(DbContextOptions<EmployeeDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Dept> Depts { get; set; }

    public virtual DbSet<Emp> Emps { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("data source = DESKTOP-052IKRS\\SQLEXPRESS; initial catalog = EmployeeDB; integrated security=SSPI; \nTrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Dept>(entity =>
        {
            entity.HasKey(e => e.DeptNo).HasName("pk_dept");

            entity.ToTable("Dept");

            entity.Property(e => e.DeptNo)
                .ValueGeneratedNever()
                .HasColumnName("dept_no");
            entity.Property(e => e.DeptName)
                .HasMaxLength(25)
                .HasColumnName("dept_name");
        });

        modelBuilder.Entity<Emp>(entity =>
        {
            entity.HasKey(e => e.EmpNo).HasName("pk_emp");

            entity.ToTable("Emp");

            entity.Property(e => e.EmpNo)
                .ValueGeneratedNever()
                .HasColumnName("emp_no");
            entity.Property(e => e.DeptNo).HasColumnName("dept_no");
            entity.Property(e => e.EmpAdd)
                .HasMaxLength(50)
                .HasColumnName("emp_add");
            entity.Property(e => e.EmpName)
                .HasMaxLength(25)
                .HasColumnName("emp_name");

            entity.HasOne(d => d.DeptNoNavigation).WithMany(p => p.Emps)
                .HasForeignKey(d => d.DeptNo)
                .HasConstraintName("fk_dept_no");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
