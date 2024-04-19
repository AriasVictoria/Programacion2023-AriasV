using ClassLibrary2;
using System.Runtime.InteropServices;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Calculadora calculadora = new Calculadora();
            Assert.AreEqual(calculadora.Suma(5, 10), 15);
        }
        public void TestMethod2()
        {
            Calculadora calculadora1 = new Calculadora();
            Assert.AreEqual(calculadora1.Restar(5, 10), 5);
        }
        public void TestMethod3()
        {
            Calculadora calculadora2 = new Calculadora();
            Assert.AreEqual(calculadora2.Restar(10, 5), 5);
        }
        public void TestMethod4()
        {
            Calculadora calculadora3 = new Calculadora();
            Assert.AreEqual(calculadora3.Division(10, 5), 5);
        }
    }
}