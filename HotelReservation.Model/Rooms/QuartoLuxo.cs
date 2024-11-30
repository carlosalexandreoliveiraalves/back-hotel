using System;
using HotelReservation.Model.Enums;

namespace HotelReservation.Model.Rooms;

public class QuartoLuxo : Quarto
{
    public bool TemVistaParaOMar {get; set;} = true;

    public QuartoLuxo()
    {
        
    }
    public QuartoLuxo(int id, string? numero, decimal? precoPorNoite, bool disponivel, TipoQuarto tipo, bool temVistaParaOMar) 
    : base(id, numero, precoPorNoite, disponivel, tipo)
    {
        TemVistaParaOMar = temVistaParaOMar;
    }
    

    public override bool Equals(object? obj)
    {
        return obj is QuartoLuxo luxo &&
               base.Equals(obj) &&
               TemVistaParaOMar == luxo.TemVistaParaOMar;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(base.GetHashCode(), TemVistaParaOMar);
    }
}
