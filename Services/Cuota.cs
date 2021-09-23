using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Services
{
    public class Cuota
    {
        public int CreditoId { get; set; }
        public int Id { get; set; }
        public int NumeroCuota { get; set; }
        public DateTime Fecha { get; set; }
        public decimal ValorCuota { get; set; }
        public decimal Abonado { get; set; }
        public DateTime FechaUltimoAbono { get; set; }
        public decimal Saldo => ValorCuota - Abonado;
    }
}
