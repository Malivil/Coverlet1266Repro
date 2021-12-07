using Xunit;

namespace CoverletReproTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            const long max = (long)int.MaxValue + 1;
            for (var i = 0L; i < max; i++)
            {
                CoverletRepro.CoverletRepro.DoThing();
            }
        }
    }
}
