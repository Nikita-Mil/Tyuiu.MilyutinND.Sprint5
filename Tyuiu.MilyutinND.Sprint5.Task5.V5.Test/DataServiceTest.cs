using Tyuiu.MilyutinND.Sprint5.Task5.V5.Lib;
namespace Tyuiu.MilyutinND.Sprint5.Task5.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\Asus\source\repos\Tyuiu.MilyutinND.Sprint5\Tyuiu.MilyutinND.Sprint5.Task5.V5\bin\Debug\net8.0\DataSprint5\InPutDataFileTask5V5.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}