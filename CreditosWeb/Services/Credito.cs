using System;
using System.Collections.Generic;

namespace CreditosWeb.Services
{
    public class Credito
    {

        public Credito() { }

        public Credito(int id, DateTime fecha, int numeroCuotas, decimal valorCredito)
        {
            Id = id;
            Fecha = fecha;
            NumeroCuotas = numeroCuotas;
            ValorCredito = valorCredito;

            for (int i = 0; i < NumeroCuotas; i++)
            {
                fecha = fecha.AddMonths(1);
                var cuota = new Cuota()
                {
                    CreditoId = Id,
                    NumeroCuota = i + 1,
                    Fecha = fecha,
                    ValorCuota = ValorCredito / NumeroCuotas
                };
                Cuotas.Add(cuota);
            }
        }

        public int Id { get; set; }



        public DateTime Fecha { get; set; }
        public int NumeroCuotas { get; set; }
        public decimal ValorCredito { get; set; }
        public decimal ValorAbonos { get; set; }
        public decimal Saldo => ValorCredito - ValorAbonos;
        public List<Cuota> Cuotas { get; set; } = new List<Cuota>();

        public void Abonar(decimal valorAbono, DateTime fechaAbono)
        {
            if (valorAbono < 0)
            {
                return;
            }

            ValorAbonos += valorAbono;
            var valorAbonoPorAplicar = valorAbono;
            foreach (var cuota in Cuotas)
            {
                if (cuota.Saldo > 0)
                {
                    var valorAplicado = cuota.Abonar(valorAbonoPorAplicar, fechaAbono);
                    valorAbonoPorAplicar -= valorAplicado;
                }
                if (valorAbonoPorAplicar == 0)
                {
                    break;
                }
            }



        }
    }



}