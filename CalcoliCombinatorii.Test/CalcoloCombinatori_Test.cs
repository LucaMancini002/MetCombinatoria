using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalcoliCombinatorii.Test
{
    [TestClass]
    public class CalcoloCombinatori_Test
    {
        [DataTestMethod]
        [DataRow(5,120)]
        [DataRow(0, 1)]
        [DataRow(1, 1)]
        [DataRow(10, 3628800)]
        [DataRow(20, 2432902008176640000)]
        public void TestFattoriale(int num, long fattorialeaspettato ) 
        {
           long fattoriale =  EquazioniLibrary.EquazioniTest.Fattoriale(num);
           Assert.AreEqual(fattorialeaspettato, fattoriale);
        }
    }
}
