using Tyuiu.GoryaevTT.Sprint7.Task7.V23.lib;
namespace Tyuiu.GoryaevTT.Sprint7.Task7.V23.test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckCalculate()
        {
            DataService ds = new DataService();
            double x = Math.PI;
            double y = Math.PI;
            double z = ds.Calculate(x, y);
            Assert.AreEqual(z, z);
        }
    }
}