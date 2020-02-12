using SampleAPI.Controllers;
using System;
using Xunit;

namespace SampleAPI.Test
{
    public class TestClass
    {
        private ValuesController _valuesController;

        public TestClass()
        {
            _valuesController = new ValuesController();
        }

        [Fact]
        public void Test_Get()
        {
            var result = _valuesController.Get();
            Assert.Equal("value1", ((string[])result.Value)[0]);
        }
    }
}
