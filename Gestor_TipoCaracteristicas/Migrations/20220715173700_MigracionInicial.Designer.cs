﻿// <auto-generated />
using Gestor_TipoCaracteristicas.Helpers;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Gestor_TipoCaracteristicas.Migrations
{
    [DbContext(typeof(ApiDataContext))]
    [Migration("20220715173700_MigracionInicial")]
    partial class MigracionInicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Gestor_TipoCaracteristicas.Entities.Modelo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Nombre")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("Nombre");

                    b.HasKey("Id");

                    b.ToTable("Modelo");
                });

            modelBuilder.Entity("Gestor_TipoCaracteristicas.Entities.TipoCaracteristica", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Abreviatura")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)")
                        .HasColumnName("Abreviatura");

                    b.Property<string>("Equipo")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("Equipo");

                    b.Property<int>("ModeloId")
                        .HasColumnType("int")
                        .HasColumnName("ModeloId");

                    b.HasKey("Id");

                    b.HasIndex("ModeloId");

                    b.ToTable("TipoCaracteristica");
                });

            modelBuilder.Entity("Gestor_TipoCaracteristicas.Entities.TipoCaracteristica", b =>
                {
                    b.HasOne("Gestor_TipoCaracteristicas.Entities.Modelo", "Modelo")
                        .WithMany()
                        .HasForeignKey("ModeloId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Modelo");
                });
#pragma warning restore 612, 618
        }
    }
}