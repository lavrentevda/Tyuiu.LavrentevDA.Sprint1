using Tyuiu.LavrentevDA.Sprint1.Task7.V14.Lib;
namespace Tyuiu.LavrentevDA.Sprint1.Task7.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 5;
            double y = 5;
            double z = Math.Pow(2, -x) + (5 * Math.Pow(x, 2)) / (3 * Math.Pow(x, 3)) - (Math.Cos(Math.Pow(x, 2)) + Math.Sin(2 * x * y));
            double wait = -0.889;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}