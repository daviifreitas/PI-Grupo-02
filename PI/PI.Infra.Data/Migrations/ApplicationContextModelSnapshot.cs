﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PI.Infra.Data.Context;

#nullable disable

namespace PI.Infra.Data.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    partial class ApplicationContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("EnterpriseMachineCategory", b =>
                {
                    b.Property<int>("EnterprisesId")
                        .HasColumnType("int");

                    b.Property<int>("MachineCategoriesId")
                        .HasColumnType("int");

                    b.HasKey("EnterprisesId", "MachineCategoriesId");

                    b.HasIndex("MachineCategoriesId");

                    b.ToTable("EnterpriseMachineCategory");
                });

            modelBuilder.Entity("PI.Domain.Entities.Enterprise", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Cnpj")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("Created_at")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("EnterpriseStatusId")
                        .HasColumnType("int");

                    b.Property<string>("FantasyName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("NumberOfLocation")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Sector")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("SocialReason")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("Updated_at")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.HasIndex("EnterpriseStatusId");

                    b.ToTable("Enterprises");
                });

            modelBuilder.Entity("PI.Domain.Entities.EnterpriseStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Enterprise_status");
                });

            modelBuilder.Entity("PI.Domain.Entities.Log", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("Created_at")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("MachineId")
                        .HasColumnType("int");

                    b.Property<double>("Noise")
                        .HasColumnType("double");

                    b.Property<double>("Temp")
                        .HasColumnType("double");

                    b.Property<DateTime>("Time")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("Updated_at")
                        .HasColumnType("datetime(6)");

                    b.Property<double>("Vibration")
                        .HasColumnType("double");

                    b.HasKey("Id");

                    b.HasIndex("MachineId");

                    b.ToTable("Logs");
                });

            modelBuilder.Entity("PI.Domain.Entities.Machine", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Brand")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Created_at")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("EnterpriseId")
                        .HasColumnType("int");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<double>("NoiseMax")
                        .HasColumnType("double");

                    b.Property<double>("NoiseMin")
                        .HasColumnType("double");

                    b.Property<string>("SerialNumber")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("StatusId")
                        .HasColumnType("int");

                    b.Property<double>("TempMax")
                        .HasColumnType("double");

                    b.Property<double>("TempMim")
                        .HasColumnType("double");

                    b.Property<DateTime>("Updated_at")
                        .HasColumnType("datetime(6)");

                    b.Property<double>("VibrationMax")
                        .HasColumnType("double");

                    b.Property<double>("VibrationMin")
                        .HasColumnType("double");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("EnterpriseId");

                    b.HasIndex("StatusId");

                    b.ToTable("Machines");
                });

            modelBuilder.Entity("PI.Domain.Entities.MachineCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("Created_at")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("Updated_at")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.ToTable("Machine_category");
                });

            modelBuilder.Entity("PI.Domain.Entities.MachineStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Machine_status");
                });

            modelBuilder.Entity("PI.Domain.Entities.OutlierRegister", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("Created_at")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("LogId")
                        .HasColumnType("int");

                    b.Property<int>("MachineId")
                        .HasColumnType("int");

                    b.Property<double>("Noise")
                        .HasColumnType("double");

                    b.Property<double>("Temp")
                        .HasColumnType("double");

                    b.Property<DateTime>("Time")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("Updated_at")
                        .HasColumnType("datetime(6)");

                    b.Property<double>("Vibration")
                        .HasColumnType("double");

                    b.HasKey("Id");

                    b.HasIndex("LogId");

                    b.HasIndex("MachineId");

                    b.ToTable("OutlierRegisters");
                });

            modelBuilder.Entity("PI.Domain.Entities.ProblemsCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("Created_at")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("Updated_at")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.ToTable("us_problems_category");
                });

            modelBuilder.Entity("PI.Domain.Entities.UserSupport", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("Created_at")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("EnterpriseId")
                        .HasColumnType("int");

                    b.Property<int>("ProblemsCategoryId")
                        .HasColumnType("int");

                    b.Property<string>("RepresentativoOfEnterpriseAddress")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("Updated_at")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.HasIndex("EnterpriseId");

                    b.HasIndex("ProblemsCategoryId");

                    b.ToTable("UserSupports");
                });

            modelBuilder.Entity("EnterpriseMachineCategory", b =>
                {
                    b.HasOne("PI.Domain.Entities.Enterprise", null)
                        .WithMany()
                        .HasForeignKey("EnterprisesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PI.Domain.Entities.MachineCategory", null)
                        .WithMany()
                        .HasForeignKey("MachineCategoriesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PI.Domain.Entities.Enterprise", b =>
                {
                    b.HasOne("PI.Domain.Entities.EnterpriseStatus", "EnterpriseStatus")
                        .WithMany()
                        .HasForeignKey("EnterpriseStatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("EnterpriseStatus");
                });

            modelBuilder.Entity("PI.Domain.Entities.Log", b =>
                {
                    b.HasOne("PI.Domain.Entities.Machine", "Machine")
                        .WithMany()
                        .HasForeignKey("MachineId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Machine");
                });

            modelBuilder.Entity("PI.Domain.Entities.Machine", b =>
                {
                    b.HasOne("PI.Domain.Entities.MachineCategory", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PI.Domain.Entities.Enterprise", "Enterprise")
                        .WithMany()
                        .HasForeignKey("EnterpriseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PI.Domain.Entities.MachineStatus", "Status")
                        .WithMany()
                        .HasForeignKey("StatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Enterprise");

                    b.Navigation("Status");
                });

            modelBuilder.Entity("PI.Domain.Entities.OutlierRegister", b =>
                {
                    b.HasOne("PI.Domain.Entities.Log", "Log")
                        .WithMany()
                        .HasForeignKey("LogId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PI.Domain.Entities.Machine", "Machine")
                        .WithMany()
                        .HasForeignKey("MachineId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Log");

                    b.Navigation("Machine");
                });

            modelBuilder.Entity("PI.Domain.Entities.UserSupport", b =>
                {
                    b.HasOne("PI.Domain.Entities.Enterprise", "Enterprise")
                        .WithMany()
                        .HasForeignKey("EnterpriseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PI.Domain.Entities.ProblemsCategory", "ProblemsCategory")
                        .WithMany()
                        .HasForeignKey("ProblemsCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Enterprise");

                    b.Navigation("ProblemsCategory");
                });
#pragma warning restore 612, 618
        }
    }
}
