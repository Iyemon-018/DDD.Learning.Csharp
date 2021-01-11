namespace DDD.Tests.WinForm
{
    using ChainingAssertion;
    using DDD.WinForm.ViewModels;
    using Xunit;
    
    public class MeasureViewModelTest
    {
        [Fact]
        public void Test_計測_シナリオ()
        {
            var viewModel = new MeasureViewModel();
            viewModel.Measure();
            viewModel.MeasureValue.Is("1.23 m/s");
        }
    }
}