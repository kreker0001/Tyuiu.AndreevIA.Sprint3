using Tyuiu.AndreevIA.Sprint3.Task0.V28.Lib;

namespace Tyuiu.AndreevIA.Sprint3.Task0.V28.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultiplySeries()
        {
            DataService ds = new DataService();
            double x = 0.25;
            int start = 1;
            int stop = 17;
            double wait = 411589.537;
            double res = ds.GetMultiplySeries(x, start, stop);
            Assert.AreEqual(wait, res);
        }
    }
}
