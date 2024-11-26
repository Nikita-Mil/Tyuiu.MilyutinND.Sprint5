using Tyuiu.MilyutinND.Sprint5.Task4.V20.Lib;

namespace Tyuiu.MilyutinND.Sprint5.Task4.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = Path.Combine(new string[] { Path.GetTempPath(), "InPutDataFileTask4V20.txt" });
            FileInfo fileinfo = new FileInfo(path);
            bool fileExists = fileinfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);

        }
    }
}