namespace MSTestExample
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [DataRow(-1)]
        [DataRow(0)]
        [DataRow(1)]
        public void IsPrime_ValuesLessThan2_ReturnFalse(int value)
        {
            var result = IsPrime(value);

            Assert.IsFalse(result, $"{value} should not be prime");
        }
        private bool IsPrime(int candidate)
        {
            if (candidate == 1)
            {
                return false;
            }
            throw new NotImplementedException("Please create a test first.");
        }
    }
}