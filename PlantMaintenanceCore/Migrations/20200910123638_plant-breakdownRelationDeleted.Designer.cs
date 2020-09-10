﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PlantMaintenanceCore.Models.DataModels;

namespace PlantMaintenanceCore.Migrations
{
    [DbContext(typeof(PlantMaintenanceCoreDbContext))]
    [Migration("20200910123638_plant-breakdownRelationDeleted")]
    partial class plantbreakdownRelationDeleted
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PlantMaintenanceCore.Models.DataModels.Breakdown", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("BreakdownTypeId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DeclareTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DoneTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDone")
                        .HasColumnType("bit");

                    b.Property<int?>("MachineId")
                        .HasColumnType("int");

                    b.Property<int?>("PersonnelMaintenanceId")
                        .HasColumnType("int");

                    b.Property<int?>("PersonnelRequestingId")
                        .HasColumnType("int");

                    b.Property<int?>("UrgencyId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BreakdownTypeId");

                    b.HasIndex("MachineId");

                    b.HasIndex("PersonnelMaintenanceId");

                    b.HasIndex("PersonnelRequestingId");

                    b.HasIndex("UrgencyId");

                    b.ToTable("Breakdowns");
                });

            modelBuilder.Entity("PlantMaintenanceCore.Models.DataModels.BreakdownType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BreakdownTypeName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("BreakdownTypes");
                });

            modelBuilder.Entity("PlantMaintenanceCore.Models.DataModels.Machine", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("MachineName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PlantId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Machines");
                });

            modelBuilder.Entity("PlantMaintenanceCore.Models.DataModels.Personnel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Performance")
                        .HasColumnType("int");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<int>("TitleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.HasIndex("TitleId");

                    b.ToTable("Personnels");
                });

            modelBuilder.Entity("PlantMaintenanceCore.Models.DataModels.Plant", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("PlantName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Plants");
                });

            modelBuilder.Entity("PlantMaintenanceCore.Models.DataModels.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("RoleName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("PlantMaintenanceCore.Models.DataModels.Title", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("TitleName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Titles");
                });

            modelBuilder.Entity("PlantMaintenanceCore.Models.DataModels.Urgency", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("UrgencyLevel")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Urgencies");
                });

            modelBuilder.Entity("PlantMaintenanceCore.Models.DataModels.Breakdown", b =>
                {
                    b.HasOne("PlantMaintenanceCore.Models.DataModels.BreakdownType", "BreakdownType")
                        .WithMany()
                        .HasForeignKey("BreakdownTypeId");

                    b.HasOne("PlantMaintenanceCore.Models.DataModels.Machine", "Machine")
                        .WithMany()
                        .HasForeignKey("MachineId");

                    b.HasOne("PlantMaintenanceCore.Models.DataModels.Personnel", "PersonnelMaintenance")
                        .WithMany()
                        .HasForeignKey("PersonnelMaintenanceId");

                    b.HasOne("PlantMaintenanceCore.Models.DataModels.Personnel", "PersonnelRequesting")
                        .WithMany()
                        .HasForeignKey("PersonnelRequestingId");

                    b.HasOne("PlantMaintenanceCore.Models.DataModels.Urgency", "Urgency")
                        .WithMany()
                        .HasForeignKey("UrgencyId");
                });

            modelBuilder.Entity("PlantMaintenanceCore.Models.DataModels.Personnel", b =>
                {
                    b.HasOne("PlantMaintenanceCore.Models.DataModels.Role", null)
                        .WithMany("Personnels")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PlantMaintenanceCore.Models.DataModels.Title", null)
                        .WithMany("Personnels")
                        .HasForeignKey("TitleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
