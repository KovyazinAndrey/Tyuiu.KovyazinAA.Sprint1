using Tyuiu.KovyazinAA.Sprint1.Task2.V17.Lib;
namespace Tyuiu.KovyazinAA.Sprint1.Task2.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 123;
            var res = ds.ConvertMinutesToHours(x);
            Assert.AreEqual(2, res);
        }
    }
}