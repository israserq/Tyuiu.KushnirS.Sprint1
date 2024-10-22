using Tyuiu.KushnirS.Sprint1.Task0.V16.lib;
namespace Tyuiu.KushnirS.Sprint1.Task0.V16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("**********************************************************************************");
            Console.WriteLine("* Спринт #1                                                                      *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                               *");
            Console.WriteLine("* Задание #0                                                                   *");
            Console.WriteLine("* Вариант #16                                                                    *");
            Console.WriteLine("* Выполнил: Кушнир Сергей | ИБКСб-24-1                                *");
            Console.WriteLine("**********************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                       *");
            Console.WriteLine("* Написать программу, которая *");
            Console.WriteLine("* вычисляет результат по формуле 6/2/3+1-6/2*3 и печатает его на экране.             *");
            Console.WriteLine("*                                                                                *");
            Console.WriteLine("**********************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                               *");
            Console.WriteLine("**********************************************************************************");
            Console.WriteLine(ds.Calculate());

        }
    }
}
