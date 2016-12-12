using GoCD.Layers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GoCD.Tests {
    [TestClass]
    public class ProcessDataTests {
        [TestMethod]
        public void ProcessSuccess()
        {

            var processData = new ProcessData();

            Assert.IsTrue(processData.Execute());
        }
    }
}
