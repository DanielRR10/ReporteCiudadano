﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using sistema_reporte_ciudadano.Models;

namespace sistema_reporte_ciudadano.Migrations
{
    [DbContext(typeof(citizenReportContext))]
    [Migration("20201217004350_addForeignKeysInUserAndIncident")]
    partial class addForeignKeysInUserAndIncident
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityByDefaultColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("sistema_reporte_ciudadano.Models.Incident", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<string>("Date")
                        .HasColumnType("text");

                    b.Property<int>("IdUser")
                        .HasColumnType("integer");

                    b.Property<int>("IdZone")
                        .HasColumnType("integer");

                    b.Property<string>("Media")
                        .HasColumnType("text");

                    b.Property<string>("Msg")
                        .HasColumnType("text");

                    b.Property<int>("Votes")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("IdUser");

                    b.ToTable("Incidents");
                });

            modelBuilder.Entity("sistema_reporte_ciudadano.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<int>("IdZone")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .HasColumnType("text");

                    b.Property<string>("Photo")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("sistema_reporte_ciudadano.Models.Incident", b =>
                {
                    b.HasOne("sistema_reporte_ciudadano.Models.User", "User")
                        .WithMany("Incidents")
                        .HasForeignKey("IdUser")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("sistema_reporte_ciudadano.Models.User", b =>
                {
                    b.Navigation("Incidents");
                });
#pragma warning restore 612, 618
        }
    }
}
