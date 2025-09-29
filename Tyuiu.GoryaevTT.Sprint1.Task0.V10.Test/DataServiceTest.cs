using Tyuiu.GoryaevTT.Sprint1.Task0.V10.lib;
namespace Tyuiu.GoryaevTT.Sprint1.Task0.V10.test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckValid()
        {
            DataService ds = new DataService();
            var res = ds.Calculate();
            Assert.AreEqual(-10.5, res);
        }
    }
}