using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.KushnirS.Sprint1.Task3.V1.Lib
{
    public class DataService : ISprint1Task3V1
    {
        public double CylinderVolume(double r, double h)
        {
            var res = (Math.PI * Math.Pow(r, 2) * h);
            return Math.Round(res, 3);
        }
    }
}
