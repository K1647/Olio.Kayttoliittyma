using Microsoft.VisualStudio.TestTools.UnitTesting;
using ViikkoViisi2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViikkoViisi2.Tests
{
    [TestClass()]
    public class CalculatorTests
    {
        [TestMethod()]
        public void AddTest()
        {
            ///AAA periaate
            ///A=Arrange, tietojen alustus
            ///A=Act, kutsutaan metodia
            ///A=Assert, varmistetaan että tulos ok
            //arrange
            Calculator calc = new Calculator();
            int a = 4;
            int b = 5;
            int expexted = 9;
            //act
            int actual = calc.Add(a,b);
            //assert
            Assert.AreEqual(expexted, actual);
            // ja toinen testi Add-metodille
            a = 0;
            b = 1;
            expexted = 1;
            actual = calc.Add(a, b);
            Assert.AreEqual(expexted, actual);
        }

        [TestMethod()]
        public void MultiplyTest()
        {
            ///AAA periaate
            ///A=Arrange, tietojen alustus
            ///A=Act, kutsutaan metodia
            ///A=Assert, varmistetaan että tulos ok
            //arrange
            Calculator calc = new Calculator();
            int a = 4;
            int b = 5;
            int expexted = 20;
            //act
            int actual = calc.Multiply(a, b);
            //assert
            Assert.AreEqual(expexted, actual);
            // ja toinen testi Add-metodille
            a = 0;
            b = 1;
            expexted = 0;
            actual = calc.Multiply(a, b);
            Assert.AreEqual(expexted, actual);
        }
        [TestMethod()]
        public void DivisionTest()
        {
            ///AAA periaate
            ///A=Arrange, tietojen alustus
            ///A=Act, kutsutaan metodia
            ///A=Assert, varmistetaan että tulos ok
            //arrange
            Calculator calc = new Calculator();
            int a = 10;
            int b = 2;
            int expexted = 5;
            //act
            int actual = calc.Division(a, b);
            //assert
            Assert.AreEqual(expexted, actual);
            // ja toinen testi Add-metodille
            a = 6;
            b = 2;
            expexted = 3;
            actual = calc.Division(a, b);
            Assert.AreEqual(expexted, actual);
        }
        [TestMethod()]
        public void ReductionTest()
        {
            ///AAA periaate
            ///A=Arrange, tietojen alustus
            ///A=Act, kutsutaan metodia
            ///A=Assert, varmistetaan että tulos ok
            //arrange
            Calculator calc = new Calculator();
            int a = 10;
            int b = 5;
            int expexted = 5;
            //act
            int actual = calc.Reduction(a, b);
            //assert
            Assert.AreEqual(expexted, actual);
            // ja toinen testi Add-metodille
            a = 5;
            b = 7;
            expexted = -2;
            actual = calc.Reduction(a, b);
            Assert.AreEqual(expexted, actual);
        }
    }
}