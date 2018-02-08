using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Prueba;

namespace PruebaTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual("Hola mundo", Program.texto());
            //prueba
            //nada
        }
    }
}
