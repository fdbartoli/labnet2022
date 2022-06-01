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
            float expectedResult = 5;
            float dividendo = 10;
            float actualResult = dividendo.Division(2);

            Assert.AreEqual(expectedResult, actualResult);
        }

        //[TestMethod()]
        //public void DivideByZeroTest()
        //{
            
        //}
    }
}