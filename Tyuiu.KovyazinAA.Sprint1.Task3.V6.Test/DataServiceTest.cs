using Tyuiu.KovyazinAA.Sprint1.Task3.V6.Lib;
namespace Tyuiu.KovyazinAA.Sprint1.Task3.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 67.0;
            double y = 8.5;
            double z = 6.5;
            double res = ds.TravelCost(x, y, z);
            Assert.AreEqual(74.035, res);
        }
    }
}