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

             int k, h;
             k = 14638;
            h = k / 3600;
             var res = ds.SecondsToHours(h);
            Assert.AreEqual(4, res);
            //
           // int k;
           // k = 14638;

           // int.TryParse( out k) && (k >= 0) && (k < 86400)))
                
       // var res = ds.SecondsToHours(k);
           // Assert.AreEqual(4, res);

        }
    }
}