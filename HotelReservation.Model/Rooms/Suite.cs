using System;
using HotelReservation.Model.Enums;

namespace HotelReservation.Model.Rooms;

public class Suite : Quarto
{
    public int Capacidade { get; set; }


    public Suite(int id, string? numero, decimal? precoPorNoite, bool disponivel, TipoQuarto tipo, int capacidade) : base(id, numero, precoPorNoite, disponivel, tipo)
    {
        Capacidade = capacidade;
    }

    public Suite()
    {
        
    }

    public override bool Equals(object? obj)
    {
        return obj is Suite suite &&
               base.Equals(obj) &&
               Capacidade == suite.Capacidade;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(base.GetHashCode(), Capacidade);
    }
}
