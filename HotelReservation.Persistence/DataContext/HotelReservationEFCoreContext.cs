using System;
using HotelReservation.Model.Enums;
using HotelReservation.Model.Reports;
using HotelReservation.Model.Reservations;
using HotelReservation.Model.Rooms;
using Microsoft.EntityFrameworkCore;

namespace HotelReservation.Persistence.DataContext;

public class HotelReservationEFCoreContext : DbContext
{
    public HotelReservationEFCoreContext(DbContextOptions<HotelReservationEFCoreContext> options) : base(options)
    {
        
    }

    // public HotelReservationEFCoreContext()
    // {
        
    // }


     protected override void OnConfiguring(DbContextOptionsBuilder options)
         => options.UseMySql(
       "Server=localhost;Database=db_SistemaHotel;User=root;Password=root;",
        new MySqlServerVersion(new Version(8, 0)) 
    );

    public DbSet<Quarto> Quarto {get; set;}
    public DbSet<QuartoLuxo> QuartoLuxo {get; set;}
    public DbSet<Suite> Suite {get; set;}
    public DbSet<QuartoSimples> QuartoSimples {get; set;}
    public DbSet<Reserva> Reserva { get; set; }
    public DbSet<RelatorioFaturamento> RelatorioFaturamento {get; set;}
    public DbSet<RelatorioOcupacao> RelatorioOcupacao {get; set;}
    
     protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder
        .Entity<Quarto>().ToTable("Quarto").HasDiscriminator<TipoQuarto>("Tipo")
                .HasValue<QuartoSimples>(TipoQuarto.Simples)
                .HasValue<Suite>(TipoQuarto.Suite)
                .HasValue<QuartoLuxo>(TipoQuarto.Luxo);

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
