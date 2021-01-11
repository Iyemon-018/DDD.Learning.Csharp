namespace DDD.Tests.WinForm
{
    using ChainingAssertion;
    using DDD.WinForm.ViewModels;
    using Mock.Infrastructure;
    using Xunit;
    
    public class MeasureViewModelTest
    {
        [Fact]
        public void Test_計測_シナリオ()
        {
            var viewModel = new MeasureViewModel(new SensorMock());
            viewModel.Measure();
            viewModel.MeasureValue.Is("1.23 m/s");
        }
    }
}