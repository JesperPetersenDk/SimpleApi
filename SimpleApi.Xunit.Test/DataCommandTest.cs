using System;
using SimpleApi.Controllers.Data;
using Xunit;

namespace SimpleApi.Xunit.Test
{
    public class DataCommandTest
    {
        private readonly MockCommand _mockCommand = new MockCommand();

        [Fact]
        public void GetDataIsNotNull()
        {
            var result = _mockCommand.GetCommandSingleById(1);
            Assert.NotNull(result);
        }
    }
}