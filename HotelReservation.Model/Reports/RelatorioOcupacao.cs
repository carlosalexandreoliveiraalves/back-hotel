using System;
using HotelReservation.Model.Reservations;

namespace HotelReservation.Model.Reports;

public class RelatorioOcupacao
{
    public int Id { get; set; }
    public DateTime DataGeracao {get; set; }
    public ICollection<Reserva>? ReservasAtivas;

    public override bool Equals(object? obj)
    {
        return obj is RelatorioOcupacao ocupacao &&
               Id == ocupacao.Id &&
               DataGeracao == ocupacao.DataGeracao &&
               EqualityComparer<ICollection<Reserva>?>.Default.Equals(ReservasAtivas, ocupacao.ReservasAtivas);
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Id, DataGeracao, ReservasAtivas);
    }
}
