using Tyuiu.GoryaevTT.Sprint1.Task5.V2.lib;
namespace Tyuiu.GoryaevTT.Sprint1.Task5.V2.test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckTemp()
        {
            DataService ds = new DataService();
            double x = 41;
            var res = ds.FahrenheitToСelsius(x);
            Assert.AreEqual(5, res);
        }
    }
}