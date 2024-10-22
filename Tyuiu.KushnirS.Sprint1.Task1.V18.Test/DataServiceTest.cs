using Tyuiu.KushnirS.Sprint1.Task1.V18.Lib;
namespace Tyuiu.KushnirS.Sprint1.Task1.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 2;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(-2, res);
        }
    }
}