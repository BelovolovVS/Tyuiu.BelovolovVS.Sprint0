namespace Tyuiu.BelovolovVS.Sprint0.Task2.V0.Test
{
    using Tyuiu.BelovolovVS.Sprint0.Task2.V0.Lib;
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Slava";
            var res = DataService.GetMessage(name);

            Assert.AreEqual("Привет Slava", res);
        }
    }
}
