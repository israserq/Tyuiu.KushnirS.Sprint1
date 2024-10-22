using Tyuiu.KushnirS.Sprint1.Task4.V21.Lib;
namespace Tyuiu.KushnirS.Sprint1.Task4.V21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();



            double x, y;
            Console.WriteLine("Введите переменную x:");
            x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите переменную y:");
            y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(ds.Calculate(x, y));

            Console.ReadLine();
        }
    }
}
