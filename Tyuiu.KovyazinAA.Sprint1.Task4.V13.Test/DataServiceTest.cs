using Tyuiu.KovyazinAA.Sprint1.Task4.V13.Lib;
namespace Tyuiu.KovyazinAA.Sprint1.Task4.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 2.0;
            double y = 3.0;
            double z = (Math.Cos(Math.PI/2) / (3 * Math.Exp(5)));
            double val = Math.Round(z, 3);
            double res = ds.Calculate(x, y);
            Assert.AreEqual(val,res);
        }
    }
}