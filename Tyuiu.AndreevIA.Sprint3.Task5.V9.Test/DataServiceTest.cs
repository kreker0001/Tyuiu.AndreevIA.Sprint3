using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.AndreevIA.Sprint3.Task5.V9.Lib;

namespace Tyuiu.AndreevIA.Sprint3.Task5.V9.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void GetSumSumSeries_ReturnsExpectedValue()
        {
            var ds = new DataService();
            int x = 5, startI = 1, startK = 1, stopI = 3, stopK = 14;

            double expected = 231.23462194334979;

            double actual = ds.GetSumSumSeries(x, startI, startK, stopI, stopK);

            Assert.AreEqual(expected, actual, 1e-10);
        }
    }
}
