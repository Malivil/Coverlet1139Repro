using Xunit;

namespace Coverlet1139Repro.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Assert.NotNull(new Class());
        }
    }
}
