using Tyuiu.LavrentevDA.Sprint1.Task4.V5.Lib;
namespace Tyuiu.LavrentevDA.Sprint1.Task4.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 2;
            double sqrtY = 2;
            double wait = 0.293;
            var res = ds.Calculate(x, sqrtY);
            res = Math.Round(res, 3);
            Assert.AreEqual(wait, res);
        }
    }
}