using Integer_Sum;
using Integer_Sum.Controllers;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        private readonly IntegerSumContext _context;

        public UnitTest1(IntegerSumContext context)
        {
            _context = context;
        }
        [TestMethod]
        public void TestMethod1()
        {
            var expactesResult = 7;
            var controller = new AddController(_context);
            var model = new IntegerModel
            {
                FirstInteger = 3,
                SecondInteger = 4
            };
            var result=controller.Post(model);
            Assert.AreEqual(expactesResult, result);
        }
    }
}