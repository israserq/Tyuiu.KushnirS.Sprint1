using Tyuiu.KushnirS.Sprint1.Task3.V1.Lib;
namespace Tyuiu.KushnirS.Sprint1.Task3.V1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            double h, r;
            h = Convert.ToDouble(Console.ReadLine());
            r = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(ds.CylinderVolume(r, h));
        }
    }
}
