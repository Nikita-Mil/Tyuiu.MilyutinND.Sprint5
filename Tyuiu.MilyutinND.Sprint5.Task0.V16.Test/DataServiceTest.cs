using Tyuiu.MilyutinND.Sprint5.Task0.V16.Lib;

namespace Tyuiu.MilyutinND.Sprint5.Task0.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\Asus\source\repos\Tyuiu.MilyutinND.Sprint5\Tyuiu.MilyutinND.Sprint5.Task0.V16\bin\Debug\net8.0\OutPutFileTask0.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}