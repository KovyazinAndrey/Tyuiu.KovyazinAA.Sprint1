using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.KovyazinAA.Sprint1.Task5.V6.Lib
{
    public class DataService : ISprint1Task5V6
    {
        public int Calculate(int k)
        {
            int n;
            int g = k;
            if (g % 7 == 0)
            {
                n = 7;
            }
            else if (g % 7 == 1)
            {
                n = 1;
            }
            else if (g % 7 == 2)
            {
                n = 2;
            }
            else if (g % 7 == 3)
            {
                n = 3;
            }
            else  if (g % 7 == 4)
            {
                n = 4;
            }
            else if (g % 7 == 5)
            {
                n = 5;
            }
            else
            {
                n = 6;
            }
            return n;
        }
    }
}
