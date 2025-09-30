using Tyuiu.GoryaevTT.Sprint1.Task3.V3.lib;
namespace Tyuiu.GoryaevTT.Sprint1.Task3.V3.test
{
    [TestClass]
    public sealed class DataSrviceTest
    {
        [TestMethod]
        public void CheckParallelepipedVolume()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 3;
            double z = 4;
            double res = ds.ParallelepipedVolume(x, y, z);
            Assert.AreEqual(24, res);
        }
    }
}