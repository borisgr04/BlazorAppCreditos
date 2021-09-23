using BlazorApp.Services;
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
    }
}