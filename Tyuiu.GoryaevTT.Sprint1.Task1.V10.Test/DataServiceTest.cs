using Tyuiu.GoryaevTT.Sprint1.Task1.V10.lib;
namespace Tyuiu.GoryaevTT.Sprint1.Task1.V10.test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void Test()
        {
            DataService ds = new DataService();
            double x = 1.0;
            double y = 2.0;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(1.5, res);
        }
    }
}