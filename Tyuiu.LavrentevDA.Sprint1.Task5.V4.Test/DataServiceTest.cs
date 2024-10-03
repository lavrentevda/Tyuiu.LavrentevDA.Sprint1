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

             int k, time;
             k = 14638;
             time = k / 3600;
             var res = ds.SecondsToHours(time);
             Assert.AreEqual(4, res);
        }
    }
}