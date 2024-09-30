using Tyuiu.LavrentevDA.Sprint1.Task3.V16.Lib;
namespace Tyuiu.LavrentevDA.Sprint1.Task3.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x1 = 1;
            double x2 = 1;
            double wait = -2;
            var res = ds.CoeffOfQuadraticEquation(x1, x2);
            Assert.AreEqual(wait, res);
          
        }
    }
}