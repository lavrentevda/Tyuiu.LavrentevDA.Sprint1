using Tyuiu.LavrentevDA.Sprint1.Task0.V7.Lib;
namespace Tyuiu.LavrentevDA.Sprint1.Task0.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            var res = ds.Calculate();
            Assert.AreEqual(5, res);
        }
    }
}