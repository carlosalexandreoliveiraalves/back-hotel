using System;

namespace HotelReservation.Model.Reports;

public class RelatorioFaturamento
{
    public int Id {get; set;}
    public DateTime DataGeracao {get; set;}
    public decimal TotalFaturado {get; set;}

    public override bool Equals(object? obj)
    {
        return obj is RelatorioFaturamento faturamento &&
               Id == faturamento.Id &&
               DataGeracao == faturamento.DataGeracao &&
               TotalFaturado == faturamento.TotalFaturado;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Id, DataGeracao, TotalFaturado);
    }
}
