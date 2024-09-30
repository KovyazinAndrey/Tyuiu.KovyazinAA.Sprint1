using Tyuiu.KovyazinAA.Sprint1.Task5.V6.Lib;
namespace Tyuiu.KovyazinAA.Sprint1.Task5.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 276;
            int res = ds.Calculate(x);
            Assert.AreEqual(3, res);
        }
    }
}