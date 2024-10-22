using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.KushnirS.Sprint1.Task7.V15.Lib
{
    public class DataService : ISprint1Task7V15
    {
        public double Calculate(double x)
        {
            var res = Math.Abs(x * x - x * x * x) - ((Math.Cos(Math.Pow(x, 3)) + 7 * x * x) / (x * x * x - 15 * x));
            return Math.Round(res, 3);
        }
    }
}
