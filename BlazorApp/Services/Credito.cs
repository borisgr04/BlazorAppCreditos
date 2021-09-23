using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Services
{
    public class Credito
    {
        
        public Credito(){ }

        public Credito(int id, DateTime fecha, int numeroCuotas,  decimal valorCredito)
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
                    CreditoId=Id, 
                    NumeroCuota = i+1,
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

        public string Abonar(DateTime fechaAbono, decimal valorAbono) 
        {
            ValorAbonos += valorAbono;
            return $"saldo nuevo es $$";
            //throw new NotImplementedException();
        }
    }

  


}