using Tyuiu.GoryaevTT.Sprint1.Task6.V18.lib;
namespace Tyuiu.GoryaevTT.Sprint1.Task6.V18.test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckNumberCheck()
        {
            DataService ds = new DataService();
            string x = "123";
            bool res = ds.CheckNumber(x);
            Assert.AreEqual(true, res);
        }
    }
}