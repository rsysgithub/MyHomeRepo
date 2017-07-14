using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace xUnitProject
{
    public class TestRunner
    {
        [Fact]
        public void TestRun()
        {
            Assert.Equal("Arvind", "Arvind");
        }
    }
}
