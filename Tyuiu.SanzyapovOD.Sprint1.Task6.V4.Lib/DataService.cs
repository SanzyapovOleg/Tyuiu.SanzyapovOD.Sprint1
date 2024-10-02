using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.SanzyapovOD.Sprint1.Task6.V4.Lib
{
    public class DataService : ISprint1Task6V4
    {
        public string CheckDoubleN(string value)
        {
            value = value.Replace("н", "нн");
            return value;
        }
    }
}
