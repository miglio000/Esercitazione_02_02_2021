using Microsoft.VisualStudio.TestTools.UnitTesting;
using LibreriaTest;
namespace Test_LibreriaTest
{
    [TestClass]
    public class Gestione_Test_2_2
    {
        [TestMethod]
        public void TestCalcoloMisterioso()
        {
            int n = 5;
            long valore_aspettato = 240;
            long resp = Gestione.CalcoloMisterioso(n);
            Assert.AreEqual (valore_aspettato, resp);
        }
        [TestMethod]
        public void TestCalcoloMisterioso2()
        {
            int n = 4;
            int valore_aspettato = -72;
            long resp = Gestione.CalcoloMisterioso2(n);
            Assert.AreEqual(valore_aspettato, resp);
        }
        [TestMethod]
        public void TestMisurazioneMisteriosa()
        {
            double[] valori = new double[] { 4, 6, 7, -9.1 };
            double valore_aspettato = 3;
            double min = Gestione.MisurazioneMisteriosa(valori);
            Assert.AreEqual(valore_aspettato, min);
        }
    }
}
