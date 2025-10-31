using Tyuiu.AndreevIA.Sprint3.Task2.V30.Lib;

namespace Tyuiu.AndreevIA.Sprint3.Task2.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CalculationValid()
        {
            DataService ds = new DataService();
            double x = 0.25;
            int start = 1, end = 11;
            double res = ds.GetMultiplySeries(x, start, end);
            Assert.AreEqual(13051.340, res);
        }
    }
}