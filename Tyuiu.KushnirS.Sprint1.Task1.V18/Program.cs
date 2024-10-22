using Tyuiu.KushnirS.Sprint1.Task1.V18.Lib;
namespace Tyuiu.KushnirS.Sprint1.Task1.V18
{
    internal class Program
    {
        static void Main(string[] args)
        {
          DataService ds = new DataService();
            double x, y;
            x = Convert.ToDouble(Console.ReadLine());
            y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(ds.Calculate(x, y));
        }
    }
}
