namespace DDD.Tests.WinForm
{
    using ChainingAssertion;
    using DDD.WinForm.ViewModels;
    using Domain.Repositories;
    using Moq;
    using Xunit;
    
    public class MeasureViewModelTest
    {
        [Fact]
        public void Test_計測_シナリオ()
        {
            var sensorMock = new Mock<ISensorRepository>();
            sensorMock.Setup(x => x.GetData()).Returns(1.23456f);

            var viewModel  = new MeasureViewModel(sensorMock.Object);

            viewModel.Measure();
            viewModel.MeasureValue.Is("1.23 m/s");

            sensorMock.Setup(x => x.GetData()).Returns(2.2f);
            viewModel.Measure();
            viewModel.MeasureValue.Is("2.2 m/s");
        }
    }
}