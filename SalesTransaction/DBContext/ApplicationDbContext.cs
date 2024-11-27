using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using SalesTransaction.Models;

namespace SalesTransaction.DBContext;

public partial class ApplicationDbContext : DbContext
{
    public ApplicationDbContext()
    {
    }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<contact> contacts { get; set; }

    public virtual DbSet<contacts_import> contacts_imports { get; set; }

    public virtual DbSet<deedinformation> deedinformations { get; set; }

    public virtual DbSet<deedinformations_import> deedinformations_imports { get; set; }

    public virtual DbSet<facility> facilities { get; set; }

    public virtual DbSet<facility_import> facility_imports { get; set; }

    public virtual DbSet<lookupsalestype> lookupsalestypes { get; set; }

    public virtual DbSet<lookupusertype> lookupusertypes { get; set; }

    public virtual DbSet<propertydetail> propertydetails { get; set; }

    public virtual DbSet<propertydetails_import> propertydetails_imports { get; set; }

    public virtual DbSet<transaction> transactions { get; set; }

    public virtual DbSet<transaction_import> transaction_imports { get; set; }

    public virtual DbSet<user> users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseNpgsql("server=52.42.52.3 ; port=5438; database=RVParksSalesTransaction; user id=rvsalestrxuser; password=RV$@les78483");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<contact>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.brokerbompanyname).HasMaxLength(200);
            entity.Property(e => e.contactpersonname).HasMaxLength(200);
            entity.Property(e => e.createddate).HasDefaultValueSql("CURRENT_DATE");
            entity.Property(e => e.email).HasMaxLength(200);
            entity.Property(e => e.id).ValueGeneratedOnAdd();
            entity.Property(e => e.phonenumber).HasMaxLength(200);
        });

        modelBuilder.Entity<contacts_import>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("contacts_import");

            entity.Property(e => e.brokerbompanyname).HasMaxLength(200);
            entity.Property(e => e.contactpersonname).HasMaxLength(200);
            entity.Property(e => e.email).HasMaxLength(200);
            entity.Property(e => e.phonenumber).HasMaxLength(200);
            entity.Property(e => e.status).HasMaxLength(200);

            entity.HasOne(d => d.profile).WithMany()
                .HasForeignKey(d => d.profileid)
                .HasConstraintName("contacts_import_profileid_fkey");
        });

        modelBuilder.Entity<deedinformation>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("deedinformation");

            entity.Property(e => e.createddate).HasDefaultValueSql("CURRENT_DATE");
            entity.Property(e => e.dateofdeed).HasMaxLength(100);
            entity.Property(e => e.deeddescription).HasMaxLength(200);
            entity.Property(e => e.deednumber).HasMaxLength(200);
            entity.Property(e => e.deedtype).HasMaxLength(200);
            entity.Property(e => e.grantee).HasMaxLength(200);
            entity.Property(e => e.grantor).HasMaxLength(200);
            entity.Property(e => e.id).ValueGeneratedOnAdd();
            entity.Property(e => e.saleprice).HasMaxLength(100);
        });

        modelBuilder.Entity<deedinformations_import>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("deedinformations_import");

            entity.Property(e => e.deeddescription).HasMaxLength(200);
            entity.Property(e => e.deednumber).HasMaxLength(200);
            entity.Property(e => e.deedtype).HasMaxLength(200);
            entity.Property(e => e.grantee).HasMaxLength(200);
            entity.Property(e => e.grantor).HasMaxLength(200);
            entity.Property(e => e.status).HasMaxLength(200);

            entity.HasOne(d => d.profile).WithMany()
                .HasForeignKey(d => d.profileid)
                .HasConstraintName("deedinformations_import_profileid_fkey");
        });

        modelBuilder.Entity<facility>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("facility");

            entity.Property(e => e._class)
                .HasMaxLength(10)
                .HasColumnName("class");
            entity.Property(e => e.createddate).HasDefaultValueSql("CURRENT_DATE");
            entity.Property(e => e.expansionpotential).HasMaxLength(100);
            entity.Property(e => e.id).ValueGeneratedOnAdd();
            entity.Property(e => e.parkingratio).HasMaxLength(100);
        });

        modelBuilder.Entity<facility_import>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("facility_import");

            entity.Property(e => e._class)
                .HasMaxLength(200)
                .HasColumnName("class");
            entity.Property(e => e.acreage).HasMaxLength(200);
            entity.Property(e => e.status).HasMaxLength(200);

            entity.HasOne(d => d.profile).WithMany()
                .HasForeignKey(d => d.profileid)
                .HasConstraintName("facility_import_profileid_fkey");
        });

        modelBuilder.Entity<lookupsalestype>(entity =>
        {
            entity.HasKey(e => e.id).HasName("lookupsalestype_pkey");

            entity.HasIndex(e => e.name, "lookupsalestype_salestype_key").IsUnique();

            entity.Property(e => e.id).HasDefaultValueSql("nextval('lookupsalestype_id_seq'::regclass)");
            entity.Property(e => e.name).HasMaxLength(100);
        });

        modelBuilder.Entity<lookupusertype>(entity =>
        {
            entity.HasKey(e => e.id).HasName("lookupusertypes_pkey");

            entity.Property(e => e.name).HasMaxLength(255);
        });

        modelBuilder.Entity<propertydetail>(entity =>
        {
            entity.HasKey(e => e.profileid).HasName("propertydetails_pkey");

            entity.Property(e => e.profileid).ValueGeneratedNever();
            entity.Property(e => e.address).HasMaxLength(200);
            entity.Property(e => e.city).HasMaxLength(100);
            entity.Property(e => e.containertype).HasMaxLength(100);
            entity.Property(e => e.createddate).HasDefaultValueSql("CURRENT_DATE");
            entity.Property(e => e.id).ValueGeneratedOnAdd();
            entity.Property(e => e.propertyname).HasMaxLength(200);
            entity.Property(e => e.sourceuniqueid).HasMaxLength(100);
            entity.Property(e => e.state).HasMaxLength(50);
            entity.Property(e => e.zipcode).HasMaxLength(50);
        });

        modelBuilder.Entity<propertydetails_import>(entity =>
        {
            entity.HasKey(e => e.profileid).HasName("propertydetails_import_pkey");

            entity.ToTable("propertydetails_import");

            entity.Property(e => e.profileid).ValueGeneratedNever();
            entity.Property(e => e.address).HasMaxLength(200);
            entity.Property(e => e.city).HasMaxLength(100);
            entity.Property(e => e.propertyname).HasMaxLength(200);
            entity.Property(e => e.state).HasMaxLength(50);
            entity.Property(e => e.status).HasMaxLength(200);
            entity.Property(e => e.zipcode).HasMaxLength(50);
        });

        modelBuilder.Entity<transaction>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("transaction");

            entity.Property(e => e.buyer).HasMaxLength(100);
            entity.Property(e => e.createddate).HasDefaultValueSql("CURRENT_DATE");
            entity.Property(e => e.datesold).HasMaxLength(100);
            entity.Property(e => e.id).ValueGeneratedOnAdd();
            entity.Property(e => e.portfoliopercentage).HasPrecision(5, 2);
            entity.Property(e => e.saletype).HasMaxLength(100);
            entity.Property(e => e.seller).HasMaxLength(100);
        });

        modelBuilder.Entity<transaction_import>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("transaction_import");

            entity.Property(e => e.portfoliopercentage).HasPrecision(5, 2);
            entity.Property(e => e.status).HasMaxLength(200);

            entity.HasOne(d => d.profile).WithMany()
                .HasForeignKey(d => d.profileid)
                .HasConstraintName("transaction_import_profileid_fkey");

            entity.HasOne(d => d.saletype).WithMany()
                .HasForeignKey(d => d.saletypeid)
                .HasConstraintName("transaction_import_saletypeid_fkey");
        });

        modelBuilder.Entity<user>(entity =>
        {
            entity.HasKey(e => e.id).HasName("users_pkey");

            entity.Property(e => e.createddate)
                .HasDefaultValueSql("(CURRENT_TIMESTAMP AT TIME ZONE 'UTC'::text)")
                .HasColumnType("timestamp without time zone");
            entity.Property(e => e.email).HasMaxLength(1000);
            entity.Property(e => e.username).HasMaxLength(2000);

            entity.HasOne(d => d.usertype).WithMany(p => p.users)
                .HasForeignKey(d => d.usertypeid)
                .HasConstraintName("fk_users_usertypeid");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
