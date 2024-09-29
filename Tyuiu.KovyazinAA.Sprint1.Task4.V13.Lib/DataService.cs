using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.KovyazinAA.Sprint1.Task4.V13.Lib
{
    public class DataService : ISprint1Task4V13
    {
        public double Calculate(double x, double y)
        {
            double ans = (Math.Cos(Math.PI / x)) / (3 * Math.Exp(x + y));
            return ans = Math.Round(ans,3);
        }
    }
}
