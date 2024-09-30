using Tyuiu.KovyazinAA.Sprint1.Task7.V30.Lib;
namespace Tyuiu.KovyazinAA.Sprint1.Task7.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 2; int y = 3;
            var res = 2 + Math.Exp(2) + ((Math.Sin(Math.Pow(2, 5)) + (Math.Pow(2, 3))) / (Math.Pow(3, 2))) + (Math.Pow(3, 5) / (Math.Pow(5, 3)));
            Assert.AreEqual(res, ds.Calculate(x,y));
        }
    }
}