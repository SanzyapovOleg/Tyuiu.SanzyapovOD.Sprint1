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
            string strTest = "������ � ��� ����������";
            string res = ds.CheckDoubleN(strTest);
            string wait = "������ � ��� ���������";
            Assert.AreEqual(wait, res);
        }
    }
}