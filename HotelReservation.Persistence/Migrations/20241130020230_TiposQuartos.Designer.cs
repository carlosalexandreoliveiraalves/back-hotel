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
    [Migration("20241130020230_TiposQuartos")]
    partial class TiposQuartos
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

                    b.Property<bool>("Disponivel")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Numero")
                        .HasColumnType("longtext");

                    b.Property<decimal?>("PrecoPorNoite")
                        .HasColumnType("decimal(65,30)");

                    b.Property<int>("Tipo")
                        .HasColumnType("int");

                    b.Property<string>("quarto_tipo")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("tb_quarto");

                    b.HasDiscriminator<string>("quarto_tipo").HasValue("quarto_simples");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("HotelReservation.Model.Rooms.QuartoLuxo", b =>
                {
                    b.HasBaseType("HotelReservation.Model.Rooms.Quarto");

                    b.HasDiscriminator().HasValue("quarto_luxo");
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

                    b.HasDiscriminator().HasValue("suite");
                });
#pragma warning restore 612, 618
        }
    }
}
