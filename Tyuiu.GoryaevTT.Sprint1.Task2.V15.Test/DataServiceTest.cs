using Tyuiu.GoryaevTT.Sprint1.Task2.V15.lib;
namespace Tyuiu.GoryaevTT.Sprint1.Task2.V15.test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckVolumeCube()
        {
            DataService ds = new DataService();
            int x = 5;
            int res = ds.CalculateCubeVolume(x);
            Assert.AreEqual(125, res);
        }
    }
}