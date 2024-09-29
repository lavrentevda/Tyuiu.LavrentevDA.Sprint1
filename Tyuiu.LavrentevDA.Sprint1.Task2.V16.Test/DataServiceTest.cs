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
            int x = 6;
            var res = ds.CalculatePerimetrCircle(x);
            Assert.AreEqual(37.699, res);

        }
    }
}