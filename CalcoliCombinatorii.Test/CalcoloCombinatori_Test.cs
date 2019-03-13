using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalcoliCombinatorii.Test
{
    [TestClass]
    public class CalcoloCombinatori_Test
    {
        [DataTestMethod]
        [DataRow(5,120)] // 1° caso
        [DataRow(0, 1)] // 2° caso
        [DataRow(1, 1)] // 3° caso
        [DataRow(10, 3628800)] // 4° caso
        [DataRow(20, 2432902008176640000)] // 5° caso
        public void TestFattoriale(int num, long fattorialeaspettato ) 
        {
           long fattoriale =  EquazioniLibrary.EquazioniTest.Fattoriale(num);
           Assert.AreEqual(fattorialeaspettato, fattoriale);
        }
    }
}
