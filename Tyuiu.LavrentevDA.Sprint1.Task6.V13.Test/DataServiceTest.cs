using Tyuiu.LavrentevDA.Sprint1.Task6.V13.Lib;
namespace Tyuiu.LavrentevDA.Sprint1.Task6.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidString()
        {
            DataService ds = new DataService();
            string strTest = "אבגדה";

            
            bool result = ds.CheckWordsAlphabet(strTest);

            
            Assert.IsTrue(result);
        }
    
    }
}