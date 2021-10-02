using CreditosWeb.Services;
using NUnit.Framework;
using System;

namespace CreditosTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void PuedeCrearCreditoTest()
        {
            var credito = new Credito(1, new DateTime(2020,1,1), 10, 2500000);
            Assert.AreEqual(10, credito.Cuotas.Count);
        }
        /// <summary>
        /// Especificacion ejecutable
        /// </summary>
        [Test]
        public void PuedeAbonarAlosCreditos() 
        {
            /*DADO
            Qué existe un crédito del día 01/03/2021 de 5 cuotas por un valor de $500.000 
            Y sin ningún abono realizado
            */
            var credito = new Credito(1, new DateTime(2021, 3, 1), 5, 500000);
            /*
            CUANDO
            Se registre un abono de $230.000 pesos el día 1 de agosto 2021
            */

            credito.Abonar(230000m, new DateTime(2021, 8, 1));

            /*ENTONCES
            El crédito tendrá un saldo final $270.000 pesos 
            Y pagará totalmente las cuotas uno y dos cuota. 
            Y la tercera cuota quedará con un saldo de $70.000
             */

            Assert.AreEqual(270000, credito.Saldo);
            Assert.AreEqual(0, credito.Cuotas[0].Saldo);
            Assert.AreEqual(0, credito.Cuotas[1].Saldo);
            Assert.AreEqual(70000, credito.Cuotas[2].Saldo);

        }

        /// <summary>
        /// Especificacion ejecutable
        /// </summary>
        [Test]
        public void NoPuedeAbonarAlosCreditosAbonoMenos1Peso()
        {
            /*DADO
            Qué existe un crédito del día 01/03/2021 de 5 cuotas por un valor de $500.000 
            Y sin ningún abono realizado
            */
            var credito = new Credito(1, new DateTime(2021, 3, 1), 5, 500000);
            /*
            CUANDO
            Se registre un abono de $230.000 pesos el día 1 de agosto 2021
            */

            credito.Abonar(-1m, new DateTime(2021, 8, 1));

            /*ENTONCES
            El crédito tendrá un saldo final $500.000 pesos 
            
             */
            Assert.AreEqual(500000, credito.Saldo);



        }
    }
}