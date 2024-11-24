using Tyuiu.MilyutinND.Sprint5.Task0.V16.Lib;

namespace Tyuiu.MilyutinND.Sprint5.Task0.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string path = @"C:\Users\Asus\AppData\Local\Temp\OutPutFileTask0.txt";
            var res = ds.SaveToFileTextData(0);
            Assert.AreEqual(path, res);
        }
    }
}