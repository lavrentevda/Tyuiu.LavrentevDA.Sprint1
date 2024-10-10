using Tyuiu.LavrentevDA.Sprint1.Task5.V4.Lib;
namespace Tyuiu.LavrentevDA.Sprint1.Task5.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            Assert.AreEqual(0, ds.SecondsToHours(0));
            Assert.AreEqual(1, ds.SecondsToHours(3660));
            Assert.AreEqual(2, ds.SecondsToHours(7200));
            Assert.AreEqual(23, ds.SecondsToHours(82800));
        }
    }
}