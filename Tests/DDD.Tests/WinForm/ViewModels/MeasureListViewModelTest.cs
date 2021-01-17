namespace DDD.Tests.WinForm.ViewModels
{
    using System.Collections.Generic;
    using ChainingAssertion;
    using DDD.Domain.Entities;
    using DDD.Domain.Helpers;
    using DDD.Domain.Repositories;
    using DDD.WinForm.ViewModels;
    using Moq;
    using Xunit;

    public class MeasureListViewModelTest
    {
        [Fact]
        public void Test_計測リスト_シナリオ()
        {
            var measureMock = new Mock<IMeasureRepository>();
            var measures = new List<MeasureEntity>
                           {
                               new MeasureEntity("guidA", "2017/01/01 13:00:00".ToDate(), 1.23456f)
                             , new MeasureEntity("guidB", "2017/01/01 14:00:00".ToDate(), 2.23456f)
                           };
            measureMock.Setup(x => x.GetData()).Returns(measures);

            var viewModel = new MeasureListViewModel(measureMock.Object);
            viewModel.Measures.Count.Is(2);

            viewModel.Measures[0].MeasureDate.Is("2017/01/01 13:00:00");
            viewModel.Measures[0].MeasureValue.Is("1.23m/s");
        }
    }
}