using Microsoft.VisualStudio.TestTools.UnitTesting;
using tp02;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp02.Tests
{
    [TestClass()]
    public class LogicTests
    {
        [TestMethod()]
        [ExpectedException(typeof(Exception))]
        public void ThrowExceptionTest()
        {
            Logic.ThrowException();
            //Assert verificado por ExpectedException
        }

        [TestMethod()]
        [ExpectedException(typeof(Exceptions.CustomException))] 
        public void ThrowCustomExceptionTest()
        {
            Logic.ThrowCustomException();
            //Assert verificado por ExpectedException
        }
    }
}