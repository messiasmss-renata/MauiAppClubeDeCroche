
using System;

namespace MauiAppClubeDeCroche.Models
{
    public class Evento
    {
        public string NomeEvento { get; set; } = "Clube do Crochê";

        public DateTime DataInicio { get; set; } =
            new DateTime(2026, 11, 20);

        public DateTime DataTermino { get; set; } =
            new DateTime(2026, 11, 22);

        public int NumeroParticipantes { get; set; }

        public string LocalEvento { get; set; } =
            "Meu Hotel - Campinas/SP";

        public decimal CustoPorParticipante { get; set; } = 50.00m;

        public string NomeParticipante { get; set; } = "";

        public bool ParticipaDia20 { get; set; }
        public bool ParticipaDia21 { get; set; }
        public bool ParticipaDia22 { get; set; }

        public TimeSpan DuracaoEvento
        {
            get { return DataTermino - DataInicio; }
        }

        public int DuracaoEmDias
        {
            get { return DuracaoEvento.Days + 1; }
        }
        public int QuantidadeDias
        {
            get
            {
                int quantidade = 0;

                if (ParticipaDia20) quantidade++;
                if (ParticipaDia21) quantidade++;
                if (ParticipaDia22) quantidade++;

                return quantidade;
            }
        }

        public decimal ValorIndividual
        {
            get { return QuantidadeDias * CustoPorParticipante; }
        }

        public decimal CustoTotal
        {
            get
            {
                return NumeroParticipantes *
                       CustoPorParticipante *
                       DuracaoEmDias;
            }
        }
    }
}
