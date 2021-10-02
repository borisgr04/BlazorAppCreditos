using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreditosWeb.Services
{
    public class Cuota
    {
        public int CreditoId { get; set; }
        public int Id { get; set; }
        public int NumeroCuota { get; set; }
        public DateTime Fecha { get; set; }
        public decimal ValorCuota { get; set; }
        public decimal Abonado { get; private set; }
        public DateTime FechaUltimoAbono { get; private set; }
        public decimal Saldo => ValorCuota - Abonado;

        internal decimal Abonar(decimal valorPorAplicar, DateTime fechaAbono)
        {
            if (Saldo >= valorPorAplicar)
            {
                Abonado += valorPorAplicar;
            }
            else
            {
                valorPorAplicar = Saldo;
                Abonado += Saldo;
            }
            FechaUltimoAbono = fechaAbono;
            return valorPorAplicar;
        }
    }
}
