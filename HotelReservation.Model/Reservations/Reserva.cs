using System;
using HotelReservation.Model.Enums;
using HotelReservation.Model.Rooms;

namespace HotelReservation.Model.Reservations;

public class Reserva
{
    public int Id {get; set;}
    public DateTime DataCheckIn {get; set;}
    public DateTime DataCheckOut {get; set;}
    public Quarto? QuartoReservado {get;}
    public decimal ValorTotal {get; set;}
    public StatusReserva Status {get;}

    public override bool Equals(object? obj)
    {
        return obj is Reserva reserva &&
               Id == reserva.Id &&
               DataCheckIn == reserva.DataCheckIn &&
               DataCheckOut == reserva.DataCheckOut &&
               EqualityComparer<Quarto?>.Default.Equals(QuartoReservado, reserva.QuartoReservado) &&
               ValorTotal == reserva.ValorTotal &&
               Status == reserva.Status;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Id, DataCheckIn, DataCheckOut, QuartoReservado, ValorTotal, Status);
    }
}
