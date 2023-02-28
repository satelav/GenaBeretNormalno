using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using ConsoleApp1;
using Microsoft.CodeAnalysis;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int i= 1;
            int j= 2;
        

            int actual = 0;

          Boom  sol = new Boom(i,j);
            int result = 0;
      
            Assert.AreEqual(actual, sol.Solution(result));
        }
    }
}
