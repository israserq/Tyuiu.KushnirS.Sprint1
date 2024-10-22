using Tyuiu.KushnirS.Sprint1.Task6.V4.Lib;
namespace Tyuiu.KushnirS.Sprint1.Task6.V4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

           

            string str = Console.ReadLine();

            

            Console.WriteLine(ds.CheckDoubleN(str));
        }
    }
}

