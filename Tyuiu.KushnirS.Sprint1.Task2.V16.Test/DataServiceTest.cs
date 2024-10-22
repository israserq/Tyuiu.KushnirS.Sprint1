using Tyuiu.KushnirS.Sprint1.Task2.V16.Lib;
namespace Tyuiu.KushnirS.Sprint1.Task2.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds= new DataService();
            int value = 1;
            var res = ds.CalculatePerimetrCircle(value);
            Assert.AreEqual(6.28, res);
        }
    }
}