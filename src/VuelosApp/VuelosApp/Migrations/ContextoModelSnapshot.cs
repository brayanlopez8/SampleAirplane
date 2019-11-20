﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VuelosApp.Contexto;

namespace VuelosApp.Migrations
{
    [DbContext(typeof(Contexto.Contexto))]
    partial class ContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("VuelosApp.Entidades.AvionesEnt", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion");

                    b.Property<int>("NumeroSerie");

                    b.Property<string>("Observacion");

                    b.HasKey("Id");

                    b.ToTable("AvionesEnt");
                });

            modelBuilder.Entity("VuelosApp.Entidades.PasajerosEnt", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CorreoElectronico");

                    b.Property<decimal>("Identificacion");

                    b.Property<string>("Nombres");

                    b.Property<decimal>("NumeroCelular");

                    b.HasKey("Id");

                    b.ToTable("PasajerosEnt");
                });

            modelBuilder.Entity("VuelosApp.Entidades.SillasEnt", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AvionesEntId");

                    b.Property<int>("IdAvion");

                    b.Property<int>("NumeroSilla");

                    b.HasKey("Id");

                    b.HasIndex("AvionesEntId");

                    b.ToTable("SillasEnt");
                });

            modelBuilder.Entity("VuelosApp.Entidades.VueloEnt", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("FechaVuelo");

                    b.HasKey("Id");

                    b.ToTable("VueloEnt");
                });

            modelBuilder.Entity("VuelosApp.Entidades.VuelosPorPasajeroEnt", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("FechaAsignacionSilla");

                    b.Property<DateTime>("FechaCompra");

                    b.Property<int>("IdAvion");

                    b.Property<int>("IdSilla");

                    b.Property<int>("IdVuelo");

                    b.Property<int?>("SillasEntId");

                    b.Property<int?>("VueloEntId");

                    b.Property<int?>("VuelosEntId");

                    b.HasKey("Id");

                    b.HasIndex("SillasEntId");

                    b.HasIndex("VueloEntId");

                    b.HasIndex("VuelosEntId");

                    b.ToTable("VuelosPorPasajeroEnt");
                });

            modelBuilder.Entity("VuelosApp.Entidades.SillasEnt", b =>
                {
                    b.HasOne("VuelosApp.Entidades.AvionesEnt", "AvionesEnt")
                        .WithMany()
                        .HasForeignKey("AvionesEntId");
                });

            modelBuilder.Entity("VuelosApp.Entidades.VuelosPorPasajeroEnt", b =>
                {
                    b.HasOne("VuelosApp.Entidades.SillasEnt", "SillasEnt")
                        .WithMany()
                        .HasForeignKey("SillasEntId");

                    b.HasOne("VuelosApp.Entidades.VueloEnt", "VueloEnt")
                        .WithMany()
                        .HasForeignKey("VueloEntId");

                    b.HasOne("VuelosApp.Entidades.AvionesEnt", "VuelosEnt")
                        .WithMany()
                        .HasForeignKey("VuelosEntId");
                });
#pragma warning restore 612, 618
        }
    }
}
