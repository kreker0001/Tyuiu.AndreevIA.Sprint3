﻿using Tyuiu.AndreevIA.Sprint3.Task3.V20.Lib;

namespace Tyuiu.AndreevIA.Sprint3.Task3.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string f = "ffff";
            int ffff = 4;
            double result = ds.GetCharCount(f, 'f');
            Assert.AreEqual(ffff, result);
        }
    }
}