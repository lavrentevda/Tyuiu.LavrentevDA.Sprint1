using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.LavrentevDA.Sprint1.Task4.V5.Lib
{
    public class DataService : ISprint1Task4V5

    {
        public double Calculate(double x, double y)
        {
            double sqrtY = Math.Sqrt(y);
            var res = 1 / (Math.Abs(x + sqrtY));
            res = Math.Round(res, 3);
            return res;
        }
    }
}
