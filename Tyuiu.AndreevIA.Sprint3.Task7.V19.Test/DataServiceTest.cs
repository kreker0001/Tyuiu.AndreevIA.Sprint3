using Tyuiu.AndreevIA.Sprint3.Task7.V19.Lib;
namespace Tyuiu.AndreevIA.Sprint3.Task7.V19.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int startvalue = -5;
            int stopvalue = 5;
            int len = stopvalue - startvalue + 1;
            double[] valueWait;
            valueWait = new double[len];

            valueWait[0] = 23.61;
            valueWait[1] = 16.08;
            valueWait[2] = 7.84;
            valueWait[3] = 4.58;
            valueWait[4] = 2.88;
            valueWait[5] = 0.75;
            valueWait[6] = -4.47;
            valueWait[7] = -9.46;
            valueWait[8] = -7.41;
            valueWait[9] = -6.16;
            valueWait[10] = -7.29;
            CollectionAssert.AreEqual(ds.GetMassFunction(-5, 5), valueWait);
        }
    }
}