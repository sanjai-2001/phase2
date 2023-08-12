using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace EFDDBF.Models
{

public partial class EmployeeMgmtContext : DbContext
{
    public EmployeeMgmtContext()
    {
    }

    public EmployeeMgmtContext(DbContextOptions<EmployeeMgmtContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Dept> Depts { get; set; }

    public virtual DbSet<Empm> Empms { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)

        => optionsBuilder.UseSqlServer("data source = SANJAIKUMAR\\SQLEXPRESS; initial catalog = EmployeeMgmt; integrated security=SSPI; TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Dept>(entity =>
        {
            entity.HasKey(e => e.Deptno).HasName("PK_dept");

            entity.ToTable("Dept");

            entity.Property(e => e.Deptno)
                .ValueGeneratedNever()
                .HasColumnName("deptno");
            entity.Property(e => e.Dname)
                .HasMaxLength(10)
                .HasColumnName("dname");
        });

        modelBuilder.Entity<Empm>(entity =>
        {
            entity.HasKey(e => e.Deptno).HasName("PK_EMP");

            entity.ToTable("Empm");

            entity.Property(e => e.Deptno)
                .ValueGeneratedNever()
                .HasColumnName("deptno");
            entity.Property(e => e.Addr)
                .HasMaxLength(30)
                .HasColumnName("addr");
            entity.Property(e => e.Empno).HasColumnName("empno");
            entity.Property(e => e.Ename)
                .HasMaxLength(25)
                .HasColumnName("ename");

            entity.HasOne(d => d.DeptnoNavigation).WithOne(p => p.Empm)
                .HasForeignKey<Empm>(d => d.Deptno)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_emp");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
}