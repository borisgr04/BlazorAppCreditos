using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Services
{
    public class CreditoService
    {
        private static readonly List<Credito> CreditosRepository = new List<Credito>()
        {
            new Credito(1,new DateTime(2021,5,20),5,1000000),
            new Credito(2,new DateTime(2021,7,15),5,2000000),
            new Credito(3,new DateTime(2021,9,12),5,3000000)
        };

        public Task<Credito[]> GetCreditosAsync() 
        {
            return Task.FromResult(CreditosRepository.ToArray());
        }

        public Task<Cuota[]> GetCuotasAsync(int creditoId)
        {
            var credito = CreditosRepository.FirstOrDefault(t => t.Id == creditoId);
            return Task.FromResult(credito.Cuotas.ToArray());
        }

        public Task<string> InsertAbonoAsync(int creditoId, DateTime fechaAbono, decimal valorAbono)
        {
            var credito= CreditosRepository.FirstOrDefault(t=>t.Id==creditoId);
            var saldo=credito.Abonar(fechaAbono, valorAbono);
            return Task.FromResult(saldo);
        }
    }
}