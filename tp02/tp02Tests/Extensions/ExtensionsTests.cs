using Microsoft.VisualStudio.TestTools.UnitTesting;
using tp02.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp02.Extensions.Tests
{
    [TestClass()]
    public class ExtensionsTests
    {
        [TestMethod()]
        public void DivisionTest()
        {
            int expectedResult = 5;
            int dividendo = 10;
            decimal actualResult = dividendo.Division(2);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod()]
        [ExpectedException(typeof(DivideByZeroException))]
        public void DivideByZeroTest()
        {
            int number = 10;
            number.DivideByZero();
            //Assert verificado por 
        }
    }
}