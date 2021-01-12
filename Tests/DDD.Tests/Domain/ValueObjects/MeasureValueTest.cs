namespace DDD.Tests.Domain.ValueObjects
{
    using DDD.Domain.ValueObjects;
    using Xunit;

    public class MeasureValueTest
    {
        [Fact]
        public void Test_イコールテスト()
        {
            var vo1 = new MeasureValue(1.23456f);
            var vo2 = new MeasureValue(1.23456f);

            Assert.Equal(vo1, vo2);
        }

        [Fact]
        public void Test_イコールイコールテスト()
        {
            var vo1 = new MeasureValue(1.23456f);
            var vo2 = new MeasureValue(1.23456f);

            Assert.True(vo1 == vo2);
        }
    }
}