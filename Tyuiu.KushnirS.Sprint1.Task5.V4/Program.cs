using Tyuiu.KushnirS.Sprint1.Task5.V4.Lib;
namespace Tyuiu.KushnirS.Sprint1.Task5.V4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int time = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(ds.SecondsToHours(time));
        }
    }
}
