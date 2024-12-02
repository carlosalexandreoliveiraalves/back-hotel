using System;
using System.Text.Json.Serialization;
using HotelReservation.Model.Enums;

namespace HotelReservation.Model.Rooms;

public class QuartoSimples : Quarto
{
    
    public QuartoSimples(int id, string? numero, decimal? precoPorNoite, bool disponivel, TipoQuarto tipo) : base(id, numero, precoPorNoite, disponivel, tipo)
    {
    }


}
