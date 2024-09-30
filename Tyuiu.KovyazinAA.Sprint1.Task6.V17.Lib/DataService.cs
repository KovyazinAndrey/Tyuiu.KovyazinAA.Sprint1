using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.KovyazinAA.Sprint1.Task6.V17.Lib
{
    public class DataService : ISprint1Task6V17
    {
        public bool CheckPalindrome(string value)
        {
            string str = new string(value.Reverse().ToArray());
            if (value == str) return true;
            else return false;
        }
    }
}
