using Tyuiu.KovyazinAA.Sprint1.Task6.V17.Lib;
namespace Tyuiu.KovyazinAA.Sprint1.Task6.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string x = "‡Íy";
            Assert.AreEqual(false, ds.CheckPalindrome(x));
        }
    }
}