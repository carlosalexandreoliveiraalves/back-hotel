﻿// <auto-generated />
using System;
using HotelReservation.Persistence.DataContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HotelReservation.Persistence.Migrations
{
    [DbContext(typeof(HotelReservationEFCoreContext))]
    [Migration("20241128155159_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("HotelReservation.Model.Reports.RelatorioFaturamento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DataGeracao")
                        .HasColumnType("datetime(6)");

                    b.Property<decimal>("TotalFaturado")
                        .HasColumnType("decimal(65,30)");

                    b.HasKey("Id");

                    b.ToTable("tb_faturamento");
                });

            modelBuilder.Entity("HotelReservation.Model.Reports.RelatorioOcupacao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DataGeracao")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.ToTable("tb_ocupacao");
                });

            modelBuilder.Entity("HotelReservation.Model.Reservations.Reserva", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DataCheckIn")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DataCheckOut")
                        .HasColumnType("datetime(6)");

                    b.Property<decimal>("ValorTotal")
                        .HasColumnType("decimal(65,30)");

                    b.HasKey("Id");

                    b.ToTable("tb_reserva");
                });

            modelBuilder.Entity("HotelReservation.Model.Rooms.Quarto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasMaxLength(13)
                        .HasColumnType("varchar(13)");

                    b.Property<bool>("Disponivel")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Numero")
                        .HasColumnType("longtext");

                    b.Property<decimal?>("PrecoPorNoite")
                        .HasColumnType("decimal(65,30)");

                    b.Property<int>("Tipo")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("tb_quarto");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Quarto");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("HotelReservation.Model.Rooms.QuartoLuxo", b =>
                {
                    b.HasBaseType("HotelReservation.Model.Rooms.Quarto");

                    b.HasDiscriminator().HasValue("QuartoLuxo");
                });

            modelBuilder.Entity("HotelReservation.Model.Rooms.QuartoSimples", b =>
                {
                    b.HasBaseType("HotelReservation.Model.Rooms.Quarto");

                    b.HasDiscriminator().HasValue("QuartoSimples");
                });

            modelBuilder.Entity("HotelReservation.Model.Rooms.Suite", b =>
                {
                    b.HasBaseType("HotelReservation.Model.Rooms.Quarto");

                    b.Property<int>("Capacidade")
                        .HasColumnType("int");

                    b.HasDiscriminator().HasValue("Suite");
                });
#pragma warning restore 612, 618
        }
    }
}