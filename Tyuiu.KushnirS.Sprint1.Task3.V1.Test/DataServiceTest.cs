using Tyuiu.KushnirS.Sprint1.Task3.V1.Lib;
namespace Tyuiu.KushnirS.Sprint1.Task3.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double r, h;
            r = 1;
            h = 1;
            var res = ds.CylinderVolume(r, h);
            Assert.AreEqual(Math.PI, res);
        }
    }
}