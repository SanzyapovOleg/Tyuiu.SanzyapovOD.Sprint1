using Tyuiu.SanzyapovOD.Sprint1.Task4.V19.Lib;
namespace Tyuiu.SanzyapovOD.Sprint1.Task4.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 4;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(5, res);
        }
    }
}