using Tyuiu.HabibullinMR.Sprint0.Task2.V0.Lib;

namespace Tyuiu.HabibullinMR.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Марат";
            var res = DataService.GetMessage(name);

            Assert.AreEqual("Привет..., Марат",res);
        }
    }
}