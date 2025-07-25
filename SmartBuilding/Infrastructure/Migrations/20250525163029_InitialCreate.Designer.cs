﻿// <auto-generated />
using System;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20250525163029_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Apartment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ApartmentNumber")
                        .HasColumnType("int");

                    b.Property<int>("BuildingId")
                        .HasColumnType("int");

                    b.Property<int>("HouseCommitteeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BuildingId");

                    b.HasIndex("HouseCommitteeId");

                    b.ToTable("Apartments");
                });

            modelBuilder.Entity("Domain.Entities.Building", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Buildings");
                });

            modelBuilder.Entity("Domain.Entities.HouseCommittee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("BuildingId")
                        .HasColumnType("int");

                    b.Property<DateOnly>("EndDate")
                        .HasColumnType("date");

                    b.Property<int>("ResidentId")
                        .HasColumnType("int");

                    b.Property<DateOnly>("StartDate")
                        .HasColumnType("date");

                    b.HasKey("Id");

                    b.HasIndex("BuildingId");

                    b.HasIndex("ResidentId");

                    b.ToTable("HouseCommittees");
                });

            modelBuilder.Entity("Domain.Entities.Meeting", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AudioFilePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateOnly?>("DateChangeDeadline")
                        .HasColumnType("date");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateOnly>("ScheduledDate")
                        .HasColumnType("date");

                    b.Property<string>("Summary")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Topic")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Meetings");
                });

            modelBuilder.Entity("Domain.Entities.MeetingAttendance", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Comment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsPresent")
                        .HasColumnType("bit");

                    b.Property<int>("MeetingId")
                        .HasColumnType("int");

                    b.Property<int>("ResidentId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MeetingId");

                    b.HasIndex("ResidentId");

                    b.ToTable("MeetingAttendances");
                });

            modelBuilder.Entity("Domain.Entities.Repair", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Comments")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RepairStatusId")
                        .HasColumnType("int");

                    b.Property<int>("RepairTypeId")
                        .HasColumnType("int");

                    b.Property<DateOnly>("ReportDate")
                        .HasColumnType("date");

                    b.Property<int>("ResidentId")
                        .HasColumnType("int");

                    b.Property<DateOnly?>("StatusChangeDate")
                        .HasColumnType("date");

                    b.HasKey("Id");

                    b.HasIndex("RepairStatusId");

                    b.HasIndex("RepairTypeId");

                    b.HasIndex("ResidentId");

                    b.ToTable("Repairs");
                });

            modelBuilder.Entity("Domain.Entities.RepairStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("RepairStatuses");
                });

            modelBuilder.Entity("Domain.Entities.RepairType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("RepairTypes");
                });

            modelBuilder.Entity("Domain.Entities.Resident", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ApartmentId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateOnly>("EndDate")
                        .HasColumnType("date");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateOnly>("StartDate")
                        .HasColumnType("date");

                    b.HasKey("Id");

                    b.HasIndex("ApartmentId");

                    b.ToTable("Residents");
                });

            modelBuilder.Entity("Apartment", b =>
                {
                    b.HasOne("Domain.Entities.Building", "Building")
                        .WithMany("Apartments")
                        .HasForeignKey("BuildingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.HouseCommittee", "HouseCommittee")
                        .WithMany()
                        .HasForeignKey("HouseCommitteeId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Building");

                    b.Navigation("HouseCommittee");
                });

            modelBuilder.Entity("Domain.Entities.HouseCommittee", b =>
                {
                    b.HasOne("Domain.Entities.Building", "Building")
                        .WithMany("HouseCommittees")
                        .HasForeignKey("BuildingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Resident", "Resident")
                        .WithMany()
                        .HasForeignKey("ResidentId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Building");

                    b.Navigation("Resident");
                });

            modelBuilder.Entity("Domain.Entities.MeetingAttendance", b =>
                {
                    b.HasOne("Domain.Entities.Meeting", "Meeting")
                        .WithMany("Attendances")
                        .HasForeignKey("MeetingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Resident", "Resident")
                        .WithMany("MeetingAttendances")
                        .HasForeignKey("ResidentId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Meeting");

                    b.Navigation("Resident");
                });

            modelBuilder.Entity("Domain.Entities.Repair", b =>
                {
                    b.HasOne("Domain.Entities.RepairStatus", "RepairStatus")
                        .WithMany("Repairs")
                        .HasForeignKey("RepairStatusId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Domain.Entities.RepairType", "RepairType")
                        .WithMany("Repairs")
                        .HasForeignKey("RepairTypeId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Resident", "Resident")
                        .WithMany("Repairs")
                        .HasForeignKey("ResidentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("RepairStatus");

                    b.Navigation("RepairType");

                    b.Navigation("Resident");
                });

            modelBuilder.Entity("Domain.Entities.Resident", b =>
                {
                    b.HasOne("Apartment", "Apartment")
                        .WithMany("Residents")
                        .HasForeignKey("ApartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Apartment");
                });

            modelBuilder.Entity("Apartment", b =>
                {
                    b.Navigation("Residents");
                });

            modelBuilder.Entity("Domain.Entities.Building", b =>
                {
                    b.Navigation("Apartments");

                    b.Navigation("HouseCommittees");
                });

            modelBuilder.Entity("Domain.Entities.Meeting", b =>
                {
                    b.Navigation("Attendances");
                });

            modelBuilder.Entity("Domain.Entities.RepairStatus", b =>
                {
                    b.Navigation("Repairs");
                });

            modelBuilder.Entity("Domain.Entities.RepairType", b =>
                {
                    b.Navigation("Repairs");
                });

            modelBuilder.Entity("Domain.Entities.Resident", b =>
                {
                    b.Navigation("MeetingAttendances");

                    b.Navigation("Repairs");
                });
#pragma warning restore 612, 618
        }
    }
}
