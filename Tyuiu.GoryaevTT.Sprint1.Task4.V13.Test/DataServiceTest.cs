using Tyuiu.GoryaevTT.Sprint1.Task4.V13.lib;
namespace Tyuiu.GoryaevTT.Sprint1.Task4.V13.test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckCalculate()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = -1;
            double res = ds.Calculate(x, y);
            Assert.AreEqual(-0.333, res);
        }
    }
}