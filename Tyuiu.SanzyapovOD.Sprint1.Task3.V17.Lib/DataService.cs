using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.SanzyapovOD.Sprint1.Task3.V17.Lib
{
    public class DataService : ISprint1Task3V17
    {
        public bool ZeroCheck(double number)
        {
            int tmp = (int)(number * 1000);
            return (tmp % 10 == 0 || tmp % 100 / 10 == 0 || tmp % 1000 / 100 == 0);
        }
    }
}
