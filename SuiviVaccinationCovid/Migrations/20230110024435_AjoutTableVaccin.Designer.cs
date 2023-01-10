﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SuiviVaccinationCovidCodeFirst.Modeles;

#nullable disable

namespace SuiviVaccinationCovid.Migrations
{
    [DbContext(typeof(VaccinationContext))]
    [Migration("20230110024435_AjoutTableVaccin")]
    partial class AjoutTableVaccin
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("SuiviVaccinationCovidCodeFirst.Modeles.Dose", b =>
                {
                    b.Property<int>("DoseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DoseId"));

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("NAMPatient")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("VaccinId")
                        .HasColumnType("int");

                    b.HasKey("DoseId");

                    b.HasIndex("VaccinId");

                    b.ToTable("Doses");
                });

            modelBuilder.Entity("SuiviVaccinationCovidCodeFirst.Modeles.Vaccin", b =>
                {
                    b.Property<int>("VaccinId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("VaccinId"));

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("VaccinId");

                    b.ToTable("Vaccins");
                });

            modelBuilder.Entity("SuiviVaccinationCovidCodeFirst.Modeles.Dose", b =>
                {
                    b.HasOne("SuiviVaccinationCovidCodeFirst.Modeles.Vaccin", "Vaccin")
                        .WithMany()
                        .HasForeignKey("VaccinId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Vaccin");
                });
#pragma warning restore 612, 618
        }
    }
}
