using Tyuiu.AndreevIA.Sprint3.Task6.V29.Lib;
namespace Tyuiu.AndreevIA.Sprint3.Task6.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumTheDivisors()
        {
            DataService ds = new DataService();

            int startvalue = 12;
            int stopvalue = 18;

            int res = ds.GetSumTheDivisors(startvalue, stopvalue);

            int wait = 178;

            Assert.AreEqual(res, wait);
        }
    }
}