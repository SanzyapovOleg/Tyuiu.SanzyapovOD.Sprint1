using Tyuiu.SanzyapovOD.Sprint1.Task6.V4.Lib;
namespace Tyuiu.SanzyapovOD.Sprint1.Task6.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidString()
        {
            DataService ds = new DataService();
            string strTest = "желанный юный медленный";
            string res = ds.CheckDoubleN(strTest);
            string wait = "желаный юнный медленый";
            Assert.AreEqual(wait, res);
        }
    }
}