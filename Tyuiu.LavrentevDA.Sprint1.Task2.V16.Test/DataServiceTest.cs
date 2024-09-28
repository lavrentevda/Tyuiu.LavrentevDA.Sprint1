using Tyuiu.LavrentevDA.Sprint1.Task2.V16.Lib;
namespace Tyuiu.LavrentevDA.Sprint1.Task2.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int x = 5;
            var res = ds.CalculatePerimetrCircle(x);
            Assert.AreEqual(25, res);
        }
    }
}