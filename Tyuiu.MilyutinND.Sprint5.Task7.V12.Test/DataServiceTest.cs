using Tyuiu.MilyutinND.Sprint5.Task7.V12.Lib;
namespace Tyuiu.MilyutinND.Sprint5.Task7.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void LDAS()
        {
            string path = @"C:\Users\Asus\AppData\Local\Temp\OutPutDataFileTask7V12.txt";

            FileInfo fileinfo = new FileInfo(path);
            bool fileExists = fileinfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}