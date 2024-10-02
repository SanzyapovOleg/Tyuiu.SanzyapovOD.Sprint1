using Tyuiu.SanzyapovOD.Sprint1.Task6.V4.Lib;
namespace Tyuiu.SanzyapovOD.Sprint1.Task6.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            string word = "оловяный";
            string result = ds.CheckDoubleN(word);
            string wait = "оловянный";
            Assert.AreEqual(result, wait);
        }
    }
}