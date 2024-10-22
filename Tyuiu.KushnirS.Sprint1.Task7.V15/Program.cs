using Tyuiu.KushnirS.Sprint1.Task7.V15.Lib;
namespace Tyuiu.KushnirS.Sprint1.Task7.V15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(ds.Calculate(x));
        }
    }
}
