namespace DDD.Tests.WinForm.ViewModels
{
    using ChainingAssertion;
    using DDD.Domain.Entities;
    using DDD.Domain.Helpers;
    using DDD.Domain.Repositories;
    using DDD.Domain.ValueObjects;
    using DDD.WinForm.ViewModels;
    using Moq;
    using Xunit;

    public class MeasureViewModelTest
    {
        [Fact]
        public void Test_計測_シナリオ()
        {
            var sensorMock = new Mock<ISensorRepository>();
            sensorMock.Setup(x => x.GetData()).Returns(new MeasureValue(1.23456f));

            var viewModel  = new MeasureViewModel(sensorMock.Object);

            viewModel.Measure();
            viewModel.MeasureValue.Is("1.23 m/s");

            sensorMock.Setup(x => x.GetData()).Returns(new MeasureValue(2.2f));
            viewModel.Measure();
            viewModel.MeasureValue.Is("2.2 m/s");
        }

        [Fact]
        public void Test_直近値_シナリオ()
        {
            var measureMock = new Mock<IMeasureRepository>();
            var measure     = new MeasureEntity("guidA", "2017/01/01 13:00:00".ToDate(), 1.23456f);
            measureMock.Setup(x => x.GetLatest()).Returns(measure);

            var viewModel   = new LatestViewModel(measureMock.Object);

            viewModel.MeasureDate.Is("2017/01/01 13:00:00");
            viewModel.MeasureValue.Is("1.23 m/s");
        }
    }
}