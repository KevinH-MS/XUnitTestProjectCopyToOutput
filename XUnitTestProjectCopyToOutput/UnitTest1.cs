using System.IO;
using System.Linq;
using Xunit;

namespace XUnitTestProjectCopyToOutput
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var values = File.ReadLines("Input.csv").First().Split(',');
            Assert.Equal(3, values.Length);
        }
    }
}
