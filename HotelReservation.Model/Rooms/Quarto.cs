using System;
using HotelReservation.Model.Enums;

namespace HotelReservation.Model.Rooms;

public abstract class Quarto
{
    public int Id { get; set; }
    public string? Numero { get; set; }
    public decimal? PrecoPorNoite { get; set; }
    public bool Disponivel { get; set; }
    public TipoQuarto Tipo { get; set; }

    public Quarto(int id, string? numero, decimal? precoPorNoite, bool disponivel, TipoQuarto tipo)
    {
        Id = id;
        Numero = numero;
        PrecoPorNoite = precoPorNoite;
        Disponivel = disponivel;
        Tipo = tipo;
    }

    public Quarto()
    {
        
    }



    public override bool Equals(object? obj)
    {
        return obj is Quarto quarto &&
               Id == quarto.Id &&
               Numero == quarto.Numero &&
               PrecoPorNoite == quarto.PrecoPorNoite &&
               Disponivel == quarto.Disponivel &&
               Tipo == quarto.Tipo;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Id, Numero, PrecoPorNoite, Disponivel, Tipo);
    }
}
