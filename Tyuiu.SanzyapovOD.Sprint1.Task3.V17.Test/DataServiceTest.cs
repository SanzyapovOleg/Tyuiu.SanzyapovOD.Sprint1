using Tyuiu.SanzyapovOD.Sprint1.Task3.V17.Lib;
namespace Tyuiu.SanzyapovOD.Sprint1.Task3.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            Assert.AreEqual(true, ds.ZeroCheck(4.012555));
        }
    }
}