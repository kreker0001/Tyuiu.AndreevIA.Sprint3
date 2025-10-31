using Tyuiu.AndreevIA.Sprint3.Task1.V14.Lib;

namespace Tyuiu.AndreevIA.Sprint3.Task1.V14.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        DataService ds = new DataService();

        [TestMethod]
        public void TestMethod1()
        {
            double x = 0.7;
            int start = 1;
            int end = 14;
            double expected = 3.546;

            double actual = ds.GetSumSeries(x, start, end);

            Assert.AreEqual(expected, actual, 1e-3, "Сумма ряда рассчитана неверно.");
        }
    }
}
