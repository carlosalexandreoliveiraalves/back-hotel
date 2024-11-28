using System;
using HotelReservation.Model.Reports;
using HotelReservation.Model.Reservations;
using HotelReservation.Model.Rooms;
using Microsoft.EntityFrameworkCore;

namespace HotelReservation.Persistence.DataContext;

public class HotelReservationEFCoreContext : DbContext
{
// public HotelReservationEFCoreContext(DbContextOptions<HotelReservationEFCoreContext> options) : base(options)
//     {
        
//     }

public HotelReservationEFCoreContext()
    {
        
    }


     protected override void OnConfiguring(DbContextOptionsBuilder options)
         => options.UseMySql(
       "Server=localhost;Database=db_SistemaHotel;User=root;Password=root;",
        new MySqlServerVersion(new Version(8, 0)) 
    );



    public DbSet<Quarto> tb_quarto {get; set;}
    public DbSet<Reserva> tb_reserva { get; set; }
    public DbSet<RelatorioFaturamento> tb_faturamento {get; set;}
    public DbSet<RelatorioOcupacao> tb_ocupacao {get; set;}
    public DbSet<QuartoSimples> QuartoSimples { get; set; }
    public DbSet<QuartoLuxo> QuartoLuxo { get; set; }
    public DbSet<Suite> Suites { get; set; }


     protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder
        .Entity<Quarto>(
            eb =>
            {
                eb.HasKey(pk => pk.Id);
            });

        base.OnModelCreating(modelBuilder);
        modelBuilder
        .Entity<Reserva>(
            eb => {
                eb.HasKey(pk => pk.Id);
            });

        base.OnModelCreating(modelBuilder);
                modelBuilder
        .Entity<RelatorioFaturamento>(
            eb => {
                eb.HasKey(pk => pk.Id);
            });

        base.OnModelCreating(modelBuilder);
                modelBuilder
        .Entity<RelatorioOcupacao>(
            eb => {
                eb.HasKey(pk => pk.Id);
            });
    }

}
