using System;
using SimpleApi.Controllers.Data;
using Xunit;

namespace SimpleApi.Xunit.Test
{
    public class DataCommandTest
    {
        private readonly MockCommand _mockCommand = new MockCommand();

        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(4)]
        public void GetDataNotNullById_Single(int id)
        {
            var result = _mockCommand.GetCommandSingleById(id);
            Assert.NotNull(result);
        }

        [Theory]
        [InlineData(0, "Jesper Petersen")]
        [InlineData(1, "Freja Hansen")]
        [InlineData(2, "Mette Willumsen")]
        public void GetDataSameById_Single(int id, string name)
        {
            var result = _mockCommand.GetCommandSingleById(id);
            Assert.NotSame(result, name);
        }

        [Theory]
        [InlineData(0, "Jesper Petersen")]
        [InlineData(1, "Freja Hansen")]
        [InlineData(2, "Mette Willumsen")]
        public void GetDataEqualById_Single(int id, string name)
        {
            var result = _mockCommand.GetCommandSingleById(id);
            Assert.Equal(name, result.Name);
        }

        [Theory]
        [InlineData(1, "Jesper Petersen")]
        [InlineData(0, "Freja Hansen")]
        [InlineData(3, "Mette Willumsen")]
        public void GetDataNotEqualById_Single(int id, string name)
        {
            var result = _mockCommand.GetCommandSingleById(id);
            Assert.NotEqual(name, result.Name);
        }

        [Theory]
        [InlineData(-1)]
        [InlineData(-2)]
        [InlineData(-3)]
        [InlineData(-4)]
        public void GetDataIsNullMulitById_Single(int id)
        {
            var result = _mockCommand.GetCommandSingleById(id);
            Assert.Null(result);
        }

        [Fact]
        public void GetDataIsNull()
        {
            var result = _mockCommand.GetAll();
            Assert.NotNull(result);
        }
    }
}