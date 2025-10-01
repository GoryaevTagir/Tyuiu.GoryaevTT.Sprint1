using Tyuiu.GoryaevTT.Sprint1.Task7.V25.Lib;

namespace Tyuiu.GoryaevTT.Sprint1.Task7.V25.Test
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Class1 ds = new Class1();
            double x = 1;
            double y = 2;
            double res = ds.Calculate(x, y);
            Assert.AreEqual(2, res);
        }
    }
}