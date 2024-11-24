using Tyuiu.MilyutinND.Sprint5.Task3.V22.Lib;

namespace Tyuiu.MilyutinND.Sprint5.Task3.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
         
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask3.bin");
            FileInfo fl = new FileInfo(path);
            bool fll = fl.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fll);
        }
    }
}