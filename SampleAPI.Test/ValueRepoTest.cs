using SampleAPI.Controllers;
using SampleAPI.Repository;
using System;
using System.Threading.Tasks;
using Xunit;

namespace SampleAPI.Test
{
    public class ValueRepoTest
    {
        private ValueRepo _valueRepo;

        public ValueRepoTest()
        {
            _valueRepo = new ValueRepo();
        }

        [Fact]
        [Trait("CalCulate", "Add")]
        public async Task Test_Calculate_Add()
        {
            Data.Operation operation = new Data.Operation()
            {
                NumberA = 1,
                NumberB = 2,
                OperationType = Data.OperationType.Addition
            };

            var result = await _valueRepo.CalCulater(operation);
            Assert.Equal(3, result);
        }

        [Fact]
        [Trait("CalCulate","Sub")]
        public async Task Test_Calculate_Subtraction()
        {
            Data.Operation operation = new Data.Operation()
            {
                NumberA = 1,
                NumberB = 2,
                OperationType = Data.OperationType.Subtraction
            };

            var result = await _valueRepo.CalCulater(operation);
            Assert.Equal(-1, result);
        }

        [Fact]
        [Trait("CalCulate", "Sub")]
        public async Task Test_Calculate_Subtraction_1()
        {
            Data.Operation operation = new Data.Operation()
            {
                NumberA = 98,
                NumberB = 2,
                OperationType = Data.OperationType.Subtraction
            };

            var result = await _valueRepo.CalCulater(operation);
            Assert.Equal(96, result);
        }
    }
}
