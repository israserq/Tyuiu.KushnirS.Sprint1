using Tyuiu.KushnirS.Sprint1.Task2.V16.Lib;
namespace Tyuiu.KushnirS.Sprint1.Task2.V16

{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int value = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(ds.CalculatePerimetrCircle(value));
        }
    }
}
